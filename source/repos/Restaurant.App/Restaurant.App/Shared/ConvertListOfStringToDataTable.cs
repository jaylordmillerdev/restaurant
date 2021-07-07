using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.App
{
    public static class ConvertListOfStringToDataTable
    {
        public static DataTable Parse(List<string> data, string ColumnName)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(ColumnName);
            foreach (string item in data)
            {
                dataTable.Rows.Add(item);
            }
            return dataTable;
        }
    }
}
