using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace ADOdemo.Models
{
    public class ProductCurd
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public ProductCurd()
        {
            string conststr = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con = new SqlConnection(conststr);
        }


        public List<Category> GetCategories()
        {
            List <Category> list = new List<Category>();
            string qry = "select * from Category";
            cmd =new SqlCommand(qry, con);
            con.Open();
            dr= cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    Category c = new Category();
                    c.CId = Convert.ToInt32(dr["cid"]);
                    c.CName = dr["cname"].ToString();
                    list.Add(c);
                }
            }
            con.Close();
            return list;
        }




        public int AddProduct(Product prod)
        {
            //step1: 
            string qry = "insert into Product values(@name,@price,@cid)";
            //step2;
            cmd=new SqlCommand(qry, con);
            //step3:
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@price", prod.Prices);
            cmd.Parameters.AddWithValue("@cid", prod.Cid);
            //step 4:
            con.Open();
            int result=cmd.ExecuteNonQuery();
            con.Close();
            return result;



        }
        public int UpdateProduct(Product prod)
        {
            // step1 -> qry
            string qry = "update Product set name=@name,price=@price,cid=@cid where id=@id";
            // step2- assign qry to command
            cmd = new SqlCommand(qry, con);
            // step3- pass valeu to the parameters
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@price", prod.Prices);
            cmd.Parameters.AddWithValue("@cid", prod.Cid);
            cmd.Parameters.AddWithValue("@id", prod.Id);
            // step4- open the connection
            con.Open();
            //step5- fire the query
            int result = cmd.ExecuteNonQuery();
            //step6- close the conn
            con.Close();
            return result;
        }

        public int DeleteProduct(int id)
        {
            // step1 -> qry
            string qry = "delete from Product where id=@id";
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


        public Product GetProductById(int id)
        {
            Product product = new Product();
            string qry = "select * from Product where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    product.Id = Convert.ToInt32(dr["id"]);
                    product.Name = dr["name"].ToString();
                    product.Prices = Convert.ToInt32(dr["price"]);
                    product.Cid = Convert.ToInt32(dr["cid"]);
                }
            }
            con.Close();
            return product;
        }

        public DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            string qry = "select * from Product";
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
