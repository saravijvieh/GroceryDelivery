using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GroceryDelivery.Models;

    public class GroceryOrderContext : DbContext
    {
        public GroceryOrderContext (DbContextOptions<GroceryOrderContext> options)
            : base(options)
        {
        }

        public DbSet<GroceryDelivery.Models.Order> Order { get; set; } = default!;
    }
