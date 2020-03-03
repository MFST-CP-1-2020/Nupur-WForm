using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

/// <summary>
/// this class is resposible for interacting with database and CRUD operations
/// </summary>

namespace DAL
{
   public  class StudentDAL
    {
        /// <summary>
        /// method to add data to student table
        /// </summary>
        /// <param name="cs"></param>
        
        public void AddStudentVal(Student cs)
        {
            
            using (var dbCtx = new TestDBEntities1())
            {
                //Add Student object into Students DBset
                dbCtx.Students.Add(cs);
                //id = ob.StudentId;
                // call SaveChanges method to save student into database
                dbCtx.SaveChanges();
            }
        }

        /// <summary>
        /// getdata method for displaying the data from database
        /// </summary>
        /// <returns></returns>
        
        public DataTable GetDataVal()
        {

            var entities = new TestDBEntities1();
            DataTable table = AddCol();
            var dt = (from d in entities.Students select d);

            foreach (var obj in dt)
            {
                DataRow dr = table.NewRow();
                dr["StudentId"] = obj.StudentId;
                dr["FirstName"] = obj.FirstName;
                dr["LastName"] = obj.LastName;
                dr["MobileNo"] = obj.MobileNo;
                dr["Gender"] = obj.Gender;
                dr["State"] = obj.State;
                dr["City"] = obj.City;
                table.Rows.Add(dr);
            }
            return table;
        }

        /// <summary>
        /// method to add columnname to datagrid
        /// </summary>
        /// <returns></returns>
        
        public DataTable AddCol()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("StudentId");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("MobileNo");
            dt.Columns.Add("Gender");
            dt.Columns.Add("State");
            dt.Columns.Add("City");
            return dt;
        }

        /// <summary>
        /// delete method to delete data from the student datatable 
        /// </summary>
        /// <param name="user"></param>

        public void DeleteStudentVal(Student user)
        {
            using (var context = new TestDBEntities1())
            {
                var bay = (from d in context.Students where d.StudentId == user.StudentId select d).Single();
                context.Students.Remove(bay);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// update method to update the records of the student datatable
        /// </summary>

        public void UpdateStudentVal(Student emp)
        {
            using (TestDBEntities1 context = new TestDBEntities1())
            {
                context.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        
    }
}
