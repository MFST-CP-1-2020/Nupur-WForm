using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class EmployeeDAL
    {
        SqlHelper h = new SqlHelper();

        public void AddEmployee(Employee em)
        {
            //create DBContext object
            using (var dbCtx = new TestDBEntities())
            {

                //Add Student object into Students DBset
                dbCtx.Employees.Add(em);
                // call SaveChanges method to save student into database
                dbCtx.SaveChanges();
            }
        }

        public void DeleteEmployee(Employee em)
        {
            using (var context = new TestDBEntities())
            {
                var bay = (from d in context.Employees where d.empid == em.empid select d).Single();
                context.Employees.Remove(bay);
                context.SaveChanges();
            }
        }

        public void UpdateEmployee(Employee emp)
        {

            using (TestDBEntities context = new TestDBEntities())
            {

                var student = (from d in context.Employees where d.empid == emp.empid select d).Single();
                // student = emp;
                student.firstname = emp.firstname;
                student.lastname = emp.lastname;
                student.mobileno = emp.mobileno;
                student.gender = emp.gender;
                student.state = emp.state;
                student.city = emp.city;

                context.SaveChanges();
            }


        }
        public List<Employee> GetDataVal()
        {
            using (TestDBEntities ctx = new TestDBEntities())
            {
                List<Employee> list;
                list = ctx.Employees.ToList();
                return list;

                //DataTable dt = new DataTable();

                //dt = h.DataAdapter("Display");

                //return dt;

            }

            /* public DataTable GetDataVal()
             {

                var entities = new TestDBEntities();
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
             }*/
        }
    }
}
    

