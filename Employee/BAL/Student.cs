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
    public class Student
    {
       /* public int studentid { get; set; }
        public string firstnm { get; set; }
        public string lastnm { get; set; }
        public long mob { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string gender { get; set; }*/

        SqlHelper h = new SqlHelper();//object of our sql helper class
        //StdDTOcs em = new StdDTOcs();
       StudentDAL obj = new StudentDAL();

        /// <summary>
        /// add method for performing add operations in our studentform
        /// </summary>
        
        public string AddStudent(StdDTOcs em)
        {
           string val= obj.AddStudentVal(em);
            /* SetParameterVal(em);
             string val= h.ExecuteScalar("AddStudent");*/
             return val;
        }

        /// <summary>
        /// getdata method for displaying the data from database
        /// </summary>
        /// <returns></returns>

        public DataTable GetData()
        {
            
            DataTable dt = new DataTable();
           dt= obj.GetDataVal();
            return dt;
        }

        /// <summary>
        /// delete method to delete data from the student datatable 
        /// </summary>
        /// <param name="user"></param>
        
        public void DeleteStudent(StdDTOcs user)
        {
            obj.DeleteStudentVal(user);
            /*SetParameterValDel(user);
            h.ExecuteNonQuery("DeleteStudent");*/
        }

        /// <summary>
        /// update method to update the records of the student datatable
        /// </summary>

        public void UpdateStudent(StdDTOcs user)
        {
            obj.UpdateStudentVal(user);
           /* SetParameterVal(user);
            h.ExecuteNonQuery("UpdateStudent");*/

        }

        /// <summary>
        /// method for deleting records from student datatable using stdid
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

      /*  public void SetParameterValDel(StdDTOcs user)
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
        */
    }
}
