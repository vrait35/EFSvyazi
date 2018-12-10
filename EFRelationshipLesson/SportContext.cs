using System;
using System.Data.Entity;
using System.Linq;

namespace EFRelationshipLesson
{
   
    public class SportContext : DbContext
    {
      
        public SportContext()
            : base("name=SportContext")
        {
        }
        public DbSet<Team>Tteams { get; set; }
       public  DbSet<Player> Players { get; set; }
    }

   
}