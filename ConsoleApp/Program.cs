using Models;

namespace ConsoleApp
{
   internal class Program
   {
      static void Main(string[] args)
      {
         using DatabaseAccess db = new();
         //var people = new People
         //{
         //   Name = "Geraldo Luiz",
         //   CreatedAt = DateOnly.Parse("22/08/2023"),
         //   TimeAt = TimeOnly.Parse("15:00")
         //};
         //db.People.Add(people);
         //db.SaveChanges();

         var items = db.People.ToList();

         Console.WriteLine("Done ...");
      }
   }
}