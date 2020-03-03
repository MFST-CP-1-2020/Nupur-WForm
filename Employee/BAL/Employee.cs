using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using BAL.Mapper;

/// <summary>
/// this class contain business logic code for data manipulation
/// </summary>

namespace BAL
{
    public class EmployeeBAL
    {
        EmployeeDAL emp = new EmployeeDAL();
        EmpMapper map = new EmpMapper();
       
        /// <summary>
        /// add method for performing add operations in our EmployeeBALform
        /// </summary>

        public void AddEmployeeBAL(EmpDTO em)
        {
            emp.AddEmployee(map.GetModel(em));
        }
      
        /// <summary>
        /// getdata method for displaying the data from database
        /// </summary>
        /// <returns></returns>

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            dt=emp.GetDataVal();
            return dt;
        }

        /// <summary>
        /// delete method to delete data from the EmployeeBAL datatable 
        /// </summary>
        /// <param name="user"></param>
        
        public void DeleteEmployeeBAL(EmpDTO em)
        {
            emp.DeleteEmployee(map.GetModel(em));
        }

        /// <summary>
        /// update method to update the records of the EmployeeBAL datatable
        /// </summary>

        public void UpdateEmployeeBAL(EmpDTO em)
        {
            emp.UpdateEmployee(map.GetModel(em));
        }
    }
}



        /// <summary>
        /// method for deleting records from EmployeeBAL datatable using empid
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        /*public SqlCommand SetParameterValDel(EmpDTO user)
        {
            SqlCommand command = new SqlCommand();
            h.ParameterValues("@empid", SqlDbType.Int, ParameterDirection.Input, user.empid);
            return command;
        }

        /// <summary>
        /// method for assigning the value to parameternames
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        public void SetParameterVal(EmpDTO user)
        {
            //SqlCommand command = new SqlCommand();
            h.ParameterValues("@empid", SqlDbType.Int, ParameterDirection.Input, user.empid);
            h.ParameterValues("@FirstName", SqlDbType.NVarChar, ParameterDirection.Input, user.firstnm);
            h.ParameterValues("@LastName", SqlDbType.NVarChar, ParameterDirection.Input, user.lastnm);
            h.ParameterValues("@MobileNo", SqlDbType.NVarChar, ParameterDirection.Input, user.mob);
            h.ParameterValues("@Gender", SqlDbType.NVarChar, ParameterDirection.Input, user.gender);
            h.ParameterValues("@State", SqlDbType.NVarChar, ParameterDirection.Input, user.state);
            h.ParameterValues("@City", SqlDbType.NVarChar, ParameterDirection.Input, user.city);
            // return command;
        }
        */
    
