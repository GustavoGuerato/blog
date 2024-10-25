using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[Post]")]
    public class Post
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public int CategoryId { get; set; }

    }
}