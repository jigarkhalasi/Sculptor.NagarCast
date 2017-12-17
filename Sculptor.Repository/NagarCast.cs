namespace Sculptor.Repository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NagarCast : DbContext
    {
        public NagarCast()
            : base("name=NagarCastEntities")
        {
        }

        public virtual DbSet<AddressMaster> AddressMasters { get; set; }
        public virtual DbSet<CastMaster> CastMasters { get; set; }
        public virtual DbSet<LoginMaster> LoginMasters { get; set; }
        public virtual DbSet<UserMapping> UserMappings { get; set; }
        public virtual DbSet<UserMaster> UserMasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressMaster>()
                .HasMany(e => e.UserMasters)
                .WithRequired(e => e.AddressMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CastMaster>()
                .HasMany(e => e.UserMasters)
                .WithRequired(e => e.CastMaster)
                .HasForeignKey(e => e.CastMasterId)
                .WillCascadeOnDelete(false);
        }
    }
}
