namespace VaccineApi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VaccinePlanViewContext : DbContext
    {
        public VaccinePlanViewContext()
            : base("name=VaccinePlanViewContext")
        {
        }

        public virtual DbSet<VaccinePlanView> VaccinePlanView { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VaccinePlanView>()
                .Property(e => e.Vac_Navn)
                .IsUnicode(false);
        }
    }
}
