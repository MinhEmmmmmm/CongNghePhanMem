using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLshopmohinh
{
    public partial class ShopMoHinhDB : DbContext
    {
        public ShopMoHinhDB()
            : base("name=ShopMoHinhDB")
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientRank> ClientRanks { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.Class)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClientRank>()
                .Property(e => e.Rank)
                .IsFixedLength();

            modelBuilder.Entity<ClientRank>()
                .HasMany(e => e.Clients)
                .WithRequired(e => e.ClientRank)
                .HasForeignKey(e => e.RankID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Password)
                .IsFixedLength();
        }
    }
}
