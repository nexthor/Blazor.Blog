using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Blog.Common.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string? Title { get; set; }
        public string? Excerpt { get; set; }
        public string? FeaturedImage { get; set; }
        public string? Content { get; set; }
        public DateTime? PublishedAt { get; set; } = DateTime.Now;
    }
}
