using Microsoft.AspNetCore.Mvc;
using GNTask.Data;
using GNTask.ViewModels;
using GNTask.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GNTask.Controllers
{
    public class targetProductController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public targetProductController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            ViewBag.CustomarList = _dbContext.UserInformation.ToList();
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

        public JsonResult GenerateStage(int id)
        {
            var isvalid = _dbContext.SalesStage.Where(x => x.stageId == id).SingleOrDefault();

            if (isvalid != null)
            {
                var data = isvalid;

                return Json(data);
            }
            return Json(null);
        }

        public void SalesTargetMaster(Sales_Target_Master obj)
        {
            _dbContext.Database.ExecuteSqlRaw($"Sales_TargetDetails_Save_SP {obj.userId}, {obj.fromDate}, {obj.toDate}");
        }

        public void SalesTargetDetails(Sales_Target_Details obj)
        {
            _dbContext.Database.ExecuteSqlRaw($"Sales_TargetMaster_Save_SP {obj.serviceProductId}, {obj.Unit}, {obj.targetVolume}, {obj.targetAmount}, {obj.salesStageId}, {obj.stageName}, {obj.stageWeightage}");
        }
    }
}
