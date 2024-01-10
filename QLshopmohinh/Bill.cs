namespace QLshopmohinh
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string ClientID { get; set; }

        [Required]
        [StringLength(50)]
        public string TaltolMoney { get; set; }

        public virtual Client Client { get; set; }
    }
}
