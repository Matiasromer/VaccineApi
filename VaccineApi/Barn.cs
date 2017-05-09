namespace VaccineApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Barn")]
    public partial class Barn
    {
        [Key]
        public int Barn_Id { get; set; }
        //datetime henter tid uden at det er vigtigt
        public DateTime Barn_Foedsel { get; set; }

        [Required]
        [StringLength(50)]
        public string Barn_Navn { get; set; }

        public int Device_id { get; set; }

        public string Gender { get; set; }
    }
}
