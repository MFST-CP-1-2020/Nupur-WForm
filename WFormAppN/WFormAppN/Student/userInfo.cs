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
    public partial class userInfo : Form
    {
        public userInfo()
        {
            InitializeComponent();
        }

        UserData obj = new UserData();
        List<UserData> l = new List<UserData>();
        DataTable state = new DataTable();
        DataTable city = new DataTable();
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
            state.Rows.Add(1, "UttarPradesh");
            state.Rows.Add(2, "Uttarakhand");
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
            int x = st.SelectedIndex;
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

        private void userInfo_Load(object sender, EventArgs e)
        {
            bindContents();
            addColCity();
        }
        void inputToGrid()
        {
           
            obj.Name = nm.Text;
            obj.Rollno = int.Parse(r.Text);
            obj.FatherName = fnm.Text;
            obj.Address = add.Text;
            if (ml.Checked)
                obj.Gender = ml.Text;
            else
                obj.Gender = fem.Text;
            obj.State = st.Text;
            obj.City = ct.Text;
            obj.Course = cous.Text;
            obj.EmailId = email.Text;
            obj.MobileNo =int.Parse( mob.Text);

        }

        private void submit_Click(object sender, EventArgs e)
        {
            inputToGrid();
            l.Add(obj);
            var sour = new BindingSource();
            sour.DataSource = l;
            grid.DataSource = sour;
        }

        private void stClosed(object sender, EventArgs e)
        {
            city.Clear();
            bCity();
        }
    }
    class UserData
    {
        public string Name { get; set; }
        public int Rollno{ get; set; }
       public string FatherName { get; set; }
        public  string Address { get; set; }
        public string Gender { get; set; }
        public string State{ get; set; }
        public string City { get; set; }
        public  string Course{ get; set; }
        public  string EmailId{ get; set; }
        public long MobileNo{ get; set; }

    }
}
