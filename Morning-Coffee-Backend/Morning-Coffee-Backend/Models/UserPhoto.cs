using System;
namespace Morning_Coffee_Backend.Models
{
    public class UserPhoto
    {

        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
        public bool IsApproved { get; set; }
        public virtual User User { get; set; }
        public string UserId { get; set; }
    }
}
