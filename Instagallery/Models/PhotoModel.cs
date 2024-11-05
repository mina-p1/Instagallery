// By Peter Mina

using System;

namespace Instagallery.Models
{
    public class PhotoModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; } // Path to the photo file
        public DateTime UploadDate { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; } // Comma-separated tags for search
        public bool IsPublic { get; set; } // Privacy setting
    }
}