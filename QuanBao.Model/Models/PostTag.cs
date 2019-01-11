using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanBao.Model.Models
{
    [Table("PostTags")]
   public class PostTag
    {
        [Key]
        public int PostID { get; set; }

        [Key]
        [Column(TypeName ="Varchar")]
        [MaxLength(256)]
        public string TagID { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}
