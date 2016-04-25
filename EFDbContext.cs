using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboAnimal.Domain.Entities;
using System.Data.Entity;

namespace HoboAnimal.Domain.Concrete

{
    public class EFDbContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
    }
}
