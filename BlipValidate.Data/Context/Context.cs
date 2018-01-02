using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlipValidate.Data.Entities;

namespace BlipValidate.Data.Context
{
    public class BlipContext : DbContext
    {
        public BlipContext(DbContextOptions<BlipContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}