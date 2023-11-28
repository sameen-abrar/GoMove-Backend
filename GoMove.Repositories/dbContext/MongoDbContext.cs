using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GoMove.Repositories.Entites;
using GoMove.Repositories.Entites.Models;

namespace GoMove.Repositories.dbContext
{
    public class MongoDbContext : DbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<DeliveryRider> DeliveryRiders => _database.GetCollection<DeliveryRider>("DeliveryRider");
        public IMongoCollection<Organization> Organizations => _database.GetCollection<Organization>("Organizations");
        public IMongoCollection<User> Users => _database.GetCollection<User>("Users");


    }
}
    

