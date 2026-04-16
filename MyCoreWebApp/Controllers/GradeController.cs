using Microsoft.AspNetCore.Mvc;
using MyCoreWebApp.Models;
using MyCoreWebApp.Services;

namespace MyCoreWebApp.Controllers
{
    public class GradeController : Controller
    {
        public IGradeService grdSvc;
        public GradeController(IGradeService grdService)
        {
            grdSvc = grdService;
        }

        public async Task<IActionResult> Index()
        {
            List<Grade> grdList = null;
            grdList = await grdSvc.GetAllGrades();
            return View(grdList);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Grade grd)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMessage = "Pleasecorrect the errors in the from";
                return View(grd);
            }
            int result = await grdSvc.AddGrade(grd);
            if (result == 0)
            {
                ViewBag.ErrorMessage = "Unable to add the record,ls check,";
                return View(grd);
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Grade grade = null;
            try
            {
                grade = await grdSvc.GetGradeById(id);
            }
            catch(HttpRequestException ex)
            {
                return View("error");
            }
            return View(grade);
        }
    }
}
