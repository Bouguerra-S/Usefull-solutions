using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace resumeadaptorv2.Models
{
    public class usersDbContext : DbContext
    {
        public DbSet<UserProfile> Users { get; set; }
    }
}
