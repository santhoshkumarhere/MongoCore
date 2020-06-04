using System;
using System.Threading.Tasks;

namespace MongoCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MongoCRUD("AddressBook");
            //var person = new PersonModel("Address", "Mani");
            //person.PrimaryAddress = new AddressModel("615 NE Bowman Dr", "Waukee", "IA", "50263");

            //db.InsertRecord("Users", person);
            //Console.WriteLine("Hello World!");

            //var records = db.LoadRecords<PersonModel>("Users");
            //foreach (var item in records)
            //{
            //    Console.WriteLine($" {item.Id}: {item.FirstName} {item.LastName}");
            //}

            //var rec = db.LoadRecordById<PersonModel>("Users", new Guid("6280abb4-14ae-40bb-b396-5b1e3b6d09e1"));
            //rec.DateOfBirth = new DateTime(1987, 7, 9, 0, 0, 0, DateTimeKind.Utc);
            //db.UpsertRecord("Users", rec.Id, rec);

            //db.DeleteRecord<PersonModel>("Users", rec.Id);


            var records = db.LoadRecords<NameModel>("Users");
            foreach (var item in records)
            {
                Console.WriteLine($" {item.Id}: {item.FirstName} {item.LastName}");
            }

            Console.ReadLine();
        }
    }
}
