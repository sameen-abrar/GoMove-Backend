using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoMove.Repositories.Entites
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String UserId { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Token { get; set; }
        public String StartAt { get; set; }

    }
}
