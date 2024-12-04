using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagallery.Models
{
    public class PhotoModel
    {
        public int Id { get; set; }                  // Unique identifier for the photo
        public string ThumbnailUrl { get; set; }    // URL of the thumbnail version of the photo
        public string Url { get; set; }             // URL of the full-size photo
        public string Title { get; set; }           // Title of the photo
        public string Description { get; set; }     // Description of the photo
    }
}
