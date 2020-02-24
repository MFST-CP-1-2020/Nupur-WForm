using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// user class for performing add,update,delete and view methods for our
/// employee registration form.
/// </summary>

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

        SqlHelper h = new SqlHelper();//object of our sql helper class

        /// <summary>
        /// add method for performing add operations in our employeeform
        /// </summary>
        
        public void AddEmployee()
        {
            h.OpenConnection();
            h.ExecuteScalar(SetParameterVal(this));
            h.CloseConnection();
        }
          
        /// <summary>
        /// getdata method for displaying the data from database
        /// </summary>
        /// <returns></returns>
                     
        public DataTable GetData()
        {
            h.OpenConnection();
            DataTable dt = new DataTable();
            dt = h.DataAdapter("Display");
            return dt;
           
        }

        /// <summary>
        /// delete method to delete data from the employee datatable 
        /// </summary>
        /// <param name="user"></param>
        /// 
        public void DeleteEmployee(User user)
        {
            h.OpenConnection();
            h.ExecuteNonQuery(user.SetParameterValDel(user),"DeleteEmployee");
            h.CloseConnection();
        }

        /// <summary>
        /// update method to update the records of the employee datatable
        /// </summary>
        
        public void UpdateEmployee(User user)
        {
            h.OpenConnection();
            h.ExecuteNonQuery(user.SetParameterVal(user),"UpdateEmployee");
            h.CloseConnection();
        }
       

        /// <summary>
        /// method for deleting records from employee datatable using empid
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        
        public SqlCommand SetParameterValDel(User user)
        {
           SqlCommand command = new SqlCommand();
           h.ParameterValues("@empid", SqlDbType.Int, ParameterDirection.Input, user.empid, command);
           return command;
        }

        /// <summary>
        /// method for assigning the value to parameternames
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        
        public SqlCommand SetParameterVal(User user)
        {
           SqlCommand command = new SqlCommand();
           h.ParameterValues("@empid", SqlDbType.Int, ParameterDirection.Input, user.empid, command);
           h.ParameterValues("@FirstName", SqlDbType.NVarChar, ParameterDirection.Input, user.firstnm, command);
           h.ParameterValues("@LastName", SqlDbType.NVarChar, ParameterDirection.Input, user.lastnm, command);
           h.ParameterValues("@MobileNo", SqlDbType.NVarChar, ParameterDirection.Input, user.mob, command);
           h.ParameterValues("@Gender", SqlDbType.NVarChar, ParameterDirection.Input, user.gender, command);
           h.ParameterValues("@State", SqlDbType.NVarChar, ParameterDirection.Input, user.state, command);
           h.ParameterValues("@City", SqlDbType.NVarChar, ParameterDirection.Input, user.city, command);
            return command;
        }
    }
}//end of namespace


