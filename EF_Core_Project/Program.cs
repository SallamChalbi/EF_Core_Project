using EF_Core_Project.Contexts;
using EF_Core_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIProjectDbContext dbContext = new ITIProjectDbContext();

            #region CRUD Operations 
            #region Instructors
            #region Create / Insert
            //Instructor ins1 = new Instructor() { Name = "Amin", Bouns = 20, Salary = 2_000, HourRate = 40 };
            //Instructor ins2 = new Instructor() { Name = "Omar", Adress = "Gabes", Bouns = 10, Salary = 1_500, HourRate = 30 };
            //Instructor testIns = new Instructor() { Name = "TestIns", Bouns = 10, Salary = 1_000, HourRate = 20 };

            //Console.WriteLine(dbContext.Entry(ins1).State);
            //dbContext.Instructors.Add(ins1);
            //dbContext.Instructors.Add(ins2);
            //dbContext.Instructors.Add(testIns);
            //Console.WriteLine(dbContext.Entry(ins1).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(ins1).State);
            #endregion

            #region Read / Select 
            //var insRead = (from I in dbContext.Instructors
            //               where I.Id == 1
            //               select I).FirstOrDefault();
            //Console.WriteLine(insRead?.Name ?? "N/A");
            #endregion

            #region Update 
            //var insUpdate = dbContext.Instructors.FirstOrDefault(I => I.Id == 2);
            //Console.WriteLine(dbContext.Entry(insUpdate).State);
            //insUpdate.Name = "Hamza";
            //Console.WriteLine(dbContext.Entry(insUpdate).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(insUpdate).State);
            #endregion

            #region Delete
            //var insDelete = (from I in dbContext.Set<Instructor>()
            //                 where I.Id == 3
            //                 select I).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(insDelete).State);
            //dbContext.Instructors.Remove(insDelete);
            //Console.WriteLine(dbContext.Entry(insDelete).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(insDelete).State);
            #endregion
            #endregion

            #region Departments
            #region Create 
            //Department dept1 = new Department() { Name = "D01", HiringDate = DateTime.Now };
            //Department dept2 = new Department() { Name = "D02", HiringDate = DateTime.Now };
            //Department testDept = new Department() { Name = "TestDept" };

            //Console.WriteLine(dbContext.Entry(dept1).State);
            //dbContext.Add(dept1);
            //dbContext.Add(dept2);
            //dbContext.Add(testDept);
            //Console.WriteLine(dbContext.Entry(dept1).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(dept1).State);
            #endregion

            #region Read
            //var deptRead = dbContext.Departments.FirstOrDefault(D => D.Id == 10);
            //Console.WriteLine(deptRead?.Name ?? "N/A");
            #endregion

            #region Update 
            //var deptUpdate = (from D in dbContext.Departments
            //                  where D.Id == 20
            //                  select D).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(deptUpdate).State);
            //deptUpdate.Name = "Dept2";
            //Console.WriteLine(dbContext.Entry(deptUpdate).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(deptUpdate).State);
            #endregion

            #region Delete 
            //var deptDelete = dbContext.Departments.FirstOrDefault(D => D.Id == 30);
            //Console.WriteLine(dbContext.Entry(deptDelete).State);
            //dbContext.Remove(deptDelete);
            //Console.WriteLine(dbContext.Entry(deptDelete).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(deptDelete).State);
            #endregion
            #endregion

            #region Students
            #region Create 
            //Student st1 = new Student() { FName = "Ahmed", LName = "Fatnasi", Age = 22, Adress = "Mahres" };
            //Student st2 = new Student() { FName = "Mona", LName = "Abdelaziz", Age = 21, Adress = "Areana" };
            //Student testSt = new Student() { FName = "testSt", LName = "testSt", Age = 22 };

            //Console.WriteLine(dbContext.Entry(st1).State);
            //dbContext.Students.Add(st1);
            //dbContext.Students.Add(st2);
            //dbContext.Students.Add(testSt);
            //Console.WriteLine(dbContext.Entry(st1).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(st1).State);
            #endregion

            #region Read 
            //var StRead = dbContext.Students.FirstOrDefault(S => S.Id == 1);
            //Console.WriteLine(StRead?.FName ?? "N/A");
            #endregion

            #region Update 
            //var StUpdate = (from S in dbContext.Students
            //                where S.Id == 2
            //                select S).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(StUpdate).State);
            //StUpdate.LName = "Mahmoud";
            //Console.WriteLine(dbContext.Entry(StUpdate).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(StUpdate).State);
            #endregion

            #region Delete 
            //var stDelete = dbContext.Students.FirstOrDefault(S => S.Id == 4);
            //Console.WriteLine(dbContext.Entry(stDelete).State);
            //dbContext.Students.Remove(stDelete);
            //Console.WriteLine(dbContext.Entry(stDelete).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(stDelete).State);
            #endregion
            #endregion

            #region Topic
            #region Create 
            //Topic top1 = new Topic() { Name = "Binding" };
            //Topic top2 = new Topic() { Name = "L2O" };
            //Topic testTop = new Topic() { Name = "testTop" };

            //Console.WriteLine(dbContext.Entry(top1).State);
            //dbContext.Add(top1);
            //dbContext.Add(top2);
            //dbContext.Add(testTop);
            //Console.WriteLine(dbContext.Entry(top1).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(top1).State);
            #endregion

            #region Read
            //var topRead = dbContext.Topic.FirstOrDefault(T => T.Id == 1);
            //Console.WriteLine(topRead?.Name ?? "N/A");
            #endregion

            #region Update 
            //var topUpdate = (from T in dbContext.Topic
            //                 where T.Id == 2
            //                 select T).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(topUpdate).State);
            //topUpdate.Name = "L2EF";
            //Console.WriteLine(dbContext.Entry(topUpdate).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(topUpdate).State);
            #endregion

            #region Delete 
            //var topDelete = dbContext.Topic.FirstOrDefault(T => T.Id == 3);
            //Console.WriteLine(dbContext.Entry(topDelete).State);
            //dbContext.Topic.Remove(topDelete);
            //Console.WriteLine(dbContext.Entry(topDelete).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(topDelete).State);
            #endregion
            #endregion

            #region Courses
            #region Create 
            //Course c1 = new Course() { Name = "C#", Duration = 5, TopicId = 1 };
            //Course c2 = new Course() { Name = "Programming", Duration = 7, TopicId = 1 };
            //Course testC = new Course() { Name = "testC", Duration = 3, TopicId = 2 };
            //Console.WriteLine(dbContext.Entry(c1).State);
            //dbContext.Courses.Add(c1);
            //dbContext.Courses.Add(c2);
            //dbContext.Courses.Add(testC);
            //Console.WriteLine(dbContext.Entry(c1).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(c1).State);
            #endregion

            #region Read
            //var cRead = dbContext.Courses.FirstOrDefault(C => C.Id == 1);
            //Console.WriteLine(cRead?.Name ?? "N/A");
            #endregion

            #region Update 
            //var cUpdate = (from C in dbContext.Courses
            //               where C.Id == 2
            //               select C).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(cUpdate).State);
            //cUpdate.TopicId = 2;
            //Console.WriteLine(dbContext.Entry(cUpdate).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(cUpdate).State);
            #endregion

            #region Delete 
            //var cDelete = dbContext.Courses.FirstOrDefault(C => C.Id == 3);
            //Console.WriteLine(dbContext.Entry(cDelete).State);
            //dbContext.Remove(cDelete);
            //Console.WriteLine(dbContext.Entry(cDelete).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(cDelete).State);
            #endregion
            #endregion

            #region StudentCourse 
            #region Create 
            //StudentCourse sc1 = new StudentCourse() { StudentId = 1, CourseId = 1, Grade = 80 };
            //StudentCourse sc2 = new StudentCourse() { StudentId = 1, CourseId = 2, Grade = 90 };
            //StudentCourse testSC = new StudentCourse() { StudentId = 2, CourseId = 2, Grade = 70 };

            //Console.WriteLine(dbContext.Entry(sc1).State);
            //dbContext.Add(sc1);
            //dbContext.Add(sc2);
            //dbContext.Add(testSC);
            //Console.WriteLine(dbContext.Entry(sc1).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(sc1).State);
            #endregion

            #region Read 
            //var scRead = dbContext.Set<StudentCourse>().FirstOrDefault(SC => SC.StudentId == 1 && SC.CourseId == 1);
            //Console.WriteLine(scRead?.Grade ?? 0);
            #endregion

            #region Update 
            //var scUpdate = (from SC in dbContext.Set<StudentCourse>()
            //                where SC.StudentId == 1 && SC.CourseId == 2
            //                select SC).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(scUpdate).State);
            //scUpdate.Grade = 100;
            //Console.WriteLine(dbContext.Entry(scUpdate).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(scUpdate).State);
            #endregion

            #region Delete 
            //var scDelete = dbContext.Set<StudentCourse>().FirstOrDefault(SC => SC.StudentId == 2 && SC.CourseId == 2);
            //Console.WriteLine(dbContext.Entry(scDelete).State);
            //dbContext.Remove(scDelete);
            //Console.WriteLine(dbContext.Entry(scDelete).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(scDelete).State);
            #endregion
            #endregion

            #region CourseInstructor
            #region Create 
            //CourseInstructor ci1 = new CourseInstructor() { InstructorId = 1, CourseId = 1, Evaluate = "Good" };
            //CourseInstructor ci2 = new CourseInstructor() { InstructorId = 1, CourseId = 2, Evaluate = "Nice" };
            //CourseInstructor ciTest = new CourseInstructor() { InstructorId = 2, CourseId = 2, Evaluate = "Bad" };
            //Console.WriteLine(dbContext.Entry(ci1).State);
            //dbContext.Add(ci1);
            //dbContext.Add(ci2);
            //dbContext.Add(ciTest);
            //Console.WriteLine(dbContext.Entry(ci1).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(ci1).State);
            #endregion

            #region Read
            //var ciRead = dbContext.Set<CourseInstructor>().FirstOrDefault(CI => CI.InstructorId == 1 && CI.CourseId == 1);
            //Console.WriteLine(ciRead?.Evaluate ?? "N/A");
            #endregion

            #region Update 
            //var ciUpdate = (from CI in dbContext.Set<CourseInstructor>()
            //                where CI.InstructorId == 1 && CI.CourseId == 2
            //                select CI).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(ciUpdate).State);
            //ciUpdate.Evaluate = "Great";
            //Console.WriteLine(dbContext.Entry(ciUpdate).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(ciUpdate).State);
            #endregion

            #region Delete 
            //var ciDelete = dbContext.Set<CourseInstructor>().FirstOrDefault(CI => CI.InstructorId == 2 && CI.CourseId == 2);
            //Console.WriteLine(dbContext.Entry(ciDelete).State);
            //dbContext.Remove(ciDelete);
            //Console.WriteLine(dbContext.Entry(ciDelete).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(ciDelete).State);
            #endregion
            #endregion
            #endregion

            #region Eager vs Easy Loading 
            #region Eager Loading
            //var inst1 = dbContext.Instructors.FirstOrDefault(I => I.Id == 1);
            //var inst2 = dbContext.Instructors.FirstOrDefault(I => I.Id == 2);
            //inst1.DepartmentId = 10;
            //inst2.DepartmentId = 10;
            //dbContext.SaveChanges();

            //var instructor = (from I in dbContext.Instructors.Include(I => I.WorkFroDepartment)
            //                  where I.Id == 1
            //                  select I).FirstOrDefault();
            //Console.WriteLine($"InstructorId = {instructor.Id} ::: InstructorName = {instructor.Name} ::: WorkForDepartment = {instructor.WorkFroDepartment.Name}");
            #endregion

            #region Lazy Loading 
            //var department = (from D in dbContext.Departments
            //                  where D.Id == 10
            //                  select D).FirstOrDefault();
            //Console.WriteLine($"Instructors in Departments {department.Name} :");
            //foreach (var ins in department.Instructors)
            //    Console.WriteLine($"- {ins.Name}");
            #endregion
            #endregion

            #region Join
            var Result = from I in dbContext.Instructors
                         join D in dbContext.Departments
                         on I.DepartmentId equals D.Id
                         where I.Adress == "Sfax"
                         select new
                         {
                             InstructorId = I.Id,
                             InstructorName = I.Name,
                             DepartmentId = D.Id,
                             DepartmentName = D.Name,
                             I.Adress
                         };
            foreach(var item in Result)
                Console.WriteLine(item);
            #endregion
        }
    }
}
