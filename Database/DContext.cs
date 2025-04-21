using Database.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Database
{
    public partial class DContext : DbContext
    {
        public DContext(DbContextOptions<DContext> options) : base(options)
        {
        }
        public void OnConfiguring(IServiceCollection services)
        {
            var connection = "server=localhost;DataBase=Tarskan;Uid=root;Password=Elzasa24012005@@;";
            services.AddDbContext<DContext>(options =>
                options.UseMySql(connection, serverVersion:null)
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = "server=localhost;DataBase=Tarskan;Uid=root;Password=Elzasa24012005@@;";
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
            }
        }

        public DbSet<UserModel> User { get; set; }

        public DContext()
        {
        }
    }


}

