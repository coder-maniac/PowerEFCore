using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PowerEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerEFCore.DbContexts
{
    public class PowerEFCoreContext : DbContext
    {
        public PowerEFCoreContext(DbContextOptions options)
            : base(options)  {}

        public DbSet<WeatherForecast> WeatherForcast { get; set; }
        
    }
}
