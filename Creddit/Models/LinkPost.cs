using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Creddit.Models
{
    public class LinkPost : IPost
    {
        public string title { get; set; }
        public string link { get; set; }
        public Subreddit subreddit { get; set; }
        public List<Comment> comments { get; set; }
        public int points { get; set; }
    }
}