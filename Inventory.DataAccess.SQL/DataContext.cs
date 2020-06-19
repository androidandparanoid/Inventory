using Inventory.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Inventory.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<SoftwareInventory> SoftwareInventory { get; set; }
        public DbSet<HardwareInventory> HardwareInventory { get; set; }        
        public DbSet<WarrantyInformation> WarrantyInformation { get; set; }
        public DbSet<SoftwareScan> SoftwareScan { get; set; }

    }
}
