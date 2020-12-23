namespace QLTB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HISTORY")]
    public partial class HISTORY
    {
        [Key]
        [StringLength(50)]
        public string ID_HISTORY { get; set; }

        [StringLength(50)]
        public string ID_DEVICE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UPDATE_CHECK { get; set; }

        public int? INFOCHECK { get; set; }

        [Column(TypeName = "text")]
        public string NOTE { get; set; }

        public int? QUANTITY { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string ID_USER { get; set; }

        public virtual DEVICE DEVICE { get; set; }
    }
}
