using System.ComponentModel.DataAnnotations;

namespace GNTask.Models
{
    public class targetProduct
    {
        [Key]
        public int productId { get; set; }
        public int serviveId { get; set; }
        public string? Unit { get; set; }
        public int targetVolume { get; set; }
        public int targetAmount { get; set; }
        public int stageId { get; set; }
        public string? stageName { get; set; }
        public double stageWeightage { get; set; }
    }
}
