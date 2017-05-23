using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViscaShop.Model.Models
{
    [Table("OrderDetails")]
  public  class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public virtual Order Orders { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Products { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
       
    }
}
