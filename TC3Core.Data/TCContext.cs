using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.SqlServer.Migrations.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TC3Core.Data.CustomMigrationOperations;
using TC3Core.Domain.Annotations;
using TC3Core.Domain.Classes;
using TC3Core.Domain.Classes.Reference;
using TC3Core.Domain.Classes.Stash;
using TC3Core.Domain.Interfaces;

namespace TC3Core.Data
{
    public interface IDbContext : IDisposable
    {
        IQueryable<T> Query<T>() where T : class;
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;
        EntityEntry Entry(object entity);
        int SaveChanges();
        //Task<int> SaveChangesAsync();
        #region "Reference"
        DbSet<BlueAngelsHistory> BlueAngelsHistories { get; set; }
        DbSet<Company> Companies { get; set; }

        DbSet<AircraftDesignation> AircraftDesignations { get; set; }
        DbSet<ShipClass> ShipClasses { get; set; }
        DbSet<ShipClassType> ShipClassTypes { get; set; }
        DbSet<Ship> Ships { get; set; }
        #endregion
        #region "Stash"
        DbSet<Book> Books { get; set; }
        DbSet<Collectable> Collectables { get; set; }
        DbSet<Decal> Decals { get; set; }
        DbSet<DetailSet> DetailSets { get; set; }
        DbSet<FinishingProduct> FinishingProducts { get; set; }
        DbSet<Kit> Kits { get; set; }
        DbSet<Music> Music { get; set; }
        DbSet<Rocket> Rockets { get; set; }
        DbSet<Software> Software { get; set; }
        DbSet<Tool> Tools { get; set; }
        DbSet<Train> Trains { get; set; }
        //DbSet<VideoResearch> VideoResearch { get; set; }
        DbSet<Episode> Episodes { get; set; }
        DbSet<Video> Videos { get; set; }
        #endregion
        #region "Miscellaneous"
        DbSet<History> Histories { get; set; }
        DbSet<Image> Images { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Query> Queries { get; set; }
        #endregion
    }
    public class TCContext : DbContext, IDbContext
    {
        #region DefineLoggerFactory
        public static readonly LoggerFactory tcLoggerFactory
            = new LoggerFactory(new[]
            {
                new ConsoleLoggerProvider((category, level)
                    => category == DbLoggerCategory.Database.Command.Name
                       && level == LogLevel.Information, true)
            });
        #endregion
        public TCContext(DbContextOptions<TCContext> options) : base(options)
        {
            //Database.SetInitializer<TCContext>(null); //EF6
            //UserName = this.Database.ExecuteSqlCommand("SELECT SUSER_NAME()", );
        }
        public TCContext() { }

        IQueryable<T> IDbContext.Query<T>()
        {
            return Set<T>();
        }
        void IDbContext.Add<T>(T entity)
        {
            Set<T>().Add(entity);
        }
        void IDbContext.Update<T>(T entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
        void IDbContext.Remove<T>(T entity)
        {
            Set<T>().Remove(entity);
        }

        #region "Reference"
        public virtual DbSet<BlueAngelsHistory> BlueAngelsHistories { get; set; }
        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<AircraftDesignation> AircraftDesignations { get; set; }
        public virtual DbSet<ShipClass> ShipClasses { get; set; }
        public virtual DbSet<ShipClassType> ShipClassTypes { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }
        #endregion
        #region "Stash"
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
        public virtual DbSet<Video> Videos { get; set; }
        #endregion
        #region "Miscellaneous"
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Query> Queries { get; set; }
        #endregion
        #region Seeding
        private void SeedAircraftDesignations(ModelBuilder modelBuilder)
        {
            //SELECT 'modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), ' +
            //    'Designation = "' +[Designation] + '", ' +
            //    'Manufacturer = "' +[Manufacturer] + '", ' +
            //    'Name = ' + IsNull('"' +[Name] + '"', 'NULL') + ', ' +
            //    'Nicknames = ' + IsNull('"' +[Nicknames] + '"', 'NULL') + ', ' +
            //    'Notes = ' + IsNull('"' +[Notes] + '"', 'NULL') + ', ' +
            //    'Number = ' + IsNull(Convert(varchar(10),[Number]), 'NULL') + ', ' +
            //    'Version = ' + IsNull('"' +[Version] + '"', 'NULL') + ', ' +
            //    'ServiceDate = new DateTime(' + IsNull(Convert(varchar(4), Year([Service Date])) + ',' + Convert(varchar(2), Month([Service Date]))+',' + Convert(varchar(2), Day([Service Date]))+',' + Convert(varchar(2), DatePart(hh,[Service Date])) + ',' + Convert(varchar(2), DatePart(mi,[Service Date])) + ',' + Convert(varchar(2), DatePart(ss,[Service Date])),'1900,01,01,00,00,00')+'), ' +
            //                            'DateCreated = new DateTime(' + Convert(varchar(4), Year([DateCreated]))+',' + Convert(varchar(2), Month([DateCreated]))+',' + Convert(varchar(2), Day([DateCreated]))+',' + Convert(varchar(2), DatePart(hh,[DateCreated])) + ',' + Convert(varchar(2), DatePart(mi,[DateCreated])) + ',' + Convert(varchar(2), DatePart(ss,[DateCreated])) + '), ' +
            //                                  'DateModified = new DateTime(' + Convert(varchar(4), Year([DateModified]))+',' + Convert(varchar(2), Month([DateModified]))+',' + Convert(varchar(2), Day([DateModified]))+',' + Convert(varchar(2), DatePart(hh,[DateModified])) + ',' + Convert(varchar(2), DatePart(mi,[DateModified])) + ',' + Convert(varchar(2), DatePart(ss,[DateModified])) + ') });'
            //FROM [dbo].[Aircraft Designations];
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-1 (AD)", Manufacturer = "Douglas", Name = "Skyraider", Nicknames = "Sandy, SPAD, Able Dog", Notes = null, Number = 1, Version = "", ServiceDate = new DateTime(1946, 11, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-3 (A3D, B-66)", Manufacturer = "Douglas", Name = "Skywarrior (See B-66 Destroyer)", Nicknames = "All Three Dead, Whale, Whistling Shitcan", Notes = null, Number = 3, Version = null, ServiceDate = new DateTime(1954, 12, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-4 (A4D)", Manufacturer = "McDonnell Douglas", Name = "Skyhawk", Nicknames = "The Scooter, Heinemann's Hot Rod, Bantam Bomber, Tinker Toy, Mighty Mite", Notes = null, Number = 4, Version = null, ServiceDate = new DateTime(1956, 10, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-5 (A3J)", Manufacturer = "Rockwell", Name = "Vigilante", Nicknames = null, Notes = null, Number = 5, Version = null, ServiceDate = new DateTime(1960, 1, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "EA-6B", Manufacturer = "Grumman", Name = "Prowler - Electronic Warfare (Intruder)", Nicknames = null, Notes = null, Number = 6, Version = "B", ServiceDate = new DateTime(1968, 5, 25, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "KA-6D", Manufacturer = "Grumman", Name = "Intruder - Tanker Version", Nicknames = null, Notes = null, Number = 6, Version = "D", ServiceDate = new DateTime(1963, 4, 19, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-6 (A2F)", Manufacturer = "Grumman", Name = "Intruder (See KA-6, EA-6B Prowler)", Nicknames = null, Notes = null, Number = 6, Version = null, ServiceDate = new DateTime(1963, 4, 19, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-7D", Manufacturer = "Vought", Name = "Corsair II - U.S.A.F. Version", Nicknames = null, Notes = null, Number = 7, Version = "D", ServiceDate = new DateTime(1966, 10, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-7E", Manufacturer = "Vought", Name = "Corsair II - U.S.N. Version", Nicknames = null, Notes = null, Number = 7, Version = "E", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-10", Manufacturer = "Fairchild/Republic", Name = "Thunderbolt II (Tank Killer)", Nicknames = null, Notes = null, Number = 10, Version = null, ServiceDate = new DateTime(1974, 12, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-11", Manufacturer = "Lockheed", Name = "Blackbird (CIA)", Nicknames = null, Notes = null, Number = 11, Version = null, ServiceDate = new DateTime(1964, 12, 22, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-20", Manufacturer = "Douglas", Name = "Boston (See P-70)", Nicknames = null, Notes = null, Number = 20, Version = null, ServiceDate = new DateTime(1940, 1, 2, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-24", Manufacturer = "Douglas", Name = "Dauntless (Land Based - Army)", Nicknames = null, Notes = null, Number = 24, Version = null, ServiceDate = new DateTime(1940, 6, 4, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-25", Manufacturer = "Curtiss", Name = "Helldiver (Marines)", Nicknames = null, Notes = null, Number = 25, Version = null, ServiceDate = new DateTime(1942, 6, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-26", Manufacturer = "Douglas", Name = "Invader", Nicknames = null, Notes = null, Number = 26, Version = null, ServiceDate = new DateTime(1943, 12, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "A-30", Manufacturer = "Martin", Name = "Baltimore", Nicknames = null, Notes = null, Number = 30, Version = null, ServiceDate = new DateTime(1941, 10, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "SB2C", Manufacturer = "Curtiss (C)", Name = "Helldiver", Nicknames = null, Notes = null, Number = null, Version = "SB2C", ServiceDate = new DateTime(1942, 6, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "SBD", Manufacturer = "Douglas (D)", Name = "Dauntless (See A-24)", Nicknames = null, Notes = null, Number = null, Version = "SBD", ServiceDate = new DateTime(1940, 6, 4, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "AC-047", Manufacturer = "Douglas", Name = "\"Puff the Magic Dragon\" Gunship (See C-47)", Nicknames = null, Notes = null, Number = 47, Version = null, ServiceDate = new DateTime(1938, 10, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "AC-119", Manufacturer = "Fairchild", Name = "Gunship (See C-119 Boxcar)", Nicknames = null, Notes = null, Number = 119, Version = null, ServiceDate = new DateTime(1949, 12, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "AC-130H", Manufacturer = "Lockheed", Name = "Hercules (Night Gunship)", Nicknames = null, Notes = null, Number = 130, Version = "H", ServiceDate = new DateTime(1955, 4, 7, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "AF-1E", Manufacturer = "North American", Name = "Fury (See F-1E, FJ-3, FJ-4 Fury)", Nicknames = null, Notes = null, Number = 1, Version = "E", ServiceDate = new DateTime(1953, 7, 3, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-1", Manufacturer = "Rockwell", Name = null, Nicknames = null, Notes = null, Number = 1, Version = null, ServiceDate = new DateTime(1979, 1, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-10", Manufacturer = "Martin", Name = null, Nicknames = null, Notes = null, Number = 10, Version = null, ServiceDate = new DateTime(1932, 3, 20, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-12", Manufacturer = "Martin", Name = null, Nicknames = null, Notes = null, Number = 12, Version = null, ServiceDate = new DateTime(1932, 3, 20, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-14", Manufacturer = "Martin", Name = null, Nicknames = null, Notes = null, Number = 14, Version = null, ServiceDate = new DateTime(1932, 3, 20, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-17", Manufacturer = "Boeing", Name = "Fortress", Nicknames = null, Notes = null, Number = 17, Version = null, ServiceDate = new DateTime(1939, 6, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-18", Manufacturer = "Douglas", Name = "Bolo/Digby-1", Nicknames = null, Notes = null, Number = 18, Version = null, ServiceDate = new DateTime(1937, 1, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-24", Manufacturer = "Consolidated", Name = "Liberator", Nicknames = null, Notes = null, Number = 24, Version = null, ServiceDate = new DateTime(1941, 6, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-25", Manufacturer = "North American", Name = "Mitchell (See F-10)", Nicknames = null, Notes = null, Number = 25, Version = null, ServiceDate = new DateTime(1940, 8, 19, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-26", Manufacturer = "Douglas", Name = "Invader (after B-26 Marauder was retired)", Nicknames = null, Notes = null, Number = 26, Version = null, ServiceDate = new DateTime(1943, 12, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-26", Manufacturer = "Martin", Name = "Marauder", Nicknames = null, Notes = null, Number = 26, Version = null, ServiceDate = new DateTime(1941, 2, 25, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-29", Manufacturer = "Boeing", Name = "Super Fortress", Nicknames = null, Notes = null, Number = 29, Version = null, ServiceDate = new DateTime(1943, 7, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-36", Manufacturer = "Convair", Name = "Peacemaker", Nicknames = null, Notes = null, Number = 36, Version = null, ServiceDate = new DateTime(1947, 8, 28, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-47", Manufacturer = "Boeing", Name = "Stratojet", Nicknames = null, Notes = null, Number = 47, Version = null, ServiceDate = new DateTime(1950, 6, 25, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-50", Manufacturer = "Boeing", Name = "Superfortress", Nicknames = null, Notes = null, Number = 50, Version = null, ServiceDate = new DateTime(1947, 6, 25, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-52", Manufacturer = "Boeing", Name = "Stratofortress", Nicknames = null, Notes = null, Number = 52, Version = null, ServiceDate = new DateTime(1955, 6, 29, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-57", Manufacturer = "Martin/General Dynamics", Name = "Canberra (See RB-57 Canberra)", Nicknames = null, Notes = null, Number = 57, Version = null, ServiceDate = new DateTime(1953, 7, 20, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "RB-57", Manufacturer = "Martin/General Dynamics", Name = "Canberra - Reconnaissance Version", Nicknames = null, Notes = null, Number = 57, Version = null, ServiceDate = new DateTime(1953, 7, 20, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-58", Manufacturer = "Convair", Name = "Hustler", Nicknames = null, Notes = null, Number = 58, Version = null, ServiceDate = new DateTime(1959, 9, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "B-66", Manufacturer = "Douglas", Name = "Destroyer (See A-3 Skywarrior)", Nicknames = null, Notes = null, Number = 66, Version = null, ServiceDate = new DateTime(1954, 12, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "C-1A", Manufacturer = "Grumman", Name = "Trader (See S-2 Tracker, E-1 Tracer)", Nicknames = null, Notes = null, Number = 1, Version = "A", ServiceDate = new DateTime(1954, 2, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "C-2A", Manufacturer = "Grumman", Name = "Greyhound (See E-2 Hawkeye)", Nicknames = null, Notes = null, Number = 2, Version = "A", ServiceDate = new DateTime(1961, 4, 19, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "C-5A", Manufacturer = "Lockheed", Name = "Galaxy", Nicknames = null, Notes = null, Number = 5, Version = "A", ServiceDate = new DateTime(1969, 12, 17, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "C-47", Manufacturer = "Douglas", Name = "Dakota", Nicknames = null, Notes = null, Number = 47, Version = null, ServiceDate = new DateTime(1938, 10, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "C-74", Manufacturer = "Douglas", Name = "Globemaster", Nicknames = null, Notes = null, Number = 74, Version = null, ServiceDate = new DateTime(1950, 5, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "C-97", Manufacturer = "Boeing", Name = "Stratofreighter/Stratotanker", Nicknames = null, Notes = null, Number = 97, Version = null, ServiceDate = new DateTime(1949, 1, 28, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "C-119", Manufacturer = "Fairchild", Name = "Boxcar (See AC-119 Gunship)", Nicknames = null, Notes = null, Number = 119, Version = null, ServiceDate = new DateTime(1949, 12, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "C-130", Manufacturer = "Lockheed", Name = "Hercules", Nicknames = null, Notes = null, Number = 130, Version = null, ServiceDate = new DateTime(1955, 4, 7, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "KC-130", Manufacturer = "Lockheed", Name = "Hercules - Tanker Version", Nicknames = null, Notes = null, Number = 130, Version = null, ServiceDate = new DateTime(1955, 4, 7, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "WC-130", Manufacturer = "Lockheed", Name = "Hercules - Weather Version", Nicknames = null, Notes = null, Number = 130, Version = null, ServiceDate = new DateTime(1955, 4, 7, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "C-133", Manufacturer = "Douglas", Name = "Cargomaster", Nicknames = null, Notes = null, Number = 133, Version = null, ServiceDate = new DateTime(1957, 8, 29, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "C-135", Manufacturer = "Boeing", Name = "Stratolifter", Nicknames = null, Notes = null, Number = 135, Version = null, ServiceDate = new DateTime(1950, 6, 25, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "C-141", Manufacturer = "Lockheed", Name = "Starlifter", Nicknames = null, Notes = null, Number = 141, Version = null, ServiceDate = new DateTime(1964, 10, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "E-1", Manufacturer = "Grumman", Name = "Tracer (See S-2 Tracker, C-1A Trader)", Nicknames = null, Notes = null, Number = 1, Version = null, ServiceDate = new DateTime(1954, 2, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "E-2", Manufacturer = "Grumman", Name = "Hawkeye", Nicknames = null, Notes = null, Number = 2, Version = null, ServiceDate = new DateTime(1961, 4, 19, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "E-3", Manufacturer = "Boeing", Name = "AWACS", Nicknames = null, Notes = null, Number = 3, Version = null, ServiceDate = new DateTime(1976, 2, 20, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-1E", Manufacturer = "North American", Name = "Fury (See AF-1E, FJ-3, FJ-4 Fury)", Nicknames = null, Notes = null, Number = 1, Version = "E", ServiceDate = new DateTime(1953, 7, 3, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F2A", Manufacturer = "Brewster (A)", Name = "Buffalo", Nicknames = null, Notes = null, Number = 2, Version = "A", ServiceDate = new DateTime(1939, 4, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-2", Manufacturer = "McDonnell", Name = "Banshee", Nicknames = null, Notes = null, Number = 2, Version = null, ServiceDate = new DateTime(1949, 3, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-3", Manufacturer = "McDonnell", Name = "Demon", Nicknames = null, Notes = null, Number = 3, Version = null, ServiceDate = new DateTime(1956, 3, 7, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F4B", Manufacturer = "Boeing (B)", Name = "", Nicknames = null, Notes = null, Number = 4, Version = ".B", ServiceDate = new DateTime(1928, 6, 25, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F4D", Manufacturer = "Douglas (D)", Name = "Skyray", Nicknames = null, Notes = null, Number = 4, Version = ".D", ServiceDate = new DateTime(1956, 4, 16, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F4F", Manufacturer = "Grumman (F)", Name = "Wildcat (British Martlet)", Nicknames = null, Notes = null, Number = 4, Version = ".F", ServiceDate = new DateTime(1940, 2, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F4U", Manufacturer = "Vought (U)", Name = "Corsair", Nicknames = null, Notes = null, Number = 4, Version = ".U", ServiceDate = new DateTime(1942, 7, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-4", Manufacturer = "McDonnell Douglas", Name = "Phantom II", Nicknames = null, Notes = null, Number = 4, Version = "A", ServiceDate = new DateTime(1960, 2, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-4B", Manufacturer = "McDonnell Douglas", Name = "Phantom II - First USN Production Model", Nicknames = null, Notes = null, Number = 4, Version = "B", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-4C", Manufacturer = "McDonnell Douglas", Name = "Phantom II - First USAF Production Model", Nicknames = null, Notes = null, Number = 4, Version = "C", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-4D", Manufacturer = "McDonnell Douglas", Name = "Phantom II - Improved USAF \"C\" Version", Nicknames = null, Notes = null, Number = 4, Version = "D", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-4E", Manufacturer = "McDonnell Douglas", Name = "Phantom II - Improved USAF \"D\" Version", Nicknames = null, Notes = null, Number = 4, Version = "E", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-4G", Manufacturer = "McDonnell Douglas", Name = "Phantom II - Radar Suppression Version", Nicknames = null, Notes = null, Number = 4, Version = "G", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-4J", Manufacturer = "McDonnell Douglas", Name = "Phantom II - Improved USN \"B\" Version", Nicknames = null, Notes = null, Number = 4, Version = "J", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-4K", Manufacturer = "McDonnell Douglas", Name = "Phantom II - British Version FG.1", Nicknames = null, Notes = null, Number = 4, Version = "K", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-4N", Manufacturer = "McDonnell Douglas", Name = "Phantom II - Improved USN \"J\" Version", Nicknames = null, Notes = null, Number = 4, Version = "N", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-4S", Manufacturer = "McDonnell Douglas", Name = "Phantom II - Improved USN \"N\" Version", Nicknames = null, Notes = null, Number = 4, Version = "S", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-5", Manufacturer = "Northrop", Name = "Tiger II", Nicknames = null, Notes = null, Number = 5, Version = null, ServiceDate = new DateTime(1959, 4, 10, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-5", Manufacturer = "Martin", Name = "Marlin", Nicknames = null, Notes = null, Number = 5, Version = null, ServiceDate = new DateTime(1951, 12, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F6F", Manufacturer = "Grumman (F)", Name = "Hellcat", Nicknames = null, Notes = null, Number = 6, Version = ".F", ServiceDate = new DateTime(1942, 10, 4, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F4D", Manufacturer = "Douglas (D)", Name = "Skyray", Nicknames = null, Notes = null, Number = 4, Version = ".F", ServiceDate = new DateTime(1956, 4, 16, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F7F", Manufacturer = "Grumman (F)", Name = "Tigercat", Nicknames = null, Notes = null, Number = 7, Version = ".F", ServiceDate = new DateTime(1944, 10, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F7U", Manufacturer = "Vought (U)", Name = "Cutlass", Nicknames = null, Notes = null, Number = 7, Version = ".U", ServiceDate = new DateTime(1954, 6, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F8F", Manufacturer = "Grumman (F)", Name = "Bearcat", Nicknames = null, Notes = null, Number = 8, Version = ".F", ServiceDate = new DateTime(1944, 11, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-8", Manufacturer = "Vought", Name = "Crusader", Nicknames = null, Notes = null, Number = 8, Version = null, ServiceDate = new DateTime(1957, 3, 25, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F9F-1", Manufacturer = "Grumman (F)", Name = "Panther", Nicknames = null, Notes = null, Number = 9, Version = ".F-1", ServiceDate = new DateTime(1948, 11, 24, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F9F-6", Manufacturer = "Grumman (F)", Name = "Cougar", Nicknames = null, Notes = null, Number = 9, Version = ".F-6", ServiceDate = new DateTime(1951, 12, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-10", Manufacturer = "North American", Name = "Mitchell (Reconnaissance) (See B-25)", Nicknames = null, Notes = null, Number = 10, Version = null, ServiceDate = new DateTime(1940, 8, 19, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-11", Manufacturer = "Grumman", Name = "Tiger", Nicknames = null, Notes = null, Number = 11, Version = null, ServiceDate = new DateTime(1957, 3, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-12", Manufacturer = "Boeing", Name = "", Nicknames = null, Notes = null, Number = 12, Version = null, ServiceDate = new DateTime(1928, 6, 25, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-14", Manufacturer = "Grumman", Name = "Tomcat", Nicknames = null, Notes = null, Number = 14, Version = null, ServiceDate = new DateTime(1972, 10, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-15A", Manufacturer = "McDonnell Douglas", Name = "Eagle", Nicknames = null, Notes = null, Number = 15, Version = "A", ServiceDate = new DateTime(1974, 3, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-15C", Manufacturer = "McDonnell Douglas", Name = "Eagle - Advanced Air Superiority Fighter", Nicknames = null, Notes = null, Number = 15, Version = "C", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-15D", Manufacturer = "McDonnell Douglas", Name = "Eagle - Two Seat Trainer", Nicknames = null, Notes = null, Number = 15, Version = "D", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-15E", Manufacturer = "McDonnell Douglas", Name = "Strike Eagle", Nicknames = null, Notes = null, Number = 15, Version = "E", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-15J", Manufacturer = "McDonnell Douglas", Name = "Eagle - Japanese Self Defense Force", Nicknames = null, Notes = null, Number = 15, Version = "J", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-16A", Manufacturer = "General Dynamics", Name = "Fighting Falcon", Nicknames = null, Notes = null, Number = 16, Version = "A", ServiceDate = new DateTime(1978, 6, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-16B", Manufacturer = "General Dynamics", Name = "Falcon - Two Seat Trainer", Nicknames = null, Notes = null, Number = 16, Version = "B", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-16C", Manufacturer = "General Dynamics", Name = "Falcon - w/LANTIRN Night Nav/Targeting", Nicknames = null, Notes = null, Number = 16, Version = "C", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-16D", Manufacturer = "General Dynamics", Name = "Falcon - Improved \"B\" Trainer", Nicknames = null, Notes = null, Number = 16, Version = "D", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-16N", Manufacturer = "General Dynamics", Name = "Falcon - Top Gun Aggressor Version", Nicknames = null, Notes = null, Number = 16, Version = "N", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-16XL", Manufacturer = "General Dynamics", Name = "Cranked Arrow Falcon", Nicknames = null, Notes = null, Number = 16, Version = "XL", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F/A-18A", Manufacturer = "Northrop/McDonnell Douglas", Name = "Hornet", Nicknames = null, Notes = null, Number = 18, Version = "A", ServiceDate = new DateTime(1980, 1, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "TF-18A", Manufacturer = "McDonnell Douglas", Name = "Hornet - U.S. Navy Two Seat Trainer", Nicknames = null, Notes = null, Number = 18, Version = "A", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F/A-18C", Manufacturer = "Northrop/McDonnell Douglas", Name = "Hornet - Improved \"A\" Version", Nicknames = null, Notes = null, Number = 18, Version = "C", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F/A-18D", Manufacturer = "Northrop/McDonnell Douglas", Name = "Hornet - Two Seat Night Attack Version", Nicknames = null, Notes = null, Number = 18, Version = "D", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "RF-18D", Manufacturer = "Northrop/McDonnell Douglas", Name = "Hornet - Two Seat Reconnaissance Version", Nicknames = null, Notes = null, Number = 18, Version = "D", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-26", Manufacturer = "Boeing", Name = null, Nicknames = null, Notes = null, Number = 26, Version = null, ServiceDate = new DateTime(1934, 1, 10, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-38", Manufacturer = "Lockheed", Name = "Lightning", Nicknames = null, Notes = null, Number = 38, Version = null, ServiceDate = new DateTime(1941, 6, 8, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-39", Manufacturer = "Bell", Name = "Airacobra", Nicknames = null, Notes = null, Number = 39, Version = null, ServiceDate = new DateTime(1939, 8, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-40", Manufacturer = "Curtiss", Name = "Hawk (Warhawk, Tomahawk, etc)", Nicknames = null, Notes = null, Number = 40, Version = null, ServiceDate = new DateTime(1940, 1, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-47", Manufacturer = "Republic", Name = "Thunderbolt", Nicknames = null, Notes = null, Number = 47, Version = null, ServiceDate = new DateTime(1942, 3, 18, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-51", Manufacturer = "North American", Name = "Mustang", Nicknames = null, Notes = null, Number = 51, Version = null, ServiceDate = new DateTime(1942, 12, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-59", Manufacturer = "Bell", Name = "Airacomet", Nicknames = null, Notes = null, Number = 59, Version = null, ServiceDate = new DateTime(1944, 8, 7, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-61", Manufacturer = "Northrop", Name = "Black Widow", Nicknames = null, Notes = null, Number = 61, Version = null, ServiceDate = new DateTime(1944, 5, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-70", Manufacturer = "Douglas", Name = "Havoc (Army Night Fighter) (See A-20)", Nicknames = null, Notes = null, Number = 70, Version = null, ServiceDate = new DateTime(1940, 1, 2, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-80", Manufacturer = "Lockheed", Name = "Shooting Star (See F-80, F-94 Starfire)", Nicknames = null, Notes = null, Number = 80, Version = null, ServiceDate = new DateTime(1944, 10, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-82", Manufacturer = "North American", Name = "Twin Mustang (See P-82)", Nicknames = null, Notes = null, Number = 82, Version = null, ServiceDate = new DateTime(1945, 4, 15, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-82", Manufacturer = "North American", Name = "Twin Mustang (See F-82)", Nicknames = null, Notes = null, Number = 82, Version = null, ServiceDate = new DateTime(1945, 4, 15, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-84F", Manufacturer = "Republic", Name = "Thunderstreak", Nicknames = null, Notes = null, Number = 84, Version = "F", ServiceDate = new DateTime(1947, 5, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "RF-84F", Manufacturer = "Republic", Name = "Thunderflash - Reconnaissance Version", Nicknames = null, Notes = null, Number = 84, Version = "F", ServiceDate = new DateTime(1947, 5, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-84", Manufacturer = "Republic", Name = "Thunderjet", Nicknames = null, Notes = null, Number = 84, Version = null, ServiceDate = new DateTime(1947, 5, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-86", Manufacturer = "North American", Name = "Sabre", Nicknames = null, Notes = null, Number = 86, Version = null, ServiceDate = new DateTime(1948, 12, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-89", Manufacturer = "Northrop", Name = "Scorpion", Nicknames = null, Notes = null, Number = 89, Version = null, ServiceDate = new DateTime(1948, 8, 16, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-94", Manufacturer = "Lockheed", Name = "Starfire (See P-80, F-80 Shooting Star)", Nicknames = null, Notes = null, Number = 94, Version = null, ServiceDate = new DateTime(1944, 10, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-100", Manufacturer = "North American", Name = "Super Sabre", Nicknames = null, Notes = null, Number = 100, Version = null, ServiceDate = new DateTime(1953, 10, 29, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-101", Manufacturer = "McDonnell", Name = "Voodoo", Nicknames = null, Notes = null, Number = 101, Version = null, ServiceDate = new DateTime(1957, 5, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "RF-101", Manufacturer = "McDonnell", Name = "Voodoo  - Reconnaissance Version", Nicknames = null, Notes = null, Number = 101, Version = null, ServiceDate = new DateTime(1957, 5, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-102", Manufacturer = "Convair", Name = "Delta Dagger", Nicknames = null, Notes = null, Number = 102, Version = null, ServiceDate = new DateTime(1955, 11, 8, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-104", Manufacturer = "Lockheed", Name = "Starfighter", Nicknames = null, Notes = null, Number = 104, Version = null, ServiceDate = new DateTime(1956, 2, 17, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-105", Manufacturer = "Republic", Name = "Thunderchief", Nicknames = null, Notes = null, Number = 105, Version = null, ServiceDate = new DateTime(1955, 10, 22, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-106", Manufacturer = "Convair", Name = "Delta Dart", Nicknames = null, Notes = null, Number = 106, Version = null, ServiceDate = new DateTime(1959, 7, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-111A", Manufacturer = "General Dynamics", Name = "Aardvark", Nicknames = null, Notes = null, Number = 111, Version = "A", ServiceDate = new DateTime(1967, 6, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-111B", Manufacturer = "General Dynamics", Name = "U.S. Navy TFX Prototype (Cancelled)", Nicknames = null, Notes = null, Number = 111, Version = "B", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-111C", Manufacturer = "General Dynamics", Name = "Aardvark - \"A\" Version w/longer wing", Nicknames = null, Notes = null, Number = 111, Version = "C", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-111D", Manufacturer = "General Dynamics", Name = "Aardvark - Improved Intakes", Nicknames = null, Notes = null, Number = 111, Version = "D", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-111E", Manufacturer = "General Dynamics", Name = "Aardvark - \"Triple Plow II\" Intakes", Nicknames = null, Notes = null, Number = 111, Version = "E", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "F-111F", Manufacturer = "General Dynamics", Name = "Aardvark - Improved Intakes", Nicknames = null, Notes = null, Number = 111, Version = "F", ServiceDate = new DateTime(1900, 01, 01, 00, 00, 00), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "FB-111A", Manufacturer = "General Dynamics", Name = "Aardvark - Fighter Bomber Version", Nicknames = null, Notes = null, Number = 111, Version = "FB-A", ServiceDate = new DateTime(1967, 6, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "FJ-3", Manufacturer = "North American", Name = "Fury (See F-1E, AF-1E, FJ-4 Fury)", Nicknames = null, Notes = null, Number = null, Version = "J-3", ServiceDate = new DateTime(1953, 7, 3, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "FJ-4", Manufacturer = "North American", Name = "Fury (See AF-1E, F-1E, FJ-3 Fury)", Nicknames = null, Notes = null, Number = null, Version = "J-4", ServiceDate = new DateTime(1954, 10, 28, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "OV-1", Manufacturer = "Grumman", Name = "Mohawk", Nicknames = null, Notes = null, Number = 1, Version = null, ServiceDate = new DateTime(1961, 2, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "OV-10", Manufacturer = "Rockwell", Name = "Bronco", Nicknames = null, Notes = null, Number = 10, Version = null, ServiceDate = new DateTime(1967, 8, 6, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "PB4Y-2", Manufacturer = "Consolidated", Name = "Privateer", Nicknames = null, Notes = null, Number = 4, Version = "Y-2", ServiceDate = new DateTime(1944, 7, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "PBM", Manufacturer = "Martin", Name = "Mariner", Nicknames = null, Notes = null, Number = null, Version = "M", ServiceDate = new DateTime(1940, 9, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "PBY-1", Manufacturer = "Consolidated", Name = "Catalina", Nicknames = null, Notes = null, Number = null, Version = "Y-1", ServiceDate = new DateTime(1936, 10, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "PBY-5", Manufacturer = "Consolidated", Name = "Catalina", Nicknames = null, Notes = null, Number = null, Version = "Y-5", ServiceDate = new DateTime(1936, 10, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "U-2", Manufacturer = "Lockheed", Name = null, Nicknames = null, Notes = null, Number = 2, Version = null, ServiceDate = new DateTime(1956, 4, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "SR-71", Manufacturer = "Lockheed", Name = "Blackbird (USAF)", Nicknames = null, Notes = null, Number = 71, Version = null, ServiceDate = new DateTime(1964, 12, 22, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-2", Manufacturer = "Lockheed", Name = "Neptune", Nicknames = null, Notes = null, Number = 2, Version = null, ServiceDate = new DateTime(1947, 3, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "S-2", Manufacturer = "Grumman", Name = "Tracker (See E-1 Tracer, C-1A Trader)", Nicknames = null, Notes = null, Number = 2, Version = null, ServiceDate = new DateTime(1954, 2, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "P-3", Manufacturer = "Lockheed", Name = "Orion", Nicknames = null, Notes = null, Number = 3, Version = null, ServiceDate = new DateTime(1961, 4, 15, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "S-3", Manufacturer = "Lockheed", Name = "Viking", Nicknames = null, Notes = null, Number = 3, Version = null, ServiceDate = new DateTime(1973, 10, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "KC-135", Manufacturer = "Boeing", Name = "Stratotanker", Nicknames = null, Notes = null, Number = 135, Version = null, ServiceDate = new DateTime(1950, 6, 25, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "TBD-1", Manufacturer = "Douglas (D)", Name = "Devastator", Nicknames = null, Notes = null, Number = null, Version = "D-1", ServiceDate = new DateTime(1937, 6, 25, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "TBF", Manufacturer = "Grumman (F)", Name = "Avenger", Nicknames = null, Notes = null, Number = null, Version = "F", ServiceDate = new DateTime(1942, 1, 30, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "TBM", Manufacturer = "Eastern Motors/GM (M)", Name = "Avenger", Nicknames = null, Notes = null, Number = null, Version = "M", ServiceDate = new DateTime(1942, 1, 30, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<AircraftDesignation>().HasData(new AircraftDesignation { ID = Guid.NewGuid(), Designation = "AD2", Manufacturer = "Douglas", Name = "Skyshark", Nicknames = null, Notes = null, Number = null, Version = null, ServiceDate = new DateTime(1950, 1, 1, 0, 0, 0), DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
        }
        private void SeedBlueAngelsHistory(ModelBuilder modelBuilder)
        {
            //SELECT 'modelBuilder.Entity<BlueAngelsHistory>().HasData(new BlueAngelsHistory { ID = Guid.NewGuid(), ' +
            //    'ServiceDates = "' +[Dates] + '", ' +
            //    'AircraftType = "' +[Aircraft Type] + '", ' +
            //    'DecalSets = ' + IsNull('"' +[Decal Sets] + '"', 'null') + ', ' +
            //    'Kits = ' + IsNull('"' +[Kits] + '"', 'null') + ', ' +
            //    'Notes = ' + IsNull('"' +[Notes] + '"', 'null') + ', ' +
            //    'DateCreated = new DateTime(' + Convert(varchar(4), Year([DateCreated]))+',' + Convert(varchar(2), Month([DateCreated]))+',' + Convert(varchar(2), Day([DateCreated]))+',' + Convert(varchar(2), DatePart(hh,[DateCreated])) + ',' + Convert(varchar(2), DatePart(mi,[DateCreated])) + ',' + Convert(varchar(2), DatePart(ss,[DateCreated])) + '), ' +
            //          'DateModified = new DateTime(' + Convert(varchar(4), Year([DateModified]))+',' + Convert(varchar(2), Month([DateModified]))+',' + Convert(varchar(2), Day([DateModified]))+',' + Convert(varchar(2), DatePart(hh,[DateModified])) + ',' + Convert(varchar(2), DatePart(mi,[DateModified])) + ',' + Convert(varchar(2), DatePart(ss,[DateModified])) + ') });'
            //FROM [dbo].[Blue Angels History];
            modelBuilder.Entity<BlueAngelsHistory>().HasData(new BlueAngelsHistory { ID = Guid.NewGuid(), ServiceDates = "1946", AircraftType = "F6F-5 Grumman Hellcat", DecalSets = "72-217", Kits = null, Notes = null, DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<BlueAngelsHistory>().HasData(new BlueAngelsHistory { ID = Guid.NewGuid(), ServiceDates = "1946-49", AircraftType = "F8F-1 Grumman Bearcat", DecalSets = "72-642", Kits = "Monogram (Germany) MG6789", Notes = null, DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<BlueAngelsHistory>().HasData(new BlueAngelsHistory { ID = Guid.NewGuid(), ServiceDates = "1949-50", AircraftType = "F9F-2 Grumman Panther", DecalSets = "N/A", Kits = "Hasegawa HA-D11", Notes = null, DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<BlueAngelsHistory>().HasData(new BlueAngelsHistory { ID = Guid.NewGuid(), ServiceDates = "1952", AircraftType = "F7U-1 Vought Cutlass (Solo Only)", DecalSets = "N/A", Kits = "Testers", Notes = null, DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<BlueAngelsHistory>().HasData(new BlueAngelsHistory { ID = Guid.NewGuid(), ServiceDates = "1952-54", AircraftType = "F9F-5 Grumman Panther", DecalSets = "N/A", Kits = "matchbox PK-124", Notes = null, DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<BlueAngelsHistory>().HasData(new BlueAngelsHistory { ID = Guid.NewGuid(), ServiceDates = "1955-57", AircraftType = "F9F-8 Grumman Cougar", DecalSets = "N/A", Kits = "Hasegawa HA-D12", Notes = null, DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<BlueAngelsHistory>().HasData(new BlueAngelsHistory { ID = Guid.NewGuid(), ServiceDates = "1957-61", AircraftType = "F11F-1 Grumman Tiger", DecalSets = "N/A", Kits = "Hasegawa HA-D16", Notes = null, DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<BlueAngelsHistory>().HasData(new BlueAngelsHistory { ID = Guid.NewGuid(), ServiceDates = "1969-73", AircraftType = "F-4J McDonnell Douglas Phantom II", DecalSets = "N/A", Kits = "Hasegawa HA-SP51", Notes = null, DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<BlueAngelsHistory>().HasData(new BlueAngelsHistory { ID = Guid.NewGuid(), ServiceDates = "1974-86", AircraftType = "A-4F McDonnell Douglas Skyhawk", DecalSets = "72-138", Kits = "Fujimi FU-G19", Notes = null, DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
            modelBuilder.Entity<BlueAngelsHistory>().HasData(new BlueAngelsHistory { ID = Guid.NewGuid(), ServiceDates = "1987-", AircraftType = "F/A-18A Northrop Hornet", DecalSets = "72-560", Kits = "Hasegawa HA-812", Notes = null, DateCreated = new DateTime(1900, 1, 1, 0, 0, 0), DateModified = new DateTime(1900, 1, 1, 0, 0, 0) });
        }
        private void SeedLocations(ModelBuilder modelBuilder)
        {
            //Select Distinct 
            // 'modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), ' +
            //    'Name = ' + IsNull('@"' +[tcLocations].[Location] + '"', '""') + ', ' +
            //    'Description = @"", ' +
            //    'PhysicalLocation = @"", ' +
            //    'OName = ' + IsNull('@"' +[tcLocations].[Location] + '"', '""') + ' });'
            //From [GGGSCP1].[TreasureChest].[dbo].[Locations]
            //        [tcLocations]
            //Order By 1;
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = "", Description = @"", PhysicalLocation = @"", OName = "" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"?? Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"?? Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"@ Large", Description = @"", PhysicalLocation = @"", OName = @"@ Large" });
            //modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Foxtrot\Public\Shared Videos\Music Videos\Styx", Description = @"", PhysicalLocation = @"", OName = @"\\Foxtrot\Public\Shared Videos\Music Videos\Styx" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Action", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Action" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Adventure", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Adventure" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Cartoon-CG", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Cartoon-CG" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Christmas", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Christmas" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Comedy", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Comedy" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Documentary", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Documentary" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Drama", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Drama" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Fantasy", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Fantasy" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Horror", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Horror" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Musical", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Musical" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Mystery", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Mystery" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Science Fiction", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Science Fiction" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Sports", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Sports" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\War", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\War" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Charlie\Public\Shared Movies\Western", Description = @"", PhysicalLocation = @"", OName = @"\\Charlie\Public\Shared Movies\Western" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Delta\Public\Shared TV\Animation", Description = @"", PhysicalLocation = @"", OName = @"\\Delta\Public\Shared TV\Animation" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Delta\Public\Shared TV\Comedy", Description = @"", PhysicalLocation = @"", OName = @"\\Delta\Public\Shared TV\Comedy" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Delta\Public\Shared TV\Drama", Description = @"", PhysicalLocation = @"", OName = @"\\Delta\Public\Shared TV\Drama" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Delta\Public\Shared TV\SciFi", Description = @"", PhysicalLocation = @"", OName = @"\\Delta\Public\Shared TV\SciFi" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Delta\Public\Shared TV\War", Description = @"", PhysicalLocation = @"", OName = @"\\Delta\Public\Shared TV\War" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Delta\Public\Shared TV\Western", Description = @"", PhysicalLocation = @"", OName = @"\\Delta\Public\Shared TV\Western" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Echo\Public\Shared TV\Animation", Description = @"", PhysicalLocation = @"", OName = @"\\Echo\Public\Shared TV\Animation" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Echo\Public\Shared TV\Comedy", Description = @"", PhysicalLocation = @"", OName = @"\\Echo\Public\Shared TV\Comedy" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Echo\Public\Shared TV\Documentary", Description = @"", PhysicalLocation = @"", OName = @"\\Echo\Public\Shared TV\Documentary" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Echo\Public\Shared TV\Documentary\NFL Films", Description = @"", PhysicalLocation = @"", OName = @"\\Echo\Public\Shared TV\Documentary\NFL Films" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Echo\Public\Shared TV\Drama", Description = @"", PhysicalLocation = @"", OName = @"\\Echo\Public\Shared TV\Drama" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Echo\Public\Shared TV\SciFi", Description = @"", PhysicalLocation = @"", OName = @"\\Echo\Public\Shared TV\SciFi" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Echo\Public\Shared TV\War", Description = @"", PhysicalLocation = @"", OName = @"\\Echo\Public\Shared TV\War" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Foxtrot\Public\Shared TV\Horror", Description = @"", PhysicalLocation = @"", OName = @"\\Foxtrot\Public\Shared TV\Horror" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Foxtrot\Public\Shared TV\SciFi", Description = @"", PhysicalLocation = @"", OName = @"\\Foxtrot\Public\Shared TV\SciFi" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Foxtrot\Public\Shared Videos\Exercise", Description = @"", PhysicalLocation = @"", OName = @"\\Foxtrot\Public\Shared Videos\Exercise" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Foxtrot\Public\Shared Videos\Music Videos", Description = @"", PhysicalLocation = @"", OName = @"\\Foxtrot\Public\Shared Videos\Music Videos" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"\\Foxtrot\Public\Shared\Videos\Music Videos", Description = @"", PhysicalLocation = @"", OName = @"\\Foxtrot\Public\Shared\Videos\Music Videos" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Apple Software Box", Description = @"", PhysicalLocation = @"", OName = @"Apple Software Box" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Applied", Description = @"", PhysicalLocation = @"", OName = @"Applied" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Art Books Box #7", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Art Books Box #7 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Attic", Description = @"", PhysicalLocation = @"", OName = @"Attic" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Aurora USS Enterprise Box", Description = @"", PhysicalLocation = @"Attic", OName = @"Aurora USS Enterprise Box [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Axis&Allies War at Sea - Allies Case", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Axis&Allies War at Sea - Allies Case" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Axis&Allies War at Sea - Axis Case", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Axis&Allies War at Sea - Axis Case" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Axis&Allies War at Sea Condition Zebra Case", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Axis&Allies War at Sea Condition Zebra Case" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Axis&Allies War at Sea Flank Speed Case", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Axis&Allies War at Sea Flank Speed Case" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Axis&Allies War at Sea Fleet Command Case", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Axis&Allies War at Sea Fleet Command Case" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Axis&Allies War at Sea Surface Action Case", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Axis&Allies War at Sea Surface Action Case" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Axis&Allies War at Sea Task Force - Allies Case", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Axis&Allies War at Sea Task Force - Allies Case" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Axis&Allies War at Sea Task Force - Axis Case", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Axis&Allies War at Sea Task Force - Axis Case" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Baseball Cards Box #1", Description = @"ESSS", PhysicalLocation = @"Closet", OName = @"Baseball Cards Box #1 (ESSS) [Closet]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Basement Toolbox", Description = @"", PhysicalLocation = @"", OName = @"Basement Toolbox" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Basement Workbench", Description = @"", PhysicalLocation = @"", OName = @"Basement Workbench" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Basement", Description = @"", PhysicalLocation = @"", OName = @"Basement" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Battlestar Galactica Raptor Armament Set", Description = @"", PhysicalLocation = @"", OName = @"Battlestar Galactica Raptor Armament Set" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase #1", Description = @"", PhysicalLocation = @"Carol's Room - East Wall (Atop)", OName = @"Bookcase #1 (Atop) [Carol's Room - East Wall]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase #1", Description = @"", PhysicalLocation = @"Carol's Room - East Wall (Second Shelf Shelf)", OName = @"Bookcase #1 (Second Shelf Shelf) [Carol's Room - East Wall]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase #1", Description = @"", PhysicalLocation = @"Carol's Room - East Wall (Third Shelf Shelf)", OName = @"Bookcase #1 (Third Shelf Shelf) [Carol's Room - East Wall]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase #1", Description = @"", PhysicalLocation = @"Carol's Room - East Wall (Top Shelf)", OName = @"Bookcase #1 (Top Shelf) [Carol's Room - East Wall]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase A", Description = @"", PhysicalLocation = @"Ken's Room - West Wall By Door (Bottom Shelf)", OName = @"Bookcase A (Bottom Shelf) [Ken's Room - West Wall By Door]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase A", Description = @"", PhysicalLocation = @"Ken's Room - West Wall By Door (Second Shelf)", OName = @"Bookcase A (Second Shelf) [Ken's Room - West Wall By Door]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase A", Description = @"", PhysicalLocation = @"Ken's Room - West Wall By Door (Third Shelf)", OName = @"Bookcase A (Third Shelf) [Ken's Room - West Wall By Door]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase A", Description = @"", PhysicalLocation = @"Ken's Room - West Wall By Door (Top Shelf)", OName = @"Bookcase A (Top Shelf) [Ken's Room - West Wall By Door]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase B", Description = @"", PhysicalLocation = @"Ken's Room - West Wall Back (Bottom Shelf)", OName = @"Bookcase B (Bottom Shelf) [Ken's Room - West Wall Back]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase B", Description = @"", PhysicalLocation = @"Ken's Room - West Wall Back (Second Shelf)", OName = @"Bookcase B (Second Shelf) [Ken's Room - West Wall Back]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase B", Description = @"", PhysicalLocation = @"Ken's Room - West Wall Back (Third Shelf)", OName = @"Bookcase B (Third Shelf) [Ken's Room - West Wall Back]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase B", Description = @"", PhysicalLocation = @"Ken's Room - West Wall Back (Top Shelf)", OName = @"Bookcase B (Top Shelf) [Ken's Room - West Wall Back]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase C", Description = @"", PhysicalLocation = @"Ken's Room - West Wall By Closet (Bottom Shelf)", OName = @"Bookcase C (Bottom Shelf) [Ken's Room - West Wall By Closet]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase C", Description = @"", PhysicalLocation = @"Ken's Room - West Wall By Closet (Second Shelf)", OName = @"Bookcase C (Second Shelf) [Ken's Room - West Wall By Closet]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase C", Description = @"", PhysicalLocation = @"Ken's Room - West Wall By Closet (Third Shelf)", OName = @"Bookcase C (Third Shelf) [Ken's Room - West Wall By Closet]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase C", Description = @"", PhysicalLocation = @"Ken's Room - West Wall By Closet (Top Shelf)", OName = @"Bookcase C (Top Shelf) [Ken's Room - West Wall By Closet]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase F", Description = @"", PhysicalLocation = @"Ken's Room - Front Wall (Second Shelf)", OName = @"Bookcase F (Second Shelf) [Ken's Room - Front Wall]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookcase F", Description = @"", PhysicalLocation = @"Ken's Room - Front Wall (Top Shelf)", OName = @"Bookcase F (Top Shelf) [Ken's Room - Front Wall]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookshelf", Description = @"", PhysicalLocation = @"Ken's Room - Back Wall (Bottom Shelf)", OName = @"Bookshelf (Bottom Shelf) [Ken's Room - Back Wall]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookshelf", Description = @"", PhysicalLocation = @"Ken's Room - East Wall (Bottom Shelf)", OName = @"Bookshelf (Bottom Shelf) [Ken's Room - East Wall]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookshelf", Description = @"", PhysicalLocation = @"Ken's Room - Back Wall (Top Shelf)", OName = @"Bookshelf (Top Shelf) [Ken's Room - Back Wall]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookshelf", Description = @"", PhysicalLocation = @"Ken's Room - East Wall (Top Shelf)", OName = @"Bookshelf (Top Shelf) [Ken's Room - East Wall]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Bookshelf", Description = @"", PhysicalLocation = @"", OName = @"Bookshelf" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Borrowed", Description = @"", PhysicalLocation = @"", OName = @"Borrowed" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #? Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #? Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #144-1", Description = @"UHS-Old", PhysicalLocation = @"Attic", OName = @"Box #144-1 (UHS-Old) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #144-1 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #144-1 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #144-2", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Box #144-2 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #144-2 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #144-2 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #3 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #3 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #350-1", Description = @"UHL", PhysicalLocation = @"Attic", OName = @"Box #350-1 (UHL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #350-1 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #350-1 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #350-2", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Box #350-2 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #350-2 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #350-2 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #700-1", Description = @"UHM-Old", PhysicalLocation = @"Attic", OName = @"Box #700-1 (UHM-Old) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #700-1 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #700-1 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #700-2", Description = @"UHL", PhysicalLocation = @"Attic", OName = @"Box #700-2 (UHL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #700-2 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #700-2 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #700-2 Ziploc bag\par", Description = @"", PhysicalLocation = @"", OName = @"Box #700-2 Ziploc bag\par" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #700-3", Description = @"UHXL", PhysicalLocation = @"Attic", OName = @"Box #700-3 (UHXL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #700-3 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #700-3 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #700-4", Description = @"Unmarked 15x12x8", PhysicalLocation = @"Attic", OName = @"Box #700-4 (Unmarked 15x12x8) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #700-4 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #700-4 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-01", Description = @"UHM", PhysicalLocation = @"Attic", OName = @"Box #72-01 (UHM) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-02", Description = @"UHM-Old", PhysicalLocation = @"Attic", OName = @"Box #72-02 (UHM-Old) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-03", Description = @"UHM", PhysicalLocation = @"Attic", OName = @"Box #72-03 (UHM) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-04", Description = @"UHM", PhysicalLocation = @"Attic", OName = @"Box #72-04 (UHM) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-05", Description = @"UHM", PhysicalLocation = @"Attic", OName = @"Box #72-05 (UHM) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-06", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Box #72-06 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-07", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Box #72-07 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-08", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Box #72-08 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-09", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Box #72-09 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-1 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #72-1 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-10", Description = @"UHM", PhysicalLocation = @"Attic", OName = @"Box #72-10 (UHM) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-10 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #72-10 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-11", Description = @"UHL-Old", PhysicalLocation = @"Attic", OName = @"Box #72-11 (UHL-Old) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-11", Description = @"UHXL-Old", PhysicalLocation = @"Attic", OName = @"Box #72-11 (UHXL-Old) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-11 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #72-11 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-12", Description = @"UHXL", PhysicalLocation = @"Attic", OName = @"Box #72-12 (UHXL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-12 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #72-12 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-13", Description = @"UHM-Old", PhysicalLocation = @"Attic", OName = @"Box #72-13 (UHM-Old) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-13 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #72-13 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-14", Description = @"UHM", PhysicalLocation = @"Attic", OName = @"Box #72-14 (UHM) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-14 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #72-14 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-2 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #72-2 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-4 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #72-4 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-5 Ziploc bag (2nd set, with wheels, left in box)", Description = @"", PhysicalLocation = @"", OName = @"Box #72-5 Ziploc bag (2nd set, with wheels, left in box)" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-5 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #72-5 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-6 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #72-6 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-7 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #72-7 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-8 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #72-8 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #72-9 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Box #72-9 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #TB-1", Description = @"", PhysicalLocation = @"", OName = @"Box #TB-1" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #TB-2", Description = @"", PhysicalLocation = @"", OName = @"Box #TB-2" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Box #TB-3", Description = @"", PhysicalLocation = @"", OName = @"Box #TB-3" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"C200809.1", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"C200809.1 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"C200809.2", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"C200809.2 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"C200809.3", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"C200809.3 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"C200810.1", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"C200810.1 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"C200810.2", Description = @"UHS", PhysicalLocation = @"Ken's Room", OName = @"C200810.2 (UHS) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Car Box #1 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"Car Box #1 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Car Collectables Box #01", Description = @"UHM", PhysicalLocation = @"Attic", OName = @"Car Collectables Box #01 (UHM) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Car Models Box #1", Description = @"UHXL", PhysicalLocation = @"Attic", OName = @"Car Models Box #1 (UHXL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Carol's Books HB Fiction", Description = @"", PhysicalLocation = @"", OName = @"Carol's Books HB Fiction" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Carol's Office", Description = @"", PhysicalLocation = @"", OName = @"Carol's Office" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Carol's Room", Description = @"", PhysicalLocation = @"", OName = @"Carol's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Box #1", Description = @"UHS", PhysicalLocation = @"Ken's Room", OName = @"CD Box #1 (UHS) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Box #2", Description = @"UHS", PhysicalLocation = @"Ken's Room", OName = @"CD Box #2 (UHS) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Box #3", Description = @"ESS", PhysicalLocation = @"Ken's Room", OName = @"CD Box #3 (ESSS) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Box #4", Description = @"ESS", PhysicalLocation = @"Ken's Room", OName = @"CD Box #4 (ESSS) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Box #5", Description = @"UHS", PhysicalLocation = @"Ken's Room", OName = @"CD Box #5 (UHS) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Box #6", Description = @"33250", PhysicalLocation = @"Basement", OName = @"CD Box #6 (33250) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Box #7", Description = @"33250", PhysicalLocation = @"Basement", OName = @"CD Box #7 (33250) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Box #8", Description = @"33250", PhysicalLocation = @"Basement", OName = @"CD Box #8 (33250) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Rack - Arcade", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"CD Rack - Arcade [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Rack - Flight Sims", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"CD Rack - Flight Sims [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Rack - FPS", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"CD Rack - FPS [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Rack - RPG/Strategy", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"CD Rack - RPG/Strategy [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Rack - Star Trek/Space Sim", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"CD Rack - Star Trek/Space Sim [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Rack - Star Wars", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"CD Rack - Star Wars [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Rack - Strategy (C&C)", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"CD Rack - Strategy (C&C) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Rack - Strategy (Civilization)", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"CD Rack - Strategy (Civilization) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Rack", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"CD Rack [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CD Rack", Description = @"", PhysicalLocation = @"", OName = @"CD Rack" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Christmas CDs", Description = @"", PhysicalLocation = @"", OName = @"Christmas CDs" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Christmas DVDs", Description = @"", PhysicalLocation = @"", OName = @"Christmas DVDs" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Closet", Description = @"", PhysicalLocation = @"", OName = @"Closet" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Combat Aircraft 2012-2014", Description = @"", PhysicalLocation = @"Top of Steps", OName = @"Combat Aircraft 2012-2014 [Top of Steps]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Combat Aircraft 2015-2018", Description = @"", PhysicalLocation = @"Top of Steps", OName = @"Combat Aircraft 2015-2018 [Top of Steps]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Computer Books Box #01", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Computer Books Box #01 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Computer Books Box #02", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Computer Books Box #02 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Computer Books Box #03", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Computer Books Box #03 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CS20101219.1", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"CS20101219.1 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"CS20101219.2", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"CS20101219.2 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Decals left in bag", Description = @"", PhysicalLocation = @"", OName = @"Decals left in bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Decals left with detail set included in kit", Description = @"", PhysicalLocation = @"", OName = @"Decals left with detail set included in kit" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Decals salvaged", Description = @"", PhysicalLocation = @"", OName = @"Decals salvaged" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Desk", Description = @"", PhysicalLocation = @"", OName = @"Desk" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Destroyed", Description = @"", PhysicalLocation = @"", OName = @"Destroyed" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Detail Sets Box", Description = @"18x13x11", PhysicalLocation = @"Ken's Room", OName = @"Detail Sets Box (18x13x11) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Die Cast Collectables Box #1", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Die Cast Collectables Box #1 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Digital Download", Description = @"", PhysicalLocation = @"", OName = @"Digital Download" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Dining Room", Description = @"", PhysicalLocation = @"", OName = @"Dining Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Donated", Description = @"", PhysicalLocation = @"", OName = @"Donated" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Doorway PB Stack", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Doorway PB Stack [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #02 - Waiting for WMV", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"DVD Box #02 (UHS) [Attic] - Waiting for WMV" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #02", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"DVD Box #02 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #03 - Waiting for WMV", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"DVD Box #03 (UHS) [Attic] - Waiting for WMV" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #03", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"DVD Box #03 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #05", Description = @"#03325", PhysicalLocation = @"Basement", OName = @"DVD Box #05 (#03325) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #06", Description = @"33250", PhysicalLocation = @"Basement", OName = @"DVD Box #06 (33250) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #07", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"DVD Box #07 [UHS Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #08", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"DVD Box #08 [UHS Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #09", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"DVD Box #09 [UHS Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #10", Description = @"33250", PhysicalLocation = @"Basement", OName = @"DVD Box #10 (33250) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #11", Description = @"33250", PhysicalLocation = @"Basement", OName = @"DVD Box #11 (33250) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #12", Description = @"33250", PhysicalLocation = @"Basement", OName = @"DVD Box #12 (33250) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #13", Description = @"33250", PhysicalLocation = @"Basement", OName = @"DVD Box #13 (33250) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #14", Description = @"33250", PhysicalLocation = @"Basement", OName = @"DVD Box #14 (33250) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #15", Description = @"33250", PhysicalLocation = @"Basement", OName = @"DVD Box #15 (33250) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #16", Description = @"33250", PhysicalLocation = @"Attic", OName = @"DVD Box #16 (33250) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #17", Description = @"33250", PhysicalLocation = @"Attic", OName = @"DVD Box #17 (33250) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #18", Description = @"33250", PhysicalLocation = @"Attic", OName = @"DVD Box #18 (33250) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #19", Description = @"33250", PhysicalLocation = @"Attic", OName = @"DVD Box #19 (33250) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #20 - Waiting for WMV", Description = @"33250", PhysicalLocation = @"Ken's Room", OName = @"DVD Box #20 (33250) [Ken's Room] - Waiting for WMV" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #20", Description = @"33250", PhysicalLocation = @"Ken's Room", OName = @"DVD Box #20 (33250) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #21", Description = @"33250", PhysicalLocation = @"Attic", OName = @"DVD Box #21 (33250) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #22", Description = @"33250", PhysicalLocation = @"Attic", OName = @"DVD Box #22 (33250) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #23", Description = @"33250", PhysicalLocation = @"Ken's Room", OName = @"DVD Box #23 (33250) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVD Box #24", Description = @"33250", PhysicalLocation = @"Ken's Room", OName = @"DVD Box #24 (33250) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVDs - General", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"DVDs - General [UHS Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVDs - General Box #1", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"DVDs - General Box #1 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVDs - General Box #2", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"DVDs - General Box #2 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"DVDs - General Box #2", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"DVDs - General Box #2 [UHS Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Entertainment Center Shelf", Description = @"", PhysicalLocation = @"", OName = @"Entertainment Center Shelf" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ether", Description = @"", PhysicalLocation = @"", OName = @"Ether" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Federation Box #1", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Federation Box #1 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Fiction Books Box #2", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Fiction Books Box #2 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Fiction Books Box #3", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Fiction Books Box #3 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Fiction Books Box #6", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Fiction Books Box #6 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Fiction Books Box #8", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Fiction Books Box #8 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"File Entry", Description = @"", PhysicalLocation = @"", OName = @"File Entry" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Football Cards Box #1", Description = @"ESSS", PhysicalLocation = @"Closet", OName = @"Football Cards Box #1 (ESSS) [Closet]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Forbidden Planet Box", Description = @"Unmarked 20x14x7", PhysicalLocation = @"Ken's Room", OName = @"Forbidden Planet Box (Unmarked 20x14x7) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"FreeTime Box #1", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"FreeTime Box #1 (Ken's Room)" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"FreeTime Box #2", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"FreeTime Box #2 (Ken's Room)" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"FreeTime Box #2", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"FreeTime Box #2 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"FreeTime Box #3", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"FreeTime Box #3 (Ken's Room)" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"FreeTime Box #3", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"FreeTime Box #3 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"FreeTime Box #4", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"FreeTime Box #4 (Ken's Room)" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"FreeTime Box #5", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"FreeTime Box #5 (Ken's Room)" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"FreeTime Box #5", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"FreeTime Box #5 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"HALO Box #1", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"HALO Box #1 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"History Books Box #10", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"History Books Box #10 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"History Books From Ken's Desk", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"History Books From Ken's Desk (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Cases #01", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Hot Cases #01 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Cases #02", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Hot Cases #02 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Cases #03", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Hot Cases #03 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Cases #04", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Hot Cases #04 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Cases #05", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Hot Cases #05 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Cases #06", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Hot Cases #06 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Cases #07", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Hot Cases #07 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Cases #08", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Hot Cases #08 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Cases #09", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Hot Cases #09 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels 48 Car Case #01", Description = @"", PhysicalLocation = @"Car Collectables Box #01", OName = @"Hot Wheels 48 Car Case #01 [Car Collectables Box #01]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels 48 Car Case #02", Description = @"", PhysicalLocation = @"Car Collectables Box #01", OName = @"Hot Wheels 48 Car Case #02 [Car Collectables Box #01]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #01", Description = @"", PhysicalLocation = @"", OName = @"Hot Wheels Box #01" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #02", Description = @"Amazon 12x9x6", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #02 (Amazon 12x9x6) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #03", Description = @"ESS", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #03 (ESSS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #04", Description = @"ESS", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #04 (ESSS) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #05", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #05 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #06", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #06 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #07", Description = @"Unmarked 14x12x6", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #07 (Unmarked 14x12x6) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #08", Description = @"B&N 13x11x6", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #08 (B&N 13x11x6) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #09", Description = @"Unmarked 12x9x6", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #09 (Unmarked 12x9x6) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #10", Description = @"Mattel L2593 Case", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #10 (Mattel L2593 Case) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #11", Description = @"Unmarked 16x12.5x6", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #11 (Unmarked 16x12.5x6) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #12", Description = @"Unmarked 13x11x5", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #12 (Unmarked 13x11x5) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #13", Description = @"Mattel L2593 Case", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #13 (Mattel L2593 Case) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #14", Description = @"Unmarked 14x10x6", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #14 (Unmarked 14x10x6) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #15", Description = @"Unmarked 10x8x6", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #15 (Unmarked 10x8x6) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #16", Description = @"Mattel BDT77 Case", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #16 (Mattel BDT77 Case) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #17", Description = @"Mattel X8893 Case", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #17 (Mattel X8893 Case) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #18", Description = @"Unmarked 14x12x6", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #18 (Unmarked 14x12x6) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #19", Description = @"Mattel X8308 Case", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #19 (Mattel X8308 Case) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #20", Description = @"Unmarked 18x10x4", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #20 (Unmarked 18x10x4) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2014A", Description = @"FantasyFlight", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #2014A (FantasyFlight) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2014B", Description = @"Amazon K3", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #2014B (Amazon K3) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2014C", Description = @"Unmarked 16x12.5x6", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #2014C (Unmarked 16x12.5x6) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2014D", Description = @"Unmarked 11x8x6", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #2014D (Unmarked 11x8x6) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2016A", Description = @"Amazon 1AE", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #2016A (Amazon 1AE) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2016B", Description = @"Amazon 1AE", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #2016B (Amazon 1AE) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2016C", Description = @"Amazon 1AE", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #2016C (Amazon 1AE) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2017A", Description = @"Unmarked 14x14x9", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #2017A (Unmarked 14x14x9) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2017B", Description = @"Unmarked 17x13x6", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #2017B (Unmarked 17x13x6) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2017C", Description = @"Unmarked 16x8x7", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #2017C (Unmarked 16x8x7) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2018A", Description = @"Mattel L2593 Case", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #2018A (Mattel L2593 Case) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2018B", Description = @"Amazon 1A5", PhysicalLocation = @"Basement", OName = @"Hot Wheels Box #2018B (Amazon 1A5) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2018C", Description = @"Unmarked 16x12x8", PhysicalLocation = @"Basement", OName = @"Hot Wheels Box #2018C (Unmarked 16x12x8) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #2018D", Description = @"Unmarked 16x8x6", PhysicalLocation = @"Basement", OName = @"Hot Wheels Box #2018D (Unmarked 16x8x6) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #21", Description = @"Unmarked 13x9x5.25", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #21 (Unmarked 13x9x5.25) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #22", Description = @"Mattel L2593 Case", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #22 (Mattel L2593 Case) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #23", Description = @"Unmarked 16x12x8", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #23 (Unmarked 16x12x8) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #24", Description = @"USPS Priority Mail Medium", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #24 (USPS Priority Mail Medium) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #25", Description = @"Unmarked 16x12x12", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #25 (Unmarked 16x12x12) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #26", Description = @"Amazon 1A7", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #26 (Amazon 1A7) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #27", Description = @"B&N.com 14x11x6", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #27 (B&N.com 14x11x6) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #28", Description = @"Unmarked Priority Mail 16x12x4", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #28 (Unmarked Priority Mail 16x12x4) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #29", Description = @"Unmarked 14x14x6.5", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #29 (Unmarked 14x14x6.5) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #30", Description = @"Unmarked 14.5x11x6.5", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #30 (Unmarked 14.5x11x6.5) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #31", Description = @"Unmarked 14x10.5x7", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #31 (Unmarked 14x10.5x7) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #32", Description = @"Unmarked Priority Mail 14x10x6", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #32 (Unmarked Priority Mail 14x10x6) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #33", Description = @"Amazon 1B4", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #33 (Amazon 1B4) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #34", Description = @"Mattel MD28", PhysicalLocation = @"Basement", OName = @"Hot Wheels Box #34 (Mattel MD28) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #Retro 13D", Description = @"Mattel BDT77 Case", PhysicalLocation = @"Attic", OName = @"Hot Wheels Box #Retro 13D (Mattel BDT77 Case) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #Retro13", Description = @"Squadron 18x12x6", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #Retro13 (Squadron 18x12x6) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #Retro13B", Description = @"Mattel X8893", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #Retro13B (Mattel X8893) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Box #Retro13C", Description = @"Mattel X8893", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Box #Retro13C (Mattel X8893) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Pop Culture - Peanuts Box", Description = @"DLB45", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Pop Culture - Peanuts Box (DLB45) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Pop Culture - Star Wars McQuarrie Box", Description = @"DLB45", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Pop Culture - Star Wars McQuarrie Box (DLB45) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Sizzlers Box #01", Description = @"", PhysicalLocation = @"Attic", OName = @"Hot Wheels Sizzlers Box #01 [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Star Wars Carships Box #1", Description = @"Unmarked 14x14x8.5", PhysicalLocation = @"Ken's Room", OName = @"Hot Wheels Star Wars Carships Box #1 (Unmarked 14x14x8.5) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Star Wars Carships Box #2", Description = @"Mattel FBB72 Case", PhysicalLocation = @"Attic", OName = @"Hot Wheels Star Wars Carships Box #2 (Mattel FBB72 Case) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Hot Wheels Star Wars C-Cars Box #1", Description = @"Unmarked 20x20x6.5", PhysicalLocation = @"Attic", OName = @"Hot Wheels Star Wars C-Cars Box #1 (Unmarked 20x20x6.5) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Husky Supplies Organizer #1", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Husky Supplies Organizer #1 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Husky Tools Organizer #1", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Husky Tools Organizer #1 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Included in kit", Description = @"", PhysicalLocation = @"", OName = @"Included in kit" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Inside E-2C Hawkeye Box (Revell 03945 Kit #2640)", Description = @"", PhysicalLocation = @"", OName = @"Inside E-2C Hawkeye Box (Revell 03945 Kit #2640)" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Inside Kit Box (Revell 03945 Kit #2640)", Description = @"", PhysicalLocation = @"", OName = @"Inside Kit Box (Revell 03945 Kit #2640)" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Inside Kit Box (Revell 04882 Kit #2619)", Description = @"", PhysicalLocation = @"", OName = @"Inside Kit Box (Revell 04882 Kit #2619)" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Inside Kit Box (Trumpeter 05711 Kit #2731)", Description = @"", PhysicalLocation = @"", OName = @"Inside Kit Box (Trumpeter 05711 Kit #2731)" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Inside Kit Box (Trumpeter 05712 Kit #2732)", Description = @"", PhysicalLocation = @"", OName = @"Inside Kit Box (Trumpeter 05712 Kit #2732)" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Inside Kit Box", Description = @"", PhysicalLocation = @"", OName = @"Inside Kit Box" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Installed", Description = @"", PhysicalLocation = @"", OName = @"Installed" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"JVC CH-200 Box Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"JVC CH-200 Box Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"JVC CH-X200 Box", Description = @"", PhysicalLocation = @"Attic", OName = @"JVC CH-X200 Box [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #01", Description = @"", PhysicalLocation = @"Basement", OName = @"Ken's Books Box #01 [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #02", Description = @"", PhysicalLocation = @"Basement", OName = @"Ken's Books Box #02 [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #03", Description = @"", PhysicalLocation = @"Basement", OName = @"Ken's Books Box #03 [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #04", Description = @"", PhysicalLocation = @"Basement", OName = @"Ken's Books Box #04 [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #05", Description = @"", PhysicalLocation = @"Basement", OName = @"Ken's Books Box #05 [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #06", Description = @"", PhysicalLocation = @"Basement", OName = @"Ken's Books Box #06 [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #07", Description = @"", PhysicalLocation = @"Basement", OName = @"Ken's Books Box #07 [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #08", Description = @"", PhysicalLocation = @"Basement", OName = @"Ken's Books Box #08 [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #09", Description = @"", PhysicalLocation = @"Basement", OName = @"Ken's Books Box #09 [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #10", Description = @"", PhysicalLocation = @"Basement", OName = @"Ken's Books Box #10 [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #11", Description = @"", PhysicalLocation = @"Basement", OName = @"Ken's Books Box #11 [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #12", Description = @"", PhysicalLocation = @"Basement", OName = @"Ken's Books Box #12 [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #13", Description = @"", PhysicalLocation = @"Basement", OName = @"Ken's Books Box #13 [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Books Box #14 - Modeling Resources", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Ken's Books Box #14 - Modeling Resources [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Desk", Description = @"", PhysicalLocation = @"", OName = @"Ken's Desk" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's DVDs Box #1", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Ken's DVDs Box #1 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's DVDs Box #2", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Ken's DVDs Box #2 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's DVDs Box #3", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Ken's DVDs Box #3 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's DVDs Box #4", Description = @"", PhysicalLocation = @"Attic", OName = @"Ken's DVDs Box #4 [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Hallmark Ornaments Box", Description = @"UHS", PhysicalLocation = @"Ken's Room", OName = @"Ken's Hallmark Ornaments Box (UHS) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ken's Room", Description = @"", PhysicalLocation = @"", OName = @"Ken's Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Key Publishing Specials Box", Description = @"", PhysicalLocation = @"Top of Steps", OName = @"Key Publishing Specials Box [Top of Steps]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Kindle", Description = @"", PhysicalLocation = @"", OName = @"Kindle" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Left in bag", Description = @"", PhysicalLocation = @"", OName = @"Left in bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Left in box", Description = @"", PhysicalLocation = @"", OName = @"Left in box" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Living Room", Description = @"", PhysicalLocation = @"", OName = @"Living Room" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Lost", Description = @"", PhysicalLocation = @"", OName = @"Lost" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"M&M's Chocolate M-PIRE Box", Description = @"USPS #13 9x7x4", PhysicalLocation = @"Ken's Room", OName = @"M&M's Chocolate M-PIRE Box (USPS #13 9x7x4) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"M&M's Chocolate M-PIRE Box", Description = @"USPS #13 9x7x4", PhysicalLocation = @"", OName = @"M&M's Chocolate M-PIRE Box [USPS #13 9x7x4]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Master Bedroom", Description = @"", PhysicalLocation = @"", OName = @"Master Bedroom" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"MH201110.1", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"MH201110.1 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"MH201110.2", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"MH201110.2 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"MH201110.3", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"MH201110.3 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"MH201110.4", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"MH201110.4 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"MH201110.5", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"MH201110.5 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"MH201110.6", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"MH201110.6 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Micro Machines - Titanium  Series Box #01", Description = @"ESS", PhysicalLocation = @"Attic", OName = @"Micro Machines - Titanium  Series Box #01 (ESSS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Micro Machines - Titanium  Series Box #02", Description = @"ESS", PhysicalLocation = @"Attic", OName = @"Micro Machines - Titanium  Series Box #02 (ESSS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Micro Machines - Titanium  Series Box #03", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Micro Machines - Titanium  Series Box #03 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Micro Machines - Titanium  Series Box #04", Description = @"ESS", PhysicalLocation = @"Attic", OName = @"Micro Machines - Titanium  Series Box #04 (ESSS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Micro Machines - Titanium  Series Box #05", Description = @"ESS", PhysicalLocation = @"Attic", OName = @"Micro Machines - Titanium  Series Box #05 (ESSS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Micro Machines - Titanium  Series Box #06", Description = @"ESS", PhysicalLocation = @"Attic", OName = @"Micro Machines - Titanium  Series Box #06 (ESSS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Micro Machines - Titanium  Series Box #06", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Micro Machines - Titanium  Series Box #06 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Micro Machines - Titanium  Series Box #07", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Micro Machines - Titanium  Series Box #07 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Micro Machines - Titanium  Series Box #08", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Micro Machines - Titanium  Series Box #08 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Micro Machines - Titanium  Series Box #09", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Micro Machines - Titanium  Series Box #09 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Micro Machines - Titanium  Series Box #10 (BSG) (SMO)", Description = @"", PhysicalLocation = @"Attic", OName = @"Micro Machines - Titanium  Series Box #10 (BSG) (SMO) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Misc Books Box #01", Description = @"", PhysicalLocation = @"", OName = @"Misc Books Box #01" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Misc Collectables Box #1", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Misc Collectables Box #1 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Models #1", Description = @"UHM", PhysicalLocation = @"Attic", OName = @"Models #1 (UHM) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Models #2", Description = @"UHM", PhysicalLocation = @"Attic", OName = @"Models #2 (UHM) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Music DVDs Box #1", Description = @"33250", PhysicalLocation = @"Ken's Room", OName = @"Music DVDs Box #1 (33250) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Nappa Valley Crate #1", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Nappa Valley Crate #1 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Nappa Valley Crate #2", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Nappa Valley Crate #2 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Nappa Valley Crate #3", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Nappa Valley Crate #3 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Office", Description = @"", PhysicalLocation = @"", OName = @"Office" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"On Order", Description = @"", PhysicalLocation = @"", OName = @"On Order" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Part of Compilaton", Description = @"", PhysicalLocation = @"", OName = @"Part of Compilaton" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"PB201110.1", Description = @"UHB", PhysicalLocation = @"Basement", OName = @"PB201110.1 (UHB) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"PB201110.2", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"PB201110.2 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"PB201110.3", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"PB201110.3 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"PB201111.4", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"PB201111.4 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"PC Games Box #1", Description = @"", PhysicalLocation = @"Closet", OName = @"PC Games Box #1 [Closet]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"PC Games Box #2", Description = @"", PhysicalLocation = @"Closet", OName = @"PC Games Box #2 [Closet]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"PC Games Box #3", Description = @"", PhysicalLocation = @"Closet", OName = @"PC Games Box #3 [Closet]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"PC Games Box #4", Description = @"", PhysicalLocation = @"Closet", OName = @"PC Games Box #4 [Closet]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"PC Games Box #4", Description = @"", PhysicalLocation = @"", OName = @"PC Games Box #4" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Pre-Ordered", Description = @"", PhysicalLocation = @"", OName = @"Pre-Ordered" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Prize Box", Description = @"", PhysicalLocation = @"", OName = @"Prize Box" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Public Music\Books", Description = @"", PhysicalLocation = @"", OName = @"Public Music\Books" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Public Music\Christmas", Description = @"", PhysicalLocation = @"", OName = @"Public Music\Christmas" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Public Music\Classical", Description = @"", PhysicalLocation = @"", OName = @"Public Music\Classical" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Public Music\Comedy", Description = @"", PhysicalLocation = @"", OName = @"Public Music\Comedy" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Public Music\Country", Description = @"", PhysicalLocation = @"", OName = @"Public Music\Country" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Public Music\New Age", Description = @"", PhysicalLocation = @"", OName = @"Public Music\New Age" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Public Music\Pop", Description = @"", PhysicalLocation = @"", OName = @"Public Music\Pop" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Public Music\Radio Shows", Description = @"", PhysicalLocation = @"", OName = @"Public Music\Radio Shows" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Public Music\Rock", Description = @"", PhysicalLocation = @"", OName = @"Public Music\Rock" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Public Music\Soundtrack", Description = @"", PhysicalLocation = @"", OName = @"Public Music\Soundtrack" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Ready to install", Description = @"", PhysicalLocation = @"", OName = @"Ready to install" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Scheduled for Donation", Description = @"", PhysicalLocation = @"", OName = @"Scheduled for Donation" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Science Books Box #14", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Science Books Box #14 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Sci-Fi Books Box #1", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Sci-Fi Books Box #1 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Sci-Fi Books Box #2", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Sci-Fi Books Box #2 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Sci-Fi Books Box #3", Description = @"UHB", PhysicalLocation = @"Basement", OName = @"Sci-Fi Books Box #3 (UHB) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Sci-Fi Books Box #4", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Sci-Fi Books Box #4 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #1", Description = @"UHM", PhysicalLocation = @"Attic", OName = @"SciFi Box #1 (UHM) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #1 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"SciFi Box #1 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #2", Description = @"UHL", PhysicalLocation = @"Attic", OName = @"SciFi Box #2 (UHL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #2 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"SciFi Box #2 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #3", Description = @"UHL", PhysicalLocation = @"Attic", OName = @"SciFi Box #3 (UHL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #3 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"SciFi Box #3 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #4", Description = @"UHXL", PhysicalLocation = @"Attic", OName = @"SciFi Box #4 (UHXL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #4 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"SciFi Box #4 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #5", Description = @"UHXL", PhysicalLocation = @"Attic", OName = @"SciFi Box #5 (UHXL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #5 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"SciFi Box #5 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #6", Description = @"UHXL", PhysicalLocation = @"Attic", OName = @"SciFi Box #6 (UHXL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #6 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"SciFi Box #6 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #7", Description = @"UHXL", PhysicalLocation = @"Attic", OName = @"SciFi Box #7 (UHXL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"SciFi Box #7 Ziploc bag", Description = @"", PhysicalLocation = @"", OName = @"SciFi Box #7 Ziploc bag" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Sealed in package", Description = @"", PhysicalLocation = @"", OName = @"Sealed in package" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Sealed with detail set included in kit", Description = @"", PhysicalLocation = @"", OName = @"Sealed with detail set included in kit" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Spares", Description = @"", PhysicalLocation = @"", OName = @"Spares" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Sports Books Box #15", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Sports Books Box #15 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Trek Attack Wing Case #01", Description = @"Plano 993179", PhysicalLocation = @"Ken's Room", OName = @"Star Trek Attack Wing Case #01 [Plano 993179]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Trek Attack Wing Case #02", Description = @"Plano 993179", PhysicalLocation = @"Ken's Room", OName = @"Star Trek Attack Wing Case #02 [Plano 993179]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Armada Box", Description = @"Unmarked 18x14x10", PhysicalLocation = @"Ken's Room", OName = @"Star Wars Armada Box (Unmarked 18x14x10) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Collectables Box #2", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Star Wars Collectables Box #2 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Collectables Box #3", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Star Wars Collectables Box #3 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Collectables Box #4", Description = @"UHM", PhysicalLocation = @"Attic", OName = @"Star Wars Collectables Box #4 (UHM) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Collectables Box #5", Description = @"UHM", PhysicalLocation = @"Attic", OName = @"Star Wars Collectables Box #5 (UHM) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Collectables Box #6", Description = @"EE 18x12x12", PhysicalLocation = @"Attic", OName = @"Star Wars Collectables Box #6 (EE 18x12x12) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Collectables Box #7", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Star Wars Collectables Box #7 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Collectables Box #8", Description = @"UHS", PhysicalLocation = @"Attic", OName = @"Star Wars Collectables Box #8 (UHS) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Collectables Box #9", Description = @"UHS", PhysicalLocation = @"Ken's Room", OName = @"Star Wars Collectables Box #9 (UHS) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Collectables Box", Description = @"UHXL", PhysicalLocation = @"Attic", OName = @"Star Wars Collectables Box (UHXL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Sterilite Flip-Top Box", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Star Wars Sterilite Flip-Top Box [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Vehicles Box #1", Description = @"UHXL", PhysicalLocation = @"Attic", OName = @"Star Wars Vehicles Box #1 (UHXL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Vehicles Box #2", Description = @"UHXL", PhysicalLocation = @"Attic", OName = @"Star Wars Vehicles Box #2 (UHXL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars Vehicles Box #3", Description = @"UHXL", PhysicalLocation = @"Attic", OName = @"Star Wars Vehicles Box #3 (UHXL) [Attic]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Star Wars X-Wing Box", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Star Wars X-Wing Box [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Starfighter Shipyards Box #1", Description = @"", PhysicalLocation = @"", OName = @"Starfighter Shipyards Box #1" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Sterilite Flip-Top Box #1", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Sterilite Flip-Top Box #1 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Sterilite Flip-Top Box #2", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Sterilite Flip-Top Box #2 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Sterilite Flip-Top Box #3", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Sterilite Flip-Top Box #3 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Sterilite Flip-Top Box #4", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Sterilite Flip-Top Box #4 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Sterilite Flip-Top Box #5", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Sterilite Flip-Top Box #5 [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Text Books Box #16", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Text Books Box #16 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"TimeLife Books Box #1", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"TimeLife Books Box #1 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"TimeLife Books Box #2", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"TimeLife Books Box #2 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"TimeLife Books Box #3", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"TimeLife Books Box #3 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Tom Clancy Book Box #9", Description = @"UHS", PhysicalLocation = @"Basement", OName = @"Tom Clancy Book Box #9 (UHS) [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Topps 2006 Football #1", Description = @"Football Cards Box #1 (ESSS)", PhysicalLocation = @"Closet", OName = @"Topps 2006 Football #1 [Football Cards Box #1 (ESSS) [Closet]]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Topps 2006 Football #2", Description = @"Football Cards Box #1 (ESSS)", PhysicalLocation = @"Closet", OName = @"Topps 2006 Football #2 [Football Cards Box #1 (ESSS) [Closet]]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Topps 2006 Football #3", Description = @"Football Cards Box #1 (ESSS)", PhysicalLocation = @"Closet", OName = @"Topps 2006 Football #3 [Football Cards Box #1 (ESSS) [Closet]]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Topps 2007 Football Complete Set Box", Description = @"Football Cards Box #1 (ESSS)", PhysicalLocation = @"Closet", OName = @"Topps 2007 Football Complete Set Box [Football Cards Box #1 (ESSS) [Closet]]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Topps 2008 Football #1", Description = @"Football Cards Box #1 (ESSS)", PhysicalLocation = @"Closet", OName = @"Topps 2008 Football #1 [Football Cards Box #1 (ESSS) [Closet]]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Topps 2008 Football Complete Set Box", Description = @"Football Cards Box #1 (ESSS)", PhysicalLocation = @"Closet", OName = @"Topps 2008 Football Complete Set Box [Football Cards Box #1 (ESSS) [Closet]]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Topps Cowboys Box #01", Description = @"Football Cards Box #1 (ESSS)", PhysicalLocation = @"Closet", OName = @"Topps Cowboys Box #01 [Football Cards Box #1 (ESSS) [Closet]]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Train Stuff", Description = @"", PhysicalLocation = @"", OName = @"Train Stuff" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Transition", Description = @"", PhysicalLocation = @"", OName = @"Transition" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Unboxed", Description = @"", PhysicalLocation = @"Basement", OName = @"Unboxed [Basement]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Unboxed", Description = @"", PhysicalLocation = @"Carol's Room", OName = @"Unboxed [Carol's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Unboxed", Description = @"", PhysicalLocation = @"Ken's Room - Near Front Wall", OName = @"Unboxed [Ken's Room - Near Front Wall]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Unboxed", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Unboxed [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Unboxed Atop Bookcase A", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Unboxed Atop Bookcase A [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Unboxed Atop Bookcase B", Description = @"", PhysicalLocation = @"Ken's Room", OName = @"Unboxed Atop Bookcase B [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Undecided (Carol)", Description = @"", PhysicalLocation = @"", OName = @"Undecided (Carol)" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Unknown - Possible Duplicate", Description = @"", PhysicalLocation = @"", OName = @"Unknown - Possible Duplicate" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Unknown", Description = @"", PhysicalLocation = @"", OName = @"Unknown" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Unspecified", Description = @"", PhysicalLocation = @"", OName = @"Unspecified" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Web Access", Description = @"", PhysicalLocation = @"", OName = @"Web Access" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Wire Rack", Description = @"", PhysicalLocation = @"Ken's Room East Wall (Top Shelf)", OName = @"Wire Rack (Top Shelf) [Ken's Room East Wall]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Work Books 20080910.1", Description = @"UHS", PhysicalLocation = @"Ken's Room", OName = @"Work Books 20080910.1 (UHS) [Ken's Room]" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Workbench", Description = @"", PhysicalLocation = @"", OName = @"Workbench" });

            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Canceled", Description = @"", PhysicalLocation = @"", OName = @"Canceled" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"EB Games.com", Description = @"", PhysicalLocation = @"", OName = @"EB Games.com" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Self-Compiled", Description = @"", PhysicalLocation = @"", OName = @"Self-Compiled" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Topps 2006 Football #1", Description = @"", PhysicalLocation = @"", OName = @"Topps 2006 Football #1" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"Undetermined", Description = @"", PhysicalLocation = @"", OName = @"Undetermined" });
            modelBuilder.Entity<Location>().HasData(new Location { ID = Guid.NewGuid(), Name = @"WishList", Description = @"", PhysicalLocation = @"", OName = @"WishList" });
        }
        private void SeedShipClassTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "XXX", Description = "Unassigned" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "ACR", Description = "Heavy Armored Cruiser - Battleship prototype" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "AD", Description = "Destroyer Tenders" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "AE", Description = "Ammunition Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "AG", Description = "Oceanographic Research Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "AGF", Description = "Miscellaneous Command Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "AGSS", Description = "Auxiliary Research Submarines" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "AO", Description = "Oilers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "AOE", Description = "Fast Combat Support Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "AOR", Description = "Replenishment Oilers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "APD", Description = "High Speed Transports" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "ARS", Description = "Salvage Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "AS", Description = "Submarine Tenders" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "ATS", Description = "Salvage and Rescue Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "BB", Description = "Battleships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "CA", Description = "Heavy (Gun) Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "CAG", Description = "Guided Missile Heavy Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "CB", Description = "Large Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "CG", Description = "Guided Missile Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "CGN", Description = "Guided Missile Cruisers (Nuclear)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "CL", Description = "Light (Gun) Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "CLC", Description = "Command Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "CLG", Description = "Light Guided Missile Cruisers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "CV", Description = "Multi-Purpose (Fleet) Aircraft Carriers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "CVE", Description = "Escort Carriers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "CVL", Description = "Light Carriers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "CVN", Description = "Multi-Purpose Aircraft Carriers (Nuclear)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "DD", Description = "Destroyers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "DDG", Description = "Guided Missile Destroyers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "DE", Description = "Destroyer Escorts" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "DL", Description = "Post World War II Frigates" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "DLG", Description = "Guided Missile Frigate (post WWII)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "FF", Description = "Frigates" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "FFG", Description = "Guided Missile Frigates" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "IX", Description = "Unclassified Miscellaneous Units" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "LCC", Description = "Amphibious Command Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "LCS", Description = "Littoral Combat Ship" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "LHA", Description = "Amphibious Assault Ships (general purpose)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "LHD", Description = "Amphibious Assault Ships (multi-purpose)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "LKA", Description = "Amphibious Cargo Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "LPD", Description = "Amphibious Transport docks" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "LPH", Description = "Amphibious Assault Ships (Helicopter)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "LSD", Description = "Dock Landing Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "LST", Description = "Tank Landing Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "MCM", Description = "Mine Countermeasures Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "MCS", Description = "Mine Countermeasures Support Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "MHC", Description = "Minehunters, Coastal" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "MSO", Description = "Ocean Minesweepers" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "PC", Description = "Patrol Craft" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "PG", Description = "Patrol Gunboats" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "PHM", Description = "Patrol Combatants - Missile (Hydrofoil)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "SS", Description = "Submarines" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "SSBN", Description = "Ballistic Missile Submarines (Nuclear)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "SSN", Description = "Submarines (Nuclear)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "SST", Description = "Training Submarines" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "T-AE", Description = "Ammunition Ships (assigned to Military Sealift Command)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "T-AFS", Description = "Combat Store Ships (assigned to Military Sealift Command)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "T-AG", Description = "Oceanographic Research Ships" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "T-AO", Description = "Oilers (assigned to Military Sealift Command)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "T-AOE", Description = "Fast Combat Support Ships (assigned to Military Sealift Command)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "T-ARS", Description = "Salvage Ships (assigned to Military Sealift Command)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "T-AS", Description = "Submarine Tenders (assigned to Military Sealift Command)" });
            modelBuilder.Entity<ShipClassType>().HasData(new ShipClassType { ID = Guid.NewGuid(), TypeCode = "T-LKA", Description = "Amphibious Cargo Ships (assigned to Military Sealift Command)" });
        }
        #endregion
        private void ConfigureAlternateIndexes(ModelBuilder modelBuilder)
        {
            #region "Reference"
            #region "AircraftDesignations"
            modelBuilder.Entity<AircraftDesignation>().HasIndex(i => new { i.Designation, i.ID }).IsUnique().HasName("IX_AircraftDesignationsByDesignation");
            #endregion

            #region "Ships"
            modelBuilder.Entity<Ship>().HasIndex(i => new { i.HullNumber, i.ID }).IsUnique().HasName("IX_ShipsByHullNumber");
            modelBuilder.Entity<Ship>().HasIndex(i => new { i.Name, i.ID }).IsUnique().HasName("IX_ShipsByName");
            #endregion
            #region "ShipClasses"
            //modelBuilder.Entity<ShipClass>().HasIndex(i => new { i.ShipClassType, i.ID }).IsUnique().HasName("IX_ShipClassesByType");
            modelBuilder.Entity<ShipClass>().HasIndex(i => new { i.Name, i.ID }).IsUnique().HasName("IX_ShipClassesByName");
            #endregion
            #region "ShipClassTypes"
            modelBuilder.Entity<ShipClassType>().HasIndex(i => new { i.TypeCode, i.ID }).IsUnique().HasName("IX_ShipClassTypesByType");
            #endregion
            #endregion
            #region "Stash"
            #region "Books"
            modelBuilder.Entity<Book>().HasIndex(i => new { i.AlphaSort, i.ID }).IsUnique().HasName("IX_BooksByAlphaSort");
            modelBuilder.Entity<Book>().HasIndex(i => new { i.Author, i.ID }).IsUnique().HasName("IX_BooksByAuthor");
            modelBuilder.Entity<Book>().HasIndex(i => new { i.MediaFormat, i.AlphaSort, i.ID }).IsUnique().HasName("IX_BooksByFormat");
            modelBuilder.Entity<Book>().HasIndex(i => new { i.ISBN, i.ID }).IsUnique().HasName("IX_BooksByISBN");
            modelBuilder.Entity<Book>().HasIndex(i => new { i.Subject, i.ID }).IsUnique().HasName("IX_BooksBySubject");
            modelBuilder.Entity<Book>().HasIndex(i => new { i.Title, i.ID }).IsUnique().HasName("IX_BooksByTitle");
            #endregion
            #region "Collectables"
            modelBuilder.Entity<Collectable>().HasIndex(i => new { i.Name, i.Series, i.Type, i.Reference, i.ID }).IsUnique().HasName("IX_CollectablesByName");
            modelBuilder.Entity<Collectable>().HasIndex(i => new { i.Series, i.Type, i.Reference, i.ID }).IsUnique().HasName("IX_CollectablesBySeries");
            modelBuilder.Entity<Collectable>().HasIndex(i => new { i.Type, i.Series, i.Reference, i.ID }).IsUnique().HasName("IX_CollectablesByType");
            #endregion
            #region "Hobby"
            #region "Kits"
            modelBuilder.Entity<Kit>().HasIndex(i => new { i.Type, i.Designation, i.Scale, i.ID }).IsUnique().HasName("IX_KitsByDesignation");
            modelBuilder.Entity<Kit>().HasIndex(i => new { i.Manufacturer, i.ID }).IsUnique().HasName("IX_KitsByManufacturer");
            modelBuilder.Entity<Kit>().HasIndex(i => new { i.Name, i.Scale, i.ID }).IsUnique().HasName("IX_KitsByName");
            modelBuilder.Entity<Kit>().HasIndex(i => new { i.Nation, i.Service, i.Era, i.ID }).IsUnique().HasName("IX_KitsByNationServiceEra");
            modelBuilder.Entity<Kit>().HasIndex(i => new { i.Scale, i.Type, i.Manufacturer, i.ID }).IsUnique().HasName("IX_KitsByScale");
            modelBuilder.Entity<Kit>().HasIndex(i => new { i.Type, i.Scale, i.ID }).IsUnique().HasName("IX_KitsByType");
            #endregion
            #region "Decals"
            modelBuilder.Entity<Decal>().HasIndex(i => new { i.Type, i.Designation, i.Scale, i.ID }).IsUnique().HasName("IX_DecalsByDesignation");
            modelBuilder.Entity<Decal>().HasIndex(i => new { i.Manufacturer, i.ID }).IsUnique().HasName("IX_DecalsByManufacturer");
            modelBuilder.Entity<Decal>().HasIndex(i => new { i.Name, i.Scale, i.ID }).IsUnique().HasName("IX_DecalsByName");
            modelBuilder.Entity<Decal>().HasIndex(i => new { i.Scale, i.Type, i.Manufacturer, i.ID }).IsUnique().HasName("IX_DecalsByScale");
            modelBuilder.Entity<Decal>().HasIndex(i => new { i.Type, i.Scale, i.ID }).IsUnique().HasName("IX_DecalsByType");
            #endregion
            #region "DetailSets"
            modelBuilder.Entity<DetailSet>().HasIndex(i => new { i.Type, i.Designation, i.Scale, i.ID }).IsUnique().HasName("IX_DetailSetsByDesignation");
            modelBuilder.Entity<DetailSet>().HasIndex(i => new { i.Manufacturer, i.ID }).IsUnique().HasName("IX_DetailSetsByManufacturer");
            modelBuilder.Entity<DetailSet>().HasIndex(i => new { i.Name, i.Scale, i.ID }).IsUnique().HasName("IX_DetailSetsByName");
            modelBuilder.Entity<DetailSet>().HasIndex(i => new { i.Scale, i.Type, i.Manufacturer, i.ID }).IsUnique().HasName("IX_DetailSetsByScale");
            modelBuilder.Entity<DetailSet>().HasIndex(i => new { i.Type, i.Scale, i.ID }).IsUnique().HasName("IX_DetailSetsByType");
            #endregion
            #endregion
            #region "Music"
            modelBuilder.Entity<Music>().HasIndex(i => new { i.AlphaSort, i.MediaFormat, i.ID }).IsUnique().HasName("IX_MusicByAlphaSort");
            modelBuilder.Entity<Music>().HasIndex(i => new { i.Artist, i.Year, i.MediaFormat, i.ID }).IsUnique().HasName("IX_MusicByArtist");
            modelBuilder.Entity<Music>().HasIndex(i => new { i.MediaFormat, i.Artist, i.Year, i.ID }).IsUnique().HasName("IX_MusicByFormat");
            modelBuilder.Entity<Music>().HasIndex(i => new { i.Type, i.Artist, i.Year, i.MediaFormat, i.ID }).IsUnique().HasName("IX_MusicByType");
            #endregion
            #region "Software"
            modelBuilder.Entity<Software>().HasIndex(i => new { i.AlphaSort, i.ID }).IsUnique().HasName("IX_SoftwareByAlphaSort");
            modelBuilder.Entity<Software>().HasIndex(i => new { i.Platform, i.AlphaSort, i.ID }).IsUnique().HasName("IX_SoftwareByPlatform");
            modelBuilder.Entity<Software>().HasIndex(i => new { i.Type, i.AlphaSort, i.ID }).IsUnique().HasName("IX_SoftwareByType");
            #endregion
            #region "Video Library"
            #region "Episodes"
            modelBuilder.Entity<Episode>().HasIndex(i => new { i.MediaFormat, i.Series, i.Number, i.ID }).IsUnique().HasName("IX_EpisodesByFormat");
            modelBuilder.Entity<Episode>().HasIndex(i => new { i.Series, i.Number, i.ID }).IsUnique().HasName("IX_EpisodesBySeries");
            modelBuilder.Entity<Episode>().HasIndex(i => new { i.Subject, i.ID }).IsUnique().HasName("IX_EpisodesBySubject");
            #endregion
            #region "Movies"
            modelBuilder.Entity<Video>().HasIndex(i => new { i.MediaFormat, i.AlphaSort, i.ID }).IsUnique().HasName("IX_VideosByFormat");
            modelBuilder.Entity<Video>().HasIndex(i => new { i.AlphaSort, i.MediaFormat, i.ID }).IsUnique().HasName("IX_VideosBySort");
            modelBuilder.Entity<Video>().HasIndex(i => new { i.Subject, i.Title, i.ID }).IsUnique().HasName("IX_VideosBySubject");
            modelBuilder.Entity<Video>().HasIndex(i => new { i.Title, i.MediaFormat, i.ID }).IsUnique().HasName("IX_VideosByTitle");
            #endregion
            #endregion
            #endregion
            #region "Miscellaneous"
            #region "FileLists"
            //modelBuilder.Entity<FileList>().HasIndex(i => new { i.Path }).IsUnique().HasName("IX_FileListByPath");
            #endregion
            #region "MenuEntries"
            //modelBuilder.Entity<MenuEntries>().HasIndex(i => new { i.ButtonLabel, i.ParentID, i.Label, i.ID }).IsUnique().HasName("IX_MenuEntriesByButton");
            //modelBuilder.Entity<MenuEntries>().HasIndex(i => new { i.ParentID, i.ButtonLabel, i.Label, i.ID }).IsUnique().HasName("IX_MenuEntriesByParentID");
            #endregion
            #endregion
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(tcLoggerFactory);
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["TC3CoreContext"].ConnectionString)
                .ReplaceService<SqlServerMigrationsAnnotationProvider, ExtendedSqlServerMigrationsAnnotationProvider>()
                .ReplaceService<SqlServerMigrationsSqlGenerator, ExtendedSqlServerMigrationsSqlGenerator>();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureAlternateIndexes(modelBuilder);
            //Define <ImageDetail>'s primary key to be the TableName/RecordID composite...

            //TODO:          modelBuilder.Entity<Video_Research>().Property(e => e.Format).IsUnicode(false);
            //TODO:          modelBuilder.Entity<Query>().Property(e => e.Name).IsUnicode(false);
            //TODO:          modelBuilder.Entity<Query>().Property(e => e.Description).IsUnicode(false);
            //TODO:          modelBuilder.Entity<Query>().Property(e => e.Query1).IsUnicode(false);

            SeedAircraftDesignations(modelBuilder);
            SeedBlueAngelsHistory(modelBuilder);
            SeedLocations(modelBuilder);
            SeedShipClassTypes(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
        public void SaveHistory(EntityEntry<IDataEntity> entry)
        {
            Guid ID = ((IDataEntity)entry.Entity).ID;
            string tableName = entry.Entity.GetType().Name;
            tableName = tableName == "Image" ? "Images" : TypeToTableName(entry.Entity.GetType().Name);
            DateTime dateChanged = DateTime.Now;
            EntityState entityState = entry.State;
            foreach (var prop in entry.CurrentValues.Properties.AsQueryable().Where(p => p.Name.Trim() != "RowID"))
            {
                var original = entry.State == EntityState.Added ? "Record Added" : entry.OriginalValues[prop.Name]?.ToString();
                var current = entry.State == EntityState.Deleted ? "Record Deleted" : entry.CurrentValues[prop.Name]?.ToString();
                History history = null;
                switch (entry.State)
                {
                    case EntityState.Added:
                        history = new History
                        {
                            TableName = tableName,
                            RecordID = ID,
                            Column = prop.Name,
                            OriginalValue = original,
                            Value = current,
                            DateCreated = dateChanged,
                            DateModified = dateChanged,
                            DateChanged = dateChanged,
                            Who = "System"
                        };
                        Debug.WriteLine("Record Added: {0}.ID #{1}: {2} {3}", tableName, ID, prop.Name, current == null ? "Null" : $"\"{current}\"");
                        break;
                    case EntityState.Deleted:
                        history = new History
                        {
                            TableName = tableName,
                            RecordID = ID,
                            Column = prop.Name,
                            OriginalValue = original,
                            Value = current,
                            DateCreated = dateChanged,
                            DateModified = dateChanged,
                            DateChanged = dateChanged,
                            Who = "System"
                        };
                        Debug.WriteLine("Record Deleted: {0}.ID #{1}: {2} {3}", tableName, ID, prop.Name, original == null ? "Null" : $"\"{original}\"");
                        break;
                    case EntityState.Modified:
                        if (original != current)
                        {
                            Debug.WriteLine("{0}.ID #{1}: {2} changed from {3} to {4}", tableName, ID, prop.Name, original == null ? "Null" : $"\"{original}\"", current == null ? "Null" : $"\"{current}\"");
                            history = new History
                            {
                                TableName = tableName,
                                RecordID = ID,
                                Column = prop.Name,
                                OriginalValue = original,
                                Value = current,
                                DateCreated = dateChanged,
                                DateModified = dateChanged,
                                DateChanged = dateChanged,
                                Who = "System"
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
            //Use the context's tracking information to add any History transactions...
            DateTime timestamp = DateTime.Now;
            foreach (var entry in this.ChangeTracker.Entries<IDataEntity>()
                    .Where(e => e.State != EntityState.Unchanged && e.State != EntityState.Detached))
            {
                entry.Entity.DateModified = timestamp;
                if (entry.Entity.DateCreated == DateTime.MinValue)
                    entry.Entity.DateCreated = timestamp;
                SaveHistory(entry);
            }
            return base.SaveChanges();  //Execute the real SaveChanges()...
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
                case "ShipClassificationType":
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
