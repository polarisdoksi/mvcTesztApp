using Microsoft.EntityFrameworkCore;
using mvcTesztApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcTesztApp.Data
{
    /// <summary>
    /// tpalee
    /// </summary>
    public class ApplicationDbContext: DbContext
    {
        /// <summary>
        /// tpalee Rocky database, . sqlserver
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }
    }
}
