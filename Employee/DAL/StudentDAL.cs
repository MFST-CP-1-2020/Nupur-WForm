using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
   public  class StudentDAL
    {
        SqlHelper h = new SqlHelper();
        public string AddStudentVal(StdDTOcs cs)
        {
            SetParameterVal(cs);
            string val = h.ExecuteScalar("AddStudent"); 
             return val;
        }
        /// <summary>
        /// getdata method for displaying the data from database
        /// </summary>
        /// <returns></returns>

        public DataTable GetDataVal()
        {

            DataTable dt = new DataTable();
            dt = h.DataAdapter("Display");
            return dt;
        }

        /// <summary>
        /// delete method to delete data from the student datatable 
        /// </summary>
        /// <param name="user"></param>

        public void DeleteStudentVal(StdDTOcs user)
        {
            SetParameterValDel(user);
            h.ExecuteNonQuery("DeleteStudent");
        }

        /// <summary>
        /// update method to update the records of the student datatable
        /// </summary>

        public void UpdateStudentVal(StdDTOcs user)
        {
           
             SetParameterVal(user);
             h.ExecuteNonQuery("UpdateStudent");

        }

        /// <summary>
        /// method for deleting records from student datatable using stdid
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

          public void SetParameterValDel(StdDTOcs user)
          {

              h.ParameterValues("@stdid", SqlDbType.Int, ParameterDirection.Input, user.studentid);

          }

          /// <summary>
          /// method for assigning the value to parameternames
          /// </summary>
          /// <param name="user"></param>
          /// <returns></returns>

          public void SetParameterVal(StdDTOcs user)
          {
             h.ParameterValues("@stdid", SqlDbType.Int, ParameterDirection.Input, user.studentid);
              h.ParameterValues("@FirstName", SqlDbType.NVarChar, ParameterDirection.Input, user.firstnm);
              h.ParameterValues("@LastName", SqlDbType.NVarChar, ParameterDirection.Input, user.lastnm);
              h.ParameterValues("@MobileNo", SqlDbType.NVarChar, ParameterDirection.Input, user.mob);
              h.ParameterValues("@Gender", SqlDbType.NVarChar, ParameterDirection.Input, user.gender);
              h.ParameterValues("@State", SqlDbType.NVarChar, ParameterDirection.Input, user.state);
              h.ParameterValues("@City", SqlDbType.NVarChar, ParameterDirection.Input, user.city);
          }
          
    }
}
