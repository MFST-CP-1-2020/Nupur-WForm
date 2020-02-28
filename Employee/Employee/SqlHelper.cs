using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// sql helper class for establishing database connectivity with employee form
/// </summary>

namespace Employee
{
    public class SqlHelper
    {
        private string connectionString;
        private List<SqlParameter> parameters = new List<SqlParameter>();


       public  SqlHelper()
        {
            connectionString = @"Database=TestDB;server=NUPUR\SQLEXPRESS;user id=sa;password=mindfire@1";
        }
        
    


        /// <summary>
        /// method used for calling stored procedure "AddEmployee"for inserting data into database
        /// </summary>
        /// <param name="command"></param>
        
        public void ExecuteScalar()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            cnn.Open();
            command.Connection = cnn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddEmployee";
            command.Parameters.Clear();
            //
            if (parameters.Count > 0)
            {
                command.Parameters.AddRange(parameters.ToArray());
            }
            try
            {
                string val = (command.ExecuteScalar().ToString());//for returning the the primarykey inserted
                MessageBox.Show(val);
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception " + ex.ToString());
            }

            if (cnn != null)
            {
                parameters.Clear();
                cnn.Close();

            }
        }

        /// <summary>
        /// statements like UPDATE,  DELETE can be used.
        ///ExecuteNonQuery returns no rows, any output parameters or return values mapped to parameters are populated with data.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cmdText"></param>
        
        public void ExecuteNonQuery(string cmdText)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            cnn.Open();
            command.Connection = cnn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = cmdText;
            command.Parameters.Clear();
            //
            if (parameters.Count > 0)
            {
                command.Parameters.AddRange(parameters.ToArray());
            }
            command.ExecuteNonQuery();

            if (cnn != null)
            {
                parameters.Clear();
                cnn.Close();

            }

        }
          
        /// <summary>
        /// this method is used for displaying the datatable in the datagrid
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
                     
        public DataTable DataAdapter(String s)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            cnn.Open();
            command.Connection = cnn;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(s, cnn);
            DataTable dt = new DataTable();
            if (cnn != null)
            {
                parameters.Clear();
                cnn.Close();

            }
            adapter.Fill(dt);
            return dt;
        }

        /// < summary>
        /// This function is use to create Sql Parameters for execute query.
        /// </summary>
        /// <param name="paramName">ParameterName</param>
        /// <param name="paramType">SqlDbType</param>
        /// <param name="paramDirection">Direction</param>
        /// <param name="obj">object </param>
        /// <param name="command">SqlCommand class object</param>
       
        public void ParameterValues(string paramName, SqlDbType paramType, ParameterDirection paramDirection, object obj)
        {
            SqlParameter val = new SqlParameter();
            val.ParameterName = paramName;
            val.SqlDbType = paramType;
            val.Direction = paramDirection;
            val.Value = obj;
            //command.Parameters.Add(val);
            parameters.Add(val);
        }
    }
}
/*
         /// <summary>
        /// method to read data one by one using execute reader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        
        public string DataReader()
        {
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            command.Connection = cnn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Display";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                output = output + reader.GetValue(0) + reader.GetValue(1) + reader.GetValue(2) + reader.GetValue(3) + reader.GetValue(4) + reader.GetValue(5) + reader.GetValue(6) + "\n";
            }
            return output;
     */

 


