using System;
using System.Collections.Generic;

namespace Avalonia44.Models
{
    public class Blog
    {
            public string title {get; set;}
            public string text {get; set;}
            public string image_path {get; set;}
            public List<string> tags { get; set; }
    }
}