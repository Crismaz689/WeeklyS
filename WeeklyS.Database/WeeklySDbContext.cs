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
        public WeeklySDbContext(DbContextOptions options) : base(options) { }
    }
}
