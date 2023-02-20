using System.ComponentModel.DataAnnotations;

namespace GNTask.Models
{
    public class productService
    {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }
        public string productUnit { get; set; }

    }
}
