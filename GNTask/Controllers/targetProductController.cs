using Microsoft.AspNetCore.Mvc;
using GNTask.Data;
using GNTask.ViewModels;
using GNTask.Models;
using GNTask.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GNTask.Controllers
{
    public class targetProductController : Controller
    {
        private targetProductService _targetProductService;
        private readonly ApplicationDbContext _dbContext;

        public targetProductController(targetProductService targetProductService, ApplicationDbContext dbContext)
        {
            _targetProductService = targetProductService;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            ViewBag.CustomarList = _dbContext.UserInformation.Where(x=>x.Status==true).ToList();
            ViewBag.ProductList = _dbContext.ProductService.ToList();
            ViewBag.SalesStageList = _dbContext.SalesStage.ToList();
            return View();
        }


        public JsonResult GenerateUnit(int? id)
        {
            var isvalid = _dbContext.ProductService.Where(x => x.productId == id).SingleOrDefault();

            if (isvalid != null)
            {
                var data = isvalid.productUnit;

                return Json(data);
            }
            return Json(null);
        }

        public JsonResult GenerateSatgeList(int? id)
        {
            if (id != null)
            {
                
                var data = (from s in _dbContext.SalesStage
                            where s.stageId == id
                            select new salesStage
                            {
                                stageName = s.stageName,
                                stageWeightage = s.stageWeightage,
                            });
                return Json(data);
            }
            return Json(null);
        }

        [HttpPost]
        public IActionResult Create(targetProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _targetProductService.Create(viewModel);
                TempData["allertMessage"] = "Meal added successfully !";
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Update(targetProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _targetProductService.Update(viewModel);
                TempData["allertMessage"] = "Meal updated successfully !";
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult DeleteAll(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            _targetProductService.Delete((int)id);

            return RedirectToAction("Index");
        }
    }
}
