﻿using System;

namespace bharathsite.Models // Replace with the namespace of your project
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
