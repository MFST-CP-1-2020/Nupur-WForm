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
    class SqlHelper
    {
        string connectionString;
        SqlConnection cnn;

        /// <summary>
        /// method for establishing database connectivity
        /// </summary>
        
        public void OpenConnection()
        {
            connectionString = @"Database=TestDB;server=NUPUR\SQLEXPRESS;user id=sa;password=mindfire@1";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }

        /// <summary>
        /// method for closing the connection with the database.
        /// </summary>
        
        public void CloseConnection()
        {
            cnn.Close();
        }

        /// <summary>
        /// method used for calling stored procedure "AddEmployee"for inserting data into database
        /// </summary>
        /// <param name="command"></param>
        
        public void ExecuteScalar(SqlCommand command)
        {
            command.Connection = cnn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AddEmployee";
            try
            {
                string val = (command.ExecuteScalar().ToString());//for returning the the primarykey inserted
                MessageBox.Show(val);
            }
            catch (Exception ex)
            {
                MessageBox.Show("exception " + ex.ToString());
            }
            command.Dispose();
            cnn.Close();
        }

        /// <summary>
        /// statements like UPDATE,  DELETE can be used.
        ///ExecuteNonQuery returns no rows, any output parameters or return values mapped to parameters are populated with data.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cmdText"></param>
        
        public void ExecuteNonQuery(SqlCommand command,string cmdText)
        {
            command.Connection = cnn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = cmdText;
            command.ExecuteNonQuery();

        }
          
        /// <summary>
        /// this method is used for displaying the datatable in the datagrid
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
                     
        public DataTable DataAdapter(String s)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = cnn;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(s, cnn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        /// <summary>
        /// This function is use to create Sql Parameters for execute query.
        /// </summary>
        /// <param name="paramName">ParameterName</param>
        /// <param name="paramType">SqlDbType</param>
        /// <param name="paramDirection">Direction</param>
        /// <param name="obj">object </param>
        /// <param name="command">SqlCommand class object</param>

        public void ParameterValues(string paramName, SqlDbType paramType, ParameterDirection paramDirection, object obj, SqlCommand command)
        {
            SqlParameter val = new SqlParameter();
            val.ParameterName = paramName;
            val.SqlDbType = paramType;
            val.Direction = paramDirection;
            val.Value = obj;
            command.Parameters.Add(val);
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

 


