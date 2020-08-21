using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Kaido11.Models;

namespace TestWebApplication.Models
{
    public class MembersDbContext : DbContext
    {
        public MembersDbContext(DbContextOptions<MembersDbContext> options) : base(options) { }
        public DbSet<Member> Members { get; set; }
    }
}