using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilbaApp.Data
{
    public class NotebookDataContext : DbContext
    {
        public NotebookDataContext(DbContextOptions<NotebookDataContext> options):
            base(options)
        { 
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<Notebook> Notebooks { get; set; }
        public DbSet<Spec> Specs { get; set; }
    }
}
