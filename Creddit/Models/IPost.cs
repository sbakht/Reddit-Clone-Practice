using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creddit.Models
{
    public interface IPost
    {
        string title { get; set; }
        Subreddit subreddit { get; set; }
        List<Comment> comments { get; set; }
        int points { get; set; }
    }
}
