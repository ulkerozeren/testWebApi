using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme2WebApi
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        { }

        public DbSet<Ulker> Ulkers { get; set; }
    }

    public class Ulker
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
