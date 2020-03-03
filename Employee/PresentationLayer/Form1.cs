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
using BAL.Mapper;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        EmployeeBAL user = new EmployeeBAL();
        EmpDTO em = new EmpDTO();
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
        
        public void AddDataToEmployee()
        {
            em.firstnm = txtFirstName.Text;
            em.lastnm = txtLastName.Text;
            try
            {
                em.mob = long.Parse(txtMobileNo.Text);
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

        /// <summary>
        /// addbutton method to add values to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void AddButton(object sender, EventArgs e)
        {
            AddDataToEmployee();
            user.AddEmployeeBAL(em);
            DataTable dt = new DataTable();
            dt = user.GetData();
            empGrid.DataSource = dt;
            ClearData();
        }

        /// <summary>
        /// update method to update the data in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void UpdateButton(object sender, EventArgs e)
        {
            em.empid = int.Parse(txtEmpId.Text);
            AddDataToEmployee();
            user.UpdateEmployeeBAL(em);
            user.GetData();
            DataTable dt = new DataTable();
            dt = user.GetData();
            empGrid.DataSource = dt;
            ClearData();
        }

        /// <summary>
        /// delete button to delete the data from database based on the employeeid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void DeleteButton(object sender, EventArgs e)
        {
            em.empid = int.Parse(txtEmpId.Text);
            user.DeleteEmployeeBAL(em);
            user.GetData();
            DataTable dt = new DataTable();
            dt = user.GetData();
            empGrid.DataSource = dt;
            ClearData();
        }

        /// <summary>
        /// view button to view the database in the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ViewButton(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt= user.GetData(); 
            empGrid.DataSource=dt;
            ClearData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
