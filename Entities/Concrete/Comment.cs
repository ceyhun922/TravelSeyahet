
using EntityLayer.Concrete;

namespace Entities.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string? CommentUserName { get; set; }
        public string? CommentUserMail { get; set; }
        public string? CommentUserComment { get; set; }
        public bool? CommentStatus { get; set; }
        public string? UserId { get; set; }
        public Writer? Writer { get; set; }
        public Tour? Tour { get; set; }
    }
}