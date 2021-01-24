using Attribute.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Attribute.Contexts
{
    public class ConvectionContext : DbContext
    {
        public ConvectionContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Vendor> vendors { get; set; }

        public DbSet<Tag> Tags { get; set; }

    }
}
