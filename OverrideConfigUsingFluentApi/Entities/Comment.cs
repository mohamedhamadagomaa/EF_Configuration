namespace OverrideConfigUsingFuentApi.Entities
{


    public class Comment
    {
        public int CommentId { get; set; }
        public int UserID { get; set; }
        public int TweetId { get; set; }
        public string CommentText { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
