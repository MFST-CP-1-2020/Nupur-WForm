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
    class StudentMapper
    {
        public DAL.Student GetModel(StdDTOcs std)
        {
            DAL.Student obj = new DAL.Student();
            obj.StudentId = std.studentid;
            obj.FirstName = std.firstnm;
            obj.LastName = std.lastnm;
            obj.MobileNo = std.mob;
            obj.Gender = std.gender;
            obj.State = std.state;
            obj.City = std.city;
            return obj;
        }

    }
}
