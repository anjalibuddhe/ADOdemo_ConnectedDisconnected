using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace ADOdemo.Models
{
    public class EmployeeCurd
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public EmployeeCurd()
        {
            string conststr = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con = new SqlConnection(conststr);
        }

        public List<Deparment>GetDeparment()
        {
            List<Deparment> list = new List<Deparment>();
            string qry = "select * from Deparment";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Deparment c = new Deparment();
                    c.DId = Convert.ToInt32(dr["did"]);
                    c.Dname = dr["dname"].ToString();
                    list.Add(c);
                }
            }
            con.Close();
            return list;
        }


        public int AddEmployee(Employee prod)
        {
            //step1: 
            string qry = "insert into Employee values(@name,@salary,@did)";
            //step2;
            cmd = new SqlCommand(qry, con);
            //step3:

            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@salary", prod.Salary);
            cmd.Parameters.AddWithValue("@did", prod.DId);
            //step 4:
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }


        public int UpdateEmployee(Employee prod)
        {
            // step1 -> qry
            string qry = "update Employee set name=@name,salary=@salary,did=@did where id=@id";
            // step2- assign qry to command
            cmd = new SqlCommand(qry, con);
            // step3- pass valeu to the parameters
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@salary", prod.Salary);
            cmd.Parameters.AddWithValue("@did", prod.DId);
            cmd.Parameters.AddWithValue("@id", prod.Id);
            // step4- open the connection
            con.Open();
            //step5- fire the query
            int result = cmd.ExecuteNonQuery();
            //step6- close the conn
            con.Close();
            return result;

        }

        public int DeleteEmployee(int id)
        {

            // step1 -> qry
            string qry = "delete from Employee where id=@id";
            // step2- assign qry to command
            cmd = new SqlCommand(qry, con);
            // step3- pass valeu to the parameters
            cmd.Parameters.AddWithValue("@id", id);
            // step4- open the connection
            con.Open();
            //step5- fire the query
            int result = cmd.ExecuteNonQuery();
            //step6- close the conn
            con.Close();
            return result;

        }


        public Employee GetEmployeeById(int id)
        {
            Employee employee = new Employee();
            string qry = "select * from Employee where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    employee.Id = Convert.ToInt32(dr["id"]);
                    employee.Name = dr["name"].ToString();
                    employee.Salary= Convert.ToInt32(dr["salary"]);
                    employee.DId = Convert.ToInt32(dr["did"]);
                }
            }
            con.Close();
            return employee;
        }


    }
}
