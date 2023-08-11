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

namespace ADOdemo
{
    public partial class Form4 : Form
    {
        StudentCurd crud;
        List<Branch> branches;
        public Form4()
        {
            InitializeComponent();
            crud = new StudentCurd();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            branches = crud.GetBranches();
            Cmdcategory.DataSource = branches;
            Cmdcategory.DisplayMember = "BName";
            Cmdcategory.ValueMember = "BId";

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student();
                s.Name = PName.Text;
                s.Gender = Sgender.Text;
                s.Age =Convert.ToInt32(Sage.Text);
                s.Bid = Convert.ToInt32(Cmdcategory.SelectedValue);
                int res = crud.StudentAdd(s);
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Student prod = crud.GetProductById(Convert.ToInt32(PId.Text));
                if (prod.Id > 0)
                {
                    foreach (Branch item in branches)
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

        private void BtnShow_Click(object sender, EventArgs e)
        {
            DataTable table = crud.GetAllStudents();
            dataGridView1.DataSource = table;
        }
    }
}
