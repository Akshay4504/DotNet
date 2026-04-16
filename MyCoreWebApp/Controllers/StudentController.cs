using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyCoreWebApp.Models;
using MyCoreWebApp.Services;

namespace MyCoreWebApp.Controllers
{
    public class StudentController : Controller
    {
        public StudentDAL stdDal;
        public SchoolDBContext _Context;
        private IGradeService gradeService;

        public StudentController(SchoolDBContext context,IGradeService grdService)
        {
            _Context = context;
            gradeService = grdService;
        }
        public IActionResult Index()
        {
            stdDal = new StudentDAL(_Context);
            List<Student> stdList = null;
            stdList=stdDal.GetAllStudents();
            return View(stdList);
        }

        [HttpGet]
        public  async Task<IActionResult> Create()
        {
            List<Grade> grades = await gradeService.GetAllGrades();
            var myList = (from g in grades
                          select new SelectListItem()
                          {
                              Value = g.GradeId.ToString(),
                              Text = $"{g.Section}-{g.Description}"
                          }).ToList();

            myList.Insert(0, new SelectListItem { Value = string.Empty, Text = "Select" });
            ViewBag.Grades = myList;
            return View();

        }

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Create(Student std)
        {
            stdDal = new StudentDAL(_Context);
            //if (!ModelState.IsValid)
            //{
            //    return View(std);
            //}
            int result=stdDal.AddStudent(std);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            stdDal=new StudentDAL(_Context);
            Student std = stdDal.GetStudentById(id);
            return View(std);
        }

        [HttpPost]
        public IActionResult Edit(int id,Student std)
        {
            stdDal = new StudentDAL(_Context);
            int result=stdDal.UpdateStudent(std);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            stdDal = new StudentDAL(_Context);
            Student std = stdDal.GetStudentById(Id);
            return View(std);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            stdDal = new StudentDAL(_Context);
            if (Id == null) return NotFound();

            Student std = stdDal.GetStudentById(Id);
            return View(std);
        }
        [HttpPost]
        public IActionResult Delete(int Id, Student student)
        {
            stdDal = new StudentDAL(_Context);
            int result = stdDal.DeleteStudentId(student);

            return RedirectToAction("Index");
        }
    }
}
