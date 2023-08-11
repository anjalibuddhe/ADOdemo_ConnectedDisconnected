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
    public partial class Form5 : Form
    {

       Studentdisconnected crud;
        DataTable table;
        public Form5()
        {
            InitializeComponent();
            crud = new Studentdisconnected();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student();
                s.Name = PName.Text;
                s.Gender = Sgender.Text;
                s.Age = Convert.ToInt32(Sage.Text);
                s.Bid = Convert.ToInt32(Cmdcategory.SelectedValue);
                int res = crud.AddStudent(s);
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
                Student s = new Student();
                s.Id = Convert.ToInt32(PId.Text);
                s.Name = PName.Text;
                s.Gender = Sgender.Text;
                s.Age = Convert.ToInt32(Sage.Text);
                s.Bid = Convert.ToInt32(Cmdcategory.SelectedValue);
                int res = crud.UpdateStudent(s);
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int res = crud.DeleteStudent(Convert.ToInt32(PId.Text));
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

       

        private void Form5_Load(object sender, EventArgs e)
        {
            {
                DataTable table = crud.GetAllBranches();
                Cmdcategory.DataSource = table;
                Cmdcategory.DisplayMember = "Bname";
                Cmdcategory.ValueMember = "Bid";
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        
        {
            try
            {
                Student prod = crud.GetStudentById(Convert.ToInt32(PId.Text));
                if (prod.Id > 0)
                {
                    List<Branch> list = new List<Branch>();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        Branch b = new Branch();
                        b.BId = Convert.ToInt32(table.Rows[i]["bid"]);
                        b.BName= table.Rows[i]["bname"].ToString();
                        list.Add(b);
                    }
                    foreach (Branch item in list)
                    {
                        if (item.BId == prod.Bid)
                        {
                            Cmdcategory.Text = item.BName;
                            break;
                        }
                    }
                    PName.Text = prod.Name;
                    Sgender.Text = prod.Gender;
                    Sage.Text = prod.Age.ToString();

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
    }
}
