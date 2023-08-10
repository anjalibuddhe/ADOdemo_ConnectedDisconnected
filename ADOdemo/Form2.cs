using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ADOdemo.Models;

namespace ADOdemo
{
    public partial class Form2 : Form
    {
        EmployeeCurd crud;
        List<Deparment> list;
        public Form2()
        {
            InitializeComponent();
            crud = new EmployeeCurd();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            list = crud.GetDeparment();
            CmbDept.DataSource = list;
            CmbDept.DisplayMember = "Dname";
            CmbDept.ValueMember = "Did";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Name = Ename.Text;
               emp.Salary = Convert.ToInt32(Esalary.Text);
                emp.DId = Convert.ToInt32(CmbDept.SelectedValue);
                int res = crud.AddEmployee(emp);
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
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(EId.Text);
                emp.Name = Ename.Text;
                emp.Salary = Convert.ToInt32(Esalary.Text);
                emp.DId = Convert.ToInt32(CmbDept.SelectedValue);
                int res = crud.UpdateEmployee(emp);
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
               Employee emp = crud.GetEmployeeById(Convert.ToInt32(EId.Text));
                if (emp.Id > 0)
                {
                    foreach (Deparment item in list)

                    {
                        if (item.DId == emp.Id)
                        {
                            CmbDept.Text = item.Dname;
                            break;
                        }
                    }
                    Ename.Text = emp.Name;
                    Esalary.Text = emp.Salary.ToString();


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

                int res = crud.DeleteEmployee(Convert.ToInt32(EId.Text));
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
    }
}

