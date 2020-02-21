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

namespace Employee
{
    public partial class Form1 : Form
    {
        User user = new User();
        //method to assign values from the text fields to the user clas variables
        public void addData()
        {
            user.firstnm = fnm.Text;
            user.lastnm = lnm.Text;
            try
            {
                user.mob = long.Parse(mob.Text);
            }
            catch (Exception) { }
            if (ml.Checked)
                user.gender = ml.Text;
            else
                user.gender = fem.Text;
            user.state = st.Text;
            user.city = ct.Text;
        }
        public void ClearData()
        {
            id.Text = "";
            fnm.Text = "";
            lnm.Text = "";
            mob.Text = "";
            ml.Checked=false;
            fem.Checked=false;
            st.Text="";
            ct.Text = "";

        }
        public Form1()
        {
            InitializeComponent();
        }
        //add button
        private void Add(object sender, EventArgs e)
        {
            addData();
            user.add(user);
            DataTable dt = new DataTable();
            dt = user.getData();
            dataGridView1.DataSource = dt;
            ClearData();
        }
        //delete button
        private void delete(object sender, EventArgs e)
        {
            user.empid = int.Parse(id.Text);
            user.del(user);
            user.getData();
            DataTable dt = new DataTable();
            dt = user.getData();
            dataGridView1.DataSource = dt;
            ClearData();
        }
        //update button
        private void Update(object sender, EventArgs e)
        {
             user.empid = int.Parse(id.Text);
             addData();
             user.update(user);
             user.getData();
             DataTable dt = new DataTable();
             dt = user.getData();
             dataGridView1.DataSource = dt;
            ClearData();
        }
        //view button
        private void viewGrid(object sender, EventArgs e)
        {
            user.getData();
            DataTable dt = new DataTable();
            dt = user.getData();
            dataGridView1.DataSource = dt;
            ClearData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
 }
