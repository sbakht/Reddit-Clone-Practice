using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Creddit.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Text { get; set; }
        public int Points { get; set; }
        public virtual IPost Post { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Comment Creation Date")]
        public DateTime CommentDate { get; set; }
        public virtual Comment ParentComment { get; set; }
        public virtual ICollection<Comment> SubComments { get; set; }
    }
}