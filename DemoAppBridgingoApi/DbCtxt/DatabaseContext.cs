using DemoAppBridgingoApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAppBridgingoApi.DbCtxt
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> users { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
    }
}
