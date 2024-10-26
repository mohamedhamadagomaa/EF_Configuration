using System.ComponentModel.DataAnnotations.Schema;

namespace OverrideConfigByDataAnnotation.Entities
{
    [Table("tblTweets")]
    internal class Tweet
    {
        public int TweetId { get; set; }
        public int UserId { get; set; }
        public string TweetText { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
