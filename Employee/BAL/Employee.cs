using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BAL
{
    public class EmployeeBAL
    {

        /* public int empid { get; set; }
         public string firstnm { get; set; }
         public string lastnm { get; set; }
         public long mob { get; set; }
         public string state { get; set; }
         public string city { get; set; }
         public string gender { get; set; }*/

        SqlHelper h = new SqlHelper();//object of our sql helper class
        EmployeeDAL emp = new EmployeeDAL();
        /// <summary>
        /// add method for performing add operations in our EmployeeBALform
        /// </summary>

        public void AddEmployeeBAL(Employee em)
        {
            emp.AddEmployee(em);
            /*SetParameterVal(em);
            h.ExecuteScalar("AddEmployeeBAL");*/
        }
      

        /// <summary>
        /// getdata method for displaying the data from database
        /// </summary>
        /// <returns></returns>

        public List<Employee> GetData()
        {

            // DataTable dt = new DataTable();
            //dt=emp.GetDataVal();
            //dt = h.DataAdapter("Display");
            //return dt;
            return emp.GetDataVal();
           

        }

        /// <summary>
        /// delete method to delete data from the EmployeeBAL datatable 
        /// </summary>
        /// <param name="user"></param>
        /// 
        public void DeleteEmployeeBAL(Employee user)
        {
            emp.DeleteEmployee(user);
            /*SetParameterValDel(user);
            h.ExecuteNonQuery("DeleteEmployeeBAL");*/

        }

        /// <summary>
        /// update method to update the records of the EmployeeBAL datatable
        /// </summary>

        public void UpdateEmployeeBAL(Employee user)
        {
            emp.UpdateEmployee(user);
            /*SetParameterVal(user);
            h.ExecuteNonQuery("UpdateEmployeeBAL");*/

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
    
