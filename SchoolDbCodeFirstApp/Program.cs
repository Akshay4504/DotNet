// See https://aka.ms/new-console-template for more information

using Microsoft.Identity.Client;
using SchoolDBCodeFirstApp.Models;

using SchoolDBCodeFirstApp.Services;

Console.WriteLine("Hello, World!");

//WorkWithDB();

//DisplayGrades();

AddStudent();

//UpdateStudent();

static void WorkWithDB()

{

    int result = AddGrade();

    Console.WriteLine($"Added {result} to Grade Table");

}

static int AddGrade()
{ 
    SchoolDBContext context = new SchoolDBContext();
    int recsAffected = 0;
    IList<Grade> grades = new List<Grade>();
    grades.Add(new Grade() { Description = "Grade 3", Section = "A" });
    grades.Add(new Grade() { Description = "Grade 3", Section = "B" });
    grades.Add(new Grade() { Description = "Grade 3", Section = "C" });
    context.Grades.AddRange(grades);
    recsAffected = context.SaveChanges();

    return recsAffected;
}

static void DisplayGrades()
{
    SchoolDBContext context = new SchoolDBContext();
    foreach (Grade grd in context.Grades)
    {
        Console.WriteLine($"Grade Id: {grd.GradeId}, Section: {grd.Section}");
    }
}
static void AddStudent()
{
    Student std = new Student();
    Console.WriteLine("Enter Data fora new Student:\nStudent Name: ");
    std.Name = Console.ReadLine();
    Console.WriteLine("Enter Roll Number: ");
    std.RollNumber = Console.ReadLine();
    Console.WriteLine("Enter Grade ID: ");
    std.GradeId = Convert.ToInt32(Console.ReadLine());
    SchoolDAL schoolDAL = new SchoolDAL();
    int recAdded = schoolDAL.AddStudent(std);
    if (recAdded > 0)
    {
        Console.WriteLine($"{recAdded} record added sucessfully");
    }
    else
        Console.WriteLine("Something went wrong");
}

static void UpdateStudent()
{
    SchoolDAL sDal = new SchoolDAL();
    Console.WriteLine("Enter Student ID to update: ");
    int stdID = Convert.ToInt32(Console.ReadLine());
    Student std = sDal.GetStudentById(stdID);
    if (std != null)
        Console.WriteLine($"Student Id: {std.Studentid}, Name: {std.Name}");
    else
    {
        Console.WriteLine("No record");
        return;
    }
    Console.WriteLine("Enter new Student Name: ");
    std.Name = Console.ReadLine();
    Console.WriteLine("Enter new Roll Number: ");
    std.RollNumber = Console.ReadLine();
    Console.WriteLine("Enter new Grade ID: ");
    std.GradeId = Convert.ToInt32(Console.ReadLine());
    SchoolDAL schoolDAL = new SchoolDAL();
    int recUpdated = schoolDAL.UpdateStudent(std);
    if (recUpdated > 0)
    {
        Console.WriteLine($"{recUpdated} record updated successfully");
    }
    else
    {
        Console.WriteLine("Update failed or no changes detected");
    }
    static void DeleteStudent()
    {
        Console.WriteLine("Enter Student Id, to be modified:");
        int stdId = Convert.ToInt32(Console.ReadLine());

        SchoolDAL sDal = new SchoolDAL();
        Student std = sDal.GetStudentById(stdId);
        if (std != null)
        {
            Console.WriteLine($"Student Id: {std.Studentid}, Name: {std.Name}");
        }
        else
        {
            Console.WriteLine("No record found");
            return;
        }

        Console.WriteLine("Do you want to delete this record Y/N");
        char choice = Convert.ToChar(Console.ReadLine());

        if (choice == 'y' || choice == 'Y')
        {
            int result = sDal.DeleteStudent(std);
            if (result > 0)
            {
                Console.WriteLine("Successfully deleted");
            }
            else
            {
                Console.WriteLine("Sorry Something Went Wrong");
            }

        }
        else
        {
            Console.WriteLine("Delete operation cancelled");
        }
        static void DisplayStudentsWithGrade()
        {
            SchoolDAL sDal = new SchoolDAL();
            List<Student> stdList = sDal.GetAllStudentsWithGrade();
            foreach (Student std in stdList)
            {
                Console.WriteLine($"Id: {std.Studentid}, Name: {std.Name}, Roll: {std.RollNumber}");
                if (std.grade != null)
                {
                    Console.WriteLine($"Grade Id: {std.grade.GradeId}, Section: {std.grade.Section}");
                }
            }
        }

        static void AddStudent()
        {
            Student std = new Student();
            Console.WriteLine("Enter Data for a new Student:\nStudent Name:");
            std.Name = Console.ReadLine();
            Console.WriteLine("Enter Roll number:");
            std.RollNumber = Console.ReadLine();
            Console.WriteLine("Enter Grade Id:");
            std.GradeId = Convert.ToInt32(Console.ReadLine());

            SchoolDAL sDal = new SchoolDAL();
            sDal.AddStudent(std);
            Console.WriteLine("Student Added Successfully!");

        }
        static void DisplayGradesWithStudents()
        {
            SchoolDAL sDal = new SchoolDAL();
            List<Grade> grdList = sDal.GetAllGradesWithStudents();
            foreach (Grade grd in grdList)
            {
                Console.WriteLine($"Id: {grd.GradeId}, Section: {grd.Section}");
                if (grd.Students != null)
                { foreach (Student std in grd.Students)
                        Console.WriteLine($"Id: {std.Studentid}, name: {std.Name},RollNumber: {std.RollNumber}");
                }
            }
        }
        static void DisplayStudentDTO()
        {
            SchoolDAL sDal = new SchoolDAL();
            List<StdWithGradeDTO> stdList = sDal.GetAllStudentsDTO();
            foreach (StdWithGradeDTO std in stdList)
            {
                Console.WriteLine($"Student Id: {std.StudentID},name:{std.StudentName},"+ $" {std.GrdSection}, Section: {std.GrdDescription}");
            }
        }

    }
}

