using le_site.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace le_site.Data.Context
{
    public class LeSiteDbContext : DbContext
    {
        public LeSiteDbContext(DbContextOptions<LeSiteDbContext> options) : base(options)
        {

        }
        public DbSet<Personne> Personnes { get; set; }
    }
}
