namespace TCDomain.DataModel
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    //using Microsoft.EntityFrameworkCore;  //i.e. EF7
    using System.Diagnostics;
    using System.Linq;
    using SharedKernel.Data;
    using SharedKernel.Data.Annotations;
    using SharedKernel.Interfaces;
    using TCDomain.DataModel.Classes;
    using TCDomain.DataModel.Interfaces;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.SqlServer;
    using System.Data.Entity.Migrations.Model;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.ModelConfiguration.Conventions;
    public partial class TCContext : DbContext
    {
       public TCContext() : base("name=TCContext")
        {
            //UserName = this.Database.ExecuteSqlCommand("SELECT SUSER_NAME()", );

        }
        public string UserName { get; }  //TODO: Determine who we're connected as...
        #region "DbSets"
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
            #endregion
            #region "Reference"
        public virtual DbSet<BlueAngelsHistory> BlueAngelsHistories { get; set; }
        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<AircraftDesignation> AircraftDesignations { get; set; }
        public virtual DbSet<ShipClass> ShipClasses { get; set; }
        public virtual DbSet<ShipClassificationType> ShipClassificationTypes { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }
            #endregion
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Query> Queries { get; set; }
        #endregion
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            CustomConventions.Add(modelBuilder);
#if EF7
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(StashBase<>).IsAssignableFrom(entityType.ClrType))
                {
                    modelBuilder.Entity(entityType.ClrType).Property("Price").HasPrecision(19, 4);
                    modelBuilder.Entity(entityType.ClrType).Property("Value").HasPrecision(19, 4);
                }
            }
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
                if (entity.GetType().IsAssignableFrom(typeof(EntityBase)))
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
        public void SaveHistory(System.Data.Entity.Infrastructure.DbEntityEntry<IEntity> entry)
        {
            Int32 ID = ((IEntity)entry.Entity).ID;
            string tableName = entry.Entity.GetType().Name;
            tableName = tableName == "Image" ? "Images" : TypeToTableName(entry.Entity.GetType().BaseType.Name);
            DateTime dateChanged = DateTime.Now;
            EntityState entityState = entry.State;
            foreach (var propName in entry.CurrentValues.PropertyNames.Where(p => p.Trim() != "RowID")) {
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
            //Automatically set DateCreated and DateModified on any entities that implement the IModificationHistory interface...
            //foreach (var entry in this.ChangeTracker.Entries<IEntity>()
            //        .Where(e => (e.State == EntityState.Added || e.State == EntityState.Modified))
            //        .Select(e => e.Entity as IEntity)) {
            //    entry.DateModified = DateTime.Now;
            //    if (entry.DateCreated == DateTime.MinValue)
            //        entry.DateCreated = DateTime.Now;
            //}

            //Use the context's tracking information to add any History transactions...
            foreach (var entry in this.ChangeTracker.Entries<IEntity>()
                    .Where(e => e.State != EntityState.Unchanged && e.State != EntityState.Detached)) {
                entry.Entity.DateModified = DateTime.Now;
                if (entry.Entity.DateCreated == DateTime.MinValue)
                    entry.Entity.DateCreated = DateTime.Now;
                SaveHistory(entry);
            }
            
            //Execute the real SaveChanges()...
            int result = base.SaveChanges();

            //Clear our ignored IsDirty flag for the application...
            foreach (var entry in this.ChangeTracker.Entries<IEntity>().Select(e => e.Entity as IEntity))
                entry.IsDirty = false;
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