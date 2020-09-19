using System;
using System.Linq;

namespace PrayWall
{
    class Program
    {
        static void Main()
        {
            using (var db = new PrayerRequest())
            {
                // Create
                Console.WriteLine("Inserting a new prayer request");
                db.Add(new Wall { Url = "http://blogs.msdn.com/adonet" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a request");
                var blog = db.Walls
                    .OrderBy(b => b.WallId)
                    .First();

                // Update
                Console.WriteLine("Updating the prayer request");
                wall.Url = "https://devblogs.microsoft.com/dotnet";
                wall.Chains.Add(
                    new Chain
                    {
                        Title = "Thanks for praying",
                        Content = "I added a new prayer request!"
                    });
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the request");
                db.Remove(wall);
                db.SaveChanges();
            }
        }
    }
}}
