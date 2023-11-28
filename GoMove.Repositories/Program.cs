using GoMove.Repositories.dbContext;
using GoMove.Repositories.Entites;
using MongoDB.Driver;

namespace GoMove.Repositories
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Initialize your MongoDB context
            var dbContext = new MongoDbContext("mongodb://localhost:27017", "GoMoveDb");

            // Perform database initialization tasks
            EnsureDatabaseExists(dbContext);

            // Start your application
            // ...
            // Create a dummy user
            var dummyUser = new User
            {
                Email = "dummy@example.com",
                Password = "dummy_password",
                Token = "dummy_token",
                StartAt = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")
            };

            // Insert the dummy user into the Users collection
            await dbContext.Users.InsertOneAsync(dummyUser);

            var results = await dbContext.Users.FindAsync(_ => true);

            foreach (var result in results.ToList())
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("Dummy user inserted successfully.");
        }

        private static void EnsureDatabaseExists(MongoDbContext dbContext)
        {
            // Perform any initialization tasks here
            // For example, you might want to create indexes or perform other setup tasks
        }
    }
}