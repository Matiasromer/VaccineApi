namespace VaccineApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaccinePlanView")]
    public partial class VaccinePlanView
    {
        [Key]
        [Column(Order = 0)]
        public DateTime Dato { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Barn_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kalender_id { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Vac_Navn { get; set; }
    }
}
