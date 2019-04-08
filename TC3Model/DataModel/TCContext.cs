#define EF7
namespace TC3Model.DataModel
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.Diagnostics;
    using System.Linq;
    using TC3Model.Annotations;
    using TC3Model.DataModel.Classes;
    using TC3Model.Interfaces;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Console;
    using Microsoft.Extensions.DependencyInjection;

    public partial class TCContext : DbContext
    {
        public TCContext() //: base("name=TCContext")
        {
            //UserName = this.Database.ExecuteSqlCommand("SELECT SUSER_NAME()", );

        }
        public string UserName { get; }  //TODO: Determine who we're connected as...
        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                   builder.AddConsole()
                          .AddFilter(DbLoggerCategory.Database.Command.Name,
                                     LogLevel.Information));
            return serviceCollection.BuildServiceProvider()
                    .GetService<ILoggerFactory>();
        }
        //Obsolete/Deprecated in EF 2.2
        //public static readonly LoggerFactory MyConsoleLoggerFactory
        //    = new LoggerFactory(new[] {
        //    new ConsoleLoggerProvider((category, level)
        //        => category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information, true)});
        #region "StashBase"
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Collectable> Collectables { get; set; }
        public virtual DbSet<Decal> Decals { get; set; }
        public virtual DbSet<DetailSet> DetailSets { get; set; }
        public virtual DbSet<FinishingProduct> FinishingProducts { get; set; }
        public virtual DbSet<Kit> Kits { get; set; }
        public virtual DbSet<Music> Music { get; set; }
        public virtual DbSet<Rocket> Rockets { get; set; }
        public virtual DbSet<Software> Software { get; set; }
        public virtual DbSet<Tool> Tools { get; set; }
        public virtual DbSet<Train> Trains { get; set; }
        //public virtual DbSet<VideoResearch> VideoResearch { get; set; }
        public virtual DbSet<Episode> Episodes { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Special> Specials { get; set; }

        public virtual DbSet<StashImage> StashImages { get; set; }

        private void BuildStashModel(ModelBuilder modelBuilder)
        {
            //Define Foreign Key for Many-to-Many Images relationship...
            modelBuilder.Entity<StashImage>().HasKey(si => new { si.StashID, si.ImageID });

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (entityType.ClrType.BaseType == typeof(StashBase)) //if (typeof(StashBase<>).IsAssignableFrom(entityType.ClrType))
                {
                    //modelBuilder.Entity<StashBase>().HasOne(sb => sb.Location).WithOne(loc => loc.Stash).IsRequired();
                    //modelBuilder.Entity(entityType.Name).Property<DateTime?>("DateCreated");
                    //modelBuilder.Entity(entityType.Name).Property<DateTime?>("DateModified");

                    //modelBuilder.Entity(entityType.Name).Property<DateTime?>("DateInventoried");
                    //modelBuilder.Entity(entityType.Name).Property<DateTime?>("DatePurchased");
                    //modelBuilder.Entity(entityType.Name).Property<DateTime?>("DateVerified");
                }
            }
            #region "Configure Indexes"
            //EFCore can't handle [Index] annotation, so we must do it here...
            modelBuilder.Entity<Book>().HasIndex(i => new { i.AlphaSort, i.ID }).IsUnique().HasName("IX_BooksByAlphaSort");
            modelBuilder.Entity<Book>().HasIndex(i => new { i.Author, i.ID }).IsUnique().HasName("IX_BooksByAuthor");
            modelBuilder.Entity<Book>().HasIndex(i => new { i.MediaFormat, i.AlphaSort, i.ID }).IsUnique().HasName("IX_BooksByFormat");
            modelBuilder.Entity<Book>().HasIndex(i => new { i.ISBN, i.ID }).IsUnique().HasName("IX_BooksByISBN");
            modelBuilder.Entity<Book>().HasIndex(i => new { i.Subject, i.ID }).IsUnique().HasName("IX_BooksBySubject");
            modelBuilder.Entity<Book>().HasIndex(i => new { i.Title, i.ID }).IsUnique().HasName("IX_BooksByTitle");
            
            modelBuilder.Entity<Collectable>().HasIndex(i => new { i.Name, i.Series, i.Type, i.Reference, i.ID }).IsUnique().HasName("IX_CollectablesByName");
            modelBuilder.Entity<Collectable>().HasIndex(i => new { i.Series, i.Type, i.Reference, i.ID }).IsUnique().HasName("IX_CollectablesBySeries");
            modelBuilder.Entity<Collectable>().HasIndex(i => new { i.Type, i.Series, i.Reference, i.ID }).IsUnique().HasName("IX_CollectablesByType");

            #region "Hobby"
            modelBuilder.Entity<Kit>().HasIndex(i => new { i.Type, i.Designation, i.Scale, i.ID }).IsUnique().HasName("IX_KitsByDesignation");
            modelBuilder.Entity<Kit>().HasIndex(i => new { i.Manufacturer, i.ID }).IsUnique().HasName("IX_KitsByManufacturer");
            modelBuilder.Entity<Kit>().HasIndex(i => new { i.Name, i.Scale, i.ID }).IsUnique().HasName("IX_KitsByName");
            modelBuilder.Entity<Kit>().HasIndex(i => new { i.Nation, i.Service, i.Era, i.ID }).IsUnique().HasName("IX_KitsByNationServiceEra");
            modelBuilder.Entity<Kit>().HasIndex(i => new { i.Scale, i.Type, i.Manufacturer, i.ID }).IsUnique().HasName("IX_KitsByScale");
            modelBuilder.Entity<Kit>().HasIndex(i => new { i.Type, i.Scale, i.ID }).IsUnique().HasName("IX_KitsByType");
            modelBuilder.Entity<Decal>().HasIndex(i => new { i.Type, i.Designation, i.Scale, i.ID }).IsUnique().HasName("IX_DecalsByDesignation");
            modelBuilder.Entity<Decal>().HasIndex(i => new { i.Manufacturer, i.ID }).IsUnique().HasName("IX_DecalsByManufacturer");
            modelBuilder.Entity<Decal>().HasIndex(i => new { i.Name, i.Scale, i.ID }).IsUnique().HasName("IX_DecalsByName");
            modelBuilder.Entity<Decal>().HasIndex(i => new { i.Scale, i.Type, i.Manufacturer, i.ID }).IsUnique().HasName("IX_DecalsByScale");
            modelBuilder.Entity<Decal>().HasIndex(i => new { i.Type, i.Scale, i.ID }).IsUnique().HasName("IX_DecalsByType");
            modelBuilder.Entity<DetailSet>().HasIndex(i => new { i.Type, i.Designation, i.Scale, i.ID }).IsUnique().HasName("IX_DetailSetsByDesignation");
            modelBuilder.Entity<DetailSet>().HasIndex(i => new { i.Manufacturer, i.ID }).IsUnique().HasName("IX_DetailSetsByManufacturer");
            modelBuilder.Entity<DetailSet>().HasIndex(i => new { i.Name, i.Scale, i.ID }).IsUnique().HasName("IX_DetailSetsByName");
            modelBuilder.Entity<DetailSet>().HasIndex(i => new { i.Scale, i.Type, i.Manufacturer, i.ID }).IsUnique().HasName("IX_DetailSetsByScale");
            modelBuilder.Entity<DetailSet>().HasIndex(i => new { i.Type, i.Scale, i.ID }).IsUnique().HasName("IX_DetailSetsByType");
            #endregion

            modelBuilder.Entity<Music>().HasIndex(i => new { i.AlphaSort, i.ID }).IsUnique().HasName("IX_MusicByAlphaSort");
            modelBuilder.Entity<Music>().HasIndex(i => new { i.Artist, i.Year, i.MediaFormat, i.ID }).IsUnique().HasName("IX_MusicByArtist");
            modelBuilder.Entity<Music>().HasIndex(i => new { i.MediaFormat, i.Artist, i.Year, i.ID }).IsUnique().HasName("IX_MusicByFormat");
            modelBuilder.Entity<Music>().HasIndex(i => new { i.Type, i.Artist, i.Year, i.MediaFormat, i.ID }).IsUnique().HasName("IX_MusicByType");

            modelBuilder.Entity<Software>().HasIndex(i => new { i.AlphaSort, i.ID }).IsUnique().HasName("IX_SoftwareByAlphaSort");
            modelBuilder.Entity<Software>().HasIndex(i => new { i.Platform, i.AlphaSort, i.ID }).IsUnique().HasName("IX_SoftwareByPlatform");
            modelBuilder.Entity<Software>().HasIndex(i => new { i.Type, i.AlphaSort, i.ID }).IsUnique().HasName("IX_SoftwareByType");

            #region "Video Library"
            modelBuilder.Entity<Episode>().HasIndex(i => new { i.MediaFormat, i.Series, i.Number, i.ID }).IsUnique().HasName("IX_EpisodesByFormat");
            modelBuilder.Entity<Episode>().HasIndex(i => new { i.Series, i.Number, i.ID }).IsUnique().HasName("IX_EpisodesBySeries");
            modelBuilder.Entity<Episode>().HasIndex(i => new { i.Subject, i.ID }).IsUnique().HasName("IX_EpisodesBySubject");
            modelBuilder.Entity<Movie>().HasIndex(i => new { i.MediaFormat, i.AlphaSort, i.ID }).IsUnique().HasName("IX_MoviesByFormat");
            modelBuilder.Entity<Movie>().HasIndex(i => new { i.AlphaSort, i.MediaFormat, i.ID }).IsUnique().HasName("IX_MoviesBySort");
            modelBuilder.Entity<Movie>().HasIndex(i => new { i.Subject, i.Title, i.ID }).IsUnique().HasName("IX_MoviesBySubject");
            modelBuilder.Entity<Movie>().HasIndex(i => new { i.Title, i.MediaFormat, i.ID }).IsUnique().HasName("IX_MoviesByTitle");
            modelBuilder.Entity<Special>().HasIndex(i => new { i.MediaFormat, i.AlphaSort, i.ID }).IsUnique().HasName("IX_SpecialsByFormat");
            modelBuilder.Entity<Special>().HasIndex(i => new { i.AlphaSort, i.MediaFormat, i.ID }).IsUnique().HasName("IX_SpecialsBySort");
            modelBuilder.Entity<Special>().HasIndex(i => new { i.Subject, i.Title, i.ID }).IsUnique().HasName("IX_SpecialsBySubject");
            modelBuilder.Entity<Special>().HasIndex(i => new { i.Title, i.MediaFormat, i.ID }).IsUnique().HasName("IX_SpecialsByTitle");
            #endregion
            #endregion
            #region "Seed Data"
            modelBuilder.Entity<Location>().HasData(new Location { ID = -1, Name = "Unknown", Description = "", PhysicalLocation = "Unknown" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = -2, Name="Unspecified", Description = "", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 1, Name="?? Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Unknown" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 2, Name="Applied", Description = "Applied to Kit", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 3, Name="Box #? Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 4, Name="Box #144-1 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 5, Name="Box #144-2 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 6, Name="Box #3 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 7, Name="Box #350-1 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 8, Name="Box #350-2 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 9, Name="Box #700-1 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 10, Name="Box #700-2 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 11, Name="Box #700-2 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 12, Name="Box #700-3 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 13, Name="Box #700-4 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 14, Name="Box #72-1 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 15, Name="Box #72-10 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 16, Name="Box #72-11 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 17, Name="Box #72-12 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 18, Name="Box #72-13 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 19, Name="Box #72-14 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 20, Name="Box #72-2 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 21, Name="Box #72-4 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 22, Name="Box #72-5 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 23, Name="Box #72-5 Ziploc bag (2nd set, with wheels, left in box)", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 24, Name="Box #72-6 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 25, Name="Box #72-7 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 26, Name="Box #72-8 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 27, Name="Box #72-9 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 28, Name="Car Box #1 Ziploc bag", Description = "", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 29, Name="Decals left in bag", Description = "", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 30, Name="Decals left with detail set included in kit", Description = "", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 31, Name="Decals salvaged", Description = "", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 32, Name="FreeTime Box #2 [Ken's Room]", Description = "", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 33, Name="FreeTime Box #3 [Ken's Room]", Description = "", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 34, Name="Included in kit", Description = "", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 35, Name="Inside E-2C Hawkeye Box (Revell 03945 Kit #2640)", Description = "", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 36, Name="JVC CH-200 Box Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 37, Name="Left in bag", Description = "", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 38, Name="Left in box", Description = "", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 39, Name="On Order", Description = "", PhysicalLocation="N/A" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 40, Name="SciFi Box #1 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 41, Name="SciFi Box #2 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 42, Name="SciFi Box #3 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 43, Name="SciFi Box #4 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 44, Name="SciFi Box #5 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 45, Name="SciFi Box #6 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 46, Name="SciFi Box #7 Ziploc bag", Description = "Ziploc Bag", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 47, Name="Sealed in package", Description = "", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 48, Name="Sealed with detail set included in kit", Description = "", PhysicalLocation="Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = 49, Name="Unboxed [Ken's Room]", Description = "", PhysicalLocation="Ken's Room" });
            #endregion
        }
        #endregion
        #region "Reference"
        public virtual DbSet<BlueAngelsHistory> BlueAngelsHistories { get; set; }
        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<AircraftDesignation> AircraftDesignations { get; set; }
        public virtual DbSet<ShipClass> ShipClasses { get; set; }
        public virtual DbSet<ShipClassType> ShipClassTypes { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }

        public virtual DbSet<ReferenceImage> ReferenceImages { get; set; }

        private void BuildReferenceModel(ModelBuilder modelBuilder)
        {
            //Define Foreign Key for Many-to-Many Images relationship...
            modelBuilder.Entity<ReferenceImage>().HasKey(ri => new { ri.ReferenceID, ri.ImageID });

            #region "Configure Indexes"
            //EFCore can't handle [Index] annotation, so we must do it here...
            modelBuilder.Entity<AircraftDesignation>().HasIndex(i => new { i.Designation, i.ID }).IsUnique().HasName("IX_AircraftDesignationsByDesignation");

            modelBuilder.Entity<Ship>().HasIndex(i => new { i.HullNumber, i.ID }).IsUnique().HasName("IX_ShipsByHullNumber");
            modelBuilder.Entity<Ship>().HasIndex(i => new { i.Name, i.ID }).IsUnique().HasName("IX_ShipsByName");

            //modelBuilder.Entity<ShipClass>().HasIndex(i => new { i.ShipClassType, i.ID }).IsUnique().HasName("IX_ShipClassesByType");
            modelBuilder.Entity<ShipClass>().HasIndex(i => new { i.Name, i.ID }).IsUnique().HasName("IX_ShipClassesByName");
            //modelBuilder.Entity<ShipClass>().HasIndex(i => new { i.ShipClassType, i.ID }).IsUnique().HasName("IX_ShipClassesByType");

            modelBuilder.Entity<ShipClassType>().HasIndex(i => new { i.Description, i.ID }).IsUnique().HasName("IX_ShipClassTypesByName");
            modelBuilder.Entity<ShipClassType>().HasIndex(i => new { i.TypeCode, i.ID }).IsUnique().HasName("IX_ShipClassTypesByType");
            #endregion
            #region "Seed Data"
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = -1, TypeCode = "XXX", Description = "Unassigned" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 01, TypeCode = "ACR", Description = "Heavy Armored Cruiser - Battleship prototype" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 02, TypeCode = "AD", Description = "Destroyer Tenders" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 03, TypeCode = "AE", Description = "Ammunition Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 04, TypeCode = "AG", Description = "Oceanographic Research Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 05, TypeCode = "AGF", Description = "Miscellaneous Command Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 06, TypeCode = "AGSS", Description = "Auxiliary Research Submarines" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 07, TypeCode = "AO", Description = "Oilers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 08, TypeCode = "AOE", Description = "Fast Combat Support Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 09, TypeCode = "AOR", Description = "Replenishment Oilers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 10, TypeCode = "APD", Description = "High Speed Transports" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 11, TypeCode = "ARS", Description = "Salvage Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 12, TypeCode = "AS", Description = "Submarine Tenders" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 13, TypeCode = "ATS", Description = "Salvage and Rescue Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 14, TypeCode = "BB", Description = "Battleships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 15, TypeCode = "CA", Description = "Heavy (Gun) Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 16, TypeCode = "CAG", Description = "Guided Missile Heavy Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 17, TypeCode = "CB", Description = "Large Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 18, TypeCode = "CG", Description = "Guided Missile Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 19, TypeCode = "CGN", Description = "Guided Missile Cruisers (Nuclear)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 20, TypeCode = "CL", Description = "Light (Gun) Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 21, TypeCode = "CLC", Description = "Command Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 22, TypeCode = "CLG", Description = "Light Guided Missile Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 23, TypeCode = "CV", Description = "Multi-Purpose (Fleet) Aircraft Carriers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 24, TypeCode = "CVE", Description = "Escort Carriers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 25, TypeCode = "CVL", Description = "Light Carriers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 26, TypeCode = "CVN", Description = "Multi-Purpose Aircraft Carriers (Nuclear)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 27, TypeCode = "DD", Description = "Destroyers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 28, TypeCode = "DDG", Description = "Guided Missile Destroyers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 29, TypeCode = "DE", Description = "Destroyer Escorts" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 30, TypeCode = "DL", Description = "Post World War II Frigates" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 31, TypeCode = "DLG", Description = "Guided Missile Frigate (post WWII)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 32, TypeCode = "FF", Description = "Frigates" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 33, TypeCode = "FFG", Description = "Guided Missile Frigates" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 34, TypeCode = "IX", Description = "Unclassified Miscellaneous Units" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 35, TypeCode = "LCC", Description = "Amphibious Command Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 36, TypeCode = "LCS", Description = "Littoral Combat Ship" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 37, TypeCode = "LHA", Description = "Amphibious Assault Ships (general purpose)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 38, TypeCode = "LHD", Description = "Amphibious Assault Ships (multi-purpose)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 39, TypeCode = "LKA", Description = "Amphibious Cargo Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 40, TypeCode = "LPD", Description = "Amphibious Transport docks" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 41, TypeCode = "LPH", Description = "Amphibious Assault Ships (Helicopter)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 42, TypeCode = "LSD", Description = "Dock Landing Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 43, TypeCode = "LST", Description = "Tank Landing Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 44, TypeCode = "MCM", Description = "Mine Countermeasures Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 45, TypeCode = "MCS", Description = "Mine Countermeasures Support Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 46, TypeCode = "MHC", Description = "Minehunters, Coastal" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 47, TypeCode = "MSO", Description = "Ocean Minesweepers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 48, TypeCode = "PC", Description = "Patrol Craft" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 49, TypeCode = "PG", Description = "Patrol Gunboats" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 50, TypeCode = "PHM", Description = "Patrol Combatants - Missile (Hydrofoil)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 51, TypeCode = "SS", Description = "Submarines" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 52, TypeCode = "SSBN", Description = "Ballistic Missile Submarines (Nuclear)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 53, TypeCode = "SSN", Description = "Submarines (Nuclear)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 54, TypeCode = "SST", Description = "Training Submarines" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 55, TypeCode = "T-AE", Description = "Ammunition Ships (assigned to Military Sealift Command)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 56, TypeCode = "T-AFS", Description = "Combat Store Ships (assigned to Military Sealift Command)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 57, TypeCode = "T-AG", Description = "Oceanographic Research Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 58, TypeCode = "T-AO", Description = "Oilers (assigned to Military Sealift Command)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 59, TypeCode = "T-AOE", Description = "Fast Combat Support Ships (assigned to Military Sealift Command)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 60, TypeCode = "T-ARS", Description = "Salvage Ships (assigned to Military Sealift Command)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 61, TypeCode = "T-AS", Description = "Submarine Tenders (assigned to Military Sealift Command)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = 62, TypeCode = "T-LKA", Description = "Amphibious Cargo Ships (assigned to Military Sealift Command)" });
            #endregion
        }
        #endregion
        #region "Miscellaneous"
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Query> Queries { get; set; }
        private void BuildMiscModel(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (entityType.ClrType.BaseType == typeof(History))
                {
                    //modelBuilder.Entity(entityType.Name).Property<DateTime>("DateChanged");
                }
            }
            #region "Configure Indexes"
            //EFCore can't handle [Index] annotation, so we must do it here...
            modelBuilder.Entity<History>().HasIndex(i => new { i.TableName, i.RecordID, i.DateChanged, i.Column }).IsUnique().HasName("IX_HistoryByRecord");
            modelBuilder.Entity<History>().HasIndex(i => new { i.DateChanged, i.TableName, i.RecordID, i.Column }).IsUnique().HasName("IX_HistoryByDate");
            modelBuilder.Entity<Image>().HasIndex(i => new { i.TableName, i.RecordID }).IsUnique().HasName("IX_ImageByRecord");
            //modelBuilder.Entity<FileList>().HasIndex(i => new { i.Path }).IsUnique().HasName("IX_FileListByPath");
            //modelBuilder.Entity<MenuEntries>().HasIndex(i => new { i.ButtonLabel, i.ParentID, i.Label, i.ID }).IsUnique().HasName("IX_MenuEntriesByButton");
            //modelBuilder.Entity<MenuEntries>().HasIndex(i => new { i.ParentID, i.ButtonLabel, i.Label, i.ID }).IsUnique().HasName("IX_MenuEntriesByParentID");
            #endregion
        }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //.UseLoggerFactory(MyConsoleLoggerFactory)
                .UseLoggerFactory(GetLoggerFactory())
                .EnableSensitiveDataLogging(true)
                .UseSqlServer("Server = (localdb)\\MSSQLLocalDB;Database=TC3a;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CustomConventions.Add(modelBuilder);
            BuildStashModel(modelBuilder);
            BuildReferenceModel(modelBuilder);
            BuildMiscModel(modelBuilder);
#if EF7

#else
            //Shouldn't be necessary with [NotMapped] attribute...
            //  modelBuilder.Types().Configure(c=>c.Ignore("IsDirty"));
            //All Entities are IEntity guys, but not all are IStash so check before this next section...
            //  modelBuilder.Types().Configure(c => c.Property("Price").HasPrecision(19, 4));
            //  modelBuilder.Types().Configure(c => c.Property("Value").HasPrecision(19, 4));
            modelBuilder.Types().Configure(entity =>
            {
                if (entity.GetType().IsAssignableFrom(typeof(StashBase)))
                {
                    entity.Property("Price").HasPrecision(19, 4);
                    entity.Property("Value").HasPrecision(19, 4);
                }
                if (entity.GetType().IsAssignableFrom(typeof(DataEntityBase)))
                    entity.HasKey("ID");
            });
#endif
            //Define <ImageDetail>'s primary key to be the TableName/RecordID composite...

            //TODO:          modelBuilder.Entity<Video_Research>().Property(e => e.Format).IsUnicode(false);
            //TODO:          modelBuilder.Entity<Query>().Property(e => e.Name).IsUnicode(false);
            //TODO:          modelBuilder.Entity<Query>().Property(e => e.Description).IsUnicode(false);
            //TODO:          modelBuilder.Entity<Query>().Property(e => e.Query1).IsUnicode(false);

            base.OnModelCreating(modelBuilder);
        }
        public void SaveHistory(EntityEntry<IDataEntity> entry)
        {
            Int32 ID = ((IDataEntity)entry.Entity).ID;
            string tableName = entry.Entity.GetType().Name;
            tableName = tableName == "Image" ? "Images" : TypeToTableName(entry.Entity.GetType().BaseType.Name);
            DateTime dateChanged = DateTime.Now;
            EntityState entityState = entry.State;
            //foreach (var propName in entry.CurrentValues.PropertyNames.Where(p => p.Trim() != "RowID")) {
            foreach (var prop in entry.Properties.Where(p => p.Metadata.Name.Trim() != "RowID"))
            {
                var propName = prop.Metadata.Name.Trim();
                var original = entry.State == EntityState.Added ? "Record Added" : entry.OriginalValues[propName]?.ToString();
                var current = entry.State == EntityState.Deleted ? "Record Deleted" : entry.CurrentValues[propName]?.ToString();
                History history = null;
                switch (entry.State)
                {
                    case EntityState.Added:
                        history = new History {
                            TableName = tableName,
                            RecordID = ID,
                            Column = propName,
                            OriginalValue = original,
                            Value = current,
                            DateCreated = dateChanged,
                            DateModified = dateChanged,
                            DateChanged = dateChanged,
                            Who = UserName
                        };
                        Debug.WriteLine("Record Added: {0}.ID #{1}: {2} {3}", tableName, ID, propName, current == null ? "Null" : $"\"{current}\"");
                        break;
                    case EntityState.Deleted:
                        history = new History
                        {
                            TableName = tableName,
                            RecordID = ID,
                            Column = propName,
                            OriginalValue = original,
                            Value = current,
                            DateCreated = dateChanged,
                            DateModified = dateChanged,
                            DateChanged = dateChanged,
                            Who = UserName
                        };
                        Debug.WriteLine("Record Deleted: {0}.ID #{1}: {2} {3}", tableName, ID, propName, original == null ? "Null" : $"\"{original}\"");
                        break;
                    case EntityState.Modified:
                        if (original != current) {
                            Debug.WriteLine("{0}.ID #{1}: {2} changed from {3} to {4}", tableName, ID, propName, original == null ? "Null" : $"\"{original}\"", current == null ? "Null" : $"\"{current}\"");
                            history = new History
                            {
                                TableName = tableName,
                                RecordID = ID,
                                Column = propName,
                                OriginalValue = original,
                                Value = current,
                                DateCreated = dateChanged,
                                DateModified = dateChanged,
                                DateChanged = dateChanged,
                                Who = UserName
                            };
                        }
                        break;
                    default:
                        break;
                }
                if (history != null)
                    Histories.Add(history);
            }
        }
        public override int SaveChanges()
        {
            var timestamp = DateTime.Now;
            //Automatically set DateCreated and DateModified on any entities that implement the IModificationHistory interface...
            //foreach (var entry in this.ChangeTracker.Entries<IEntity>()
            //        .Where(e => (e.State == EntityState.Added || e.State == EntityState.Modified))
            //        .Select(e => e.Entity as IEntity)) {
            //    entry.DateModified = DateTime.Now;
            //    if (entry.DateCreated == DateTime.MinValue)
            //        entry.DateCreated = DateTime.Now;
            //}

            ////Use the context's tracking information to add any History transactions...
            //foreach (var entry in this.ChangeTracker.Entries<IDataEntity>()
            //        .Where(e => e.State != EntityState.Unchanged && e.State != EntityState.Detached))
            //{
            //    entry.Entity.DateModified = timestamp;
            //    if (entry.Entity.DateCreated == DateTime.MinValue)
            //        entry.Entity.DateCreated = timestamp;
            //    SaveHistory(entry);
            //}

            //Execute the real SaveChanges()...
            int result = base.SaveChanges();

            //Clear our ignored IsDirty flag for the application...
            //foreach (var entry in this.ChangeTracker.Entries<IDataEntity>().Select(e => e.Entity as IDataEntity))
            //    entry.IsDirty = false;
            return result;
        }
        public string TypeToTableName(string TableName)
        {
            switch (TableName)
            {
                case "AircraftDesignation":
                case "Book":
                case "Collectable":
                case "Decal":
                case "DetailSet":
                case "Episode":
                case "FinishingProduct":
                case "Image":
                case "Kit":
                case "Location":
                case "Movie":
                case "Rocket":
                case "Ship":
                case "ShipClassType":
                case "Special":
                case "Tool":
                case "Train":
                    TableName += "s";
                    break;
                case "__MigrationHistory":
                case "BlueAngelsHistory":
                case "History":
                case "Music":
                case "Query":
                case "ShipClass":
                case "Software":
                    break;
                case "Companies":
                    TableName = "Company";
                    break;
                default:
                    break;
            }
            return TableName;
        }
    }
}