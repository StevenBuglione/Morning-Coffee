using System;
namespace Morning_Coffee_Backend.Dtos.UserInfoDtos.UserPhotoDetails
{
    public class PhotoForReturnDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool HasProfilePic { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }
    }
}
