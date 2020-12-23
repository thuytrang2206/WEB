namespace QLTB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLTB_Model : DbContext
    {
        public QLTB_Model()
            : base("name=QLTB_Model")
        {
        }

        public virtual DbSet<DEVICE> DEVICEs { get; set; }
        public virtual DbSet<GROUP_DEVICE> GROUP_DEVICE { get; set; }
        public virtual DbSet<HISTORY> HISTORies { get; set; }
        public virtual DbSet<RULE> RULEs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DEVICE>()
                .HasMany(e => e.HISTORies)
                .WithOptional(e => e.DEVICE)
                .HasForeignKey(e => e.ID_DEVICE);

            modelBuilder.Entity<GROUP_DEVICE>()
                .HasMany(e => e.DEVICEs)
                .WithOptional(e => e.GROUP_DEVICE)
                .HasForeignKey(e => e.DeviceGroup);

            modelBuilder.Entity<HISTORY>()
                .Property(e => e.ID_HISTORY)
                .IsUnicode(false);

            modelBuilder.Entity<HISTORY>()
                .Property(e => e.NOTE)
                .IsUnicode(false);

            modelBuilder.Entity<HISTORY>()
                .Property(e => e.ID_USER)
                .IsUnicode(false);

            modelBuilder.Entity<RULE>()
                .Property(e => e.ID_RULE)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.ID_RULE)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.DEVICEs)
                .WithOptional(e => e.USER)
                .HasForeignKey(e => e.Creator);
        }
    }
}
