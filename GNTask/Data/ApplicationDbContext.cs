using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GNTask.Models;

namespace GNTask.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<userInfo> UserInformation { get; set; }
        public DbSet<salesStage> SalesStage { get; set; }
        public DbSet<productService> ProductService { get; set; }
        public DbSet<targetProduct> TargetProductService { get; set; }
        public DbSet<Sales_Target_Details> Sales_Target_Details { get; set; }
        public DbSet<Sales_Target_Master> Sales_Target_Master { get; set; }
    }
}