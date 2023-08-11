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
using System.Xml.Linq;

namespace ADOdemo
{
    public partial class Form3 : Form
    {
        ProductDisconnected crud;
        DataTable table;
        public Form3()
        {
            InitializeComponent();
            crud =new ProductDisconnected();
        }

        private void PId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            {
                DataTable table = crud.GetAllCategories();
                Cmdcategory.DataSource = table;
                Cmdcategory.DisplayMember = "Cname";
                Cmdcategory.ValueMember = "Cid";
            }

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
                    List<Category> list = new List<Category>();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        Category c = new Category();
                        c.CId = Convert.ToInt32(table.Rows[i]["cid"]);
                        c.CName = table.Rows[i]["cname"].ToString();
                        list.Add(c);
                    }
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

        }
    }
}
