using System;
using Microsoft.AspNetCore.Http;

namespace Morning_Coffee_Backend.Dtos.UserInfoDtos.UserPhotoDetails
{
    public class PhotoForCreationDto
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public DateTime DateAdded { get; set; }
        public bool HasProfilePic { get; set; }
        public string PublicId { get; set; }
        public PhotoForCreationDto()
        {
            DateAdded = DateTime.Now;
        }
    }
}
