using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Data
{
    class Context : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams  { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public Context() : base("localsql")
        {
        }
    }
}
