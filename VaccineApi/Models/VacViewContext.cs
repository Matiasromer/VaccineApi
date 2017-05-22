namespace VaccineApi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VacViewContext : DbContext
    {
        public VacViewContext()
            : base("name=VacViewContext")
        {
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<VaccineView> VaccineView { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VaccineView>()
                .Property(e => e.Vac_Navn)
                .IsUnicode(false);

            modelBuilder.Entity<VaccineView>()
                .Property(e => e.Vac_Info)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<VaccineApi.Models.VaccinePlanView> VaccinePlanViews { get; set; }
    }
}
