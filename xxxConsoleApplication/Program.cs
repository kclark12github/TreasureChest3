using TCDomain.Classes;
using TCDomain.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureChest3
{
    class Program
    {
        private static void SimpleGraphQuery()
        {
            using (var context = new TCContext())
            {
                context.Database.Log = Console.WriteLine;
                Book book = context.Books
                    .Include(b => b.Location)   //Eager Loading
                    .FirstOrDefault(b => b.Title.StartsWith("ABC"));

                //If Location is declared as Virtual EF would load the collection
                //on a lazy basis without explicitly loading...
                Book anotherBook = context.Books
                    .FirstOrDefault(b => b.Title.StartsWith("Death"));
                //context.Entry(anotherBook).Collection(b => b.Location).Load();
            }
        }
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<TCContext>());

            SimpleGraphQuery();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press RETURN to continue...");
                Console.ReadLine();
            }
        }
    }
}
