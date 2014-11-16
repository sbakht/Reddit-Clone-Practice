using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Creddit.Models
{
    public class Subreddit
    {
        public int SubredditID { get; set; }
        [Required]
        public string Title { get; set; }
        public virtual ICollection<IPost> Posts { get; set; } 
    }
}