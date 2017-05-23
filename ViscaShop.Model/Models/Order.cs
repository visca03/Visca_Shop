﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViscaShop.Model.Abstract;

namespace ViscaShop.Model.Models
{
    [Table("Orders")]
    public class Order : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }

        [Required]
        public string CustomerMobile { get; set; }

        public string CustomerMessage { get; set; }

        [Required]
        public string PaymentMethod { get; set; }

        [Required]
        public string PaymentStatus { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}