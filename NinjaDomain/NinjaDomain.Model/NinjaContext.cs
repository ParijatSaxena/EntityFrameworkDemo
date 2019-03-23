using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace NinjaDomain.Model
{
    public class NinjaContext :DbContext
    { 
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipment> Equipment { get; set; }
    }
}
