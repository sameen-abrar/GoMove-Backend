using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GoMove.Repositories.dbContext
{
    public class MongoDbContext: DbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext()
        {

        }
    }
}
