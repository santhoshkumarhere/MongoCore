using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoCore
{
    public class NameModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string FirstName;
        public string LastName;

        public NameModel(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
