using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyS.Core.Models;

namespace WeeklyS.Database
{
    public class WeeklySDbContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<WTask> WTasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=A5\\SQLEXPRESS;Database=weeklyS;Trusted_Connection=True;");

            base.OnConfiguring(options);
        }
    }
}
