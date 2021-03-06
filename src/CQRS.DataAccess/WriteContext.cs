﻿using CQRS.Contracts.Events;
using Microsoft.EntityFrameworkCore;


namespace CQRS.DataAccess
{
    public class WriteContext : DbContext
    {
        public virtual DbSet<ItemBaseEvent> ItemEvents { get; set; }
        public virtual DbSet<ItemUpdatedEvent> ItemUpdated { get; set; }
        public virtual DbSet<ItemAddedEvent> ItemAdded { get; set; }
        public virtual DbSet<ItemDeletedEvent> ItemDeleted { get; set; }

        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-JQOI1KG;database=CQRS-WriteDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemBaseEvent>().HasKey(e => e.Id).HasName("PrimaryKey_Id");
            base.OnModelCreating(modelBuilder);
        }
    }
}
