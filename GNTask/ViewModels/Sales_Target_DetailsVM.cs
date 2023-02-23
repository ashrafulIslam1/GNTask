using GNTask.Models;

namespace GNTask.ViewModels
{
    public class Sales_Target_DetailsVM
    {
        public int Id { get; set; }
        public int serviceProductId { get; set; }
        public string? Unit { get; set; }
        public int targetVolume { get; set; }
        public int targetAmount { get; set; }
        public int salesStageId { get; set; }
        public string? stageName { get; set; }
        public double stageWeightage { get; set; }
        public List<Sales_Target_Details> selsp { get; set; }
    }
}
