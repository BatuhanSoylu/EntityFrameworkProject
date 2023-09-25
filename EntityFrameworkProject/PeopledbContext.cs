using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject
{
    public class PeopledbContext:DbContext
    {
        public DbSet<People> People { get; set; }

    }
}
