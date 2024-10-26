using ConfigurationByConvention.Data;

namespace ConfigurationByConvention
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var context = new AppDbContext())
            {
                Console.WriteLine("----------Users-------------------");
                Console.WriteLine();
                foreach (var user in context.Users)
                {
                    Console.WriteLine(user.UserName);
                }
                Console.WriteLine("----------Tweets-------------------");
                Console.WriteLine();
                foreach (var user in context.Tweets)
                {
                    Console.WriteLine(user.TweetText);
                }
                Console.WriteLine("----------Comments-------------------");
                Console.WriteLine();
                foreach (var user in context.Comments)
                {
                    Console.WriteLine(user.CommentText);
                }
            }
        }
    }
}
