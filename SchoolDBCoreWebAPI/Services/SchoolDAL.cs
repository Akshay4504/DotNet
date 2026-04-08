using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;

using SchoolDBCodeFirstApp.Models;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace SchoolDBCodeFirstApp.Services

{

    internal class SchoolDAL : DbContext

    {

        public string _ConStr;

        public SchoolDBContext Context;

        public SchoolDAL()

        {

            IConfiguration config = new ConfigurationBuilder()

                .AddJsonFile("AppSetting.json", optional: false, reloadOnChange: true)

                .Build();

            _ConStr = config.GetConnectionString("SchoolCon");

            Context = new SchoolDBContext(_ConStr);

        }

        public int AddStudent(Student std)

        {

            Context.Students.Add(std);

            int result = Context.SaveChanges();

            return result;

        }

        public void DisplayStudents()

        {

            foreach (Student std in Context.Students)

                Console.WriteLine($"Student Id: {std.Studentid}, Name: {std.Name}");

        }

        public int UpdateStudent(Student std)

        {

            Context.Students.Update(std);

            // OR

            Context.Students.Entry(std).State = EntityState.Modified;

            int result = Context.SaveChanges();

            return result;

        }

        public Student GetStudentById(int stdId)
        {

            return Context.Students.FirstOrDefault(s => s.Studentid == stdId);

        }

        public StdWithNameAndRoll GetStudentNameAndRollById(int stdId)
        {

            Student std = Context.Students.FirstOrDefault(s => s.Studentid == stdId);

            return new StdWithNameAndRoll { StudentName = std.Name, RollNumber = std.RollNumber };

        }

        public int DeleteStudent(Student std)

        {

            Context.Students.Entry(std).State = EntityState.Deleted;

            int result = Context.SaveChanges();

            return result;

        }

        public List<Student> GetAllStudentsWithGrade()
        {

            List<Student> AllStudents;

            try

            {

                AllStudents = Context.Students.OrderBy(s => s.Name).Include(s => s.grade).ToList();

                //ALLStudents [.. Context. Students. Orderby(ss. Name). Include(s>s.grade)];

            }

            catch (Exception ex)
            {

                throw ex;

            }
            return AllStudents;
        }

        public List<Grade> GetAllGradesWithStudents()
        {
            List<Grade> allGrades;
            try
            {
                allGrades = Context.Grades.Include(g => g.Students).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return allGrades;
        }
        public List<StdWithGradeDTO> GetAllStudentsDTO()
        {
            List<StdWithGradeDTO> AllStudents;
            try
            {
                AllStudents = [..Context.Students
                    .OrderBy(s => s.Name)
                    .Include(s => s.grade)
                    .Select(s => new StdWithGradeDTO()
                    {
                        StudentID = s.Studentid,
                        StudentName = s.Name,
                        GrdDescription = s.grade.Description,
                        GrdSection = s.grade.Section
                    })];
            }
            catch (Exception)
            {
                throw;
            }
            /*var std = Context.Students.Include(s => s.grade)
                .Select(s => new StdWithGradeDTO()
                {
                    StudentID = s.Studentid,
                    StudentName = s.Name,

                    GrdDescription=s.grade.Description,
                    GrdSection=s.grade.Section
                }).SingleOrDefault(s=> s.StudentID==1);*/
            return AllStudents;
        }
    }
}
