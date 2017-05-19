namespace VaccineApi
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VaccineContext : DbContext
    {
        public VaccineContext()
            : base("name=VaccineContext1")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Barn> Barn { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<Historik> Historik { get; set; }
        public virtual DbSet<Kalender> Kalender { get; set; }
        public virtual DbSet<Vaccine> Vaccine { get; set; } 
        public virtual DbSet<Vaccine_Table> Vaccine_Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Barn>()
                .Property(e => e.Barn_Navn)
                .IsUnicode(false);

            modelBuilder.Entity<Device>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Vaccine>()
                .Property(e => e.Vac_Navn)
                .IsUnicode(false);

            modelBuilder.Entity<Vaccine>()
                .Property(e => e.Vac_Info)
                .IsUnicode(false);
        }
    }
}
