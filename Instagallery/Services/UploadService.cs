using System;
using System.IO;
using System.Threading.Tasks;
using Instagallery.Models;

namespace Instagallery.Services
{
    public class UploadService : IUploadService
    {
        private readonly string _photoStoragePath = "wwwroot/uploads"; // Define the path for photo storage

        public async Task<PhotoModel> UploadPhotoAsync(PhotoModel photo, byte[] photoData)
        {
            var fileName = $"{Guid.NewGuid()}_{photo.Title}.jpg";
            var filePath = Path.Combine(_photoStoragePath, fileName);

            // Ensure the directory exists
            if (!Directory.Exists(_photoStoragePath))
            {
                Directory.CreateDirectory(_photoStoragePath);
            }

            await File.WriteAllBytesAsync(filePath, photoData);

            // Set the URL of the uploaded photo
            photo.Url = $"/uploads/{fileName}";
            photo.UploadDate = DateTime.Now;

            // In a real application, save photo metadata to the database here

            return photo;
        }

        public async Task<bool> DeletePhotoAsync(int photoId)
        {
            // Retrieve the photo details from the database (not implemented here)
            var photoPath = Path.Combine(_photoStoragePath, $"{photoId}.jpg");

            if (File.Exists(photoPath))
            {
                File.Delete(photoPath);
                return true;
            }
            return false;
        }

        public async Task<string> GetPhotoUrlAsync(int photoId)
        {
            // Retrieve photo details from the database or cache (not implemented here)
            // Assuming photo URL is already stored
            return $"/uploads/{photoId}.jpg";
        }
    }
}
