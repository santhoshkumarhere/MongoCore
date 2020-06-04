using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoCore
{
    public class PersonModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string FirstName;
        public string LastName;

        [BsonElement("dob")]
        public DateTime DateOfBirth { get; set; }
        public AddressModel PrimaryAddress { get; set; }

        public PersonModel(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
