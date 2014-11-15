using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Creddit.Models
{
    public class Comment
    {
        public string text { get; set; }
        public IPost post { get; set }
        public Comment parentComment { get; set; }
        public List<Comment> subComments { get; set; }
        public int points { get; set; }
    }
}