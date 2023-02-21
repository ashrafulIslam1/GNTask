using System.ComponentModel.DataAnnotations;

namespace GNTask.Models
{
    public class salesStage
    {
        [Key]
        public int stageId { get; set; }
        public string salesStageName { get; set; }
        public string stageName { get; set; }
        public double stageWeightage { get; set; }

    }
}
