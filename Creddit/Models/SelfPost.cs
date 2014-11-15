using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Creddit.Models
{
    public class SelfPost : IPost
    {
        public string title { get; set; }
        public string description { get; set; }
        public Subreddit subreddit { get; set; }
        public List<Comment> comments { get; set; }
        public int points { get; set; }
    }
}