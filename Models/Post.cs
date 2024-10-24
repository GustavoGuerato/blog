using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[Post]")]
    public class Post
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Summary { get; set; }
        public required string Body { get; set; }
        public required string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public int AuthorId { get; set; }
        [Write(false)]
        public required User Author { get; set; }

        public int CategoryId { get; set; }
        [Write(false)]
        public required Category Category { get; set; }

        [Write(false)]
        public required List<Tag> Tags { get; set; }
    }
}