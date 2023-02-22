using System.ComponentModel.DataAnnotations;

namespace GNTask.Models
{
    public class Sales_Target_Master
    {
        [Key]
        public int Id { get; set; }
        public int userId { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
    }
}
