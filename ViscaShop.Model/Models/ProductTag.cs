using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViscaShop.Model.Models
{
    [Table("ProductTags")]
  public  class ProductTag
    {
        public int ProductID { get; set; }
        [ForeignKey("ProcductID")]
        public virtual Product Product { get; set; }
        public int TagID { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}
