using ADOdemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADOdemo.Models;
using System.Xml.Linq;


namespace ADOdemo
{
    public partial class Form1 : Form
    {
            ProductCurd crud;
        List<Category> list;
        public Form1()
        {


            InitializeComponent();
            crud=new ProductCurd();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           list= crud.GetCategories();
            Cmdcategory.DataSource = list;
            Cmdcategory.DisplayMember = "Cname";
            Cmdcategory.ValueMember = "Cid";

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            try
            {
                Product p = new Product();
                p.Name = PName.Text;
                p.Prices = Convert.ToInt32(Pprice.Text);
                p.Cid = Convert.ToInt32(Cmdcategory.SelectedValue);
                int res = crud.AddProduct(p);
                if (res > 0)
                {
                    MessageBox.Show("Record inserted..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Id = Convert.ToInt32(PId.Text);
                p.Name = PName.Text;
                p.Prices = Convert.ToInt32(Pprice.Text);
                p.Cid = Convert.ToInt32(Cmdcategory.SelectedValue);
                int res = crud.UpdateProduct(p);
                if (res > 0)
                {
                    MessageBox.Show("Record updated..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                Product prod = crud.GetProductById(Convert.ToInt32(PId.Text));
                if (prod.Id > 0)
                {
                    foreach (Category item in list)
                    {
                        if (item.CId == prod.Cid)
                        {
                            Cmdcategory.Text = item.CName;
                            break;
                        }
                    }
                    PName.Text = prod.Name;
                    Pprice.Text = prod.Prices.ToString();

                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int res = crud.DeleteProduct(Convert.ToInt32(PId.Text));
                if (res > 0)
                {
                    MessageBox.Show("Record deleted..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {

            DataTable table = crud.GetAllProducts();
            dataGridView1.DataSource = table;

        }
    }
}
