using System;
namespace Morning_Coffee_Backend.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool HasProfilePic { get; set; }
        public DateTime DateAdded { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}
