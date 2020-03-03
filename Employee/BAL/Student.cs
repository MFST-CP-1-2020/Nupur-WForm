using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BAL.Mapper;
using DTO;

/// <summary>
/// this class contain business logic code for data manipulation
/// </summary>

namespace BAL
{
    public class Student
    {
       StudentDAL obj = new StudentDAL();
       StudentMapper map=new StudentMapper();

        /// <summary>
        /// add method for performing add operations in our studentform
        /// </summary>
        
        public void AddStudent(StdDTOcs em)
        {
           obj.AddStudentVal(map.GetModel(em));
             
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
            obj.DeleteStudentVal(map.GetModel(user));
        }

        /// <summary>
        /// update method to update the records of the student datatable
        /// </summary>

        public void UpdateStudent(StdDTOcs user)
        {
            obj.UpdateStudentVal(map.GetModel(user));
        }
    }
}
