using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Employee registration form with add,delete,update and view button.
/// </summary>
namespace Employee
{
    public partial class Form1 : Form
    {  

        User user = new User();//object of the class user
        
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
            txtMale.Checked=false;
            txtFemale.Checked=false;
            txtState.Text="";
            txtCity.Text = "";

        }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  add button for adding values from the employeeform to database 
        ///  and to display it into the datagrid
        /// </summary>

        private void AddButton(object sender, EventArgs e)
        {
            AddDataToEmployee();
            user.AddEmployee();
            DataTable dt = new DataTable();
            dt = user.GetData();
            dataGridView1.DataSource = dt;
            ClearData();
        }

        /// <summary>
        /// delete button for deleting the respective row/data from the database 
        /// based on the employeeid mentioned in the form.
        /// </summary>
        
        private void DeleteButton(object sender, EventArgs e)
        {
            user.empid = int.Parse(txtEmpId.Text);
            user.DeleteEmployee(user);
            user.GetData();
            DataTable dt = new DataTable();
            dt = user.GetData();
            dataGridView1.DataSource = dt;
            ClearData();
        }

        /// <summary>
        /// update button for updating the records in the employeetable 
        /// based on the mentioned employeeid
        /// </summary>
        
        private void UpdateButton(object sender, EventArgs e)
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
        
        /// <summary>
        /// view button for viewing the datatable in the datagrid view
        /// </summary>
        
        private void ViewButton(object sender, EventArgs e)
        {
            user.GetData();
            DataTable dt = new DataTable();
            dt = user.GetData();
            dataGridView1.DataSource = dt;
            ClearData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
     }//end of form1 class
 }
