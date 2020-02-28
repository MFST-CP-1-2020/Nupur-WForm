using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace EmpRegis
{
    public partial class Form1 : Form
    {
        Employee user = new Employee();
        /// <summary>
        ///  method to assign values from the text fields to the user class variables
        /// </summary>

        public void AddDataToEmployee()
        {
            user.firstnm = txtFirstName.Text;
            user.lastnm = txtLastName.Text;
            try
            {
                user.mob = long.Parse(txtMobileNo.Text);
            }
            catch (Exception) { }
            if (txtMale.Checked)
                user.gender = txtMale.Text;
            else
                user.gender = txtFemale.Text;
            user.state = txtState.Text;
            user.city = txtCity.Text;
        }

        /// <summary>
        ///method for automatically clearing the textfield once 
        ///the respective buttons are clicked 
        /// </summary>
        public void ClearData()
        {
            txtEmpId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMobileNo.Text = "";
            txtMale.Checked = false;
            txtFemale.Checked = false;
            txtState.Text = "";
            txtCity.Text = "";

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddDataToEmployee();
            user.AddEmployee();
            DataTable dt = new DataTable();
            dt = user.GetData();
            dataGridView1.DataSource = dt;
            ClearData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user.empid = int.Parse(txtEmpId.Text);
            AddDataToEmployee();
            user.UpdateEmployee(user);
            user.GetData();
            DataTable dt = new DataTable();
            dt = user.GetData();
            dataGridView1.DataSource = dt;
            ClearData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user.empid = int.Parse(txtEmpId.Text);
            user.DeleteEmployee(user);
            user.GetData();
            DataTable dt = new DataTable();
            dt = user.GetData();
            dataGridView1.DataSource = dt;
            ClearData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            user.GetData();
            DataTable dt = new DataTable();
            dt = user.GetData();
            dataGridView1.DataSource = dt;
            ClearData();
        }
    }
}
