using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamRegistration.Models
{
    public class TeamsContext : DbContext
    {
        public TeamsContext(DbContextOptions<TeamsContext> options) : base(options)
        {

        }

        public DbSet<Teams> Teams { get; set; }
    }
}
