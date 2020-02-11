using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormAppN.Student
{
    public partial class frmUserReg : Form
    {
        DataTable state = new DataTable();
        DataTable city = new DataTable();
        DataTable user = new DataTable();
        int indexRow;
        public frmUserReg()
        {
            InitializeComponent();
        }
        void bindContents()
        {
            bState();
            st.DataSource = state;
          
           bCity();
           ct.DataSource = city;

        }
        void bState()
        {
            //add columns
            state.Columns.Add("Id", typeof(int));
            state.Columns.Add("Name", typeof(string));
            DataRow row = state.NewRow();
            //add data rows
            state.Rows.Add(1,"UttarPradesh");
            state.Rows.Add(2,"Uttarakhand");
            state.Rows.Add(3, "Assam");
            state.Rows.Add(4, "Bihar");
            //display and value member of combobox(st)
            st.DisplayMember = "Name";
            st.ValueMember = "Id";
           

        }
        void bCity()
        {
            //add columns
            city.Columns.Add("Id", typeof(int));
            city.Columns.Add("Name", typeof(string));
            DataRow row = city.NewRow();
            //add data rows
            city.Rows.Add(1,"Lucknow");
            city.Rows.Add(2,"Almora");
            city.Rows.Add(3,"Tezpur");
            city.Rows.Add(4,"Patna");
            
            //display and value member of combobox(ct)
            ct.DisplayMember = "Name";
            ct.ValueMember = "Id";
        }
        void addColumn()
        {
            user.Columns.Add("Name",typeof(string));
            user.Columns.Add("Rollno",typeof(int));
            user.Columns.Add("FatherName",typeof(string));
            user.Columns.Add("Address");
            user.Columns.Add("Gender");
            user.Columns.Add("State");
            user.Columns.Add("City");
            user.Columns.Add("Course",typeof(string));
            user.Columns.Add("EmailId");
            user.Columns.Add("MobileNo",typeof(int));
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            grid.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "edit";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

        }
        private void frmUserReg_Load(object sender, EventArgs e)
        {
            bindContents();
            addColumn();
        }
      
            

    
        void bindUser()
        {
            DataRow d = user.NewRow();
            
            d[0] = nm.Text;
            d[1] = rollno.Text;
            d[2] = fathernm.Text;
            d[3] = add.Text;
            bool x = ml.Checked;
            if (x)
                d["gender"] = ml.Text;
            else
                d["gender"] = fem.Text;
            d[5] = st.Text;
            d[6] = ct.Text;
            d[7] = cous.Text;
            d[8] = email.Text;
            d[9] = mob.Text;
            
            user.Rows.Add(d);
            grid.DataSource = user;
            // for clearing the text field
            nm.Text = "";
            rollno.Text = "";
            fathernm.Text = "";
            add.Text = "";
            st.ResetText();
            ct.ResetText();
            cous.Text = "";
            email.Text = "";
            mob.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //frm.dataGridView1.Rows.Add(nm.Text, rollno.Text, fathernm.Text, add.Text,st.Text,ct.Text,cous.Text,email.Text,mob.Text,fem.Text,ml.Text);
            bindUser();

        }

        private void nm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void st_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = grid.Rows[indexRow];

            nm.Text = row.Cells[1].Value.ToString();
            rollno.Text = row.Cells[2].Value.ToString();
            fathernm.Text = row.Cells[3].Value.ToString();
             add.Text = row.Cells[4].Value.ToString();
            st.Text = row.Cells[5].Value.ToString();
            ct.Text= row.Cells[6].Value.ToString();
            cous.Text= row.Cells[7].Value.ToString();
            email.Text= row.Cells[8].Value.ToString();
            mob.Text= row.Cells[9].Value.ToString();

        }
    }
}
