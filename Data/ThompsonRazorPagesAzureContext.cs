#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThompsonRazorPagesAzure.Models;

namespace ThompsonRazorPagesAzure.Data
{
    public class ThompsonRazorPagesAzureContext : DbContext
    {
        public ThompsonRazorPagesAzureContext (DbContextOptions<ThompsonRazorPagesAzureContext> options)
            : base(options)
        {
        }

        public DbSet<ThompsonRazorPagesAzure.Models.UserPreferences> UserPreferences { get; set; }
    }
}
