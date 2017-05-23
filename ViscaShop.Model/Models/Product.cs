using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using ViscaShop.Model.Abstract;

namespace ViscaShop.Model.Models
{
    [Table("Products")]
    public class Product : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int CategoryID { get; set; }

        [Required]
        public string Image { get; set; }

        public XElement MoreImages { get; set; }
        public decimal Price { get; set; }
        public decimal? Promoption { get; set; }
        public int? Waranty { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public int ViewCount { get; set; }
        public bool? HotFlag { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { get; set; }
    }
}