using Domain.Model.Result;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Context
{
    public class MyWeatherForeCastContext : DbContext
    {
        public MyWeatherForeCastContext(DbContextOptions<MyWeatherForeCastContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.BuildAccountModel();
        }
    }
}
