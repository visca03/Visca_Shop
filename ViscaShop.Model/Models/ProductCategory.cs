﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViscaShop.Model.Abstract;

namespace ViscaShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory: Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int ParentID { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int DisplayOrder { get; set; }
        public bool? HomeFlag { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
         
    }
}
