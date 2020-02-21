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
    class SqlHelper
    {
        string connectionString;
        SqlConnection cnn;
        public void connection()
        {
            connectionString = @"Database=TestDB;server=NUPUR\SQLEXPRESS;user id=sa;password=mindfire@1";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }
        //for adding employee to data grid
        public void executeScalar(SqlCommand command)
        {
            command.Connection = cnn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddEmployee";
            try
            {
                string val = (command.ExecuteScalar().ToString());
                MessageBox.Show(val);
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception " + ex.ToString());
            }
            command.Dispose();
            cnn.Close();
        }
        //for deleting and updating the grid
        public void executeNonQuery(SqlCommand command,string cmdText)
        {
            command.Connection = cnn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = cmdText;
            command.ExecuteNonQuery();

        }  
        //for viewing data     
        public DataTable dataAdapter(String s)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = cnn;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(s, cnn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        //for adding parameter values
        public void ParameterValues(string s, SqlDbType db, ParameterDirection d, object obj, SqlCommand command)
        {
            SqlParameter val = new SqlParameter();
            val.ParameterName = s;
            val.SqlDbType = db;
            val.Direction = d;
            val.Value = obj;
            command.Parameters.Add(val);
        }
        //for delete method
        public SqlCommand SetParameterValDel(User user)
        {
            SqlCommand command = new SqlCommand();
            ParameterValues("@empid", SqlDbType.Int, ParameterDirection.Input, user.empid, command);
            return command;
        }
        //for insert and update method
        public SqlCommand SetParameterVal(User user)
        {
            SqlCommand command = new SqlCommand();
            ParameterValues("@empid", SqlDbType.Int, ParameterDirection.Input, user.empid, command);
            ParameterValues("@FirstName", SqlDbType.NVarChar, ParameterDirection.Input, user.firstnm, command);
            ParameterValues("@LastName", SqlDbType.NVarChar, ParameterDirection.Input, user.lastnm, command);
            ParameterValues("@MobileNo", SqlDbType.NVarChar, ParameterDirection.Input, user.mob, command);
            ParameterValues("@Gender", SqlDbType.NVarChar, ParameterDirection.Input, user.gender, command);
            ParameterValues("@State", SqlDbType.NVarChar, ParameterDirection.Input, user.state, command);
            ParameterValues("@City", SqlDbType.NVarChar, ParameterDirection.Input, user.city, command);
            return command;
        }
      }
}
/*  
 public string dataReader(string sql)
 {
     SqlDataReader reader;
     command.Connection = cnn;
     command.CommandText=sql;
     reader = command.ExecuteReader();
     while (reader.Read())
     {
         output = output + reader.GetValue(0) + reader.GetValue(1) + reader.GetValue(2) + reader.GetValue(3) + reader.GetValue(4) + reader.GetValue(5) + reader.GetValue(6) + "\n";
     }
     return output;
 }*/


