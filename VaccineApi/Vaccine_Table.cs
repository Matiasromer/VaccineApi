namespace VaccineApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vaccine_Table
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Vaccine_nr { get; set; }

        public int Vac_Id { get; set; }

        public int Tid { get; set; }
    }
}
