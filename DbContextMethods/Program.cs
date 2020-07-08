using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using EdDbEfLib.Controllers;
using EdDbEfLib.Models;

namespace DbContextMethods
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var majorCtrl = new MajorsController();
            //var majors = await majorCtrl.GetAll();
            var medMajor = await majorCtrl.GetByPk(1);
            //var major = new Major()
            //{
            //    Id = 0, Code = "MEDS", Description = "Medical", MinSat = 1200
            //};
            //var result = await majorCtrl.Insert(major);
            //mathMajor.Description = "Medicinal Wizard";
            //var result = await majorCtrl.Update(mathMajor.Id, mathMajor);
            //var result = await majorCtrl.Delete(medMajor.Id);
            var studentCtrl = new StudentsController();
            var studentNew = await studentCtrl.GetByPk(67);
            //var student = new Student()
            //{
            //    Id = 0,
            //    Firstname = "Franklin",
            //    Lastname = "Borgono",
            //    StateCode = "IL",
            //    Sat = 1230,
            //    Gpa = 3.8m
            //};
            //var result = await studentCtrl.Insert(student);
            studentNew.MajorId = 9;
            var result = await studentCtrl.Update(studentNew.Id, studentNew);
        }
    }
}
