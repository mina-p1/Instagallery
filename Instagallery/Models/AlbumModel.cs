using System;
using System.Collections.Generic;

namespace Instagallery.Models
{
    public class AlbumModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsPublic { get; set; } // Privacy setting
        public int UserId { get; set; } // Owner of the album
        public List<PhotoModel> Photos { get; set; } = new List<PhotoModel>();
    }
}
