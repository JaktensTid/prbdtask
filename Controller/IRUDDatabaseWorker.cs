using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasesProjectingTask1.Controller
{
    interface IRUDDatabaseWorker
    {
        void InsertRow(string tableName, string[] columns, string[] values);
        void DeleteRow(string tableName, int rowID);
        string[] TablesNames { get; }
        string[] ColumnsNames(string tableName);
    }
}
