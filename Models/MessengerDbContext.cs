using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NightFlow.Messenger.Models
{
    public class MessengerDbContext : DbContext
    {
        public DbSet<Account> Accounts{ get; set; }

        public DbSet<User> Users{ get; set; }

        public DbSet<Confirmation> Confirmations{ get; set; }

        public DbSet<Message> Messages { get; set; }
        public MessengerDbContext(DbContextOptions<MessengerDbContext> options) : base(options)
        {
            Database.EnsureCreated();  


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
            .HasOne(a => a.User).WithOne(b => b.Account)
            .HasForeignKey<User>(e => e.AccountId);
        }
    }
}
