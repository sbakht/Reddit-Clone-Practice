using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Creddit.Models
{
    public class SelfPost : IPost
    {
        public int PostID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Post Creation Date")]
        public DateTime PostDate { get; set; }
        public virtual Subreddit Subreddit { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}