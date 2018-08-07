namespace Entity_2_1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Car
    {
        public int Id { get; set; }

        [Column("Car")]
        [Required]
        [StringLength(50)]
        public string Car1 { get; set; }

        public int maxSpeed { get; set; }
    }
}
