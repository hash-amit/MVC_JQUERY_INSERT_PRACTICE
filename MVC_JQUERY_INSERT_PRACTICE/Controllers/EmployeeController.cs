using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_JQUERY_INSERT_PRACTICE.Controllers
{
    public class EmployeeController : Controller
    {
        SqlConnection _connection = new SqlConnection("data source=DESKTOP-IOJE25P\\SQLEXPRESS;initial catalog=DB_MVC_PRACTICE;integrated security=true");
        // GET: Employee
        public ActionResult EmployeeForm()
        {
            return View();
        }

        public void EmployeeInsert(string A, string B, int C)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("sp_Insert", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", A);
            cmd.Parameters.AddWithValue("@address", B);
            cmd.Parameters.AddWithValue("@age", C);
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
    }
}