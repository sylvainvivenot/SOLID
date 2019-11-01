using System;
using System.Data.Entity;

namespace SingleResponsability
{
    public class DatabaseContext:DbContext
    {
        public virtual DbSet<Person> Persons { get; set; }
    }
}
