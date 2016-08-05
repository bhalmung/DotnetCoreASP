using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstDotnetCoreWebApplication.Models
{
    public class UserDetailsContext: DbContext
    {
        public UserDetailsContext(DbContextOptions<UserDetailsContext> options)
            : base(options)
        { }

        public DbSet<UserDetails> Users { get; set; }

    }
}
