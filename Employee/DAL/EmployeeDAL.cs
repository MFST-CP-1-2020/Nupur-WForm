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
    public class EmployeeDAL
    {

        /// <summary>
        /// method to add data into the database
        /// </summary>
        /// <param name="em"></param>
        
        public void AddEmployee(Employee em)
        {
            //create DBContext object
            using (var dbCtx = new TestDBEntities1())
            {
                //Add Student object into Students DBset
                dbCtx.Employees.Add(em);
                // call SaveChanges method to save student into database
                dbCtx.SaveChanges();
            }
        }

        /// <summary>
        /// method to delete data from employee table
        /// </summary>
        /// <param name="em"></param>
       
        public void DeleteEmployee(Employee em)
        {
            using (var context = new TestDBEntities1())
            {
                var bay = (from d in context.Employees where d.empid == em.empid select d).Single();
                context.Employees.Remove(bay);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// method to update employee 
        /// </summary>
        /// <param name="emp"></param>
        
        public void UpdateEmployee(Employee emp)
        {
            using (TestDBEntities1 context = new TestDBEntities1())
            {
                var employee = (from d in context.Employees where d.empid == emp.empid select d).Single();
                employee.firstname = emp.firstname;
                employee.lastname = emp.lastname;
                employee.mobileno = emp.mobileno;
                employee.gender = emp.gender;
                employee.state = emp.state;
                employee.city = emp.city;
                context.SaveChanges();
            }
        }
      
        /// <summary>
        /// // method to display data into the datagrid
        /// </summary>
        /// <returns></returns>
        
             public DataTable GetDataVal()
             {
                 var entities = new TestDBEntities1();
                 DataTable table = AddCol();
                     var dt = (from d in entities.Employees select d);
                     foreach (var obj in dt)
                     {
                     DataRow dr = table.NewRow();
                     dr["EmpId"]= obj.empid;
                     dr["FirstName"] = obj.firstname;
                     dr["LastName"] = obj.lastname;
                     dr["MobileNo"] = obj.mobileno;
                     dr["Gender"] = obj.gender;
                     dr["State"] = obj.state;
                     dr["City"] = obj.city;
                     table.Rows.Add(dr);
                 }
                     return table;
                 }

        /// <summary>
        /// methods to add column in datagrid
        /// </summary>
        /// <returns></returns>
        
             public DataTable AddCol()
             {
                 DataTable dt = new DataTable();
                 dt.Columns.Add("EmpId");
                 dt.Columns.Add("FirstName");
                 dt.Columns.Add("LastName");
                 dt.Columns.Add("MobileNo");
                 dt.Columns.Add("Gender");
                 dt.Columns.Add("State");
                 dt.Columns.Add("City");
                 return dt;
             }
        }
    }

    

