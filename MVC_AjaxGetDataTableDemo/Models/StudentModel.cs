using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MVC_AjaxGetDataTableDemo.Models
{
    /// <summary>
    /// Student Model
    /// </summary>
    public class StudentModel
    {
        private readonly DataTable _Students;

        /// <summary>
        /// Get Student DataTable
        /// </summary>
        public DataTable Students
        {
            get { return _Students; }
        }

        public StudentModel()
        {
            DataColumn id = new DataColumn()
            {
                ColumnName = "Id",
                DataType = typeof(int)
            };

            DataColumn name = new DataColumn()
            {
                ColumnName = "Name",
                DataType = typeof(string)
            };

            DataColumn age = new DataColumn()
            {
                ColumnName = "Age",
                DataType = typeof(int)
            };

            _Students = new DataTable();
            _Students.Columns.Add(id);
            _Students.Columns.Add(name);
            _Students.Columns.Add(age);

            for (var i = 0; i <= 10; i++)
            {
                DataRow row = _Students.NewRow();
                row["Id"] = i + 1;
                row["Name"] = $"ABC_{i + 1}";
                row["Age"] = 12 + i;
                _Students.Rows.Add(row);
            }
        }
    }
}