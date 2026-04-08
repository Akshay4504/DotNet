//SchoolController.cs

using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;

using SchoolDBCodeFirstApp.Models;

using SchoolDBCoreWebAPI.Services;

namespace SchoolDBCoreWebAPI.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class StudentController : ControllerBase

    {

        public StudentDAL stDAL;

        [HttpGet]

        public ActionResult<List<Student>> GetAllStudents()

        {

            stDAL = new StudentDAL();

            return stDAL.GetAllStudents();

        }

    }

}

