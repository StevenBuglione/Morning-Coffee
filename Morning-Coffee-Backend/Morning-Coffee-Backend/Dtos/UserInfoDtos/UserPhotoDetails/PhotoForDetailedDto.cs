using System;
namespace Morning_Coffee_Backend.Dtos
{
    public class PhotoForDetailedDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool HasProfilePic { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
