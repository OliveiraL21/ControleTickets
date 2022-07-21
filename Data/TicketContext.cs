using Data.Mapeamento;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class TicketContext : DbContext
    {
        public DbSet<Ticket> tickets { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ticket;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer("Server=tcp:trabalhos.database.windows.net,1433;Initial Catalog=Controle_Tickets_Desktop;Persist Security Info=False;User ID=Lucas;Password=Lj99D06O@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>(new TicketMap().Configure);
           
        }
    }
}
