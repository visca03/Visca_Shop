using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViscaShop.Model.Abstract;

namespace ViscaShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int ParentID { get; set; }

        [Required]
        public string Description { get; set; }

        public string Image { get; set; }
        public int DisplayOrder { get; set; }
        public bool? HomeFlag { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
        public virtual IEnumerable<PostTag> PostTags { get; set; }
    }
}