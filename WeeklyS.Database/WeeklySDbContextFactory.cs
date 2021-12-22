using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyS.Database
{
    public class WeeklySDbContextFactory : IDesignTimeDbContextFactory<WeeklySDbContext>
    {
        public WeeklySDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<WeeklySDbContext>();
            options.UseSqlServer("Server=A5\\SQLEXPRESS;Database=weeklyS;Trusted_Connection=True;");

            return new WeeklySDbContext(options.Options);
        }
    }
}
