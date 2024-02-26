using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public class MyProjectContext : DbContext
    {
        public MyProjectContext(DbContextOptions<MyProjectContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

    }
}
