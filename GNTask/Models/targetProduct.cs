using System.ComponentModel.DataAnnotations;

namespace GNTask.Models
{
    public class targetProduct
    {
        [Key]
        public int productId { get; set; }
        public string? selectProduct { get; set; }
        public int targetVolume { get; set; }
        public int targetAmount { get; set; }
        public string? salesStage { get; set; }
        public string? stageName { get; set; }
        public double stageWeightage { get; set; }
    }
}
