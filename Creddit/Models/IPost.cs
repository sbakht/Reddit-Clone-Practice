using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creddit.Models
{
    public interface IPost
    {
        int PostID { get; set; }
        string Title { get; set; }
        int Points { get; set; }
        DateTime PostDate { get; set; }
        Subreddit Subreddit { get; set; }
        ICollection<Comment> Comments { get; set; }
    }
}
