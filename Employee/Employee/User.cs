using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    class User
    {
        public int empid { get; set; }
        public string firstnm { get; set; }
        public string lastnm { get; set; }
        public long mob { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string gender { get; set; }
        SqlHelper h = new SqlHelper();
        public void add(User user)
        {
            h.connection();
            h.executeScalar(h.SetParameterVal(user));
        }
       
        public DataTable getData()
        {
            h.connection();
            DataTable dt = new DataTable();
            dt = h.dataAdapter("Display");
            return dt;
        }
        public void del(User user)
        {
            h.connection();
            h.executeNonQuery(h.SetParameterValDel(user),"DeleteEmployee");
        }
        public void update(User user)
        {
            h.connection();
            h.executeNonQuery(h.SetParameterVal(user),"UpdateEmployee");
        }
    }
}//end of namespace

/* public void view()
        {
            h.connection();
            string sql = $"select * from Employee";
            string s = h.dataReader(sql);
            MessageBox.Show(s);
        }*/
