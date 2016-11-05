using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcAuth.Models
{
    public class BlogPost
    {
        [Key]
        public int BlogPostID { get; set; }

        [MinLength(1)]//number of characters
        [MaxLength(300)]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedAt { get; set; }

        //but what about the author??
    }
}