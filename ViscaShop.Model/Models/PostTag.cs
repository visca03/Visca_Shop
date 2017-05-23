using System.ComponentModel.DataAnnotations.Schema;

namespace ViscaShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        public int PostID { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }

        public int TagID { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}