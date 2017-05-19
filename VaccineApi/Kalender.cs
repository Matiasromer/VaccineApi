namespace VaccineApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kalender")]
    public partial class Kalender
    {
        [Key]
        [Column(Order = 0)]
        public DateTime Dato { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Barn_id { get; set; }

        [Required]
        [StringLength(20)]
        public string Vac_navn { get; set; }
    }
}
