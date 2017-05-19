namespace VaccineApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaccineView")]
    public partial class VaccineView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Vac_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Vac_Navn { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "text")]
        public string Vac_Info { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RkFlg { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TidMdr { get; set; }
    }
}
