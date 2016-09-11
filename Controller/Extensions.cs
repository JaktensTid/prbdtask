using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasesProjectingTask1.Controller
{
    public static class Extensions
    {
        public static string AggregateToSqlTableNames(this string[] current)
        {
            string result = "";

            result += "(";
            for (int i = 0; i < current.Length - 1; i++)
            {
                var str = current[i];
                result += str + " ,";
            }
            result += current[current.Length - 1];
            result += ")";

            return result;
        }

        public static string AggregateToSqlTableValues(this string[] current)
        {
            string result = "";

            result += "(";
            for (int i = 0; i < current.Length - 1; i++)
            {
                var str = current[i];
                result += "'" + str + "'" + " ,";
            }
            result += "'" + current[current.Length - 1] + "'";
            result += ")";

            return result;
        }
    }
}
