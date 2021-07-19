using System;
using WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Brokers
{
    public class StorageBroker : DbContext
    {
        public StorageBroker(DbContextOptions<StorageBroker> options) : base(options) => this.Database.Migrate();

        public DbSet<Student> Students { get; set; }
    }
}
