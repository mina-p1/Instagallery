using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagallery.Models
{
    public class PhotoModel
    {
        public int Id { get; set; }                  // Primary key
        public string ThumbnailUrl { get; set; }    // Thumbnail URL
        public string Url { get; set; }             // Full-size image URL
        public string Title { get; set; }           // Photo title
        public string Description { get; set; }     // Photo description
    }
}

