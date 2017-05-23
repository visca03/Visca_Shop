using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using ViscaShop.Model.Abstract;

namespace ViscaShop.Model.Models
{
    [Table("Posts")]
    public class Post : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Post Posts { get; set; }

        public string Image { get; set; }
        public XElement MoreImage { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Content { get; set; }

        public int ViewCount { get; set; }
        public bool? HotFlag { get; set; }
    }
}