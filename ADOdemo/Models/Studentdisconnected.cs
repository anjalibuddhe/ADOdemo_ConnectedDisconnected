using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOdemo.Models
{
    public class Studentdisconnected
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public Studentdisconnected()
        {
            string connstr = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con = new SqlConnection(connstr);
        }

        public DataSet GetAllStudents()
        {
            string qry = "select * from Student";
            da = new SqlDataAdapter(qry, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Student");
            return ds;
        }
        public DataTable GetAllBranches()
        {
            string qry = "select * from Branch";
            da = new SqlDataAdapter(qry, con);
            ds = new DataSet();
            da.Fill(ds, "Branch");
            return ds.Tables["Branch"];
        }


        public int AddStudent(Student prod)
        {
            ds = GetAllStudents();
            DataRow row = ds.Tables["Student"].NewRow();
            row["name"] = prod.Name;
            row["gender"] = prod.Gender;
            row["age"] = prod.Age;
            row["bid"] = prod.Bid;
            ds.Tables["Student"].Rows.Add(row);
            int res = da.Update(ds.Tables["Student"]);
            return res;

        }

        public int UpdateStudent(Student prod)
        {
            ds = GetAllStudents();
            int res = 0;
            DataRow row = ds.Tables["Student"].Rows.Find(prod.Id);
            if (row != null)
            {
                row["name"] = prod.Name;
                row["gender"] = prod.Gender;
                row["age"] = prod.Age;
                row["bid"] = prod.Bid;

                res = da.Update(ds.Tables["Student"]);
            }
            return res;
        }


        public int DeleteStudent(int id)
        {
            ds = GetAllStudents();
            int res = 0;
            DataRow row = ds.Tables["Student"].Rows.Find(id);
            if (row != null)
            {
                row.Delete();
                res = da.Update(ds.Tables["Student"]);
            }
            return res;
        }

        public Student GetStudentById(int id)
        {
            ds = GetAllStudents();
            DataRow row = ds.Tables["Student"].Rows.Find(id);
            Student stud = new Student();
            stud.Id = Convert.ToInt32(row["id"]);
            stud.Name = row["name"].ToString();
            stud.Gender = row["gender"].ToString();
            stud.Age = Convert.ToInt32(row["age"]);
            stud.Bid = Convert.ToInt32(row["bid"]);
            return stud;
        }
    }
}
