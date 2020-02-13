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
        //method for binding combobox for state and city
        void bindContents()
        {
            bState();
            st.DataSource = state;
            
            

        }
        //method to add state into the datatable
        void bState()
        {
            //add columns
            state.Columns.Add("Id", typeof(int));
            state.Columns.Add("Name", typeof(string));
            //add data rows
            state.Rows.Add(1,"UttarPradesh");
            state.Rows.Add(2,"Uttarakhand");
            state.Rows.Add(3, "Assam");
            state.Rows.Add(4, "Bihar");
            //display and value member of combobox(st)
            st.DisplayMember = "Name";
            st.ValueMember = "Id";
        }
        void addColCity()
        {
            //add columns
            city.Columns.Add("Id", typeof(int));
            city.Columns.Add("Name", typeof(string));
        }
        //method to add city into the datatable
        void bCity()
        {
            int  x= st.SelectedIndex;
            DataRow row = city.NewRow();
            //add data rows
            switch (x)
            {
              case 0:
                   city.Rows.Add(1, "Lucknow");
                    city.Rows.Add(2, "AGRA");
                    break;
                case 1:
                    city.Rows.Add(1, "Almora");
                    city.Rows.Add(2, "Nainital");
                    break;
                case 2:
                    city.Rows.Add(1, "Tezpur");
                    break;
                case 3:
                    city.Rows.Add(1, "Patna");
                    break;
            } 
            //display and value member of combobox(ct)
            ct.DisplayMember = "Name";
            ct.ValueMember = "Id";
            ct.DataSource = city;
        }
        //method to add user data(columns) into the grid
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
        }
        String gender()
        {
            bool x = ml.Checked;
            if (x)
                return  ml.Text;
            else
                return fem.Text;
        }
        //method to bind userdata into the datatable (user)
        void bindUser()
        {
            //datarow for usertable
            /*  DataRow d = user.NewRow();
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
              grid.DataSource = user;*/
            user.Rows.Add(nm.Text, rollno.Text, fathernm.Text, add.Text,gender(), st.Text, ct.Text, cous.Text, email.Text, mob.Text);
            grid.DataSource = user; 
            clearData();
        }
        // for clearing the text field
        void clearData()
        {
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
        //method for calling bindContents,addColumn method when form is been loaded
        private void frmUserReg_Load(object sender, EventArgs e)
        {
            
           // frmUserReg.Size = new Size(300, 300);
            bindContents();
            addColumn();
            addColCity();
            update.Enabled = false;
        }
        //method for submit button
        private void submitButton(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            grid.Columns.Add(btn);
            grid.Columns.Add(btn1);
            btn1.Text = "Del";
            btn.HeaderText = "";
            btn.Text = "EDIT";
            btn.Name = "btn";
            btn1.Name = "btn1";
            btn.UseColumnTextForButtonValue = true;
            btn1.UseColumnTextForButtonValue = true;
            bindUser();
        }
        void delete()
        {
            grid.Rows.RemoveAt(indexRow);

        }
        void edit()
        {
           // indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = grid.Rows[indexRow];
            //value from the grid is being added back to the form to their respective textfield on clicking the edit button
            nm.Text = row.Cells["Name"].Value.ToString();
            rollno.Text = row.Cells["RollNo"].Value.ToString();
            fathernm.Text = row.Cells["FatherName"].Value.ToString();
            add.Text = row.Cells["Address"].Value.ToString();
            String X = row.Cells["Gender"].Value.ToString();
            if (X.Equals(fem.Text))
                fem.Checked = true;
            else
                ml.Checked = true;
            st.Text = row.Cells["State"].Value.ToString();
            ct.Text = row.Cells["City"].Value.ToString();
            city.Clear();
            bCity();
            cous.Text = row.Cells["Course"].Value.ToString();
            email.Text = row.Cells["EmailId"].Value.ToString();
            mob.Text = row.Cells["MobileNo"].Value.ToString();


        }
        //method for the edit button in the grid table
        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            indexRow = e.RowIndex; // get the selected Row Index
            int indexCol = e.ColumnIndex;
            if (indexCol == 1)
            
                delete();
                else
                edit();

                 
           
            //for enabling update and submit
            update.Enabled = true;
            Submit.Enabled = false;
        }
        void match()
        {
            

        }
        //method to update the values of the grid 
        void updateData()
        {
            //data from the textfield is being added back to grid after being changed
            user.Rows[indexRow]["Name"] = nm.Text;
            user.Rows[indexRow]["Rollno"] = rollno.Text;
            user.Rows[indexRow]["FatherName"] = fathernm.Text;
            user.Rows[indexRow]["Address"] = add.Text;
            bool x = ml.Checked;
            if (x)
                user.Rows[indexRow]["Gender"] = ml.Text;
            else
                user.Rows[indexRow]["Gender"] = fem.Text;
            user.Rows[indexRow]["State"] = st.Text;
            user.Rows[indexRow]["City"] = ct.Text;
            user.Rows[indexRow]["Course"] = cous.Text;
            user.Rows[indexRow]["EmailId"] = email.Text;
            user.Rows[indexRow]["MobileNo"] = mob.Text;
        }
        //method for updating the content
        private void updateButton(object sender, EventArgs e)
        {
            updateData();
            clearData();
            update.Enabled = false;
            Submit.Enabled = true;
            
        }
        private void label4_Click(object sender, EventArgs e)
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

        private void st_DropDownClosed(object sender, EventArgs e)
        {
            city.Clear();
            bCity();
        }
    }
}
