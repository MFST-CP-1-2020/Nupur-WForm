using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WFormAppN.Student
{ 
    public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();


    }
    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        ds.ReadXml(@"D:\Projects\WFormCP\WFormAppN\WFormAppN\Student\XMLFile1.xml");
        dataGridView1.DataSource = ds.Tables[0];

    }
}
}
