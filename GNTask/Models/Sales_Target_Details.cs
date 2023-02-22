namespace GNTask.Models
{
    public class Sales_Target_Details
    {
        public int Id { get; set; }
        //public int userId { get; set; }
        //public DateTime fromDate { get; set; }
        //public DateTime toDate { get; set; }
        public int serviceProductId { get; set; }
        public string? Unit { get; set; }
        public int targetVolume { get; set; }
        public int targetAmount { get; set; }
        public int salesStageId { get; set; }
        public string? stageName { get; set; }
        public double stageWeightage { get; set; }


    }
}
