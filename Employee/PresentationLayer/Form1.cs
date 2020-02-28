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
using DTO;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        EmployeeBAL user = new EmployeeBAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        /// <summary>
        ///  method to assign values from the text fields to the user class variables
        /// </summary>
        DTO.Employee em = new DTO.Employee();
        public void AddDataToEmployee()
        {
            em.firstname = txtFirstName.Text;
            em.lastname = txtLastName.Text;
            try
            {
                em.mobileno = long.Parse(txtMobileNo.Text);
            }
            catch (Exception) { }
            if (txtMale.Checked)
                em.gender = txtMale.Text;
            else
                em.gender = txtFemale.Text;
            em.state = txtState.Text;
            em.city = txtCity.Text;
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

        private void AddButton(object sender, EventArgs e)
        {
            AddDataToEmployee();
            user.AddEmployeeBAL(em);
           DataTable dt = new DataTable();
          /*  dt = user.GetData();
            dataGridView1.DataSource = dt;
            ClearData();*/
        }

        private void UpdateButton(object sender, EventArgs e)
        {
           em.empid = int.Parse(txtEmpId.Text);
            AddDataToEmployee();
            user.UpdateEmployeeBAL(em);
          /* user.GetData();
            DataTable dt = new DataTable();
            dt = user.GetData();
            dataGridView1.DataSource = dt;
            ClearData();*/
        }

        private void DeleteButton(object sender, EventArgs e)
        {
            em.empid = int.Parse(txtEmpId.Text);
            user.DeleteEmployeeBAL(em);
           /* user.GetData();
            DataTable dt = new DataTable();
            dt = user.GetData();
            dataGridView1.DataSource = dt;
            ClearData();*/
        }

        private void ViewButton(object sender, EventArgs e)
        {

           // user.GetData();
           // DataTable dt = new DataTable();
          // dt user.GetData();
               // d.ToList(); 
            dataGridView1.DataSource=user.GetData();
           
            ClearData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
