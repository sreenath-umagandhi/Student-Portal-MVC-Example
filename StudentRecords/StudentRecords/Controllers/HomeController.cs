using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace StudentRecords.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private SqlConnection conn;
        private void connection()
        {
        //  string constr =  ConfigurationManager.ConnectionStrings["Data Source=.;Initial Catalog=StudentRecords;Integrated Security=True"].ToString();
            conn = new SqlConnection("Data Source=IMMY-233\\SQLEXPRESS;Initial Catalog=StudentRecords;Integrated Security=True");
        }


        public ActionResult AddStudentInfo(Models.StudentRecord Stu)
        {
            if(ModelState.IsValid)
            {

                connection();
                SqlCommand com = new SqlCommand("InsertData", conn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@studentID", Stu.studentID);
                com.Parameters.AddWithValue("@studentName", Stu.studentName);
                com.Parameters.AddWithValue("@studentAge", Stu.studentAge);
                com.Parameters.AddWithValue("@studentMajor", Stu.studentMajor);

                com.Parameters.AddWithValue("@studentGPA", Stu.studentGPA);
                conn.Open();
                
                int i = com.ExecuteNonQuery();
                conn.Close();
                if (i>=1)
                {
                    ViewBag.Message = "New Student has been added!!";
                    
                }

            }
            ModelState.Clear();
            return View();
        }
    }
}