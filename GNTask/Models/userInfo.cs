using System.ComponentModel.DataAnnotations;

namespace GNTask.Models
{
    public class userInfo
    {
        [Key]
        public int userId { get; set; }
        public string userName { get; set; }
    }
}
