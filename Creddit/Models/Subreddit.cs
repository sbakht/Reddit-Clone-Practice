﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Creddit.Models
{
    public class Subreddit
    {
        public string title { get; set; }
        public List<IPost> posts { get; set; } 
    }
}