namespace LearningPlanner_1._0._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Z406_01.Cytaty")]
    public partial class Cytaty
    {
        [Key]
        public int IDcytatu { get; set; }

        [Required]
        [StringLength(200)]
        public string Tresc { get; set; }
    }
}
