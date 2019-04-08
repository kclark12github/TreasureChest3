namespace TC3Model.DataModel.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AircraftDesignations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Designation = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Official Designationof this aircraft.")
                                },
                            }),
                        Manufacturer = c.String(maxLength: 72,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Manufacturer of this aircraft.")
                                },
                            }),
                        Name = c.String(maxLength: 72,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Official Name of this aircraft.")
                                },
                            }),
                        Nicknames = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unofficial Nicknames of this aircraft.")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous Notes.")
                                },
                            }),
                        Number = c.Double(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Designation number of this aircraft (for sorting).")
                                },
                            }),
                        ServiceDate = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date this aircraft entered service.")
                                },
                            }),
                        Type = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Type of this aircraft (i.e. Fighter, Bomber, etc.).")
                                },
                            }),
                        Version = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Version of this aircraft.")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Aircraft Designations" },
                })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BlueAngelsHistory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        ServiceDates = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Dates this aircraft served with the Blue Angels.")
                                },
                            }),
                        AircraftType = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Aircraft Type serving with the Blue Angels.")
                                },
                            }),
                        Decals = c.String(),
                        DecalSets = c.String(),
                        Kits = c.String(),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous Notes.")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        AlphaSort = c.String(nullable: false, maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Sort string.")
                                },
                                { 
                                    "MinLength",
                                    new AnnotationValues(oldValue: null, newValue: "1")
                                },
                            }),
                        Author = c.String(nullable: false, maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Author of the publication.")
                                },
                                { 
                                    "MinLength",
                                    new AnnotationValues(oldValue: null, newValue: "1")
                                },
                            }),
                        MediaFormat = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Media/Format of the publication (i.e. Hardcover, Paperback, etc).")
                                },
                                { 
                                    "MinLength",
                                    new AnnotationValues(oldValue: null, newValue: "1")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "'Unspecified'")
                                },
                            }),
                        ISBN = c.String(maxLength: 24,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "International Standard Book Number.")
                                },
                            }),
                        Misc = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous information.")
                                },
                            }),
                        Subject = c.String(nullable: false, maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Subject of the publication.")
                                },
                                { 
                                    "MinLength",
                                    new AnnotationValues(oldValue: null, newValue: "1")
                                },
                            }),
                        Title = c.String(nullable: false, maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Title of the publication.")
                                },
                                { 
                                    "MinLength",
                                    new AnnotationValues(oldValue: null, newValue: "1")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Library of Books, Magazines, and electronic media." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Description = c.String(maxLength: 1024,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Description of box/container (if applicable).")
                                },
                            }),
                        Name = c.String(maxLength: 1024,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Name of location.")
                                },
                            }),
                        PhysicalLocation = c.String(maxLength: 1024,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Physical location of the box/container represented by this Location.")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Location of catalogued items." },
                })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Collectables",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Condition = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Condition of the item (i.e. Packaged, Opened, etc.).")
                                },
                            }),
                        Manufacturer = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Manufacturer of the item.")
                                },
                            }),
                        Name = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Name of the item.")
                                },
                            }),
                        OutOfProduction = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is the item out-of-production?")
                                },
                            }),
                        Reference = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Reference number/code identifying the item.")
                                },
                            }),
                        Series = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Series of the item.")
                                },
                            }),
                        Type = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Type of collectable (i.e. baseball card, board game, Hot Wheel, etc.).")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Collectables, ranging from baseball cards, to Hot Wheels to Keepsake Ornaments." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Account = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Account number for ordering from this company.")
                                },
                            }),
                        Address = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Company mailing address.")
                                },
                            }),
                        Code = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Company code.")
                                },
                            }),
                        Name = c.String(maxLength: 72,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Full Company Name.")
                                },
                            }),
                        Phone = c.String(maxLength: 14,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Company phone number.")
                                },
                            }),
                        ProductType = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Type of hobby products supplied by this company.")
                                },
                            }),
                        ShortName = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Company Short Name.")
                                },
                            }),
                        WebSite = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Company web site.")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Hobby supply company address book." },
                })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Decals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Designation = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Designation of the corresponding Model Kit (i.e. F-14A, BB-63, etc.) used to display possible applications of the particular Decal.")
                                },
                            }),
                        Manufacturer = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Manufacturer of the Decal.")
                                },
                            }),
                        Name = c.String(maxLength: 256,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Name of the Decal.")
                                },
                            }),
                        Nation = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Nationality of the Decal.")
                                },
                            }),
                        ProductCatalog = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Vendor where the Decal was purchased (or priced).")
                                },
                            }),
                        Reference = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Reference number/code identifying the Decal.")
                                },
                            }),
                        Scale = c.String(maxLength: 12,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Scale of Decal.")
                                },
                            }),
                        Type = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Type of Decal (i.e. Aircraft, Ship, etc.).")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Decals." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.Kits",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Condition = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Condition of the Model Kit (i.e. Built, Opened, etc.).")
                                },
                            }),
                        Designation = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Designation of the Model Kit (i.e. F-14A, BB-63, etc.).")
                                },
                            }),
                        Era = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Era the prototype of the Model Kit served (i.e. WWII, Vietnam, etc.).")
                                },
                            }),
                        Manufacturer = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Manufacturer of the Model Kit.")
                                },
                            }),
                        Name = c.String(maxLength: 256,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Name of the Model Kit.")
                                },
                            }),
                        Nation = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Nationality of the Model Kit.")
                                },
                            }),
                        OutOfProduction = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is the item out-of-production?")
                                },
                            }),
                        ProductCatalog = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Vendor where the Model Kit was purchased (or priced).")
                                },
                            }),
                        Reference = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Reference number/code identifying the Model Kit.")
                                },
                            }),
                        Scale = c.String(maxLength: 12,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Scale of Model Kit.")
                                },
                            }),
                        Service = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Service the prototype of the Model Kit served (i.e. USN, USMC, USAAF, etc.).")
                                },
                            }),
                        Type = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Type of Model Kit (i.e. Aircraft, Ship, etc.).")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Decal_ID = c.Int(),
                        DetailSet_ID = c.Int(),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Model Kits." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Decals", t => t.Decal_ID)
                .ForeignKey("dbo.DetailSets", t => t.DetailSet_ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.Decal_ID)
                .Index(t => t.DetailSet_ID)
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.DetailSets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Designation = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Designation of the corresponding model kit (i.e. F-14A, BB-63, etc.) used to display possible applications of the particular Detail Set.")
                                },
                            }),
                        Manufacturer = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Manufacturer of the Detail Set.")
                                },
                            }),
                        Name = c.String(maxLength: 256,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Name of the Detail Set.")
                                },
                            }),
                        Nation = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Nationality of the Detail Set.")
                                },
                            }),
                        ProductCatalog = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Vendor where the Detail Set was purchased (or priced).")
                                },
                            }),
                        Reference = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Reference number/code identifying the Detail Set.")
                                },
                            }),
                        Scale = c.String(maxLength: 12,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Scale of Detail Set.")
                                },
                            }),
                        Type = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Type of Detail Set (i.e. Aircraft, Ship, etc.).")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Detail Sets." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.Episodes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Distributor = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Distributor of this title.")
                                },
                            }),
                        MediaFormat = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Media/Format of this title (i.e. VHS, DVD, Blu-Ray, MP4, etc.).")
                                },
                                { 
                                    "MinLength",
                                    new AnnotationValues(oldValue: null, newValue: "1")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "'Unspecified'")
                                },
                            }),
                        Number = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Episode number.")
                                },
                            }),
                        DateReleased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the title was originally released (if known).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Series = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Name of this TV Series.")
                                },
                            }),
                        StoreBought = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Was this episode/set purchased as opposed to recorded or ripped from the library? (TODO: Move into MediaFormat)")
                                },
                            }),
                        Subject = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Subject of this title (i.e. Comedy, Drama, etc.).")
                                },
                            }),
                        Taped = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Was this episode/set taped? (TODO: Move into MediaFormat)")
                                },
                            }),
                        Title = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Title of this episode/set.")
                                },
                            }),
                        WMV = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this episode/set been ripped to digital format? (TODO: Move into MediaFormat)")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "TV Episode Library" },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.FinishingProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Count = c.Double(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Count of this item.")
                                },
                            }),
                        Manufacturer = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Manufacturer of the item.")
                                },
                            }),
                        Name = c.String(maxLength: 72,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Name of the item.")
                                },
                            }),
                        ProductCatalog = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Vendor where the item was purchased (or priced).")
                                },
                            }),
                        Reference = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Reference number/code identifying the item.")
                                },
                            }),
                        Type = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Type of the item (i.e. Paint, Brush, Sanding Stick, etc.).")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Inventory of Finishing Products (i.e. Paint, Brushes, etc.)." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.History",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Column = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Column changed.")
                                },
                            }),
                        DateChanged = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date of this change.")
                                },
                            }),
                        OriginalValue = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Original (changed from) value.")
                                },
                            }),
                        RecordID = c.Int(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Record changed.")
                                },
                            }),
                        TableName = c.String(nullable: false, maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Table changed.")
                                },
                            }),
                        Value = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "New (changed to) value.")
                                },
                            }),
                        Who = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "User ID affecting this change.")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "History of changes applied by the application." },
                })
                .PrimaryKey(t => t.ID)
                .Index(t => new { t.DateChanged, t.TableName, t.RecordID, t.Column }, unique: true, name: "IX_HistoryByDate")
                .Index(t => new { t.TableName, t.RecordID, t.DateChanged, t.Column }, unique: true, name: "IX_HistoryByRecord");
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Name = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Image Name.")
                                },
                            }),
                        Image = c.Binary(storeType: "image",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Actual Image binary.")
                                },
                            }),
                        FileName = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "File system object from which this Image was imported.")
                                },
                            }),
                        URL = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Internel web site providing this Image (if applicable).")
                                },
                            }),
                        Height = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Height in pixels of this Image.")
                                },
                            }),
                        Width = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Width in pixels of this Image.")
                                },
                            }),
                        Category = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Category of this Image.")
                                },
                            }),
                        AlphaSort = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Sort string.")
                                },
                            }),
                        TableName = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Table of the record related to this image.")
                                },
                            }),
                        RecordID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Record ID of the record related to this image.")
                                },
                            }),
                        Thumbnail = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Does this image represent the thumbnail of another, main image?")
                                },
                            }),
                        Caption = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Image Caption.")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous Notes.")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        ThumbnailImage_ID = c.Int(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Images both independent and those representing items tracked in the database." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Images", t => t.ThumbnailImage_ID)
                .Index(t => new { t.TableName, t.RecordID }, name: "IX_ImageByRecord")
                .Index(t => t.ThumbnailImage_ID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        AlphaSort = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Sort string.")
                                },
                            }),
                        Distributor = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Distributor of this title.")
                                },
                            }),
                        MediaFormat = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Media/Format of this title (i.e. VHS, DVD, Blu-Ray, MP4, etc.).")
                                },
                                { 
                                    "MinLength",
                                    new AnnotationValues(oldValue: null, newValue: "1")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "'Unspecified'")
                                },
                            }),
                        DateReleased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the title was originally released (if known).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        StoreBought = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Was this title purchased as opposed to recorded or ripped from the library? (TODO: Move into MediaFormat)")
                                },
                            }),
                        Subject = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Subject of this title (i.e. Comedy, Drama, etc.).")
                                },
                            }),
                        Title = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Title of this Movie.")
                                },
                            }),
                        WMV = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this title been ripped to digital format? (TODO: Move into MediaFormat)")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Movie Library" },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.Music",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Artist = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Artist of the album.")
                                },
                            }),
                        AlphaSort = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Sort string.")
                                },
                            }),
                        MediaFormat = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Media/Format of this album (i.e. LP, CD, MP3, etc.).")
                                },
                                { 
                                    "MinLength",
                                    new AnnotationValues(oldValue: null, newValue: "1")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "'Unspecified'")
                                },
                            }),
                        Title = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Album title.")
                                },
                            }),
                        Type = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Genre of this title.")
                                },
                            }),
                        Year = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Year this album was originally released.")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Library of Music, including physical and electronic media." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.Query",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Name = c.String(maxLength: 250,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Query Name.")
                                },
                            }),
                        Description = c.String(maxLength: 250,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Query Description.")
                                },
                            }),
                        QueryText = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Query body.")
                                },
                            }),
                        Access = c.Short(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Query Access.")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Canned queries which can be run within the application." },
                })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rockets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Designation = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Designation of the Rocket (i.e. Saturn-V, etc.).")
                                },
                            }),
                        Manufacturer = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Manufacturer of the Rocket.")
                                },
                            }),
                        Name = c.String(maxLength: 72,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Name of the Rocket.")
                                },
                            }),
                        Nation = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Nationality of the Rocket.")
                                },
                            }),
                        ProductCatalog = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Vendor where the Rocket was purchased (or priced).")
                                },
                            }),
                        Reference = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Reference number/code identifying the Rocket.")
                                },
                            }),
                        Scale = c.String(maxLength: 12,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Scale of Rocket.")
                                },
                            }),
                        Type = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Type of Rocket.")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Rockets." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.ShipClass",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Year = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Year this Class was designed.")
                                },
                            }),
                        Aircraft = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Aircraft typically deployed with this Ship/Class.")
                                },
                            }),
                        ASWWeapons = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Anti-Submarine-Warfare (ASW) weapon capability of this Ship/Class.")
                                },
                            }),
                        Beam = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Beam (width) of this Ship/Class.")
                                },
                            }),
                        Boilers = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Boilers typically outfitted for this Ship/Class.")
                                },
                            }),
                        Description = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "General Description of this Ship/Class.")
                                },
                            }),
                        Displacement = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Displacement of this Ship/Class.")
                                },
                            }),
                        Draft = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Draft of this Ship/Class.")
                                },
                            }),
                        EW = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Electronic Warfare (EW) capability of this Ship/Class.")
                                },
                            }),
                        FireControl = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "FireControl capability of this Ship/Class.")
                                },
                            }),
                        Guns = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Gun armament of this Ship/Class.")
                                },
                            }),
                        Length = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Length of this Ship/Class.")
                                },
                            }),
                        Manning = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Crew compliment of this Ship/Class.")
                                },
                            }),
                        Missiles = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Missile armament of this Ship/Class.")
                                },
                            }),
                        Name = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Name of this Ship/Class.")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous Notes.")
                                },
                            }),
                        Propulsion = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Propulsion system of this Ship/Class.")
                                },
                            }),
                        Radars = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "RADAR capability of this Ship/Class.")
                                },
                            }),
                        Speed = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Speed of this Ship/Class.")
                                },
                            }),
                        Sonars = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "SONAR capability of this Ship/Class.")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        ShipClassificationType_ID = c.Int(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "United States Navy Ship Classes." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ShipClassificationTypes", t => t.ShipClassificationType_ID)
                .Index(t => t.ShipClassificationType_ID);
            
            CreateTable(
                "dbo.ShipClassificationTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Description = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Classification Type Description (i.e. Aircraft Carrier, Battleship, Destroyer, etc.).")
                                },
                            }),
                        TypeCode = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Classification Type Code (i.e. CV, BB, DD, etc.).")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "United States Navy Ship Classification Types." },
                })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Ships",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Command = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Command to which this Ship is currently assigned.")
                                },
                            }),
                        DateCommissioned = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date this Ship was [last] commissioned.")
                                },
                            }),
                        History = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "History of this Ship.")
                                },
                            }),
                        HullNumber = c.String(maxLength: 12,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Designation of this Ship (i.e. Classification Type Code + Number).")
                                },
                            }),
                        HomePort = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current Home Port of this Ship.")
                                },
                            }),
                        InternetURL = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Public Internet Web Site of this Ship.")
                                },
                            }),
                        LocalURL = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Ken's Local intranet web site of this Ship.")
                                },
                            }),
                        Number = c.Double(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Designation number of this Ship (for sorting).")
                                },
                            }),
                        Status = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current Status of this Ship.")
                                },
                            }),
                        ZipCode = c.String(maxLength: 18,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current Zip Code for snail-mail to the crew of this Ship.")
                                },
                            }),
                        Aircraft = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Aircraft typically deployed with this Ship/Class.")
                                },
                            }),
                        ASWWeapons = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Anti-Submarine-Warfare (ASW) weapon capability of this Ship/Class.")
                                },
                            }),
                        Beam = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Beam (width) of this Ship/Class.")
                                },
                            }),
                        Boilers = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Boilers typically outfitted for this Ship/Class.")
                                },
                            }),
                        Description = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "General Description of this Ship/Class.")
                                },
                            }),
                        Displacement = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Displacement of this Ship/Class.")
                                },
                            }),
                        Draft = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Draft of this Ship/Class.")
                                },
                            }),
                        EW = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Electronic Warfare (EW) capability of this Ship/Class.")
                                },
                            }),
                        FireControl = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "FireControl capability of this Ship/Class.")
                                },
                            }),
                        Guns = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Gun armament of this Ship/Class.")
                                },
                            }),
                        Length = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Length of this Ship/Class.")
                                },
                            }),
                        Manning = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Crew compliment of this Ship/Class.")
                                },
                            }),
                        Missiles = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Missile armament of this Ship/Class.")
                                },
                            }),
                        Name = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Name of this Ship/Class.")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous Notes.")
                                },
                            }),
                        Propulsion = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Propulsion system of this Ship/Class.")
                                },
                            }),
                        Radars = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "RADAR capability of this Ship/Class.")
                                },
                            }),
                        Speed = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Speed of this Ship/Class.")
                                },
                            }),
                        Sonars = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "SONAR capability of this Ship/Class.")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        ShipClassificationType_ID = c.Int(),
                        ShipClass_ID = c.Int(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "United States Navy Ships." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ShipClassificationTypes", t => t.ShipClassificationType_ID)
                .ForeignKey("dbo.ShipClass", t => t.ShipClass_ID)
                .Index(t => t.ShipClassificationType_ID)
                .Index(t => t.ShipClass_ID);
            
            CreateTable(
                "dbo.Software",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        AlphaSort = c.String(nullable: false, maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Sort string.")
                                },
                            }),
                        CDkey = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "License key (if applicable).")
                                },
                            }),
                        DateReleased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the software was originally released (if known).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Developer = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Company who developed the Software.")
                                },
                            }),
                        ISBN = c.String(maxLength: 24,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "International Standard Book Number (if known).")
                                },
                            }),
                        MediaFormat = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Distribution Media (i.e. CD, DVD, Digital Download, etc.).")
                                },
                                { 
                                    "MinLength",
                                    new AnnotationValues(oldValue: null, newValue: "1")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "'Unspecified'")
                                },
                            }),
                        Platform = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Operating System (O/S) or hardware Platform.")
                                },
                            }),
                        Publisher = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Company who published the Software.")
                                },
                            }),
                        Title = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Software Title.")
                                },
                            }),
                        Type = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Type of Software (i.e. Game, Development IDE, etc.).")
                                },
                            }),
                        Version = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Software version number (if known).")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Library of Software, ranging from floppy discs, to CD/DVD to electronic media." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.AlphaSort, unique: true, name: "IX_SoftwareByAlphaSort")
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.Specials",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        AlphaSort = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Sort string.")
                                },
                            }),
                        Distributor = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Distributor of this title.")
                                },
                            }),
                        MediaFormat = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Media/Format of this title (i.e. VHS, DVD, Blu-Ray, MP4, etc.).")
                                },
                                { 
                                    "MinLength",
                                    new AnnotationValues(oldValue: null, newValue: "1")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "'Unspecified'")
                                },
                            }),
                        DateReleased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the title was originally released (if known).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        StoreBought = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Was this title purchased as opposed to recorded or ripped from the library? (TODO: Move into MediaFormat)")
                                },
                            }),
                        Subject = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Subject of this title (i.e. Comedy, Drama, etc.).")
                                },
                            }),
                        Title = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Title of this Special.")
                                },
                            }),
                        WMV = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this title been ripped to digital format? (TODO: Move into MediaFormat)")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Video Specials Library" },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.Tools",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Manufacturer = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Manufacturer of the Tool.")
                                },
                            }),
                        Name = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Name of the Tool.")
                                },
                            }),
                        ProductCatalog = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Vendor where the Tool was purchased (or priced).")
                                },
                            }),
                        Reference = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Reference number/code identifying the Tool.")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Tools." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.Location_ID);
            
            CreateTable(
                "dbo.Trains",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Unique system-generated identifier.")
                                },
                            }),
                        Line = c.String(maxLength: 72,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Railroad line of this particular item")
                                },
                            }),
                        Manufacturer = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Manufacturer of the item.")
                                },
                            }),
                        Name = c.String(maxLength: 132,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Name of this particular item")
                                },
                            }),
                        ProductCatalog = c.String(maxLength: 80,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Vendor where the item was purchased (or priced).")
                                },
                            }),
                        Reference = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Reference number/code identifying the item.")
                                },
                            }),
                        Scale = c.String(maxLength: 12,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Reference number/code identifying the item.")
                                },
                            }),
                        Type = c.String(maxLength: 32,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Type of the item (i.e. Trains, Locomotives, Rolling Stock, etc.).")
                                },
                            }),
                        Cataloged = c.Boolean(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Has this item been catalogued? (as oppsed to representing something not actually owned)")
                                },
                            }),
                        DateInventoried = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last inventoried (location confirmed).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DatePurchased = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was purchased (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateVerified = c.DateTime(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the value of the item was confirmed/updated (null means unknown).")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Notes = c.String(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Miscellaneous notes regarding the item.")
                                },
                            }),
                        Price = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Purchase price of the item.")
                                },
                            }),
                        Value = c.Decimal(storeType: "money",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Current value of the item.")
                                },
                            }),
                        WishList = c.Boolean(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Is this a WishList item?")
                                },
                            }),
                        OID = c.Int(
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Pre-conversion unique system-generated identifier.")
                                },
                            }),
                        RowID = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion",
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "System-managed concurrency control field.")
                                },
                            }),
                        DateCreated = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was added to the database.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        DateModified = c.DateTime(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "ColumnDescription",
                                    new AnnotationValues(oldValue: null, newValue: "Date the item was last modified.")
                                },
                                { 
                                    "SqlDefaultValue",
                                    new AnnotationValues(oldValue: null, newValue: "getdate()")
                                },
                            }),
                        Location_ID = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Trains/Locomotives/Rolling Stock." },
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.Location_ID, cascadeDelete: true)
                .Index(t => t.Location_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trains", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Tools", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Specials", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Software", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Ships", "ShipClass_ID", "dbo.ShipClass");
            DropForeignKey("dbo.Ships", "ShipClassificationType_ID", "dbo.ShipClassificationTypes");
            DropForeignKey("dbo.ShipClass", "ShipClassificationType_ID", "dbo.ShipClassificationTypes");
            DropForeignKey("dbo.Rockets", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Music", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Movies", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Images", "ThumbnailImage_ID", "dbo.Images");
            DropForeignKey("dbo.FinishingProducts", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Episodes", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Decals", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Kits", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.DetailSets", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Kits", "DetailSet_ID", "dbo.DetailSets");
            DropForeignKey("dbo.Kits", "Decal_ID", "dbo.Decals");
            DropForeignKey("dbo.Collectables", "Location_ID", "dbo.Locations");
            DropForeignKey("dbo.Books", "Location_ID", "dbo.Locations");
            DropIndex("dbo.Trains", new[] { "Location_ID" });
            DropIndex("dbo.Tools", new[] { "Location_ID" });
            DropIndex("dbo.Specials", new[] { "Location_ID" });
            DropIndex("dbo.Software", new[] { "Location_ID" });
            DropIndex("dbo.Software", "IX_SoftwareByAlphaSort");
            DropIndex("dbo.Ships", new[] { "ShipClass_ID" });
            DropIndex("dbo.Ships", new[] { "ShipClassificationType_ID" });
            DropIndex("dbo.ShipClass", new[] { "ShipClassificationType_ID" });
            DropIndex("dbo.Rockets", new[] { "Location_ID" });
            DropIndex("dbo.Music", new[] { "Location_ID" });
            DropIndex("dbo.Movies", new[] { "Location_ID" });
            DropIndex("dbo.Images", new[] { "ThumbnailImage_ID" });
            DropIndex("dbo.Images", "IX_ImageByRecord");
            DropIndex("dbo.History", "IX_HistoryByRecord");
            DropIndex("dbo.History", "IX_HistoryByDate");
            DropIndex("dbo.FinishingProducts", new[] { "Location_ID" });
            DropIndex("dbo.Episodes", new[] { "Location_ID" });
            DropIndex("dbo.DetailSets", new[] { "Location_ID" });
            DropIndex("dbo.Kits", new[] { "Location_ID" });
            DropIndex("dbo.Kits", new[] { "DetailSet_ID" });
            DropIndex("dbo.Kits", new[] { "Decal_ID" });
            DropIndex("dbo.Decals", new[] { "Location_ID" });
            DropIndex("dbo.Collectables", new[] { "Location_ID" });
            DropIndex("dbo.Books", new[] { "Location_ID" });
            DropTable("dbo.Trains",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Trains/Locomotives/Rolling Stock." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Line",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Railroad line of this particular item" },
                        }
                    },
                    {
                        "Manufacturer",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Manufacturer of the item." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Name of this particular item" },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "ProductCatalog",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Vendor where the item was purchased (or priced)." },
                        }
                    },
                    {
                        "Reference",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Reference number/code identifying the item." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Scale",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Reference number/code identifying the item." },
                        }
                    },
                    {
                        "Type",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Type of the item (i.e. Trains, Locomotives, Rolling Stock, etc.)." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                });
            DropTable("dbo.Tools",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Tools." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Manufacturer",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Manufacturer of the Tool." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Name of the Tool." },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "ProductCatalog",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Vendor where the Tool was purchased (or priced)." },
                        }
                    },
                    {
                        "Reference",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Reference number/code identifying the Tool." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                });
            DropTable("dbo.Specials",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Video Specials Library" },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "AlphaSort",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Sort string." },
                        }
                    },
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateReleased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the title was originally released (if known)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Distributor",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Distributor of this title." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "MediaFormat",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Media/Format of this title (i.e. VHS, DVD, Blu-Ray, MP4, etc.)." },
                            { "MinLength", "1" },
                            { "SqlDefaultValue", "'Unspecified'" },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "StoreBought",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Was this title purchased as opposed to recorded or ripped from the library? (TODO: Move into MediaFormat)" },
                        }
                    },
                    {
                        "Subject",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Subject of this title (i.e. Comedy, Drama, etc.)." },
                        }
                    },
                    {
                        "Title",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Title of this Special." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                    {
                        "WMV",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this title been ripped to digital format? (TODO: Move into MediaFormat)" },
                        }
                    },
                });
            DropTable("dbo.Software",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Library of Software, ranging from floppy discs, to CD/DVD to electronic media." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "AlphaSort",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Sort string." },
                        }
                    },
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "CDkey",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "License key (if applicable)." },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateReleased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the software was originally released (if known)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Developer",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Company who developed the Software." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "ISBN",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "International Standard Book Number (if known)." },
                        }
                    },
                    {
                        "MediaFormat",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Distribution Media (i.e. CD, DVD, Digital Download, etc.)." },
                            { "MinLength", "1" },
                            { "SqlDefaultValue", "'Unspecified'" },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Platform",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Operating System (O/S) or hardware Platform." },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "Publisher",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Company who published the Software." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Title",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Software Title." },
                        }
                    },
                    {
                        "Type",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Type of Software (i.e. Game, Development IDE, etc.)." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "Version",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Software version number (if known)." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                });
            DropTable("dbo.Ships",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "United States Navy Ships." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Aircraft",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Aircraft typically deployed with this Ship/Class." },
                        }
                    },
                    {
                        "ASWWeapons",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Anti-Submarine-Warfare (ASW) weapon capability of this Ship/Class." },
                        }
                    },
                    {
                        "Beam",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Beam (width) of this Ship/Class." },
                        }
                    },
                    {
                        "Boilers",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Boilers typically outfitted for this Ship/Class." },
                        }
                    },
                    {
                        "Command",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Command to which this Ship is currently assigned." },
                        }
                    },
                    {
                        "DateCommissioned",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date this Ship was [last] commissioned." },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Description",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "General Description of this Ship/Class." },
                        }
                    },
                    {
                        "Displacement",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Displacement of this Ship/Class." },
                        }
                    },
                    {
                        "Draft",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Draft of this Ship/Class." },
                        }
                    },
                    {
                        "EW",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Electronic Warfare (EW) capability of this Ship/Class." },
                        }
                    },
                    {
                        "FireControl",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "FireControl capability of this Ship/Class." },
                        }
                    },
                    {
                        "Guns",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Gun armament of this Ship/Class." },
                        }
                    },
                    {
                        "History",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "History of this Ship." },
                        }
                    },
                    {
                        "HomePort",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current Home Port of this Ship." },
                        }
                    },
                    {
                        "HullNumber",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Designation of this Ship (i.e. Classification Type Code + Number)." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "InternetURL",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Public Internet Web Site of this Ship." },
                        }
                    },
                    {
                        "Length",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Length of this Ship/Class." },
                        }
                    },
                    {
                        "LocalURL",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Ken's Local intranet web site of this Ship." },
                        }
                    },
                    {
                        "Manning",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Crew compliment of this Ship/Class." },
                        }
                    },
                    {
                        "Missiles",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Missile armament of this Ship/Class." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Name of this Ship/Class." },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous Notes." },
                        }
                    },
                    {
                        "Number",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Designation number of this Ship (for sorting)." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Propulsion",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Propulsion system of this Ship/Class." },
                        }
                    },
                    {
                        "Radars",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "RADAR capability of this Ship/Class." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Sonars",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "SONAR capability of this Ship/Class." },
                        }
                    },
                    {
                        "Speed",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Speed of this Ship/Class." },
                        }
                    },
                    {
                        "Status",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current Status of this Ship." },
                        }
                    },
                    {
                        "ZipCode",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current Zip Code for snail-mail to the crew of this Ship." },
                        }
                    },
                });
            DropTable("dbo.ShipClassificationTypes",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "United States Navy Ship Classification Types." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Description",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Classification Type Description (i.e. Aircraft Carrier, Battleship, Destroyer, etc.)." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "TypeCode",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Classification Type Code (i.e. CV, BB, DD, etc.)." },
                        }
                    },
                });
            DropTable("dbo.ShipClass",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "United States Navy Ship Classes." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Aircraft",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Aircraft typically deployed with this Ship/Class." },
                        }
                    },
                    {
                        "ASWWeapons",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Anti-Submarine-Warfare (ASW) weapon capability of this Ship/Class." },
                        }
                    },
                    {
                        "Beam",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Beam (width) of this Ship/Class." },
                        }
                    },
                    {
                        "Boilers",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Boilers typically outfitted for this Ship/Class." },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Description",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "General Description of this Ship/Class." },
                        }
                    },
                    {
                        "Displacement",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Displacement of this Ship/Class." },
                        }
                    },
                    {
                        "Draft",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Draft of this Ship/Class." },
                        }
                    },
                    {
                        "EW",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Electronic Warfare (EW) capability of this Ship/Class." },
                        }
                    },
                    {
                        "FireControl",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "FireControl capability of this Ship/Class." },
                        }
                    },
                    {
                        "Guns",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Gun armament of this Ship/Class." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Length",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Length of this Ship/Class." },
                        }
                    },
                    {
                        "Manning",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Crew compliment of this Ship/Class." },
                        }
                    },
                    {
                        "Missiles",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Missile armament of this Ship/Class." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Name of this Ship/Class." },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous Notes." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Propulsion",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Propulsion system of this Ship/Class." },
                        }
                    },
                    {
                        "Radars",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "RADAR capability of this Ship/Class." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Sonars",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "SONAR capability of this Ship/Class." },
                        }
                    },
                    {
                        "Speed",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Speed of this Ship/Class." },
                        }
                    },
                    {
                        "Year",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Year this Class was designed." },
                        }
                    },
                });
            DropTable("dbo.Rockets",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Rockets." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Designation",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Designation of the Rocket (i.e. Saturn-V, etc.)." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Manufacturer",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Manufacturer of the Rocket." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Name of the Rocket." },
                        }
                    },
                    {
                        "Nation",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Nationality of the Rocket." },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "ProductCatalog",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Vendor where the Rocket was purchased (or priced)." },
                        }
                    },
                    {
                        "Reference",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Reference number/code identifying the Rocket." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Scale",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Scale of Rocket." },
                        }
                    },
                    {
                        "Type",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Type of Rocket." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                });
            DropTable("dbo.Query",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Canned queries which can be run within the application." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Access",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Query Access." },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Description",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Query Description." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Query Name." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "QueryText",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Query body." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                });
            DropTable("dbo.Music",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Library of Music, including physical and electronic media." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "AlphaSort",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Sort string." },
                        }
                    },
                    {
                        "Artist",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Artist of the album." },
                        }
                    },
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "MediaFormat",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Media/Format of this album (i.e. LP, CD, MP3, etc.)." },
                            { "MinLength", "1" },
                            { "SqlDefaultValue", "'Unspecified'" },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Title",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Album title." },
                        }
                    },
                    {
                        "Type",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Genre of this title." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                    {
                        "Year",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Year this album was originally released." },
                        }
                    },
                });
            DropTable("dbo.Movies",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Movie Library" },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "AlphaSort",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Sort string." },
                        }
                    },
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateReleased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the title was originally released (if known)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Distributor",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Distributor of this title." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "MediaFormat",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Media/Format of this title (i.e. VHS, DVD, Blu-Ray, MP4, etc.)." },
                            { "MinLength", "1" },
                            { "SqlDefaultValue", "'Unspecified'" },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "StoreBought",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Was this title purchased as opposed to recorded or ripped from the library? (TODO: Move into MediaFormat)" },
                        }
                    },
                    {
                        "Subject",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Subject of this title (i.e. Comedy, Drama, etc.)." },
                        }
                    },
                    {
                        "Title",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Title of this Movie." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                    {
                        "WMV",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this title been ripped to digital format? (TODO: Move into MediaFormat)" },
                        }
                    },
                });
            DropTable("dbo.Images",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Images both independent and those representing items tracked in the database." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "AlphaSort",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Sort string." },
                        }
                    },
                    {
                        "Caption",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Image Caption." },
                        }
                    },
                    {
                        "Category",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Category of this Image." },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "FileName",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "File system object from which this Image was imported." },
                        }
                    },
                    {
                        "Height",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Height in pixels of this Image." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Image",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Actual Image binary." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Image Name." },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous Notes." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "RecordID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Record ID of the record related to this image." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "TableName",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Table of the record related to this image." },
                        }
                    },
                    {
                        "Thumbnail",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Does this image represent the thumbnail of another, main image?" },
                        }
                    },
                    {
                        "URL",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Internel web site providing this Image (if applicable)." },
                        }
                    },
                    {
                        "Width",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Width in pixels of this Image." },
                        }
                    },
                });
            DropTable("dbo.History",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "History of changes applied by the application." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Column",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Column changed." },
                        }
                    },
                    {
                        "DateChanged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date of this change." },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "OriginalValue",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Original (changed from) value." },
                        }
                    },
                    {
                        "RecordID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Record changed." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "TableName",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Table changed." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "New (changed to) value." },
                        }
                    },
                    {
                        "Who",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "User ID affecting this change." },
                        }
                    },
                });
            DropTable("dbo.FinishingProducts",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Inventory of Finishing Products (i.e. Paint, Brushes, etc.)." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "Count",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Count of this item." },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Manufacturer",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Manufacturer of the item." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Name of the item." },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "ProductCatalog",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Vendor where the item was purchased (or priced)." },
                        }
                    },
                    {
                        "Reference",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Reference number/code identifying the item." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Type",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Type of the item (i.e. Paint, Brush, Sanding Stick, etc.)." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                });
            DropTable("dbo.Episodes",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "TV Episode Library" },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateReleased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the title was originally released (if known)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Distributor",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Distributor of this title." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "MediaFormat",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Media/Format of this title (i.e. VHS, DVD, Blu-Ray, MP4, etc.)." },
                            { "MinLength", "1" },
                            { "SqlDefaultValue", "'Unspecified'" },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "Number",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Episode number." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Series",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Name of this TV Series." },
                        }
                    },
                    {
                        "StoreBought",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Was this episode/set purchased as opposed to recorded or ripped from the library? (TODO: Move into MediaFormat)" },
                        }
                    },
                    {
                        "Subject",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Subject of this title (i.e. Comedy, Drama, etc.)." },
                        }
                    },
                    {
                        "Taped",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Was this episode/set taped? (TODO: Move into MediaFormat)" },
                        }
                    },
                    {
                        "Title",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Title of this episode/set." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                    {
                        "WMV",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this episode/set been ripped to digital format? (TODO: Move into MediaFormat)" },
                        }
                    },
                });
            DropTable("dbo.DetailSets",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Detail Sets." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Designation",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Designation of the corresponding model kit (i.e. F-14A, BB-63, etc.) used to display possible applications of the particular Detail Set." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Manufacturer",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Manufacturer of the Detail Set." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Name of the Detail Set." },
                        }
                    },
                    {
                        "Nation",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Nationality of the Detail Set." },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "ProductCatalog",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Vendor where the Detail Set was purchased (or priced)." },
                        }
                    },
                    {
                        "Reference",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Reference number/code identifying the Detail Set." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Scale",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Scale of Detail Set." },
                        }
                    },
                    {
                        "Type",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Type of Detail Set (i.e. Aircraft, Ship, etc.)." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                });
            DropTable("dbo.Kits",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Model Kits." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "Condition",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Condition of the Model Kit (i.e. Built, Opened, etc.)." },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Designation",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Designation of the Model Kit (i.e. F-14A, BB-63, etc.)." },
                        }
                    },
                    {
                        "Era",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Era the prototype of the Model Kit served (i.e. WWII, Vietnam, etc.)." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Manufacturer",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Manufacturer of the Model Kit." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Name of the Model Kit." },
                        }
                    },
                    {
                        "Nation",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Nationality of the Model Kit." },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "OutOfProduction",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is the item out-of-production?" },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "ProductCatalog",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Vendor where the Model Kit was purchased (or priced)." },
                        }
                    },
                    {
                        "Reference",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Reference number/code identifying the Model Kit." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Scale",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Scale of Model Kit." },
                        }
                    },
                    {
                        "Service",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Service the prototype of the Model Kit served (i.e. USN, USMC, USAAF, etc.)." },
                        }
                    },
                    {
                        "Type",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Type of Model Kit (i.e. Aircraft, Ship, etc.)." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                });
            DropTable("dbo.Decals",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Decals." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Designation",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Designation of the corresponding Model Kit (i.e. F-14A, BB-63, etc.) used to display possible applications of the particular Decal." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Manufacturer",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Manufacturer of the Decal." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Name of the Decal." },
                        }
                    },
                    {
                        "Nation",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Nationality of the Decal." },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "ProductCatalog",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Vendor where the Decal was purchased (or priced)." },
                        }
                    },
                    {
                        "Reference",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Reference number/code identifying the Decal." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Scale",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Scale of Decal." },
                        }
                    },
                    {
                        "Type",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Type of Decal (i.e. Aircraft, Ship, etc.)." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                });
            DropTable("dbo.Companies",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Hobby supply company address book." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Account",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Account number for ordering from this company." },
                        }
                    },
                    {
                        "Address",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Company mailing address." },
                        }
                    },
                    {
                        "Code",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Company code." },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Full Company Name." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Phone",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Company phone number." },
                        }
                    },
                    {
                        "ProductType",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Type of hobby products supplied by this company." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "ShortName",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Company Short Name." },
                        }
                    },
                    {
                        "WebSite",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Company web site." },
                        }
                    },
                });
            DropTable("dbo.Collectables",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Collection of Collectables, ranging from baseball cards, to Hot Wheels to Keepsake Ornaments." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "Condition",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Condition of the item (i.e. Packaged, Opened, etc.)." },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Manufacturer",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Manufacturer of the item." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Name of the item." },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "OutOfProduction",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is the item out-of-production?" },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "Reference",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Reference number/code identifying the item." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Series",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Series of the item." },
                        }
                    },
                    {
                        "Type",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Type of collectable (i.e. baseball card, board game, Hot Wheel, etc.)." },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                });
            DropTable("dbo.Locations",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Location of catalogued items." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Description",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Description of box/container (if applicable)." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Name of location." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "PhysicalLocation",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Physical location of the box/container represented by this Location." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                });
            DropTable("dbo.Books",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Library of Books, Magazines, and electronic media." },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "AlphaSort",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Sort string." },
                            { "MinLength", "1" },
                        }
                    },
                    {
                        "Author",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Author of the publication." },
                            { "MinLength", "1" },
                        }
                    },
                    {
                        "Cataloged",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Has this item been catalogued? (as oppsed to representing something not actually owned)" },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateInventoried",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last inventoried (location confirmed)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DatePurchased",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was purchased (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateVerified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the value of the item was confirmed/updated (null means unknown)." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "ISBN",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "International Standard Book Number." },
                        }
                    },
                    {
                        "MediaFormat",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Media/Format of the publication (i.e. Hardcover, Paperback, etc)." },
                            { "MinLength", "1" },
                            { "SqlDefaultValue", "'Unspecified'" },
                        }
                    },
                    {
                        "Misc",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous information." },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous notes regarding the item." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "Price",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Purchase price of the item." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "Subject",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Subject of the publication." },
                            { "MinLength", "1" },
                        }
                    },
                    {
                        "Title",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Title of the publication." },
                            { "MinLength", "1" },
                        }
                    },
                    {
                        "Value",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Current value of the item." },
                        }
                    },
                    {
                        "WishList",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Is this a WishList item?" },
                        }
                    },
                });
            DropTable("dbo.BlueAngelsHistory",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "AircraftType",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Aircraft Type serving with the Blue Angels." },
                        }
                    },
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous Notes." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "ServiceDates",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Dates this aircraft served with the Blue Angels." },
                        }
                    },
                });
            DropTable("dbo.AircraftDesignations",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "TableDescription", "Aircraft Designations" },
                },
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "DateCreated",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was added to the database." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "DateModified",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date the item was last modified." },
                            { "SqlDefaultValue", "getdate()" },
                        }
                    },
                    {
                        "Designation",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Official Designationof this aircraft." },
                        }
                    },
                    {
                        "ID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unique system-generated identifier." },
                        }
                    },
                    {
                        "Manufacturer",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Manufacturer of this aircraft." },
                        }
                    },
                    {
                        "Name",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Official Name of this aircraft." },
                        }
                    },
                    {
                        "Nicknames",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Unofficial Nicknames of this aircraft." },
                        }
                    },
                    {
                        "Notes",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Miscellaneous Notes." },
                        }
                    },
                    {
                        "Number",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Designation number of this aircraft (for sorting)." },
                        }
                    },
                    {
                        "OID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Pre-conversion unique system-generated identifier." },
                        }
                    },
                    {
                        "RowID",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "System-managed concurrency control field." },
                        }
                    },
                    {
                        "ServiceDate",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Date this aircraft entered service." },
                        }
                    },
                    {
                        "Type",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Type of this aircraft (i.e. Fighter, Bomber, etc.)." },
                        }
                    },
                    {
                        "Version",
                        new Dictionary<string, object>
                        {
                            { "ColumnDescription", "Version of this aircraft." },
                        }
                    },
                });
        }
    }
}
