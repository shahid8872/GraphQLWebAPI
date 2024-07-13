using GraphQLEI.API.Data.Models;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GraphQLEI.API.Data
{
    public class EntityDatabaseContext : DbContext
    {
        public EntityDatabaseContext(DbContextOptions<EntityDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Employee> EmployeeEntity { get; set; }

        public DbSet<Review> ReviewEntity { get; set; }
    }
}
