using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DAL
{
    class PersonDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local);Database=LearnForms;Trusted_Connection=True;");
        }
        public DbSet<Models.Person> People { get; set; }
        public DbSet<Models.SupportTickets.TicketTypes> TicketTypes {get; set;}
    }
}

