using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlipValidate.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlipValidate.Data.BlipContext
{
    public class BlipContext : DbContext
    {
        public BlipContext(DbContextOptions<BlipContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}