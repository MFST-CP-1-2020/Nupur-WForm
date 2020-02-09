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
        Form1 frm;
        public frmUserReg(Form1 f)
        {
            InitializeComponent();
            this.frm = f;
        }
      
        private void frmUserReg_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            frm.dataGridView1.Rows.Add(nm.Text, rollno.Text, fathernm.Text, add.Text,st.Text,ct.Text,cous.Text,email.Text,mob.Text);
            // for clearing the text field
            nm.Text = "";
            rollno.Text = "";
            fathernm.Text = "";
            add.Text = "";
           // ml.
            //fem.Text = "";
            st.Text = "";
            dist.Text = "";
            ct.Text = "";
            cous.Text = "";
            email.Text = "";
            mob.Text = "";    
            
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
    }
}
