﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [ForeignKey("ProductID")]
        public virtual IEnumerable<Product> Products { get; set; }

        [ForeignKey("OrderID")]
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}