using ADOdemo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOdemo.Models
{
    public class StudentCurd
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public StudentCurd() {

            String conststr = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con= new SqlConnection(conststr);
        } 
        
        public List<Branch>GetBranches()
        {
            List<Branch> list = new List<Branch>();
            String qry = "select * from Branch";
            cmd =new SqlCommand(qry, con);
            con.Open();
            dr=cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    Branch branch = new Branch();
                    branch.BId = Convert.ToInt32(dr["bid"]);
                    branch.BName = dr["bname"].ToString();
                    list.Add(branch);
                }
            }
            con.Close();
            return list;
        }
        public int StudentAdd(Student prod)
        {
            string qry = "insert into Student values(@name,@gender,@age,@bid)";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@gender", prod.Gender);
            cmd.Parameters.AddWithValue("@age", prod.Age);
            cmd.Parameters.AddWithValue("@bid", prod.Bid);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public int UpdateStudent(Student prod)
        {
            string qry = "update Student set name=@name,gender=@gender,age=@age,bid=@bid where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@gender", prod.Gender);
            cmd.Parameters.AddWithValue("@age", prod.Age);
            cmd.Parameters.AddWithValue("@bid", prod.Bid);
            cmd.Parameters.AddWithValue("@id", prod.Id);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public int DeleteStudent(int id)
        {
            string qry = "delete from Student where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public Student GetProductById(int id)
        {
            Student student = new Student();
            string qry = "select * from Student where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    student.Id = Convert.ToInt32(dr["id"]);
                    student.Name = dr["name"].ToString();
                    student.Gender = dr["gender"].ToString();
                    student.Age = Convert.ToInt32(dr["age"]);
                    student.Bid = Convert.ToInt32(dr["bid"]);
                }
            }
            con.Close();
            return student;
        }

        public DataTable GetAllStudents()
        {
            DataTable dt = new DataTable();
            string qry = "select * from Student";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dt.Load(dr);
            }
            con.Close();
            return dt;
        }


    }
}
