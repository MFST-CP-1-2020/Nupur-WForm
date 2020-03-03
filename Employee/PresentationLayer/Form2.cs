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
    public partial class Form2 : Form
    {
        BAL.Student user2 = new BAL.Student();
        StdDTOcs student = new StdDTOcs();
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  method to assign values from the text fields to the user class variables
        /// </summary>
       
        public void AddDataToStudent()
        {
            student.firstnm = txtFirstName.Text;
            student.lastnm = txtLastName.Text;
            try
            {
                student.mob = long.Parse(txtMobileNo.Text);
            }
            catch (Exception) { }
            if (txtMale.Checked)
                student.gender = txtMale.Text;
            else
                student.gender = txtFemale.Text;
            student.state = txtState.Text;
            student.city = txtCity.Text;
        }

        /// <summary>
        ///method for automatically clearing the textfield once 
        ///the respective buttons are clicked 
        /// </summary>
        public void ClearData()
        {
            txtStudentId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMobileNo.Text = "";
            txtMale.Checked = false;
            txtFemale.Checked = false;
            txtState.Text = "";
            txtCity.Text = "";
        }

        /// <summary>
        ///  add button for adding values from the studentform to database 
        ///  and to display it into the datagrid
        /// </summary>

        private void AddButton(object sender, EventArgs e)
        {
            AddDataToStudent();
           user2.AddStudent(student);
            DataTable dt = new DataTable();
            dt = user2.GetData();
            stdGrid.DataSource = dt;
            ClearData();
        }

        /// <summary>
        /// update button for updating the records in the studenttable 
        /// based on the mentioned employeeid
        /// </summary>

        private void UpdateButton(object sender, EventArgs e)
        {
            student.studentid = int.Parse(txtStudentId.Text);
            AddDataToStudent();
            user2.UpdateStudent(student);
            user2.GetData();
            DataTable dt = new DataTable();
            dt = user2.GetData();
            stdGrid.DataSource = dt;
            ClearData();
        }

        /// <summary>
        /// delete button for deleting the respective row/data from the database 
        /// based on the employeeid mentioned in the form.
        /// </summary>

        private void DeleteButton(object sender, EventArgs e)
        {
            student.studentid = int.Parse(txtStudentId.Text);
            user2.DeleteStudent(student);
            user2.GetData();
            DataTable dt = new DataTable();
            dt = user2.GetData();
            stdGrid.DataSource = dt;
            ClearData();
        }

        /// <summary>
        /// view button for viewing the datatable in the datagrid view
        /// </summary>

        private void ViewButton(object sender, EventArgs e)
        {
            user2.GetData();
            DataTable dt = new DataTable();
            dt = user2.GetData();
            stdGrid.DataSource = dt;
            ClearData();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

       


    }
}
