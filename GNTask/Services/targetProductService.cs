using GNTask.Data;
using GNTask.Models;
using GNTask.ViewModels;

namespace GNTask.Services
{
    public class targetProductService
    {
        private readonly ApplicationDbContext _dbContext;
        public targetProductService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(targetProductViewModel viewModel)
        {
            var model = new targetProduct // here this 'targetProduct' is the main model.
            {
                // Here I assign the viewModel properties to model properties
                productId = viewModel.productId,
                serviveId = viewModel.serviveId,
                Unit = viewModel.Unit,
                targetAmount = viewModel.targetAmount,
                targetVolume = viewModel.targetVolume,
                stageId = viewModel.stageId,
                stageName = viewModel.stageName,
                stageWeightage = viewModel.stageWeightage,
            };

            _dbContext.TargetProductService.Add(model); // Here 'TargetProductService' is the table name
            _dbContext.SaveChanges();
        }

        public void Update(targetProductViewModel viewModel)
        {
            var model = _dbContext.TargetProductService.Find(viewModel.productId);

            if (model == null)
                throw new Exception();

            model.productId = viewModel.productId;
            model.serviveId = viewModel.serviveId;
            model.Unit = viewModel.Unit;
            model.targetAmount = viewModel.targetAmount;
            model.targetVolume = viewModel.targetVolume;
            model.stageId = viewModel.stageId;
            model.stageName = viewModel.stageName;
            model.stageWeightage = viewModel.stageWeightage;

            _dbContext.TargetProductService.Update(model);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var model = _dbContext.TargetProductService.Find(id);
            if (model == null)
                throw new Exception();

            _dbContext.TargetProductService.Remove(model);
            _dbContext.SaveChanges();
        }

        public List<targetProductViewModel> GetAll()
        {
            var query = (from s in _dbContext.TargetProductService
                         join ps in _dbContext.ProductService on s.serviveId equals ps.productId
                         join st in _dbContext.SalesStage on s.stageId equals st.stageId
                         select new targetProductViewModel
                         {
                             productId = s.productId,
                             serviveId = s.serviveId,
                             productServiceName = ps.productName,
                             Unit = s.Unit,
                             targetAmount = s.targetAmount,
                             targetVolume = s.targetVolume,
                             stageId = s.stageId,
                             SalesStage = st.salesStageName,
                             stageName = s.stageName,
                             stageWeightage = s.stageWeightage,
                         }).AsQueryable();

            return query.ToList();
        }

        public List<DropDownViewModel> UserInfoDropDown()
        {
            var data = (from s in _dbContext.UserInformation
                        select new DropDownViewModel
                        {
                            Value = s.userId,
                            Text = s.userName
                        }).ToList();
            return data;
        }

        public List<DropDownViewModel> TargetProductDropDown()
        {
            var data = (from s in _dbContext.ProductService
                        select new DropDownViewModel
                        {
                            Value = s.productId,
                            Text = s.productName
                        }).ToList();
            return data;
        }

        public List<DropDownViewModel> SalesStageDropDown()
        {
            var data = (from s in _dbContext.SalesStage
                        select new DropDownViewModel
                        {
                            Value = s.stageId,
                            Text = s.salesStageName
                        }).ToList();
            return data;
        }
    }
}
