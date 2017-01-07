using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Data.SQLite;
using DatabasesProjectingTask1.Controller;

namespace DatabasesProjectingTask1
{
    class CDdatabase : IRUDDatabaseWorker
    {
        private static string dbName = "E://Program Files (x86)/Visual Studio projects/prbdtask/Model/ConfectionaryDatabase.db3";
        private static string rootPath = "E://Program Files (x86)/Visual Studio projects/prbdtask";
        static CDdatabase()
        {
            string sqlText = "";
            foreach (var file in Directory.GetFiles(rootPath + "/SqlScripts"))
            {
                sqlText += File.ReadAllText(file) + " ";
            }
            SQLiteConnection.CreateFile(dbName);
            SQLiteConnection connection =
            new SQLiteConnection(string.Format("Data Source={0};", dbName));
            SQLiteCommand command =
                new SQLiteCommand(sqlText, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable Addresses { get { return GetTableByName("AddressCandies", "*"); } }

        public DataTable CandyTypes { get { return GetTableByName("CandyTypes", "*"); } }

        public DataTable Companies { get { return GetTableByName("Companies", "*"); } }

        public DataTable Factories { get { return GetTableByName("Factories", "*"); } }

        public DataTable Persons { get { return GetTableByName("Persons", "*"); } }

        public string[] TablesNames
        {
            get
            {
                using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbName)))
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

            using (SQLiteConnection sqlConnection = new SQLiteConnection(string.Format("Data Source={0};", dbName)))
            {
                sqlConnection.Open();
                string commandString = "SELECT " +
                                       "*" +
                                       " FROM " +
                                       tableName + " ORDER BY ID";
                SQLiteCommand command = new SQLiteCommand(commandString, sqlConnection);
                using (SQLiteDataReader reader = command.ExecuteReader())
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

            using (SQLiteConnection sqlConnection = new SQLiteConnection(string.Format("Data Source={0};", dbName)))
            {
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
                SQLiteCommand command = new SQLiteCommand(commandString, sqlConnection);
                using (SQLiteDataReader reader = command.ExecuteReader())
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

            using (SQLiteConnection sqlConnection = new SQLiteConnection(string.Format("Data Source={0};", dbName)))
            {
                sqlConnection.Open();
                string columns = "";

                string commandString = "SELECT " +
                                       "*" +
                                       " FROM " +
                                       tableName + " ORDER BY ID";
                SQLiteCommand command = new SQLiteCommand(commandString, sqlConnection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            dataTable.TableName = tableName;
            return dataTable;
        }

        private DataTable GetTableByCommand(SQLiteCommand command)
        {
            DataTable dataTable = new DataTable();

            using (SQLiteConnection sqlConnection = new SQLiteConnection(string.Format("Data Source={0};", dbName)))
            {
                sqlConnection.Open();
                command.Connection = sqlConnection;
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        }

        public DataTable GetCompaniesByCandyType(string candy)
        {
            SQLiteCommand command = new SQLiteCommand();
            string commandString =
                "SELECT CompanyName FROM Factories " +
                "WHERE Addr = " +
                "(SELECT Addr FROM AddressCandies WHERE Candies = @0)";
            command.CommandText = commandString;
            command.Parameters.Add(new SQLiteParameter("0", candy));

            return GetTableByCommand(command);
        }

        public DataTable GetCompanyByPerson(string firstLastName)
        {
            var splited = firstLastName.Split(' ');
            if(splited.Length != 2)
            {
                throw new InvalidOperationException("No data found");
            }
            string firstName = splited[0];
            string lastName = splited[1];
            SQLiteCommand command = new SQLiteCommand();
            string commandString =
                "SELECT DISTINCT CompanyName FROM Persons WHERE FirstName = @0 AND LastName = @1";
            command.CommandText = commandString;
            command.Parameters.Add(new SQLiteParameter("0", firstName));
            command.Parameters.Add(new SQLiteParameter("1", lastName));

            return GetTableByCommand(command);
        }

        public void DeleteRow(string tableName, int rowID)
        {
            using (SQLiteConnection sqlConnection = new SQLiteConnection(string.Format("Data Source={0};", dbName)))
            {
                sqlConnection.Open();

                SQLiteCommand deleteRecord = new SQLiteCommand();
                deleteRecord.Connection = sqlConnection;
                deleteRecord.CommandType = CommandType.Text;

                string sql = "DELETE FROM " + tableName + " WHERE ID = " + rowID;

                SQLiteParameter RowParameter = new SQLiteParameter();
                RowParameter.ParameterName = "@RowID";
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

            using (SQLiteConnection sqlConnection = new SQLiteConnection(string.Format("Data Source={0};", dbName)))
            {
                sqlConnection.Open();

                SQLiteCommand deleteRecord = new SQLiteCommand();
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
