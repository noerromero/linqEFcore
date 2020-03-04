using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace linq.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=dev-bd.c4eg064xqfsk.sa-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User ID=sa;Password=Agosto2019$;")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(MyLoggerFactory);

            base.OnConfiguring(optionsBuilder);

        }

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter((category, level) =>
                category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information)
                .AddConsole();
        });

        public DbSet<Estudiante> Estudiante { get; set; }

    }
}
