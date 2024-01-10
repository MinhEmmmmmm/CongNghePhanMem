namespace QLshopmohinh
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemName { get; set; }

        public int Price { get; set; }

        public int Inventory { get; set; }

        public int ClassID { get; set; }

        public virtual Class Class { get; set; }
    }
}
