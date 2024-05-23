using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MVCFORM.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace MVCFORM.Models
{
    public class EmployeeDB
    {
        private SqlConnection con;
        private void Connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["mydb"].ToString();

            con = new SqlConnection(constring);
        }

        public bool AddEmp(string MODE , EmployeeModel trans)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("EMPLOYEEDATILS", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MODE", MODE);
            cmd.Parameters.AddWithValue("@Name", trans.Name);
            cmd.Parameters.AddWithValue("@Emp_Id", trans.Emp_Id);
            cmd.Parameters.AddWithValue("@Email", trans.Email);
            cmd.Parameters.AddWithValue("@Age", trans.Age);
            cmd.Parameters.AddWithValue("@Gender", trans.Gender);
            cmd.Parameters.AddWithValue("@Mobile", trans.Mobile);
            cmd.Parameters.AddWithValue("@Password", trans.Password);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i >= 1)
            {
                return true;
            }
            else
                return false;
        }

        public bool LoginEmp(string MODE, EmployeeModel trans)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("EMPLOYEEDATILS", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MODE", MODE);
            cmd.Parameters.AddWithValue("@Email", trans.Email);
            cmd.Parameters.AddWithValue("@Password", trans.Password);

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                
                return dr.HasRows;
            }
        }

        // ***************** UPDATE STUDENT DETAILS *********************
        public bool UpdateDetails(EmployeeModel smodel)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("UpdateStudentDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.AddWithValue("@Name", smodel.Name);
            
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool DeleteStudent(int id)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("DeleteStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@StdId", id);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true;
            else
                return false;
        }

        public List<EmployeeModel> GetStudent()
        {
            Connection();
            List<EmployeeModel> studentlist = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("GetStudentDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            sd.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                studentlist.Add(
                new EmployeeModel
                {
                    Id = int.Parse(dr["Id"].ToString()),
                    Name = dr["Name"].ToString(),
                    City = dr["City"].ToString(),
                    Address = dr["Address"].ToString()
                });
            }
            return studentlist;
        }
    }
}