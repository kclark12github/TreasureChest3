using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using TC3Core.Data;
using TC3Core.Data.Services;
using TC3Core.Data.Services.SQL;
using TC3Core.Domain.Classes.Stash;

namespace TreasureChest3
{
    class Program
    {
        private static void SimpleRepoGraphQuery()
        {
            StashRepository<Book> _repo = new StashRepository<Book>(new TCContext());
            using (var context = new TCContext())
            {
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
        private static void SimpleBookGraphQuery()
        {
            using (var context = new TCContext())
            {
                Book book = context.Books
                    .Include(b => b.Location)   //Eager Loading
                    .FirstOrDefault(b => b.Title.StartsWith("ABC"));

                //If Location is declared as Virtual EF would load the collection
                //on a lazy basis without explicitly loading...
                Book anotherBook = context.Books
                    .Include(b => b.Location)   //Eager Loading
                    .FirstOrDefault(b => b.Title.StartsWith("Death"));
                //context.Entry(anotherBook).Collection(b => b.Location).Load();
            }
        }
        private static void SimpleDecalDemo()
        {
            using (var context = new TCContext())
            {
                StashRepository<Decal> repo = new StashRepository<Decal>(context);
                Decal decal = (Decal)repo.FindByKeyWithImages(Guid.Parse("3e206a4d-4f27-e911-9c25-001583f52824"));
                //Debug.WriteLine("[Before] Decals.ID #{0}: Reference:=\"{1}\"", decal.ID, decal.Reference);
                //Debug.WriteLine("[Before] Images.ID #{0}: FileName:=\"{1}\"", decal.Images[0].ID, decal.Images[0].FileName);
                decal.Reference = decal.Reference == "FTD72003" ? "FTD72003 Data changed" : "FTD72003";
                //Debug.WriteLine("[After] Decals.ID #{0}: Reference:=\"{1}\"", decal.ID, decal.Reference);
                //decal.Images[0].FileName = decal.Images[0].FileName == null ? "Unknown" : null;
                //Debug.WriteLine("[After] Images.ID #{0}: FileName:=\"{1}\"", decal.Images[0].ID, decal.Images[0].FileName);
                //repo.UpdateDisconnected(decal);   //Will update but will not know original values for History updates...
                context.SaveChanges();
            }
        }
        private static void InsertDecalDemo()
        {
            using (var context = new TCContext())
            {
                var decal = new Decal
                {
                    //ID = AutoIncrement,
                    OID = 35,
                    //RowID = Null,
                    //DateCreated = Null,
                    //DateModified = Null,
                    Cataloged = true,
                    DateInventoried = new DateTime(2005, 9, 5, 16, 5, 29),
                    DatePurchased = new DateTime(2005, 9, 5, 16, 5, 28),
                    DateVerified = new DateTime(2005, 9, 6, 17, 6, 39),
                    Location = context.Locations.Find(2),
                    Notes = "",
                    Price = 0,
                    Value = 0,
                    WishList = false,
                    Designation = "UNKNOWN",
                    Manufacturer = "Monogram",
                    Name = "Rommel's Rod™ - Tom Daniel",
                    Nation = "N/A",
                    ProductCatalog = "HobbyTown USA",
                    Reference = "85-4260",
                    Scale = "1/24",
                    Type = "Car"
                };
                context.Add(decal);
                context.SaveChanges();
                //decal = context.Decals.Find(1);

                decal = context.Decals.Where(d => d.ID == Guid.Parse("3e206a4d-4f27-e911-9c25-001583f52824")).Include(d => d.Location).FirstOrDefault();
            }
        }
        static void Main(string[] args)
        {
            SimpleDecalDemo();
            InsertDecalDemo();

            if (Debugger.IsAttached)
            {
                Console.Write("Press RETURN to continue...");
                Console.ReadLine();
            }
        }
    }
}
