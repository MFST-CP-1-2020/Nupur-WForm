using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
/// <summary>
/// mapper class to map the objects of DTO class with entitymodel
/// </summary>

namespace BAL.Mapper
{
    public class EmpMapper
    {
        public Employee GetModel(EmpDTO emp)
        {
            Employee obj = new Employee();
            obj.empid = emp.empid;
            obj.firstname = emp.firstnm;
            obj.lastname = emp.lastnm;
            obj.mobileno = emp.mob;
            obj.gender = emp.gender;
            obj.state = emp.state;
            obj.city = emp.city;
            return obj;
        }
    }
}
