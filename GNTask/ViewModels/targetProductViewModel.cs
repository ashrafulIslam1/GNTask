namespace GNTask.ViewModels
{
    public class targetProductViewModel
    {
        public int productId { get; set; }
        public int serviveId { get; set; }
        public string? productServiceName { get; set; }
        public string? Unit { get; set; }
        public int targetVolume { get; set; }
        public int targetAmount { get; set; }
        public int stageId { get; set; }
        public string? SalesStage { get; set; }
        public string? stageName { get; set; }
        public double stageWeightage { get; set; }
    }
}
