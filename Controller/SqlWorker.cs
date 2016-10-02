using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DatabasesProjectingTask1.Controller;

namespace DatabasesProjectingTask1
{
    class CDdatabase : IRUDDatabaseWorker
    {
        private static string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="
            + '"' +
            @"c:\users\andre\documents\visual studio 2015\Projects\DatabasesProjectingTask1\Model\CDdatabase.mdf"
            + '"' + "; Integrated Security = True";

        public DataTable Artists { get { return GetTableByName("Artists", "*"); } }

        public DataTable Albums { get { return GetTableByName("Albums", "*"); } }

        public DataTable Tracks { get { return GetTableByName("Tracks", "*"); } }

        public DataTable Labels { get { return GetTableByName("Labels", "*"); } }

        public DataTable Performances { get { return GetTableByName("Performances", "*"); } }

        public string[] TablesNames
        {
            get
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    DataTable schema = connection.GetSchema("Tables");
                    List<string> tableNames = new List<string>();
                    foreach (DataRow row in schema.Rows)
                    {
                        tableNames.Add(row[2].ToString());
                    }
                    return tableNames.ToArray();
                }
            }
        }

        public string[] ColumnsNames(string tableName)
        {
            List<string> columnNames = new List<string>();

            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();
                string columns = "";

                string commandString = "SELECT " +
                                       "*" +
                                       " FROM " +
                                       tableName + " ORDER BY ID";
                SqlCommand command = new SqlCommand(commandString, sqlConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            foreach (DataColumn column in dataTable.Columns)
            {
                columnNames.Add(column.ColumnName);
            }

            if (columnNames.Contains("ID")) columnNames.Remove("ID");

            return columnNames.ToArray();
        }

        public DataTable GetTableByName(string tableName, params string[] colNames)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();
                string columns = "";

                for (int i = 0; i < colNames.Length - 1; i++)
                {
                    columns += colNames[i] + ",";
                }

                columns += colNames[colNames.Length - 1];
                string commandString = "SELECT " +
                                       columns +
                                       " FROM " +
                                       tableName + " ORDER BY ID";
                SqlCommand command = new SqlCommand(commandString, sqlConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            dataTable.TableName = tableName;
            return dataTable;
        }

        public DataTable GetTableByName(string tableName)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();
                string columns = "";

                string commandString = "SELECT " +
                                       "*" +
                                       " FROM " +
                                       tableName + " ORDER BY ID";
                SqlCommand command = new SqlCommand(commandString, sqlConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            dataTable.TableName = tableName;
            return dataTable;
        }

        private DataTable GetTableByCommand(SqlCommand command)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();
                command.Connection = sqlConnection;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }

        public DataTable GetAlbumsByArtist(string artist)
        {
            SqlCommand command = new SqlCommand();
            string commandString =
                "SELECT DISTINCT Albums.Name " +
                "FROM Albums, Artists " +
                "WHERE Albums.Artist = (SELECT Name FROM Artists WHERE Name = @0)";
            command.CommandText = commandString;
            command.Parameters.Add(new SqlParameter("0", artist));

            return GetTableByCommand(command);
        }

        public DataTable GetSongsByAlbum(string album)
        {
            SqlCommand command = new SqlCommand();
            string commandString =
                "SELECT DISTINCT Tracks.Name, Tracks.Duration " +
                "FROM Tracks, Albums " +
                "WHERE Tracks.AlbumID = (SELECT ID FROM Albums WHERE Name = @0)";
            command.CommandText = commandString;
            command.Parameters.Add(new SqlParameter("0", album));

            return GetTableByCommand(command);
        }

        public void DeleteRow(string tableName, int rowID)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();

                SqlCommand deleteRecord = new SqlCommand();
                deleteRecord.Connection = sqlConnection;
                deleteRecord.CommandType = CommandType.Text;

                string sql = "DELETE FROM " + tableName + " WHERE ID = " + rowID;

                SqlParameter RowParameter = new SqlParameter();
                RowParameter.ParameterName = "@RowID";
                RowParameter.SqlDbType = SqlDbType.Int;
                RowParameter.IsNullable = false;
                RowParameter.Value = rowID;

                deleteRecord.Parameters.Add(RowParameter);
                deleteRecord.CommandText = sql;
                deleteRecord.ExecuteNonQuery();
                deleteRecord.Connection.Close();
            }
        }


        public void InsertRow(string tableName, string[] columns, string[] values)
        {
            if (columns.Length != values.Length)
            {
                throw new ArgumentException("Columns count != values count");
            }

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();

                SqlCommand deleteRecord = new SqlCommand();
                deleteRecord.Connection = sqlConnection;
                deleteRecord.CommandType = CommandType.Text;

                string sql = @"INSERT INTO " + tableName + columns.AggregateToSqlTableNames() + @"
                               VALUES " + values.AggregateToSqlTableValues();

                deleteRecord.CommandText = sql;
                deleteRecord.ExecuteNonQuery();
                deleteRecord.Connection.Close();
            }
        }
    }
}
