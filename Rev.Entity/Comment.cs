using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Rev.Entity
{
    [Table ("Comment")]
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(200)]
        public string Text { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Review")]
        public int ReviewId { get; set; }

        public virtual Review Review { get; set; }
        public virtual User User { get; set; }

    }
}
