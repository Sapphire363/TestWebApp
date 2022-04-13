#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestWebApp.Models;

namespace TestWebApp.Data
{
    public class TestWebAppContext : DbContext
    {
        public TestWebAppContext (DbContextOptions<TestWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<TestWebApp.Models.Bed> Bed { get; set; }
    }
}
