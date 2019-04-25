using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TC3Core.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            #region Create Tables
            migrationBuilder.CreateTable(
                name: "AircraftDesignations",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Designation = table.Column<string>(maxLength: 32, nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 72, nullable: true),
                    Name = table.Column<string>(maxLength: 72, nullable: true),
                    Nicknames = table.Column<string>(maxLength: 80, nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Number = table.Column<double>(nullable: true),
                    ServiceDate = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(maxLength: 32, nullable: true),
                    Version = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftDesignations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BlueAngelsHistory",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    ServiceDates = table.Column<string>(maxLength: 80, nullable: true),
                    AircraftType = table.Column<string>(maxLength: 80, nullable: true),
                    Decals = table.Column<string>(nullable: true),
                    DecalSets = table.Column<string>(nullable: true),
                    Kits = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueAngelsHistory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Account = table.Column<string>(maxLength: 32, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Code = table.Column<string>(maxLength: 32, nullable: true),
                    Name = table.Column<string>(maxLength: 72, nullable: true),
                    Phone = table.Column<string>(maxLength: 14, nullable: true),
                    ProductType = table.Column<string>(maxLength: 32, nullable: true),
                    ShortName = table.Column<string>(maxLength: 32, nullable: true),
                    WebSite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Column = table.Column<string>(maxLength: 32, nullable: true),
                    DateChanged = table.Column<DateTime>(nullable: false),
                    OriginalValue = table.Column<string>(nullable: true),
                    RecordID = table.Column<Guid>(nullable: false),
                    TableName = table.Column<string>(maxLength: 32, nullable: false),
                    Value = table.Column<string>(nullable: true),
                    Who = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    Image = table.Column<byte[]>(type: "image", nullable: true),
                    FileName = table.Column<string>(maxLength: 80, nullable: true),
                    URL = table.Column<string>(maxLength: 132, nullable: true),
                    Height = table.Column<int>(nullable: true),
                    Width = table.Column<int>(nullable: true),
                    Category = table.Column<string>(maxLength: 80, nullable: true),
                    AlphaSort = table.Column<string>(maxLength: 256, nullable: true),
                    TableName = table.Column<string>(maxLength: 32, nullable: true),
                    RecordID = table.Column<Guid>(nullable: true),
                    Thumbnail = table.Column<bool>(nullable: false),
                    ThumbnailImage = table.Column<byte[]>(type: "image", nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 1024, nullable: true),
                    Name = table.Column<string>(maxLength: 1024, nullable: true),
                    PhysicalLocation = table.Column<string>(maxLength: 1024, nullable: true),
                    OName = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Query",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    QueryText = table.Column<string>(nullable: true),
                    Access = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Query", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShipClassTypes",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 80, nullable: true),
                    TypeCode = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipClassTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    AlphaSort = table.Column<string>(maxLength: 80, nullable: false),
                    Author = table.Column<string>(maxLength: 80, nullable: false),
                    MediaFormat = table.Column<string>(maxLength: 80, nullable: true),
                    ISBN = table.Column<string>(maxLength: 24, nullable: true),
                    Misc = table.Column<string>(maxLength: 32, nullable: true),
                    Subject = table.Column<string>(maxLength: 80, nullable: false),
                    Title = table.Column<string>(maxLength: 132, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Books_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Collectables",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    Condition = table.Column<string>(maxLength: 80, nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 80, nullable: true),
                    Name = table.Column<string>(maxLength: 132, nullable: true),
                    OutOfProduction = table.Column<bool>(nullable: false),
                    Reference = table.Column<string>(maxLength: 32, nullable: true),
                    Series = table.Column<string>(maxLength: 80, nullable: true),
                    Type = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collectables", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Collectables_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Decals",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 132, nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    ProductCatalog = table.Column<string>(maxLength: 132, nullable: true),
                    Reference = table.Column<string>(maxLength: 132, nullable: true),
                    Type = table.Column<string>(maxLength: 132, nullable: true),
                    Designation = table.Column<string>(maxLength: 132, nullable: true),
                    Nation = table.Column<string>(maxLength: 132, nullable: true),
                    Scale = table.Column<string>(maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Decals_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailSets",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 132, nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    ProductCatalog = table.Column<string>(maxLength: 132, nullable: true),
                    Reference = table.Column<string>(maxLength: 132, nullable: true),
                    Type = table.Column<string>(maxLength: 132, nullable: true),
                    Designation = table.Column<string>(maxLength: 132, nullable: true),
                    Nation = table.Column<string>(maxLength: 132, nullable: true),
                    Scale = table.Column<string>(maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailSets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DetailSets_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    Distributor = table.Column<string>(maxLength: 80, nullable: true),
                    MediaFormat = table.Column<string>(maxLength: 80, nullable: true),
                    DateReleased = table.Column<DateTime>(nullable: true),
                    StoreBought = table.Column<bool>(nullable: true),
                    Subject = table.Column<string>(maxLength: 80, nullable: true),
                    Title = table.Column<string>(maxLength: 80, nullable: true),
                    WMV = table.Column<bool>(nullable: true),
                    Taped = table.Column<bool>(nullable: true),
                    SourceTable = table.Column<string>(maxLength: 80, nullable: true),
                    Series = table.Column<string>(maxLength: 80, nullable: true),
                    Number = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Episodes_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinishingProducts",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 132, nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    ProductCatalog = table.Column<string>(maxLength: 132, nullable: true),
                    Reference = table.Column<string>(maxLength: 132, nullable: true),
                    Type = table.Column<string>(maxLength: 132, nullable: true),
                    Count = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishingProducts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FinishingProducts_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Music",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    Artist = table.Column<string>(maxLength: 80, nullable: true),
                    AlphaSort = table.Column<string>(maxLength: 80, nullable: true),
                    MediaFormat = table.Column<string>(maxLength: 80, nullable: true),
                    Title = table.Column<string>(maxLength: 80, nullable: true),
                    Type = table.Column<string>(maxLength: 80, nullable: true),
                    Year = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Music", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Music_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rockets",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 132, nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    ProductCatalog = table.Column<string>(maxLength: 132, nullable: true),
                    Reference = table.Column<string>(maxLength: 132, nullable: true),
                    Type = table.Column<string>(maxLength: 132, nullable: true),
                    Designation = table.Column<string>(maxLength: 132, nullable: true),
                    Nation = table.Column<string>(maxLength: 132, nullable: true),
                    Scale = table.Column<string>(maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rockets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rockets_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Software",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    AlphaSort = table.Column<string>(maxLength: 132, nullable: false),
                    CDkey = table.Column<string>(maxLength: 80, nullable: true),
                    DateReleased = table.Column<DateTime>(nullable: true),
                    Developer = table.Column<string>(maxLength: 80, nullable: true),
                    ISBN = table.Column<string>(maxLength: 24, nullable: true),
                    MediaFormat = table.Column<string>(maxLength: 80, nullable: true),
                    Platform = table.Column<string>(maxLength: 32, nullable: true),
                    Publisher = table.Column<string>(maxLength: 80, nullable: true),
                    Title = table.Column<string>(maxLength: 80, nullable: true),
                    Type = table.Column<string>(maxLength: 32, nullable: true),
                    Version = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Software", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Software_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tools",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 132, nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    ProductCatalog = table.Column<string>(maxLength: 132, nullable: true),
                    Reference = table.Column<string>(maxLength: 132, nullable: true),
                    Type = table.Column<string>(maxLength: 132, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tools_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trains",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 132, nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    ProductCatalog = table.Column<string>(maxLength: 132, nullable: true),
                    Reference = table.Column<string>(maxLength: 132, nullable: true),
                    Type = table.Column<string>(maxLength: 132, nullable: true),
                    Line = table.Column<string>(maxLength: 72, nullable: true),
                    Scale = table.Column<string>(maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trains", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Trains_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    Distributor = table.Column<string>(maxLength: 80, nullable: true),
                    MediaFormat = table.Column<string>(maxLength: 80, nullable: true),
                    DateReleased = table.Column<DateTime>(nullable: true),
                    StoreBought = table.Column<bool>(nullable: true),
                    Subject = table.Column<string>(maxLength: 80, nullable: true),
                    Title = table.Column<string>(maxLength: 80, nullable: true),
                    WMV = table.Column<bool>(nullable: true),
                    Taped = table.Column<bool>(nullable: true),
                    SourceTable = table.Column<string>(maxLength: 80, nullable: true),
                    AlphaSort = table.Column<string>(maxLength: 132, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Videos_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShipClass",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Aircraft = table.Column<string>(nullable: true),
                    ASWWeapons = table.Column<string>(nullable: true),
                    Beam = table.Column<string>(nullable: true),
                    Boilers = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Displacement = table.Column<string>(nullable: true),
                    Draft = table.Column<string>(nullable: true),
                    EW = table.Column<string>(nullable: true),
                    FireControl = table.Column<string>(nullable: true),
                    Guns = table.Column<string>(nullable: true),
                    Length = table.Column<string>(nullable: true),
                    Manning = table.Column<string>(nullable: true),
                    Missiles = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 80, nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Propulsion = table.Column<string>(nullable: true),
                    Radars = table.Column<string>(nullable: true),
                    Speed = table.Column<string>(maxLength: 132, nullable: true),
                    Sonars = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: true),
                    ShipClassTypeID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipClass", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShipClass_ShipClassTypes_ShipClassTypeID",
                        column: x => x.ShipClassTypeID,
                        principalTable: "ShipClassTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kits",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<Guid>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 132, nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    ProductCatalog = table.Column<string>(maxLength: 132, nullable: true),
                    Reference = table.Column<string>(maxLength: 132, nullable: true),
                    Type = table.Column<string>(maxLength: 132, nullable: true),
                    Designation = table.Column<string>(maxLength: 132, nullable: true),
                    Nation = table.Column<string>(maxLength: 132, nullable: true),
                    Scale = table.Column<string>(maxLength: 12, nullable: true),
                    DecalID = table.Column<Guid>(nullable: true),
                    DetailSetID = table.Column<Guid>(nullable: true),
                    Condition = table.Column<string>(maxLength: 132, nullable: true),
                    Era = table.Column<string>(maxLength: 80, nullable: true),
                    OutOfProduction = table.Column<bool>(nullable: false),
                    Service = table.Column<string>(maxLength: 132, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Kits_Decals_DecalID",
                        column: x => x.DecalID,
                        principalTable: "Decals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kits_DetailSets_DetailSetID",
                        column: x => x.DetailSetID,
                        principalTable: "DetailSets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kits_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ships",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    OID = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Aircraft = table.Column<string>(nullable: true),
                    ASWWeapons = table.Column<string>(nullable: true),
                    Beam = table.Column<string>(nullable: true),
                    Boilers = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Displacement = table.Column<string>(nullable: true),
                    Draft = table.Column<string>(nullable: true),
                    EW = table.Column<string>(nullable: true),
                    FireControl = table.Column<string>(nullable: true),
                    Guns = table.Column<string>(nullable: true),
                    Length = table.Column<string>(nullable: true),
                    Manning = table.Column<string>(nullable: true),
                    Missiles = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 80, nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Propulsion = table.Column<string>(nullable: true),
                    Radars = table.Column<string>(nullable: true),
                    Speed = table.Column<string>(maxLength: 132, nullable: true),
                    Sonars = table.Column<string>(nullable: true),
                    Command = table.Column<string>(maxLength: 80, nullable: true),
                    DateCommissioned = table.Column<DateTime>(nullable: true),
                    History = table.Column<string>(nullable: true),
                    HullNumber = table.Column<string>(maxLength: 12, nullable: true),
                    HomePort = table.Column<string>(maxLength: 80, nullable: true),
                    InternetURL = table.Column<string>(maxLength: 132, nullable: true),
                    LocalURL = table.Column<string>(maxLength: 132, nullable: true),
                    Number = table.Column<double>(nullable: true),
                    Status = table.Column<string>(maxLength: 80, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 18, nullable: true),
                    ShipClassID = table.Column<Guid>(nullable: true),
                    ShipClassTypeID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ships", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ships_ShipClass_ShipClassID",
                        column: x => x.ShipClassID,
                        principalTable: "ShipClass",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ships_ShipClassTypes_ShipClassTypeID",
                        column: x => x.ShipClassTypeID,
                        principalTable: "ShipClassTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });
            #endregion
            #region Seeding
            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("5d989666-6d5f-4f2d-a952-961dd94952b0"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-7E", "Vought", "Corsair II - U.S.N. Version", null, null, 7.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "E" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("f387a227-8afb-45d4-8245-0f0a69d75029"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-3", "McDonnell", "Demon", null, null, 3.0, null, new DateTime(1956, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("ad37acc1-3838-42ea-a26f-da1cd7d62c76"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-2", "McDonnell", "Banshee", null, null, 2.0, null, new DateTime(1949, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e4b68a03-cda5-475c-b94c-ab274d9eb5aa"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F2A", "Brewster (A)", "Buffalo", null, null, 2.0, null, new DateTime(1939, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("55f8d8cb-3d75-49c5-bddd-1127ba49ae80"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-1E", "North American", "Fury (See AF-1E, FJ-3, FJ-4 Fury)", null, null, 1.0, null, new DateTime(1953, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "E" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("f8c382db-4b88-457d-ac4b-061b333942e7"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "E-3", "Boeing", "AWACS", null, null, 3.0, null, new DateTime(1976, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("8918da02-3271-46c9-93e7-b1f7ddcd81d9"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "E-2", "Grumman", "Hawkeye", null, null, 2.0, null, new DateTime(1961, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a894f0fe-aac3-48e7-95ea-de6454785acf"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "E-1", "Grumman", "Tracer (See S-2 Tracker, C-1A Trader)", null, null, 1.0, null, new DateTime(1954, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("ee98d503-995c-4585-82cd-ec229676d2ab"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-141", "Lockheed", "Starlifter", null, null, 141.0, null, new DateTime(1964, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("fed9a805-1624-4d7c-a80f-19c9ccf0ad53"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-135", "Boeing", "Stratolifter", null, null, 135.0, null, new DateTime(1950, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("8e264a63-7edc-4da2-9d1e-41a2d55dcc43"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-133", "Douglas", "Cargomaster", null, null, 133.0, null, new DateTime(1957, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("0b175215-92ba-461a-b738-d1c7c8588d6f"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WC-130", "Lockheed", "Hercules - Weather Version", null, null, 130.0, null, new DateTime(1955, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a3a6c2fb-d6ee-447a-ab7b-e8bc91520d01"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KC-130", "Lockheed", "Hercules - Tanker Version", null, null, 130.0, null, new DateTime(1955, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("297b020e-4ab5-4434-9887-0c485d0a2212"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-130", "Lockheed", "Hercules", null, null, 130.0, null, new DateTime(1955, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("3bbac584-0fa1-4f2a-a7a5-2eba9ff02434"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-119", "Fairchild", "Boxcar (See AC-119 Gunship)", null, null, 119.0, null, new DateTime(1949, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7f923d80-066d-4dbc-84bb-b5ae8733178f"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-74", "Douglas", "Globemaster", null, null, 74.0, null, new DateTime(1950, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("310f4e9c-40d1-4721-a58f-3cfc5cf0f75b"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-47", "Douglas", "Dakota", null, null, 47.0, null, new DateTime(1938, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("8fbff267-b150-4664-bf53-e053752da7ed"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-5A", "Lockheed", "Galaxy", null, null, 5.0, null, new DateTime(1969, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("af169758-bf28-4979-8dda-6eea3b8d9f3b"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F4B", "Boeing (B)", "", null, null, 4.0, null, new DateTime(1928, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".B" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("95fa0757-19e2-4324-a849-b4fb70d96747"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-2A", "Grumman", "Greyhound (See E-2 Hawkeye)", null, null, 2.0, null, new DateTime(1961, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("680e08a4-236c-4d5d-b0e4-5ff7c0f03b77"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F4D", "Douglas (D)", "Skyray", null, null, 4.0, null, new DateTime(1956, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("bccc5146-a863-4a4f-8c1f-730c4d8ddf88"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F4U", "Vought (U)", "Corsair", null, null, 4.0, null, new DateTime(1942, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".U" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("21c6ff54-3803-42a6-b158-f01b12b950bb"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F8F", "Grumman (F)", "Bearcat", null, null, 8.0, null, new DateTime(1944, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("645ce43f-9b05-4b01-b035-15c3269807d9"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F7U", "Vought (U)", "Cutlass", null, null, 7.0, null, new DateTime(1954, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".U" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("94eef546-e28e-4acc-acc2-de4bd24c9817"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F7F", "Grumman (F)", "Tigercat", null, null, 7.0, null, new DateTime(1944, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e0122cf9-fab7-4176-b7e8-bf3237dd065d"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F4D", "Douglas (D)", "Skyray", null, null, 4.0, null, new DateTime(1956, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e0b41fe5-b672-48d0-b6d1-4866d432706a"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F6F", "Grumman (F)", "Hellcat", null, null, 6.0, null, new DateTime(1942, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("949f827a-bc94-4cbd-994f-a2c5682f416c"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-5", "Martin", "Marlin", null, null, 5.0, null, new DateTime(1951, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("34cae762-f033-49a5-a972-61f827ae314d"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-5", "Northrop", "Tiger II", null, null, 5.0, null, new DateTime(1959, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("efa888f7-9c31-44e0-9b2a-f86647ecb431"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4S", "McDonnell Douglas", "Phantom II - Improved USN \"N\" Version", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "S" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("42108603-15ec-4639-b920-10a02c0dd222"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4N", "McDonnell Douglas", "Phantom II - Improved USN \"J\" Version", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "N" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7fbbf85a-414f-479d-9299-6c9f54328e13"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4K", "McDonnell Douglas", "Phantom II - British Version FG.1", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "K" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("aa85f602-462c-4ad2-8c10-12fc5cdccd64"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4J", "McDonnell Douglas", "Phantom II - Improved USN \"B\" Version", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "J" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("fcfba7f1-a83c-4a7d-86fd-df414d11e4df"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4G", "McDonnell Douglas", "Phantom II - Radar Suppression Version", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "G" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("3d83b684-c838-4236-b66a-b396fd734a3d"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4E", "McDonnell Douglas", "Phantom II - Improved USAF \"D\" Version", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "E" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("bf31bd9b-0a73-42bf-8142-7137232cda36"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4D", "McDonnell Douglas", "Phantom II - Improved USAF \"C\" Version", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a5cb6e05-c916-41b0-8ef8-53c7616d925a"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4C", "McDonnell Douglas", "Phantom II - First USAF Production Model", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "C" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7a60f764-9c05-4937-84a0-2226442b68b4"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4B", "McDonnell Douglas", "Phantom II - First USN Production Model", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "B" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("b99e412b-593b-4f96-9eff-7c12cfe70410"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4", "McDonnell Douglas", "Phantom II", null, null, 4.0, null, new DateTime(1960, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("742b5773-3884-45f1-9266-b83ec871e057"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F4F", "Grumman (F)", "Wildcat (British Martlet)", null, null, 4.0, null, new DateTime(1940, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("dab26cff-11fa-4ad8-bd1a-623510daf25a"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-8", "Vought", "Crusader", null, null, 8.0, null, new DateTime(1957, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("bd64ba7a-1f5e-4415-bd05-cd39acf89a37"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-1A", "Grumman", "Trader (See S-2 Tracker, E-1 Tracer)", null, null, 1.0, null, new DateTime(1954, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("f4d70c54-8364-44ab-b95d-191eaa7f2cde"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-58", "Convair", "Hustler", null, null, 58.0, null, new DateTime(1959, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7aaddcf3-acd5-4919-90f6-62a9aa5fd7b5"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SBD", "Douglas (D)", "Dauntless (See A-24)", null, null, null, null, new DateTime(1940, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SBD" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("4bcb1c04-8bda-4a01-bc3d-9a5e12d0ce34"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SB2C", "Curtiss (C)", "Helldiver", null, null, null, null, new DateTime(1942, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SB2C" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("0f41da4a-5981-4221-ae05-28165d6d783f"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-30", "Martin", "Baltimore", null, null, 30.0, null, new DateTime(1941, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("6cac2ec4-36f3-491b-8ca2-d6917dbc1962"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-26", "Douglas", "Invader", null, null, 26.0, null, new DateTime(1943, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("d1322d48-7ca9-48d8-a047-4f6d1241b284"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-25", "Curtiss", "Helldiver (Marines)", null, null, 25.0, null, new DateTime(1942, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7613863f-4a30-4b67-9db2-8e0ec9778b6b"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-24", "Douglas", "Dauntless (Land Based - Army)", null, null, 24.0, null, new DateTime(1940, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("d5b95506-78ce-4d2d-b1b5-1ede5cfdffbe"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-20", "Douglas", "Boston (See P-70)", null, null, 20.0, null, new DateTime(1940, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("119e8024-05ad-4d5c-b29d-86d6c7db96c7"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-11", "Lockheed", "Blackbird (CIA)", null, null, 11.0, null, new DateTime(1964, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("83cf9d80-93c3-4810-b9c2-df70a48984e9"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-10", "Fairchild/Republic", "Thunderbolt II (Tank Killer)", null, null, 10.0, null, new DateTime(1974, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("57e38e43-3e27-46f2-9541-9ce2a86e6d68"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-7D", "Vought", "Corsair II - U.S.A.F. Version", null, null, 7.0, null, new DateTime(1966, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("f23ff226-b790-47d1-9bf5-a44758cf505c"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-6 (A2F)", "Grumman", "Intruder (See KA-6, EA-6B Prowler)", null, null, 6.0, null, new DateTime(1963, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a30292f2-c50a-4e3c-ad21-c231dbc61a71"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KA-6D", "Grumman", "Intruder - Tanker Version", null, null, 6.0, null, new DateTime(1963, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("ba887819-e238-4958-b0ef-b5d81348ffd4"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EA-6B", "Grumman", "Prowler - Electronic Warfare (Intruder)", null, null, 6.0, null, new DateTime(1968, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "B" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("3af0a804-22fa-46ce-8993-6f5576d346b5"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-5 (A3J)", "Rockwell", "Vigilante", null, null, 5.0, null, new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7a39385f-5217-40d9-8485-83425095960b"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-4 (A4D)", "McDonnell Douglas", "Skyhawk", "The Scooter, Heinemann's Hot Rod, Bantam Bomber, Tinker Toy, Mighty Mite", null, 4.0, null, new DateTime(1956, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("64d0b886-3113-4ff2-b699-7d64d60e56f8"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-3 (A3D, B-66)", "Douglas", "Skywarrior (See B-66 Destroyer)", "All Three Dead, Whale, Whistling Shitcan", null, 3.0, null, new DateTime(1954, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("b1b64fc0-16df-4d4c-8307-77653db156e9"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-1 (AD)", "Douglas", "Skyraider", "Sandy, SPAD, Able Dog", null, 1.0, null, new DateTime(1946, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("8a81a612-a8c8-4812-a70f-83879b045207"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AC-047", "Douglas", "\"Puff the Magic Dragon\" Gunship (See C-47)", null, null, 47.0, null, new DateTime(1938, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a87a73b6-ac00-4dbe-8ab6-82bcb8004f7b"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-66", "Douglas", "Destroyer (See A-3 Skywarrior)", null, null, 66.0, null, new DateTime(1954, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("01059865-187f-4dd3-8fc3-c0388dc995bd"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AC-119", "Fairchild", "Gunship (See C-119 Boxcar)", null, null, 119.0, null, new DateTime(1949, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("1b7f119c-313d-4129-9060-693915df1c2d"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AF-1E", "North American", "Fury (See F-1E, FJ-3, FJ-4 Fury)", null, null, 1.0, null, new DateTime(1953, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "E" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("2727c03f-aa19-4b36-b86f-180cb52b7bd0"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RB-57", "Martin/General Dynamics", "Canberra - Reconnaissance Version", null, null, 57.0, null, new DateTime(1953, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e6be7ba6-1709-427c-bd58-e79a451be67f"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-57", "Martin/General Dynamics", "Canberra (See RB-57 Canberra)", null, null, 57.0, null, new DateTime(1953, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("462a4ce8-7648-41d6-9ad9-088fac4f98e7"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-52", "Boeing", "Stratofortress", null, null, 52.0, null, new DateTime(1955, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("5219ef4b-ef9a-45c6-a105-1b8c19a53840"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-50", "Boeing", "Superfortress", null, null, 50.0, null, new DateTime(1947, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e206d45d-905d-4325-b21e-d6d6ff3e830f"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-47", "Boeing", "Stratojet", null, null, 47.0, null, new DateTime(1950, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e9a62f85-5132-4f46-a0a7-33bdf58e0ee5"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-36", "Convair", "Peacemaker", null, null, 36.0, null, new DateTime(1947, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("fee0fabe-7f9c-409b-881e-97fb33b3b514"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-29", "Boeing", "Super Fortress", null, null, 29.0, null, new DateTime(1943, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("3219eaf7-8c72-49f3-95b9-118fd12e4290"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-26", "Martin", "Marauder", null, null, 26.0, null, new DateTime(1941, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("483bccce-5740-46a7-ac6e-dbc098f712df"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-26", "Douglas", "Invader (after B-26 Marauder was retired)", null, null, 26.0, null, new DateTime(1943, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("bf55d9bd-9cae-46c0-9ed2-d3dfbf685560"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-25", "North American", "Mitchell (See F-10)", null, null, 25.0, null, new DateTime(1940, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("3e61caff-2c1e-4cd5-b863-f583d133e799"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-24", "Consolidated", "Liberator", null, null, 24.0, null, new DateTime(1941, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("648295f9-9a26-4aef-ba10-459b2911d961"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-18", "Douglas", "Bolo/Digby-1", null, null, 18.0, null, new DateTime(1937, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("0b00dcc8-2812-4056-bb36-203527c3eab4"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-17", "Boeing", "Fortress", null, null, 17.0, null, new DateTime(1939, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("5b7bd808-d0b1-4743-bb5d-d6526146e9dd"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-14", "Martin", null, null, null, 14.0, null, new DateTime(1932, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e3923da7-429f-4a92-bd61-2cbaa1adfc2e"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-12", "Martin", null, null, null, 12.0, null, new DateTime(1932, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("304ecbba-056a-4db3-8a8f-e1d91882e81d"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-10", "Martin", null, null, null, 10.0, null, new DateTime(1932, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("8b9b9093-77dd-4be0-b8ab-aa1ea1d73067"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-1", "Rockwell", null, null, null, 1.0, null, new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("c1bb050d-9382-4f96-9e5d-e81f9ab28a08"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AC-130H", "Lockheed", "Hercules (Night Gunship)", null, null, 130.0, null, new DateTime(1955, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "H" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7cafa6d5-a247-4454-962e-782595627809"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F9F-1", "Grumman (F)", "Panther", null, null, 9.0, null, new DateTime(1948, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F-1" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e13b3d84-a9eb-4a4a-8f12-fd2954e87328"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-97", "Boeing", "Stratofreighter/Stratotanker", null, null, 97.0, null, new DateTime(1949, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("117769de-cc5b-4b23-a8ae-f0dfeb64a0e7"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-10", "North American", "Mitchell (Reconnaissance) (See B-25)", null, null, 10.0, null, new DateTime(1940, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("1c602783-0f36-4616-9472-72a6ef8a4fc6"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FB-111A", "General Dynamics", "Aardvark - Fighter Bomber Version", null, null, 111.0, null, new DateTime(1967, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FB-A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("be8fc313-881a-466a-8c58-cd50959414f8"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-111F", "General Dynamics", "Aardvark - Improved Intakes", null, null, 111.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("07322162-976c-4137-bcd7-f143cead6776"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-111E", "General Dynamics", "Aardvark - \"Triple Plow II\" Intakes", null, null, 111.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "E" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("2fd45cb3-1b0a-49f6-b3a6-32d2d5ff5b6d"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-111D", "General Dynamics", "Aardvark - Improved Intakes", null, null, 111.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("f8d53497-9e7d-48a3-b606-ab84d786934c"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-111C", "General Dynamics", "Aardvark - \"A\" Version w/longer wing", null, null, 111.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "C" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("b5a8119c-ca92-4f30-96ff-daf7df0d6f75"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-111B", "General Dynamics", "U.S. Navy TFX Prototype (Cancelled)", null, null, 111.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "B" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("3c07b993-bb31-4785-abbd-fd3fc92cb4ed"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FJ-3", "North American", "Fury (See F-1E, AF-1E, FJ-4 Fury)", null, null, null, null, new DateTime(1953, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "J-3" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("29ad8869-4216-4dde-90a7-b5c1221edc94"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-111A", "General Dynamics", "Aardvark", null, null, 111.0, null, new DateTime(1967, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("79a42442-4ad8-42b7-aa40-5ca59f8c5b89"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-105", "Republic", "Thunderchief", null, null, 105.0, null, new DateTime(1955, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("26b907a0-93fe-44f6-95df-8dbac4534fe2"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-104", "Lockheed", "Starfighter", null, null, 104.0, null, new DateTime(1956, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7848c049-902f-4f6b-9a52-c05411ca895a"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-102", "Convair", "Delta Dagger", null, null, 102.0, null, new DateTime(1955, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("338cdf3c-4f91-4613-8f1a-055cc22d4a3d"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RF-101", "McDonnell", "Voodoo  - Reconnaissance Version", null, null, 101.0, null, new DateTime(1957, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("8a30896d-9c48-40a0-9095-b6ee42d285bb"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-101", "McDonnell", "Voodoo", null, null, 101.0, null, new DateTime(1957, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a3589ae0-3aa6-4b9d-b786-d2aac7977d99"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-100", "North American", "Super Sabre", null, null, 100.0, null, new DateTime(1953, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("b0c9235c-eaac-41fd-90c0-9852f4941e9f"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-106", "Convair", "Delta Dart", null, null, 106.0, null, new DateTime(1959, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7602453f-6b57-4562-89d3-cedaf0b6e02e"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FJ-4", "North American", "Fury (See AF-1E, F-1E, FJ-3 Fury)", null, null, null, null, new DateTime(1954, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "J-4" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("c15ba406-aa27-4f25-90d2-ddf0c944de48"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OV-1", "Grumman", "Mohawk", null, null, 1.0, null, new DateTime(1961, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("faade243-4fd3-4503-909e-5881414e3248"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OV-10", "Rockwell", "Bronco", null, null, 10.0, null, new DateTime(1967, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("3b520a48-7b5c-42b8-aa27-cbbf6222a615"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD2", "Douglas", "Skyshark", null, null, null, null, new DateTime(1950, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("d9d47988-4547-489a-9f5f-6b0ae5a26dd5"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TBM", "Eastern Motors/GM (M)", "Avenger", null, null, null, null, new DateTime(1942, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "M" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("65974e6e-b1e1-4924-ba41-4647a7645803"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TBF", "Grumman (F)", "Avenger", null, null, null, null, new DateTime(1942, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("373f0828-2af8-4081-a8da-25a39158401e"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TBD-1", "Douglas (D)", "Devastator", null, null, null, null, new DateTime(1937, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D-1" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("faf5f162-179d-43cc-99af-1d7de4411278"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KC-135", "Boeing", "Stratotanker", null, null, 135.0, null, new DateTime(1950, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("675ada84-806c-4b94-bb03-204842ac3ae9"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S-3", "Lockheed", "Viking", null, null, 3.0, null, new DateTime(1973, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("14c2dd16-e741-4082-ac0c-a3c7fb01b631"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-3", "Lockheed", "Orion", null, null, 3.0, null, new DateTime(1961, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("d7ceb934-36fd-4213-9486-2dc5eecb6116"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S-2", "Grumman", "Tracker (See E-1 Tracer, C-1A Trader)", null, null, 2.0, null, new DateTime(1954, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("ac0e48b4-e797-47c4-bfb2-7f021c210e35"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-2", "Lockheed", "Neptune", null, null, 2.0, null, new DateTime(1947, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e4d52b4b-c50c-44f4-a2aa-6f1dafa5e85f"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SR-71", "Lockheed", "Blackbird (USAF)", null, null, 71.0, null, new DateTime(1964, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("d3c3dd6c-1f88-4fa2-852e-a8572a797365"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "U-2", "Lockheed", null, null, null, 2.0, null, new DateTime(1956, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("96bd3667-709c-46bf-a67c-c22ac0625432"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PBY-5", "Consolidated", "Catalina", null, null, null, null, new DateTime(1936, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Y-5" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("04828ef3-5fb6-41ac-8a57-23251637e139"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PBY-1", "Consolidated", "Catalina", null, null, null, null, new DateTime(1936, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Y-1" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("28d45c7a-e18b-4cfc-a2f2-c41bfeca78fa"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PBM", "Martin", "Mariner", null, null, null, null, new DateTime(1940, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "M" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("34e8cdce-fb74-48a5-a6e1-fda50524a4f7"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB4Y-2", "Consolidated", "Privateer", null, null, 4.0, null, new DateTime(1944, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Y-2" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("21ec2935-a829-4142-86e7-d879f4a4ec1f"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F9F-6", "Grumman (F)", "Cougar", null, null, 9.0, null, new DateTime(1951, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F-6" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("5520743f-d439-4b8d-92b5-e53fe0c67f67"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-89", "Northrop", "Scorpion", null, null, 89.0, null, new DateTime(1948, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("5207294f-494e-4271-9c06-eb6730af47d5"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-94", "Lockheed", "Starfire (See P-80, F-80 Shooting Star)", null, null, 94.0, null, new DateTime(1944, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("5f39b61f-e69b-428b-bc82-830918bc679e"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-86", "North American", "Sabre", null, null, 86.0, null, new DateTime(1948, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("cc4b35b8-347d-40c8-9502-92c199271128"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-16XL", "General Dynamics", "Cranked Arrow Falcon", null, null, 16.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "XL" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("2c27aaa1-3ede-48d2-b583-8b5606dde5da"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-16N", "General Dynamics", "Falcon - Top Gun Aggressor Version", null, null, 16.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "N" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("dd680362-b91c-4029-97d1-a18c47f41604"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-16D", "General Dynamics", "Falcon - Improved \"B\" Trainer", null, null, 16.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("99a8eb82-88af-4e13-88af-5adc89c1e483"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-16C", "General Dynamics", "Falcon - w/LANTIRN Night Nav/Targeting", null, null, 16.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "C" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7ebffc5d-f362-4bfc-8929-1c9820b32e0b"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-16B", "General Dynamics", "Falcon - Two Seat Trainer", null, null, 16.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "B" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7dc639cf-a2ee-4e75-9408-1345858aa470"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-16A", "General Dynamics", "Fighting Falcon", null, null, 16.0, null, new DateTime(1978, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("fe7586ec-36aa-4e19-b18f-d180b4a7e0f1"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F/A-18A", "Northrop/McDonnell Douglas", "Hornet", null, null, 18.0, null, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("79f4fee6-ef8e-4e8d-89ad-49ca14aea8dc"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-15J", "McDonnell Douglas", "Eagle - Japanese Self Defense Force", null, null, 15.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "J" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("b0828f7d-9878-412f-942b-b07e54456eae"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-15D", "McDonnell Douglas", "Eagle - Two Seat Trainer", null, null, 15.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("1e6b92d3-409f-4e98-a9a7-f9f5550d8ebf"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-15C", "McDonnell Douglas", "Eagle - Advanced Air Superiority Fighter", null, null, 15.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "C" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("6d067ea5-fb76-42e5-b083-a09c752c723a"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-15A", "McDonnell Douglas", "Eagle", null, null, 15.0, null, new DateTime(1974, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e1a60548-f1d1-4f4d-a491-1ac15585546f"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-14", "Grumman", "Tomcat", null, null, 14.0, null, new DateTime(1972, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("cfc704bb-4835-45c4-ab08-e0ca5fe4a56d"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-12", "Boeing", "", null, null, 12.0, null, new DateTime(1928, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("2ed61799-7752-44fe-a9d2-d3a365dd2e2e"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-11", "Grumman", "Tiger", null, null, 11.0, null, new DateTime(1957, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("91ccc724-7819-49e6-8e4f-de0f9e74970b"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-15E", "McDonnell Douglas", "Strike Eagle", null, null, 15.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "E" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("2e41c4c4-2932-4470-b4b2-95067fc10865"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F/A-18C", "Northrop/McDonnell Douglas", "Hornet - Improved \"A\" Version", null, null, 18.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "C" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("dce700c5-4ea0-4923-a50b-8e33660cbaef"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TF-18A", "McDonnell Douglas", "Hornet - U.S. Navy Two Seat Trainer", null, null, 18.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("13879796-b6cd-4e9d-bf85-baa7a2255ae4"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RF-18D", "Northrop/McDonnell Douglas", "Hornet - Two Seat Reconnaissance Version", null, null, 18.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("ce5ae201-30ac-4360-a913-8e7c45f37b9a"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-84", "Republic", "Thunderjet", null, null, 84.0, null, new DateTime(1947, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("379d3194-b178-4ef9-a545-c76a36b24bb5"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RF-84F", "Republic", "Thunderflash - Reconnaissance Version", null, null, 84.0, null, new DateTime(1947, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("0e019f48-b688-4b14-a9af-18d334e1542e"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-84F", "Republic", "Thunderstreak", null, null, 84.0, null, new DateTime(1947, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a7c676e6-1a4c-46a0-b71b-c14efe905aa1"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-82", "North American", "Twin Mustang (See F-82)", null, null, 82.0, null, new DateTime(1945, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("79a7ddd0-1f88-4158-a44d-77d7774830d8"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-82", "North American", "Twin Mustang (See P-82)", null, null, 82.0, null, new DateTime(1945, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("0cd94e1e-f8a8-4da2-8e2a-0dce664524b6"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-80", "Lockheed", "Shooting Star (See F-80, F-94 Starfire)", null, null, 80.0, null, new DateTime(1944, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("b5ca6f63-7148-4b4a-a635-eb0c3b220a00"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F/A-18D", "Northrop/McDonnell Douglas", "Hornet - Two Seat Night Attack Version", null, null, 18.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("ca6411fe-7999-4e01-ac18-0e25ff0d1bc9"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-61", "Northrop", "Black Widow", null, null, 61.0, null, new DateTime(1944, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("2133d405-0dee-4a9f-8943-e1226745f422"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-70", "Douglas", "Havoc (Army Night Fighter) (See A-20)", null, null, 70.0, null, new DateTime(1940, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("97446793-d59b-49da-a0a3-ffdeac127be1"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-51", "North American", "Mustang", null, null, 51.0, null, new DateTime(1942, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("165a31a9-c01e-4e4f-bc6e-de2dfbdee3c8"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-47", "Republic", "Thunderbolt", null, null, 47.0, null, new DateTime(1942, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a8722c80-b649-4304-a9ba-f795e2ca4d6e"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-40", "Curtiss", "Hawk (Warhawk, Tomahawk, etc)", null, null, 40.0, null, new DateTime(1940, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("f949dfc2-78de-44ea-b335-799e7840f3ac"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-39", "Bell", "Airacobra", null, null, 39.0, null, new DateTime(1939, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("f472bae3-3cf7-4c46-a06a-26117d11b785"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-38", "Lockheed", "Lightning", null, null, 38.0, null, new DateTime(1941, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("0dd4f77d-89e8-4495-a2ec-5c5d2d19b52a"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-26", "Boeing", null, null, null, 26.0, null, new DateTime(1934, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("051b94f0-b5ec-48ef-8a3b-4685e2c5d153"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-59", "Bell", "Airacomet", null, null, 59.0, null, new DateTime(1944, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("2a10a532-2fe4-4647-99e0-d18e706486a2"), "F/A-18A Northrop Hornet", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "72-560", null, "Hasegawa HA-812", null, null, "1987-" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("85bbf156-ca22-4cae-8734-34ddd2223ccd"), "A-4F McDonnell Douglas Skyhawk", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "72-138", null, "Fujimi FU-G19", null, null, "1974-86" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("9e6feba6-c233-4a5f-a050-0ca5caad22d9"), "F-4J McDonnell Douglas Phantom II", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N/A", null, "Hasegawa HA-SP51", null, null, "1969-73" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("8c8d771c-ae38-49fc-80c6-9da8c2785879"), "F11F-1 Grumman Tiger", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N/A", null, "Hasegawa HA-D16", null, null, "1957-61" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("a8e1f8c1-138c-4bed-89c1-563298d96978"), "F9F-5 Grumman Panther", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N/A", null, "matchbox PK-124", null, null, "1952-54" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("0742dd70-5506-4817-bcd5-7eb59cbeddfe"), "F9F-8 Grumman Cougar", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N/A", null, "Hasegawa HA-D12", null, null, "1955-57" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("704e90ac-d944-4bdf-a15c-0e0562e849a7"), "F9F-2 Grumman Panther", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N/A", null, "Hasegawa HA-D11", null, null, "1949-50" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("8ffa6bd3-2074-41cd-9584-bb03723f5d36"), "F6F-5 Grumman Hellcat", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "72-217", null, null, null, null, "1946" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("f0f74d48-e5df-422a-bd84-0cd0bec61dd0"), "F7U-1 Vought Cutlass (Solo Only)", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N/A", null, "Testers", null, null, "1952" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("1352372d-bfb5-4553-b8f6-14cf4509a35b"), "F8F-1 Grumman Bearcat", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "72-642", null, "Monogram (Germany) MG6789", null, null, "1946-49" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9666f3f1-53ff-4bea-9558-b0f92879b881"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "PC Games Box #3", null, "PC Games Box #3 [Closet]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8dbaa486-510f-46a2-ba35-09364a8dbdd6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "PC Games Box #2", null, "PC Games Box #2 [Closet]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0d0410c9-a2ff-4fa3-9e89-6ac7fc4189e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "PC Games Box #1", null, "PC Games Box #1 [Closet]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("449123f4-ec23-4e1e-8483-30922ac01cd0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "PB201111.4", null, "PB201111.4 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d8d61289-81b2-47fb-afa8-b91c1019218a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "PB201110.3", null, "PB201110.3 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("296a913c-c030-4b7c-8348-a12fa15b74fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "PB201110.2", null, "PB201110.2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f6166a92-0629-4b34-9d37-b276205b135a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHB", "PB201110.1", null, "PB201110.1 (UHB) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("70256862-74cb-4042-aa44-c581822e59a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Part of Compilaton", null, "Part of Compilaton", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b8bddabf-787b-477c-9e53-13b49fa1678a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "On Order", null, "On Order", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bf74ff88-e7ff-49f8-a533-346795a6156b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Office", null, "Office", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("995bfdf3-983b-4be4-a5b1-c938f109a709"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Nappa Valley Crate #3", null, "Nappa Valley Crate #3 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("af0a3bb8-8b1e-4abf-8aa0-ff15576bb34a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Nappa Valley Crate #2", null, "Nappa Valley Crate #2 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a55fde2a-de99-4815-8f33-73d6930791f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Nappa Valley Crate #1", null, "Nappa Valley Crate #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("89927a2e-e7a6-4989-b651-962b301249b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "Music DVDs Box #1", null, "Music DVDs Box #1 (33250) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("25f2131e-2140-49ee-a995-53ab07708bcc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Models #2", null, "Models #2 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d9d5828e-d18e-4934-8a84-96e3b7d6b107"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "PC Games Box #4", null, "PC Games Box #4 [Closet]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cb0aef2d-d24e-4bb7-9465-a94db34c8a4d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHB", "Sci-Fi Books Box #3", null, "Sci-Fi Books Box #3 (UHB) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("36d20024-0dbf-4889-9d67-e7d693ddc781"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "PC Games Box #4", null, "PC Games Box #4", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("da6609ee-d696-4fe2-8922-61099f89c81b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Models #1", null, "Models #1 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a4cc8382-9aad-41fb-84c4-9b568dd1dbb9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Sci-Fi Books Box #2", null, "Sci-Fi Books Box #2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("03ea424e-60f8-46c4-a6ac-31ef2d728a23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Sci-Fi Books Box #1", null, "Sci-Fi Books Box #1 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e167e4de-8c32-48d0-a760-2915e2c41b55"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Science Books Box #14", null, "Science Books Box #14 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ff278ff4-4037-4787-816a-a83733fa612f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Scheduled for Donation", null, "Scheduled for Donation", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9acd97e2-bc82-485c-b8a9-9a21c7be4666"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ready to install", null, "Ready to install", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b6d53cec-2454-4300-9dbb-c741fe5ea94b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Soundtrack", null, "Public Music\\Soundtrack", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("74360f37-7040-4273-8f0c-b581ce79c5b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Rock", null, "Public Music\\Rock", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("414e70e2-c789-44a4-972b-f57e38fc61c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Radio Shows", null, "Public Music\\Radio Shows", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("51af1bdc-a302-4680-a208-6e237e46a632"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Pop", null, "Public Music\\Pop", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d20ebcda-7765-447e-a9e3-e159084034d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\New Age", null, "Public Music\\New Age", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8a617c53-1198-4bf6-92b9-2f97e62acf2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Country", null, "Public Music\\Country", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b0988b48-bb7a-460c-8a12-6e437657d2ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Comedy", null, "Public Music\\Comedy", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0f8ab35f-86a6-4f37-95eb-e8ef61039aab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Classical", null, "Public Music\\Classical", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("172c9f05-4eb9-4e37-9d05-c1fcf70bc2d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Christmas", null, "Public Music\\Christmas", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f2441db3-2b25-4e82-a50c-b698022f55a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Books", null, "Public Music\\Books", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2939a13f-f7af-4a9c-8f6e-0fd8e4c15cff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Pre-Ordered", null, "Pre-Ordered", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("20dc14cd-b1f3-4336-ae8f-b92deef1f725"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Prize Box", null, "Prize Box", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a48b7a1b-6c38-4067-b421-f96804b1ad83"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Misc Books Box #01", null, "Misc Books Box #01", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7f0411c3-a82d-484f-9420-1f46c33c9a7f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Micro Machines - Titanium  Series Box #10 (BSG) (SMO)", null, "Micro Machines - Titanium  Series Box #10 (BSG) (SMO) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9348f470-06f7-431a-aeaf-b00af29d7c46"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Left in box", null, "Left in box", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("625a9e0c-cb16-49c7-b024-9c28dc371580"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Left in bag", null, "Left in bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("59450d28-73d2-44a2-8568-b81004285232"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Kindle", null, "Kindle", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("015f7c0c-1910-4e78-8187-22cdf80c312d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Key Publishing Specials Box", null, "Key Publishing Specials Box [Top of Steps]", "Top of Steps" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4a7e53ee-ee32-4148-a3f6-e68e2270ae1c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Room", null, "Ken's Room", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e60127b5-89be-4370-92ad-bc7b82e6922f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Ken's Hallmark Ornaments Box", null, "Ken's Hallmark Ornaments Box (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4ccf6a37-3fd5-407b-ae30-410b0cad8f3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's DVDs Box #4", null, "Ken's DVDs Box #4 [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b93e0106-dcd6-42a9-9cf1-f7404ea40cf1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's DVDs Box #3", null, "Ken's DVDs Box #3 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0d88b890-9943-44f1-8bef-a3ec36a1def3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's DVDs Box #2", null, "Ken's DVDs Box #2 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("320669c4-bb19-41d0-9ed1-03843be6bd71"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's DVDs Box #1", null, "Ken's DVDs Box #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ead6af66-4cd9-4cdf-8219-cdd52ce50bc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Desk", null, "Ken's Desk", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0ec2ccce-5243-44ff-956f-07ccec8f0ac2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #14 - Modeling Resources", null, "Ken's Books Box #14 - Modeling Resources [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("06cbd449-1de4-4b01-a3f1-4acc0f757e5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #13", null, "Ken's Books Box #13 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("68a9d23a-c65b-4ff9-b1ff-360dd92796b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Sci-Fi Books Box #4", null, "Sci-Fi Books Box #4 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("84398de1-3c02-41ae-b6e9-b9819aa754f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #12", null, "Ken's Books Box #12 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0bc448f1-6ed8-4cd3-85d1-bf050628f2bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Living Room", null, "Living Room", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("271a1cb9-b58d-4d02-aa86-4e1884323187"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Lost", null, "Lost", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("59ccf301-f21a-4f37-a3bc-03706d6a61b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "USPS #13 9x7x4", "M&M's Chocolate M-PIRE Box", null, "M&M's Chocolate M-PIRE Box (USPS #13 9x7x4) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("decefec2-e3e8-4eec-90d3-8f30e3798ec0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "USPS #13 9x7x4", "M&M's Chocolate M-PIRE Box", null, "M&M's Chocolate M-PIRE Box [USPS #13 9x7x4]", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("41350343-cb8c-48f9-aabb-199f6f0b8b57"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Micro Machines - Titanium  Series Box #09", null, "Micro Machines - Titanium  Series Box #09 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("889f641d-47a4-4454-893b-9068eefb0622"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Micro Machines - Titanium  Series Box #08", null, "Micro Machines - Titanium  Series Box #08 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("98b3ce5d-21b8-443b-af9b-5f2f02394c08"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Micro Machines - Titanium  Series Box #07", null, "Micro Machines - Titanium  Series Box #07 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6c2af78c-042c-4cdf-89e0-966fa1610714"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Micro Machines - Titanium  Series Box #06", null, "Micro Machines - Titanium  Series Box #06 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("be781c05-ffe2-4ce0-89ae-8514fc034589"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Micro Machines - Titanium  Series Box #06", null, "Micro Machines - Titanium  Series Box #06 (ESSS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8561e12d-ca6e-45a6-bfbd-593a13709788"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Micro Machines - Titanium  Series Box #05", null, "Micro Machines - Titanium  Series Box #05 (ESSS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b7e6f5dd-f117-453e-81b6-dfb3611b2d13"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Micro Machines - Titanium  Series Box #03", null, "Micro Machines - Titanium  Series Box #03 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("72c21daf-e0ae-4a26-91ef-858ac2bc5756"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Misc Collectables Box #1", null, "Misc Collectables Box #1 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f57487f6-c024-4797-b829-2403f77b3ea7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Micro Machines - Titanium  Series Box #02", null, "Micro Machines - Titanium  Series Box #02 (ESSS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c44d348c-d3d1-4b4a-bf80-ce493a0f7fca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "MH201110.6", null, "MH201110.6 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9b797aab-95bf-443b-9d1b-5ac7b68d8d4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "MH201110.5", null, "MH201110.5 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d1bee47e-cb03-4d18-9266-b685dcefde15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "MH201110.4", null, "MH201110.4 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ef500a02-cf90-49d8-bcbb-b236a257dcdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "MH201110.3", null, "MH201110.3 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e45876df-2a79-44e7-ad9b-7f4c5350f7c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "MH201110.2", null, "MH201110.2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7d2cb131-a3a5-4b5a-ba13-1d13240d734b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "MH201110.1", null, "MH201110.1 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6dee89c9-6b99-4448-88f5-7c09b79ee232"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Master Bedroom", null, "Master Bedroom", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d1e019b2-1f8b-4fe3-bb0d-475c1b9df0cd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Micro Machines - Titanium  Series Box #01", null, "Micro Machines - Titanium  Series Box #01 (ESSS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c3bbf67c-162e-4a81-9601-f316c9ae8d1c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "SciFi Box #1", null, "SciFi Box #1 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b255fca1-e5cf-49d0-8e9b-d82514bafcdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", null, "", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("fd60f0f6-24d4-456b-90da-cf5392cf6dc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHL", "SciFi Box #2", null, "SciFi Box #2 (UHL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("92d76f0f-a8ae-4ee0-be7e-374ec314cbc7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unboxed", null, "Unboxed [Carol's Room]", "Carol's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5cc55e1d-fb68-47ca-8f49-2352cc0c4df0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unboxed", null, "Unboxed [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8e88952f-4800-4ff8-a8cd-606e029d2b2a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Transition", null, "Transition", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a6e1239f-a522-40f0-8aa9-18761981a3a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Train Stuff", null, "Train Stuff", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("600d693c-2e17-4b40-a6b8-dd59a0d5db11"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps Cowboys Box #01", null, "Topps Cowboys Box #01 [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("627531f0-77f1-49b4-b3bd-b0394535a6c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps 2008 Football Complete Set Box", null, "Topps 2008 Football Complete Set Box [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("47518ce3-37a1-467d-9a52-91be01a54dd8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps 2008 Football #1", null, "Topps 2008 Football #1 [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3ea078d8-f601-404f-80a5-f1e107cff34c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps 2007 Football Complete Set Box", null, "Topps 2007 Football Complete Set Box [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("07ec9065-5c14-4a5c-bc4a-fc49328dfbed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps 2006 Football #3", null, "Topps 2006 Football #3 [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bbeaf335-887d-4306-94d2-f29b2aedec00"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps 2006 Football #2", null, "Topps 2006 Football #2 [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d005bb6b-3574-436d-963e-66a10427da4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps 2006 Football #1", null, "Topps 2006 Football #1 [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("393e6db1-7d5c-4469-a4e0-7725c3f0603d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Tom Clancy Book Box #9", null, "Tom Clancy Book Box #9 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7f235fdc-86e9-4878-856c-a011f64df55f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "TimeLife Books Box #3", null, "TimeLife Books Box #3 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("46d4b7d6-d50a-4d77-a1ee-a25c916bd7c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "TimeLife Books Box #2", null, "TimeLife Books Box #2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("239e4399-a752-4fa9-9d91-476d820ee75d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "TimeLife Books Box #1", null, "TimeLife Books Box #1 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("179708ea-5130-44c9-bcc4-b8b399f3bd85"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unboxed", null, "Unboxed [Ken's Room - Near Front Wall]", "Ken's Room - Near Front Wall" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b6e57f41-4dad-44fe-88cd-60c5b429ade0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Text Books Box #16", null, "Text Books Box #16 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d69b2846-bf87-4a3d-a3ec-925eae64c13a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unboxed", null, "Unboxed [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("101dbe97-8b05-4d42-86ae-043ebd26f08e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unboxed Atop Bookcase B", null, "Unboxed Atop Bookcase B [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("79516df0-891e-4e03-8f95-ad55ae29f41a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #11", null, "Ken's Books Box #11 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ec59221e-2eca-42db-a8f7-131973ef4af3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "WishList", null, "WishList", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("62078afb-8cf4-4e6d-a548-5689f0d09318"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Undetermined", null, "Undetermined", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1a4370a7-8703-48a8-92e8-f5123ab2b41a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Topps 2006 Football #1", null, "Topps 2006 Football #1", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5cb0d48a-f58c-42b3-9453-41794bf66e63"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Self-Compiled", null, "Self-Compiled", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e14ea361-6d46-4716-a091-d23c131aabb7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "EB Games.com", null, "EB Games.com", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("043b3eb8-6b3f-4b32-a599-d0b45a8ea007"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Canceled", null, "Canceled", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("198fbf1d-d3e0-483e-a7b9-bdec797def8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Workbench", null, "Workbench", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2af9bf0c-9146-401f-866c-b1934a5591c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Work Books 20080910.1", null, "Work Books 20080910.1 (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f5f4c9b4-bbe5-41ad-9cae-3036d1974c9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Wire Rack", null, "Wire Rack (Top Shelf) [Ken's Room East Wall]", "Ken's Room East Wall (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("51a86945-2210-4401-a0aa-7034b36ac37e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Web Access", null, "Web Access", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1961f321-3613-4c6e-bf33-1ff815a1f194"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unspecified", null, "Unspecified", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4ca90123-193c-46c1-aa8a-808a1377dbea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unknown", null, "Unknown", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("03d7c8e0-dfc1-4138-972d-cb989302d217"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unknown - Possible Duplicate", null, "Unknown - Possible Duplicate", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f5be55cc-7034-43bb-bb63-7af210408040"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Undecided (Carol)", null, "Undecided (Carol)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("20188308-f95a-4437-ac99-8766ee3bfc41"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unboxed Atop Bookcase A", null, "Unboxed Atop Bookcase A [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("de5e89dd-c63e-46e4-b966-1c58950c66ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sterilite Flip-Top Box #5", null, "Sterilite Flip-Top Box #5 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9c72a381-71bf-4c09-92ae-170fe12b0f11"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sterilite Flip-Top Box #4", null, "Sterilite Flip-Top Box #4 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c6bb37fa-5754-403d-aabd-089d456614b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sterilite Flip-Top Box #3", null, "Sterilite Flip-Top Box #3 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b11a9241-2c12-47bd-8f79-909a10c50a94"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Sports Books Box #15", null, "Sports Books Box #15 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1e1b834a-6554-41e4-8e97-c2e878a6c3f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Spares", null, "Spares", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("86ed1037-72ef-42cb-9659-c9f3194c3863"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sealed with detail set included in kit", null, "Sealed with detail set included in kit", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ca7aee62-b78d-4990-845a-3662234857f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sealed in package", null, "Sealed in package", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b17d5059-ae9c-4da6-81be-ddd1f020d7fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #7 Ziploc bag", null, "SciFi Box #7 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("54c96e78-6b37-4d47-a52c-6968bdef214a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "SciFi Box #7", null, "SciFi Box #7 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("65f57578-06d7-41b7-8801-3cfed2461f24"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #6 Ziploc bag", null, "SciFi Box #6 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c16b581d-c271-4e16-a8bb-3f99ab8de971"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "SciFi Box #6", null, "SciFi Box #6 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6c05612c-577c-4385-9da1-0016cd193c41"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #5 Ziploc bag", null, "SciFi Box #5 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2aa8a51e-b292-496d-92ca-1b45f0732de2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "SciFi Box #5", null, "SciFi Box #5 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("994daa4c-409f-4675-8c59-b7f72baeb8fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #4 Ziploc bag", null, "SciFi Box #4 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5cc4bb7a-d994-4b84-b80f-b53e4580eb1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "SciFi Box #4", null, "SciFi Box #4 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ae0c0c03-b05d-4f12-a4de-4b386950cd1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #3 Ziploc bag", null, "SciFi Box #3 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c44e64f4-0616-45c7-aaaa-bfdc34d81517"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHL", "SciFi Box #3", null, "SciFi Box #3 (UHL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("83aafac2-fa3e-4d4f-bf44-aad99c92b90c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #2 Ziploc bag", null, "SciFi Box #2 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a7e155c8-2a34-466d-a7f7-82a820d3d78d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plano 993179", "Star Trek Attack Wing Case #01", null, "Star Trek Attack Wing Case #01 [Plano 993179]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("95c640e6-62e9-4c67-b7c5-d46edf24410b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plano 993179", "Star Trek Attack Wing Case #02", null, "Star Trek Attack Wing Case #02 [Plano 993179]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ab0dad90-2a34-4349-96e9-9e7f68f762b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 18x14x10", "Star Wars Armada Box", null, "Star Wars Armada Box (Unmarked 18x14x10) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("aed74545-9bbf-406c-aaaa-770a61dd732c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Star Wars Collectables Box #2", null, "Star Wars Collectables Box #2 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ae01eaaf-7d61-4d32-aae8-6510f910fbb4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sterilite Flip-Top Box #2", null, "Sterilite Flip-Top Box #2 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c3c046e3-8286-4d46-bc68-fdae4d98e104"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sterilite Flip-Top Box #1", null, "Sterilite Flip-Top Box #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7bd5e127-3cf5-486f-962d-44d0f50349d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Starfighter Shipyards Box #1", null, "Starfighter Shipyards Box #1", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7ab78dbf-ae70-4e25-be3c-5ef5eee032d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Star Wars X-Wing Box", null, "Star Wars X-Wing Box [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("17f56ad8-8411-4f27-9a97-d0f0baa775b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Star Wars Vehicles Box #3", null, "Star Wars Vehicles Box #3 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f211a16d-e4bb-4354-aef3-fda68e4273ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Star Wars Vehicles Box #2", null, "Star Wars Vehicles Box #2 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0d22bea4-4b9e-4c66-b333-0c194f57ef2a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Star Wars Vehicles Box #1", null, "Star Wars Vehicles Box #1 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("175eb56c-638e-4517-9877-b085b79600c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #1 Ziploc bag", null, "SciFi Box #1 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("56de90c3-edc1-4731-8a6d-7328b45e2b72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Star Wars Sterilite Flip-Top Box", null, "Star Wars Sterilite Flip-Top Box [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c27527f9-59eb-4ce1-9de7-2c317a04c858"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Star Wars Collectables Box #9", null, "Star Wars Collectables Box #9 (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ad06e5af-5a9e-4e5a-ad24-859715b11eae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Star Wars Collectables Box #8", null, "Star Wars Collectables Box #8 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3cde9035-8de1-4b78-90cf-0cb8f88a4429"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Star Wars Collectables Box #7", null, "Star Wars Collectables Box #7 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b0c302ef-9553-491b-a5d3-682c92e58b43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EE 18x12x12", "Star Wars Collectables Box #6", null, "Star Wars Collectables Box #6 (EE 18x12x12) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d2e5a3c5-a88b-4d23-9210-eb41a848d666"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Star Wars Collectables Box #5", null, "Star Wars Collectables Box #5 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e48a6a1f-860a-4c73-b352-730ee00fdc35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Star Wars Collectables Box #4", null, "Star Wars Collectables Box #4 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("851355b4-2704-4c0e-9fd4-f49d9e8f5b3f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Star Wars Collectables Box #3", null, "Star Wars Collectables Box #3 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("be16358d-ac99-4519-bb04-ea3b3c77c9df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Star Wars Collectables Box", null, "Star Wars Collectables Box (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ef09be40-13a9-4361-b9c9-c02edeca36fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #10", null, "Ken's Books Box #10 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1dceacfb-78bd-4afc-8688-942fccd37563"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Micro Machines - Titanium  Series Box #04", null, "Micro Machines - Titanium  Series Box #04 (ESSS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("35f12815-2b7f-4448-bf46-f1755c38f5c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #08", null, "Ken's Books Box #08 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f381f200-9fb7-45d2-a397-6f37b16cdc61"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Box #72-05", null, "Box #72-05 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("32d6936d-0041-44fb-8473-a536d003fd8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Box #72-06", null, "Box #72-06 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e1c083e5-ccf0-40ac-bee3-5cb9eeef419c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Box #72-07", null, "Box #72-07 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d58ead69-77a0-448d-bfaa-6bbd2fbe39fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Box #72-08", null, "Box #72-08 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("36bd9861-7d12-46c8-9554-7e7f7b8538a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Box #72-09", null, "Box #72-09 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1b8e026d-ec1f-4bcb-9771-68ee94a012ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-1 Ziploc bag", null, "Box #72-1 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e05ff9c1-f5ff-42f6-ab72-99f76126cefc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Box #72-10", null, "Box #72-10 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1f35087b-49fb-4d6a-844b-222ebf2fa9e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Box #72-04", null, "Box #72-04 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ca16eb0c-fe6a-4e58-86ef-1dfeceb8d225"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-10 Ziploc bag", null, "Box #72-10 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f1f24d7e-c0b5-4438-a4ee-db9ec8d5fdca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL-Old", "Box #72-11", null, "Box #72-11 (UHXL-Old) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("698adf75-2ea8-4896-9827-0d2b67b45116"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-11 Ziploc bag", null, "Box #72-11 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("786bd0b7-9d6e-413f-b125-5a3d41921553"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Box #72-12", null, "Box #72-12 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("41fd5312-4758-4095-8001-17b8d84b8065"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-12 Ziploc bag", null, "Box #72-12 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("55a11871-0bf4-4462-b997-3cd65296e920"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM-Old", "Box #72-13", null, "Box #72-13 (UHM-Old) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("15672e3d-c4ec-408d-b1f9-aa6d7fd0f3e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-13 Ziploc bag", null, "Box #72-13 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a48013bb-2e79-428e-aee9-d306eecc5682"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Box #72-14", null, "Box #72-14 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("939faaab-f62c-4388-8d60-b4c4caee48b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHL-Old", "Box #72-11", null, "Box #72-11 (UHL-Old) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("07ef447e-4f84-4571-887c-581f783560ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-14 Ziploc bag", null, "Box #72-14 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("df03e6e9-fec1-4764-8e64-b426543a2d64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Box #72-03", null, "Box #72-03 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("766d5d76-f616-4678-bf79-1121dcabae14"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Box #72-01", null, "Box #72-01 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3d227d0b-f35a-4d61-8651-5de35cc37ee0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Box #144-2", null, "Box #144-2 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a30276bf-5653-47f9-ae67-fb5030d2ee38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #144-2 Ziploc bag", null, "Box #144-2 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("81eb36f1-e074-44fa-bd12-31c9cd8d8ec1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #3 Ziploc bag", null, "Box #3 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("211a4a81-40a3-432b-beb4-a71f598c1000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHL", "Box #350-1", null, "Box #350-1 (UHL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ed2d26b5-69a4-41b5-a820-2cceeaa968f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #350-1 Ziploc bag", null, "Box #350-1 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f498d0eb-8651-4a7c-b07e-697a8df3bdbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Box #350-2", null, "Box #350-2 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8b11fc90-6c1b-4f48-8c64-f88027deb93e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #350-2 Ziploc bag", null, "Box #350-2 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b6d1a446-3ee1-4686-ab4d-e1555863eeeb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM-Old", "Box #72-02", null, "Box #72-02 (UHM-Old) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b48691f0-8940-4240-af43-7a6a6ccc899c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM-Old", "Box #700-1", null, "Box #700-1 (UHM-Old) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1e7ab396-ee8d-42bd-b833-77a63ead36d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHL", "Box #700-2", null, "Box #700-2 (UHL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8787dcef-2543-4f1f-b63c-c66e81391c22"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #700-2 Ziploc bag", null, "Box #700-2 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("74bc9abf-c5e2-4a45-a71e-4cc3f46b965c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #700-2 Ziploc bag\\par", null, "Box #700-2 Ziploc bag\\par", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4155c02c-6197-4896-aa59-1cf4b992e2e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Box #700-3", null, "Box #700-3 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c9a2782b-74ef-4472-a29f-b32e0278f3fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #700-3 Ziploc bag", null, "Box #700-3 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c14d1597-6582-4b64-8376-295ae8074509"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 15x12x8", "Box #700-4", null, "Box #700-4 (Unmarked 15x12x8) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a6bc772f-32d9-45c3-90b3-7efc2d787f3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #700-4 Ziploc bag", null, "Box #700-4 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d9ef6eda-f23c-402e-9adf-45850b83179d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #700-1 Ziploc bag", null, "Box #700-1 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("99f646b8-768c-4be6-903d-e2375a89bdc7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #144-1 Ziploc bag", null, "Box #144-1 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("329cd9fc-f40e-422f-954d-e22783f9bfe7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-2 Ziploc bag", null, "Box #72-2 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0bec035b-9814-41d4-92c7-fa36880e9c10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-5 Ziploc bag (2nd set, with wheels, left in box)", null, "Box #72-5 Ziploc bag (2nd set, with wheels, left in box)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1120e839-bce5-4a82-b6dd-8f66c3af2d40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "CD Box #2", null, "CD Box #2 (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cd7188b4-0eae-4fea-938a-4e22249ee640"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "CD Box #3", null, "CD Box #3 (ESSS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cbf8a9c6-2a18-425d-baf6-6bd1fd05eb9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "CD Box #4", null, "CD Box #4 (ESSS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cc5bdcdf-833d-4500-8a8e-f4932493e122"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "CD Box #5", null, "CD Box #5 (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("76612146-b646-40f4-9af0-4023d1412202"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "CD Box #6", null, "CD Box #6 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5a232a99-1978-4c2e-a9ec-9a1999859712"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "CD Box #7", null, "CD Box #7 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d3edbc58-d53e-49e5-a5a3-cccc44351205"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "CD Box #8", null, "CD Box #8 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("686c3487-f581-49f8-afcb-2593a0105f70"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "CD Box #1", null, "CD Box #1 (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6706364a-457c-4329-b7f8-0814e4db1bfc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - Arcade", null, "CD Rack - Arcade [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2185b0b5-9888-4d68-bd35-561a0b955dfb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - FPS", null, "CD Rack - FPS [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8eac2d87-1867-42a7-b275-e4f40e00d57e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - RPG/Strategy", null, "CD Rack - RPG/Strategy [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("068a8404-ba8e-4420-9e2f-fcd5cfdc3bad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - Star Trek/Space Sim", null, "CD Rack - Star Trek/Space Sim [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f4c1ece1-2734-4b95-bdf6-8d657c91c3a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - Star Wars", null, "CD Rack - Star Wars [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5fb6f0af-ae4d-4faa-9e5b-acfc96e7bbef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - Strategy (C&C)", null, "CD Rack - Strategy (C&C) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a9b80b35-6df8-42cc-902f-cc3dc3badf4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - Strategy (Civilization)", null, "CD Rack - Strategy (Civilization) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1be4ba93-4e6c-4fda-8041-a60deceb799c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack", null, "CD Rack [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("24bcd63d-621f-49d4-8ebf-2e09319c9a8f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - Flight Sims", null, "CD Rack - Flight Sims [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("205ef2db-8738-4efa-ae60-bbc5bb0cddff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-4 Ziploc bag", null, "Box #72-4 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("35356d1a-7666-4daf-841b-37e93194fc9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Carol's Room", null, "Carol's Room", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d20210d1-389d-4203-be21-74a5c4c55f37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Carol's Books HB Fiction", null, "Carol's Books HB Fiction", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bbd26398-76fd-4de1-a275-70c26ace67db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-5 Ziploc bag", null, "Box #72-5 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("fe7500ce-82ba-41d3-9ded-256fe021f5f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-6 Ziploc bag", null, "Box #72-6 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("571ba536-4b5d-46ab-98fc-12c027820117"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-7 Ziploc bag", null, "Box #72-7 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("327b5606-e8a4-4442-b647-2f30e62d6594"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-8 Ziploc bag", null, "Box #72-8 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("dafc1f93-9c80-4d21-a021-49a6614924be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-9 Ziploc bag", null, "Box #72-9 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2133c268-9931-44f5-958d-863809a5bfbb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #TB-1", null, "Box #TB-1", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4e451282-095e-49a6-81ff-aa8753eec838"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #TB-2", null, "Box #TB-2", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cc903db6-0308-45bf-8f88-fd9268b8090f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Carol's Office", null, "Carol's Office", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0c48b33d-aebe-43e9-8999-8c36815f8dea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #09", null, "Ken's Books Box #09 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("158bd858-0775-4afb-89f8-42608f9263e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "C200809.2", null, "C200809.2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b6a730cd-810a-4cf2-ba7e-ff0bbf2d84ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "C200809.3", null, "C200809.3 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d5f6f97a-8f23-433b-9d22-edf7e02776e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "C200810.1", null, "C200810.1 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("278db3bb-8fb4-403c-aeaf-78f0fca1b485"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "C200810.2", null, "C200810.2 (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2b32fcf5-e69a-4232-85fd-a685d157b12e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Car Box #1 Ziploc bag", null, "Car Box #1 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("15d4fefa-2fad-40aa-aba0-e9b11cfa04ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Car Collectables Box #01", null, "Car Collectables Box #01 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cefc6760-b74a-42e4-abd5-a85851e82d75"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Car Models Box #1", null, "Car Models Box #1 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7f637a55-bd03-483b-acad-8962da85098f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "C200809.1", null, "C200809.1 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c9e39ced-4733-422a-acb6-474fdb91eceb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack", null, "CD Rack", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("58446778-ca14-4d30-a535-5dd4e356b8b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS-Old", "Box #144-1", null, "Box #144-1 (UHS-Old) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2b728d90-3679-4727-a367-702e8c454d2d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Borrowed", null, "Borrowed", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e350d372-901f-4ee9-a141-3e5fba317b0f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Delta\\Public\\Shared TV\\SciFi", null, "\\\\Delta\\Public\\Shared TV\\SciFi", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("95e78a3d-0905-4a1d-8518-9f33906ab97c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Delta\\Public\\Shared TV\\War", null, "\\\\Delta\\Public\\Shared TV\\War", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3f99695a-c9c1-4be6-9cee-3f80a5308848"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Delta\\Public\\Shared TV\\Western", null, "\\\\Delta\\Public\\Shared TV\\Western", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d6075c6a-1a35-4f39-ae73-3d9e5c748e6f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\Animation", null, "\\\\Echo\\Public\\Shared TV\\Animation", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4c0c65fd-cd7e-4b3a-b9c4-c49afc2eae2c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\Comedy", null, "\\\\Echo\\Public\\Shared TV\\Comedy", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1adb51f3-bd7d-4268-947f-017df074b5f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\Documentary", null, "\\\\Echo\\Public\\Shared TV\\Documentary", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f532299f-d01d-4595-9b73-768e273d7190"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\Documentary\\NFL Films", null, "\\\\Echo\\Public\\Shared TV\\Documentary\\NFL Films", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ae055892-c6aa-4c58-9da4-ee04bfe8efba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Delta\\Public\\Shared TV\\Drama", null, "\\\\Delta\\Public\\Shared TV\\Drama", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("684e6aff-cc7a-45e7-a72c-cdf0cc131463"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\Drama", null, "\\\\Echo\\Public\\Shared TV\\Drama", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("71ae75c8-204b-40f1-bd98-1265d60ff850"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\War", null, "\\\\Echo\\Public\\Shared TV\\War", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0f0ac2a6-7adb-49a1-8f19-e8aaef9dfdb5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Foxtrot\\Public\\Shared TV\\Horror", null, "\\\\Foxtrot\\Public\\Shared TV\\Horror", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6dbf349a-d7f4-4bb0-ac5c-aa10164ad2a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Foxtrot\\Public\\Shared TV\\SciFi", null, "\\\\Foxtrot\\Public\\Shared TV\\SciFi", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9d919039-1426-4420-95cd-0198b94a43fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Foxtrot\\Public\\Shared Videos\\Exercise", null, "\\\\Foxtrot\\Public\\Shared Videos\\Exercise", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("65b3e9ef-5068-4e83-bffc-b5f14bfb9cf0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Foxtrot\\Public\\Shared Videos\\Music Videos", null, "\\\\Foxtrot\\Public\\Shared Videos\\Music Videos", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5763c936-5e17-47a7-90b8-cddf3be83c68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Foxtrot\\Public\\Shared\\Videos\\Music Videos", null, "\\\\Foxtrot\\Public\\Shared\\Videos\\Music Videos", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("fe46a771-f0f1-4abf-aea4-e1e304157a40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Apple Software Box", null, "Apple Software Box", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d7dc7fd1-3e27-4e07-bdf8-8081ea306891"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\SciFi", null, "\\\\Echo\\Public\\Shared TV\\SciFi", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0bf78cb8-6ecf-4d92-8c9d-4b0e03fffd5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Applied", null, "Applied", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4c4f047a-6923-431b-b163-d308c0ca6ff3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Delta\\Public\\Shared TV\\Comedy", null, "\\\\Delta\\Public\\Shared TV\\Comedy", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("621ae32e-786e-43f4-bd7f-43267c117578"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Western", null, "\\\\Charlie\\Public\\Shared Movies\\Western", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("34050d8e-9192-4747-823c-3a1bafb07fb3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "?? Ziploc bag", null, "?? Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2ca177c8-d6dd-40b9-9ed5-2f4502fd1819"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "@ Large", null, "@ Large", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2a8e5bec-9206-4290-985b-ab73b74c889d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Action", null, "\\\\Charlie\\Public\\Shared Movies\\Action", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("18f704f3-ca35-4883-a8e2-0f27137313af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Adventure", null, "\\\\Charlie\\Public\\Shared Movies\\Adventure", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3bc6e48b-566e-4b6f-a87b-25b0f0e8958b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Cartoon-CG", null, "\\\\Charlie\\Public\\Shared Movies\\Cartoon-CG", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f334a0bf-a94e-4dc9-9930-d46c5e9467bd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Christmas", null, "\\\\Charlie\\Public\\Shared Movies\\Christmas", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("06931010-7cf4-4400-80b7-11756fd8ef49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Comedy", null, "\\\\Charlie\\Public\\Shared Movies\\Comedy", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4b575358-c929-4da6-a628-eedc63694ba0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Delta\\Public\\Shared TV\\Animation", null, "\\\\Delta\\Public\\Shared TV\\Animation", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bf90bdc3-09bd-49a4-92be-1c44ed959377"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Documentary", null, "\\\\Charlie\\Public\\Shared Movies\\Documentary", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1f1290ec-c65e-40df-97d5-b0c64a8f2135"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Fantasy", null, "\\\\Charlie\\Public\\Shared Movies\\Fantasy", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("52e54e61-5b35-4689-b74e-66f67841c69c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Horror", null, "\\\\Charlie\\Public\\Shared Movies\\Horror", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b94db799-3125-421f-b2c5-598831d556f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Musical", null, "\\\\Charlie\\Public\\Shared Movies\\Musical", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("538d0ef5-2240-448f-9524-1c1d79184b7f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Mystery", null, "\\\\Charlie\\Public\\Shared Movies\\Mystery", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b05f483d-2a15-47e4-b14b-a69160d63f4e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Science Fiction", null, "\\\\Charlie\\Public\\Shared Movies\\Science Fiction", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f359a9f3-5145-4b8d-82cb-5e728e8071e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Sports", null, "\\\\Charlie\\Public\\Shared Movies\\Sports", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("34c75524-82d3-4386-8d96-294629d842a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\War", null, "\\\\Charlie\\Public\\Shared Movies\\War", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ce3e0796-bb20-4005-af36-e30449b5e798"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Drama", null, "\\\\Charlie\\Public\\Shared Movies\\Drama", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1631d63d-a735-4c14-b109-ba714d22ef1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #? Ziploc bag", null, "Box #? Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("352d27db-dd07-4233-a857-9110e5c3b6d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Art Books Box #7", null, "Art Books Box #7 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("fb5458d4-c664-4016-b781-9461fda0a0da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Aurora USS Enterprise Box", null, "Aurora USS Enterprise Box [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e5c247b1-daa4-45bb-8431-7e7dea32bdbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase A", null, "Bookcase A (Top Shelf) [Ken's Room - West Wall By Door]", "Ken's Room - West Wall By Door (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0d052919-f139-4119-93a2-35d89b921b3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase B", null, "Bookcase B (Bottom Shelf) [Ken's Room - West Wall Back]", "Ken's Room - West Wall Back (Bottom Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("aee8f41b-af57-4dcd-b12d-c2056a114e74"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase B", null, "Bookcase B (Second Shelf) [Ken's Room - West Wall Back]", "Ken's Room - West Wall Back (Second Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("24994b11-590d-4aea-888b-f1f3626b85e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase B", null, "Bookcase B (Third Shelf) [Ken's Room - West Wall Back]", "Ken's Room - West Wall Back (Third Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d65f90e7-c683-4a0c-8929-e97a5156fd64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase B", null, "Bookcase B (Top Shelf) [Ken's Room - West Wall Back]", "Ken's Room - West Wall Back (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8c4e48a8-ec8b-440f-b9dc-35783220d28d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase C", null, "Bookcase C (Bottom Shelf) [Ken's Room - West Wall By Closet]", "Ken's Room - West Wall By Closet (Bottom Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("877d3f14-39e2-48dd-bdbf-e7736cb44e04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase C", null, "Bookcase C (Second Shelf) [Ken's Room - West Wall By Closet]", "Ken's Room - West Wall By Closet (Second Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("385389a4-898f-40ea-a668-22ea7376de91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase A", null, "Bookcase A (Third Shelf) [Ken's Room - West Wall By Door]", "Ken's Room - West Wall By Door (Third Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("73488154-dd13-4bbe-af82-f2c5aaaa2020"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase C", null, "Bookcase C (Third Shelf) [Ken's Room - West Wall By Closet]", "Ken's Room - West Wall By Closet (Third Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("89053eab-5e78-41b8-8190-6338ac4ea862"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase F", null, "Bookcase F (Second Shelf) [Ken's Room - Front Wall]", "Ken's Room - Front Wall (Second Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2b8c5357-1374-4699-8ad1-e803a6c88400"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase F", null, "Bookcase F (Top Shelf) [Ken's Room - Front Wall]", "Ken's Room - Front Wall (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1e174f0a-a969-4587-b713-9c5213e08723"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookshelf", null, "Bookshelf (Bottom Shelf) [Ken's Room - Back Wall]", "Ken's Room - Back Wall (Bottom Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f5e079c6-0cf1-4ad2-9862-2a71a70cb188"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookshelf", null, "Bookshelf (Bottom Shelf) [Ken's Room - East Wall]", "Ken's Room - East Wall (Bottom Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e9197a76-5304-4b91-b022-aebb0014ab7b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookshelf", null, "Bookshelf (Top Shelf) [Ken's Room - Back Wall]", "Ken's Room - Back Wall (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("84e08c7c-98d8-40f0-9ad9-c43808626f55"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookshelf", null, "Bookshelf (Top Shelf) [Ken's Room - East Wall]", "Ken's Room - East Wall (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9af2a869-0d10-4528-8000-05b29867f67c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookshelf", null, "Bookshelf", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ec233619-4043-4642-895d-551e6f56ca6f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase C", null, "Bookcase C (Top Shelf) [Ken's Room - West Wall By Closet]", "Ken's Room - West Wall By Closet (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c047648a-a3d4-4e9e-9e62-0eaee152c2d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Attic", null, "Attic", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("410b4aff-b47d-4214-857d-12f11f54f889"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase A", null, "Bookcase A (Second Shelf) [Ken's Room - West Wall By Door]", "Ken's Room - West Wall By Door (Second Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("15be25ca-482c-4497-b7fb-2b2d8856243a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase #1", null, "Bookcase #1 (Top Shelf) [Carol's Room - East Wall]", "Carol's Room - East Wall (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("82373c25-8eb2-45f3-9928-d2cf6ad0720c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea - Allies Case", null, "Axis&Allies War at Sea - Allies Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d3f80cfd-495a-4e0e-9b73-5fce6dc0eb8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea - Axis Case", null, "Axis&Allies War at Sea - Axis Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1c1cecae-aeef-4fcf-b8e9-65679681fdcf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea Condition Zebra Case", null, "Axis&Allies War at Sea Condition Zebra Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("56f47228-9650-4f80-b1e7-345b7912d958"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea Flank Speed Case", null, "Axis&Allies War at Sea Flank Speed Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7cd0665f-38f5-44df-a08d-269d0b1d968d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea Fleet Command Case", null, "Axis&Allies War at Sea Fleet Command Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b9a46e8a-0ae7-427c-883a-369defa26dfb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea Surface Action Case", null, "Axis&Allies War at Sea Surface Action Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bd372e37-8567-4ef2-b4ae-a66f1a427f3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea Task Force - Allies Case", null, "Axis&Allies War at Sea Task Force - Allies Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f613d637-1dd9-45ef-bc13-9c4f5322c853"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase A", null, "Bookcase A (Bottom Shelf) [Ken's Room - West Wall By Door]", "Ken's Room - West Wall By Door (Bottom Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("78443ac3-3b1c-43a8-84ef-0d4324159fbd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea Task Force - Axis Case", null, "Axis&Allies War at Sea Task Force - Axis Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f23aa1b3-57b4-4ef0-a57b-1d8a10dbda8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Basement Toolbox", null, "Basement Toolbox", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("86418488-3373-4285-b673-da301c29bbc5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Basement Workbench", null, "Basement Workbench", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bd835362-d8d9-454e-9988-7ac05edf0738"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Basement", null, "Basement", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a311b350-ee87-4124-b766-e058a1bd4264"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Battlestar Galactica Raptor Armament Set", null, "Battlestar Galactica Raptor Armament Set", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9340873d-9a71-429f-9186-0625ed06aec9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase #1", null, "Bookcase #1 (Atop) [Carol's Room - East Wall]", "Carol's Room - East Wall (Atop)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("92ff220b-21c7-42b1-87ed-bf7a228e9a26"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase #1", null, "Bookcase #1 (Second Shelf Shelf) [Carol's Room - East Wall]", "Carol's Room - East Wall (Second Shelf Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e1c2787a-34b3-44e7-ab16-9080e3fc3f77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase #1", null, "Bookcase #1 (Third Shelf Shelf) [Carol's Room - East Wall]", "Carol's Room - East Wall (Third Shelf Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7fc48c4d-8eb0-440a-9ba6-7943f7235e5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESSS", "Baseball Cards Box #1", null, "Baseball Cards Box #1 (ESSS) [Closet]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("01b5760e-48ec-4b8a-934e-455f30a919c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Christmas CDs", null, "Christmas CDs", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5e69f3b6-3725-4da7-a010-3ea43557ca8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #TB-3", null, "Box #TB-3", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3f60ab9c-2f09-4991-b2be-099791f70540"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Closet", null, "Closet", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("acd2d839-4ee9-478a-a463-e275896505f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon K3", "Hot Wheels Box #2014B", null, "Hot Wheels Box #2014B (Amazon K3) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("72519c67-20e1-4fad-93ac-e61c314a5d10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x12.5x6", "Hot Wheels Box #2014C", null, "Hot Wheels Box #2014C (Unmarked 16x12.5x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bbea0c99-df02-4370-9805-7bfb553834a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 11x8x6", "Hot Wheels Box #2014D", null, "Hot Wheels Box #2014D (Unmarked 11x8x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d0ac3adf-5720-4c46-8c8a-12e7baf65319"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 1AE", "Hot Wheels Box #2016A", null, "Hot Wheels Box #2016A (Amazon 1AE) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("67b24a62-2d18-4c9b-8e77-7f3e37dba89f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 1AE", "Hot Wheels Box #2016B", null, "Hot Wheels Box #2016B (Amazon 1AE) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1d1dd78f-d83a-475c-a67c-78628c718643"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 1AE", "Hot Wheels Box #2016C", null, "Hot Wheels Box #2016C (Amazon 1AE) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("202fe251-40cf-4dad-9554-041244150125"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x14x9", "Hot Wheels Box #2017A", null, "Hot Wheels Box #2017A (Unmarked 14x14x9) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("82acc42c-4a03-44cb-9209-418548942559"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FantasyFlight", "Hot Wheels Box #2014A", null, "Hot Wheels Box #2014A (FantasyFlight) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("60558c51-917b-4bef-b8f0-2e938609034d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 17x13x6", "Hot Wheels Box #2017B", null, "Hot Wheels Box #2017B (Unmarked 17x13x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8d986d6b-8b4c-41b0-866d-bcd11db0cad9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Christmas DVDs", null, "Christmas DVDs", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("05a4a12d-6f7a-4bf5-b8db-a9cafd2c944f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 1A5", "Hot Wheels Box #2018B", null, "Hot Wheels Box #2018B (Amazon 1A5) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d18cf4f9-0c38-487b-ad51-072126ec0f52"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x12x8", "Hot Wheels Box #2018C", null, "Hot Wheels Box #2018C (Unmarked 16x12x8) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("80f896c5-bf18-4363-956a-38d8b3ee24ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x8x6", "Hot Wheels Box #2018D", null, "Hot Wheels Box #2018D (Unmarked 16x8x6) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("82f3da51-c44a-4448-af09-305c9e4bef50"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 13x9x5.25", "Hot Wheels Box #21", null, "Hot Wheels Box #21 (Unmarked 13x9x5.25) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("67c71d99-8974-4758-af6b-69cab35bb9e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel L2593 Case", "Hot Wheels Box #22", null, "Hot Wheels Box #22 (Mattel L2593 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ebf01ea6-720e-48ec-bf8f-1134fe92773a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x12x8", "Hot Wheels Box #23", null, "Hot Wheels Box #23 (Unmarked 16x12x8) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5a395dee-29ce-43dc-846a-ed6fb93e2cb9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x8x7", "Hot Wheels Box #2017C", null, "Hot Wheels Box #2017C (Unmarked 16x8x7) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("62b5d316-2e84-4214-89f3-2924a84de37a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "USPS Priority Mail Medium", "Hot Wheels Box #24", null, "Hot Wheels Box #24 (USPS Priority Mail Medium) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ce800990-e604-473a-8611-2be8463638d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 18x10x4", "Hot Wheels Box #20", null, "Hot Wheels Box #20 (Unmarked 18x10x4) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1b7118ac-eed4-4eda-b730-b631ef4d0cef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x12x6", "Hot Wheels Box #18", null, "Hot Wheels Box #18 (Unmarked 14x12x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d362e5e0-93fd-4db1-af47-9fb54057ea08"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 12x9x6", "Hot Wheels Box #02", null, "Hot Wheels Box #02 (Amazon 12x9x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5a57f6e5-0613-4fbb-ada8-6db259adc002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Hot Wheels Box #03", null, "Hot Wheels Box #03 (ESSS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ea2ab4dc-964a-4d3c-8d37-0c409b4c184b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Hot Wheels Box #04", null, "Hot Wheels Box #04 (ESSS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b627044c-691d-4fdc-b0bc-c4979d7e7635"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Hot Wheels Box #05", null, "Hot Wheels Box #05 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("41eef900-3dad-4e7a-bc71-ac498b85c16e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Hot Wheels Box #06", null, "Hot Wheels Box #06 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1b75574c-f018-481e-9957-3aa3671a578a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x12x6", "Hot Wheels Box #07", null, "Hot Wheels Box #07 (Unmarked 14x12x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("98ba92a5-4038-42fc-942d-80f95cea26c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B&N 13x11x6", "Hot Wheels Box #08", null, "Hot Wheels Box #08 (B&N 13x11x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6f40be36-1c73-4030-8c63-a29c6e370075"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel X8308 Case", "Hot Wheels Box #19", null, "Hot Wheels Box #19 (Mattel X8308 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c3e3e823-37d2-4100-a3bc-a9446e4e6b85"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 12x9x6", "Hot Wheels Box #09", null, "Hot Wheels Box #09 (Unmarked 12x9x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f60959d5-87d8-4cf4-b463-e3d1cc0c5328"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x12.5x6", "Hot Wheels Box #11", null, "Hot Wheels Box #11 (Unmarked 16x12.5x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c0893e43-7ec4-47bb-9364-31ef8a6842b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 13x11x5", "Hot Wheels Box #12", null, "Hot Wheels Box #12 (Unmarked 13x11x5) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7772bd0d-c203-4973-8b80-5bc4feb70ef0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel L2593 Case", "Hot Wheels Box #13", null, "Hot Wheels Box #13 (Mattel L2593 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4a752602-096e-47a0-a060-1ccb447e45e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x10x6", "Hot Wheels Box #14", null, "Hot Wheels Box #14 (Unmarked 14x10x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b397f37e-0771-4dbe-b643-930473133d29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 10x8x6", "Hot Wheels Box #15", null, "Hot Wheels Box #15 (Unmarked 10x8x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ba3daf87-9bb3-4168-bbcb-5755ca3dfea8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel BDT77 Case", "Hot Wheels Box #16", null, "Hot Wheels Box #16 (Mattel BDT77 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f045d7a9-9349-480a-87c1-4f952be1dfd6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel X8893 Case", "Hot Wheels Box #17", null, "Hot Wheels Box #17 (Mattel X8893 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ba740135-93c0-4783-94f2-617a8c17e781"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel L2593 Case", "Hot Wheels Box #10", null, "Hot Wheels Box #10 (Mattel L2593 Case) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ebb6dcf6-8431-480c-b4b2-2adc2239b894"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Wheels Box #01", null, "Hot Wheels Box #01", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d5b32e36-5459-4bd0-bd3d-4e4a4ffebbd2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x12x12", "Hot Wheels Box #25", null, "Hot Wheels Box #25 (Unmarked 16x12x12) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7bd46fc7-8cbf-4e6e-9041-adc4b141f884"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B&N.com 14x11x6", "Hot Wheels Box #27", null, "Hot Wheels Box #27 (B&N.com 14x11x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5e44860e-7886-41b0-9012-ee1d41528d34"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Inside E-2C Hawkeye Box (Revell 03945 Kit #2640)", null, "Inside E-2C Hawkeye Box (Revell 03945 Kit #2640)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("179d299d-8518-489b-b18b-207c98f51b44"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Inside Kit Box (Revell 03945 Kit #2640)", null, "Inside Kit Box (Revell 03945 Kit #2640)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ce6b3201-e622-43a8-8e47-47cf692d3c22"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Inside Kit Box (Revell 04882 Kit #2619)", null, "Inside Kit Box (Revell 04882 Kit #2619)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("539768de-ed4f-4a62-892d-a644ffac4a75"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Inside Kit Box (Trumpeter 05711 Kit #2731)", null, "Inside Kit Box (Trumpeter 05711 Kit #2731)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2726599a-9a04-41b3-9d3e-1b0f86419299"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Inside Kit Box (Trumpeter 05712 Kit #2732)", null, "Inside Kit Box (Trumpeter 05712 Kit #2732)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("02044972-c5e8-4047-9674-b1d55de4f923"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Inside Kit Box", null, "Inside Kit Box", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("19f9be03-eaab-4953-a1ef-ac30d11aa38f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Installed", null, "Installed", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4ec2f978-b747-47c3-b374-e67953d474c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Included in kit", null, "Included in kit", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("69f09d85-ee24-46a5-9f94-6cddfa30381f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "JVC CH-200 Box Ziploc bag", null, "JVC CH-200 Box Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("70f19f23-c40c-4d25-8b25-038af8fb87dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #01", null, "Ken's Books Box #01 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d2bcc42f-f5b2-4cc5-a07b-6344397ab113"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #02", null, "Ken's Books Box #02 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("771bc5c8-041d-48a1-ad59-1cafe7ae0fbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #03", null, "Ken's Books Box #03 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("780eaa74-0e34-4f4e-bfb8-275f8dc33a10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #04", null, "Ken's Books Box #04 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("287869f7-8dd2-4dce-b90f-eab15b7e8451"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #05", null, "Ken's Books Box #05 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8c65acda-6c47-4b48-89a6-701c79fc7d8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #06", null, "Ken's Books Box #06 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e6be2a9f-c9cd-49ee-8dae-4cdbb4844268"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #07", null, "Ken's Books Box #07 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b8d18ec5-2e36-4fa9-8eb8-ae8be05f2cef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "JVC CH-X200 Box", null, "JVC CH-X200 Box [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4b177bc3-6b27-43d2-8190-bf90d606c291"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 1A7", "Hot Wheels Box #26", null, "Hot Wheels Box #26 (Amazon 1A7) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8a33dc4b-2cd6-4c9a-b76a-00e5cb0dc50d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Husky Tools Organizer #1", null, "Husky Tools Organizer #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7df1c8b5-e872-47db-a943-4e4be315107e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 20x20x6.5", "Hot Wheels Star Wars C-Cars Box #1", null, "Hot Wheels Star Wars C-Cars Box #1 (Unmarked 20x20x6.5) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("dad3d0ab-9c7e-44ee-bc83-126164281e8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked Priority Mail 16x12x4", "Hot Wheels Box #28", null, "Hot Wheels Box #28 (Unmarked Priority Mail 16x12x4) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5d284ab7-9dd2-40d8-a64f-a55f9d9700a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x14x6.5", "Hot Wheels Box #29", null, "Hot Wheels Box #29 (Unmarked 14x14x6.5) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1d0b074e-d62a-4fab-a9c7-b669ac170650"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14.5x11x6.5", "Hot Wheels Box #30", null, "Hot Wheels Box #30 (Unmarked 14.5x11x6.5) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("981be036-6e69-4d91-be07-e835067e1473"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x10.5x7", "Hot Wheels Box #31", null, "Hot Wheels Box #31 (Unmarked 14x10.5x7) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("18d685a9-62fd-46e7-9cb2-810b98fc94ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked Priority Mail 14x10x6", "Hot Wheels Box #32", null, "Hot Wheels Box #32 (Unmarked Priority Mail 14x10x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("22640367-c618-4ab5-b8aa-6e0264042cdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 1B4", "Hot Wheels Box #33", null, "Hot Wheels Box #33 (Amazon 1B4) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d0e0af43-51dc-4c1f-b581-265fb9d1d5c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel MD28", "Hot Wheels Box #34", null, "Hot Wheels Box #34 (Mattel MD28) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ee6f9f46-e0d6-4022-8b8a-b9199b78cd70"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Husky Supplies Organizer #1", null, "Husky Supplies Organizer #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b8c81fbd-a37f-4a6b-93bf-342c7a62ebe7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel BDT77 Case", "Hot Wheels Box #Retro 13D", null, "Hot Wheels Box #Retro 13D (Mattel BDT77 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3db27fdf-f821-48a4-bee0-fa982d1523ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel X8893", "Hot Wheels Box #Retro13B", null, "Hot Wheels Box #Retro13B (Mattel X8893) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2d3372cc-a693-408d-b8d0-9d9fdaf0cc89"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel X8893", "Hot Wheels Box #Retro13C", null, "Hot Wheels Box #Retro13C (Mattel X8893) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("01a952c4-2ad7-47a8-8619-78d7eaef6ba6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DLB45", "Hot Wheels Pop Culture - Peanuts Box", null, "Hot Wheels Pop Culture - Peanuts Box (DLB45) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0df3a3e7-db9f-479e-a821-6d0d2017fafc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DLB45", "Hot Wheels Pop Culture - Star Wars McQuarrie Box", null, "Hot Wheels Pop Culture - Star Wars McQuarrie Box (DLB45) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("799b2ef5-dc20-425c-ab1d-054adda587e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Wheels Sizzlers Box #01", null, "Hot Wheels Sizzlers Box #01 [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("95db5a10-b375-42aa-8e6c-703d15c179df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x14x8.5", "Hot Wheels Star Wars Carships Box #1", null, "Hot Wheels Star Wars Carships Box #1 (Unmarked 14x14x8.5) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2a89c74d-5e85-495c-948f-a0ef4d460058"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel FBB72 Case", "Hot Wheels Star Wars Carships Box #2", null, "Hot Wheels Star Wars Carships Box #2 (Mattel FBB72 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("34f8f2e1-ae59-4028-9962-11c94eae4175"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Squadron 18x12x6", "Hot Wheels Box #Retro13", null, "Hot Wheels Box #Retro13 (Squadron 18x12x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("682c2c7a-83c9-4674-a378-a70f7bd67f40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Wheels 48 Car Case #02", null, "Hot Wheels 48 Car Case #02 [Car Collectables Box #01]", "Car Collectables Box #01" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e732f3b0-2cd6-48d8-9a19-dd28b21d13d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel L2593 Case", "Hot Wheels Box #2018A", null, "Hot Wheels Box #2018A (Mattel L2593 Case) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a4ac08f1-8acb-4da2-be2e-65558c3b21f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #09", null, "Hot Cases #09 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d0761850-0225-4d29-8f47-8bb8db1f9513"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #03 - Waiting for WMV", null, "DVD Box #03 (UHS) [Attic] - Waiting for WMV", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("eb0fe790-b2dd-4293-b381-97ee18d32ba3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #03", null, "DVD Box #03 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8dc77134-003e-4f37-acff-46a17d821bf9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#03325", "DVD Box #05", null, "DVD Box #05 (#03325) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("86a9dce3-09ec-4c34-9047-980559396151"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #06", null, "DVD Box #06 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bc1cb1bd-786e-49ee-b839-6d1e89716a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #07", null, "DVD Box #07 [UHS Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d97b63bb-187d-4a25-ac50-a6e020a762f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #08", null, "DVD Box #08 [UHS Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9f8cdbcd-397a-4916-9d41-49bac59aa0fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #09", null, "DVD Box #09 [UHS Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("13b5b078-51de-4d9b-8910-a3a80bb8090d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #02", null, "DVD Box #02 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("dec1874a-4f8a-411c-a149-6d7c645d6c8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #10", null, "DVD Box #10 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2f5eb469-e82c-41ca-b232-2a5aa03b5c3b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #12", null, "DVD Box #12 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("58e2eda1-9028-4a2d-8b6c-d2a2dbbec0da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #13", null, "DVD Box #13 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f11301e0-1c10-471f-a497-8b1b475c6ddf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #14", null, "DVD Box #14 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7d828a42-2627-494e-a5e4-ee6924a1bcf0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #15", null, "DVD Box #15 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("41899946-bc7f-4e27-a4c2-908f769ea4b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #16", null, "DVD Box #16 (33250) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("357fdbe7-5fbf-4423-a3e0-29cd0e2fabef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #17", null, "DVD Box #17 (33250) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cfeaacf2-9e8d-49d9-8b2e-5bff3c24d080"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #18", null, "DVD Box #18 (33250) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8098407c-f544-4202-ab2d-09cf2833bcce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #11", null, "DVD Box #11 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("95586718-32b9-482f-ad4a-d4c7cb137786"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #19", null, "DVD Box #19 (33250) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ff0837ca-0548-4a34-af70-d8264fe8b111"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #02 - Waiting for WMV", null, "DVD Box #02 (UHS) [Attic] - Waiting for WMV", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d25d273a-c542-4a2a-b42e-32ebac534fcb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Donated", null, "Donated", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d03da636-1bb7-4477-907a-87e65f390f58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Combat Aircraft 2012-2014", null, "Combat Aircraft 2012-2014 [Top of Steps]", "Top of Steps" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b4b9ac3a-0418-455b-8bb3-511a14fb1587"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Combat Aircraft 2015-2018", null, "Combat Aircraft 2015-2018 [Top of Steps]", "Top of Steps" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8e45eab8-436a-4619-9a13-82b1d491ea79"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Computer Books Box #01", null, "Computer Books Box #01 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9ab13b55-b02c-4747-a3b7-d58a382c64dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Computer Books Box #02", null, "Computer Books Box #02 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cf36f141-adf5-448c-95bc-06883f9e70be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Computer Books Box #03", null, "Computer Books Box #03 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ea977781-f196-4699-b51c-ee1cdfd3a34a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "CS20101219.1", null, "CS20101219.1 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2e93aecb-d46c-4fbc-a167-bea479be8576"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "CS20101219.2", null, "CS20101219.2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("61e16b77-b60c-4e0b-a334-49e6705684de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Doorway PB Stack", null, "Doorway PB Stack [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c4f8d054-6a66-45aa-8ab0-1fdca7ba4e84"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Wheels 48 Car Case #01", null, "Hot Wheels 48 Car Case #01 [Car Collectables Box #01]", "Car Collectables Box #01" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9dbd7be9-e3f9-4b10-9cbd-6c3bdbee6c6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Decals salvaged", null, "Decals salvaged", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("57a926d9-31fb-44c2-84a0-1620c49d987d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Desk", null, "Desk", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bee19aef-1c79-4a8e-9a1b-7791c7818615"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Destroyed", null, "Destroyed", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("fca998dc-41c8-45d7-a26d-d207e9be3664"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "18x13x11", "Detail Sets Box", null, "Detail Sets Box (18x13x11) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5e234d82-137e-40fb-9a35-fbf6cb6283da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Die Cast Collectables Box #1", null, "Die Cast Collectables Box #1 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("80b630a9-2a1f-4943-bff2-2f1f1ba82081"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Digital Download", null, "Digital Download", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3bc3d608-07bf-4f8c-ad10-0fc5a61762ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Dining Room", null, "Dining Room", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("82642be6-c1f9-42fe-8b8b-abf68c349360"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Decals left with detail set included in kit", null, "Decals left with detail set included in kit", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5afec9a6-9f11-4e98-972f-777e0421f719"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #20 - Waiting for WMV", null, "DVD Box #20 (33250) [Ken's Room] - Waiting for WMV", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3e59b35d-e4ae-4646-96f5-5157ef702f03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Decals left in bag", null, "Decals left in bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ca88d6b3-f654-4fed-a6eb-5f95c557d2e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #21", null, "DVD Box #21 (33250) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3bd1fd9c-ca12-4758-beae-f12eaf19d472"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #3", null, "FreeTime Box #3 (Ken's Room)", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("31272b8a-e4bd-4582-a94c-c55d100420d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #3", null, "FreeTime Box #3 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6cc54d09-2451-468c-ba74-4cac702f67a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #4", null, "FreeTime Box #4 (Ken's Room)", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c4e6b3b6-145e-49fc-8dc4-a957493537e3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #5", null, "FreeTime Box #5 (Ken's Room)", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f30bfa8e-8c95-4adb-8add-7e0bb0e97693"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #5", null, "FreeTime Box #5 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("090a9ca0-de57-413d-b3f5-ab854b876d80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "HALO Box #1", null, "HALO Box #1 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("092f638c-cb19-4b0f-949d-74f34e3b5d2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "History Books Box #10", null, "History Books Box #10 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b1cf2a69-e4d2-4554-9ed7-d3e7001b4f7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #2", null, "FreeTime Box #2 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6b1f860b-6d17-460c-a2c2-b1dda4734e88"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "History Books From Ken's Desk", null, "History Books From Ken's Desk (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f684b070-e19b-4758-8a90-f5106d813173"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #02", null, "Hot Cases #02 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("782654e2-0df0-4ec5-bad0-ee38bd8e59d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #03", null, "Hot Cases #03 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("81da8618-d318-49c4-917f-f58345d27f0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #05", null, "Hot Cases #05 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("164a95dc-0055-4baf-b08a-36827d620929"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #06", null, "Hot Cases #06 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("870246c4-ff03-4b90-af2b-e2b3271c78d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #07", null, "Hot Cases #07 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bf762ed2-6643-4770-a46d-52d808079998"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #08", null, "Hot Cases #08 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("958b34da-454f-4ab1-b668-c27562709e29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #20", null, "DVD Box #20 (33250) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c47ee284-89cc-468a-8a31-89ccf9d28edc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #01", null, "Hot Cases #01 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1a00dfb8-9c49-430a-a5d9-cf352b3c74b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #2", null, "FreeTime Box #2 (Ken's Room)", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2334cb14-1b8c-4510-9e87-40765544c6c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #04", null, "Hot Cases #04 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("53448fdb-8efc-4c7d-8cac-2af904b065d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 20x14x7", "Forbidden Planet Box", null, "Forbidden Planet Box (Unmarked 20x14x7) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8a6c1195-3953-4422-8095-bd7e140d7478"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #1", null, "FreeTime Box #1 (Ken's Room)", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3cefb039-3f4f-461c-8948-f14521f68f49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #23", null, "DVD Box #23 (33250) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("89c84d1d-a615-42e5-a30b-da5f8e32c5f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #24", null, "DVD Box #24 (33250) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2057f146-04d2-4c2a-8bf2-b104de7b6319"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #22", null, "DVD Box #22 (33250) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2fc7f37a-3653-4f38-b3ec-3a287473db56"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "DVDs - General Box #1", null, "DVDs - General Box #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b17ec06c-dc45-44c2-912d-e28caf761bd0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "DVDs - General Box #2", null, "DVDs - General Box #2 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("44a2129a-e293-4aca-9253-e477ccd795f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVDs - General Box #2", null, "DVDs - General Box #2 [UHS Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2704b2fd-a0a9-48d1-8980-a91bb66af64d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Entertainment Center Shelf", null, "Entertainment Center Shelf", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ea010cca-ed2a-40b7-a110-d7ebf32d42ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVDs - General", null, "DVDs - General [UHS Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1597b097-04fb-4980-8ef9-ad08f0f135b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Federation Box #1", null, "Federation Box #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("15c2663e-f8c5-457e-998d-a62602314a7b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Fiction Books Box #2", null, "Fiction Books Box #2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3deb3ea0-23e0-4960-b971-be05383625a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Fiction Books Box #3", null, "Fiction Books Box #3 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1acf4c90-103a-490a-a080-75b0046d367e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Fiction Books Box #6", null, "Fiction Books Box #6 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("845a3439-564c-4568-9b5a-fdc162a32028"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Fiction Books Box #8", null, "Fiction Books Box #8 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("089af86b-ecf7-4225-81f9-9ea7dc1f8b0a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "File Entry", null, "File Entry", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f3b24200-efc7-49d3-a77b-039d09726af9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ether", null, "Ether", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a1081049-60f5-4462-b1e4-8ea988d94166"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESSS", "Football Cards Box #1", null, "Football Cards Box #1 (ESSS) [Closet]", "Closet" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("f46aea9d-2000-48d2-8980-64fd5de4e920"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guided Missile Frigates", null, "FFG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("d4d7063d-9e66-40a1-a607-70be380c0fdc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mine Countermeasures Support Ships", null, "MCS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("0ba1fadd-af90-4796-b04f-77ec85d97bd9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mine Countermeasures Ships", null, "MCM" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("178b0f8b-17e1-49c9-b961-02032473df16"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tank Landing Ships", null, "LST" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("bbe9b0e7-a44f-4089-be60-511210c61c0e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dock Landing Ships", null, "LSD" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("d513d3d6-1974-44f0-8446-4c4e4951eb04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Assault Ships (Helicopter)", null, "LPH" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("bde74b05-c597-4ed7-9dd3-5e6e613f2730"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Assault Ships (general purpose)", null, "LHA" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("652f014f-1aa1-43c5-b86b-4fb9243a6390"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Cargo Ships", null, "LKA" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("e25fc1a9-b9d4-418c-9e21-72d7db047aad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Assault Ships (multi-purpose)", null, "LHD" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("52b185dc-85f4-4464-a8ed-26849fa3ba69"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Littoral Combat Ship", null, "LCS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("24f78246-e4b7-4520-b7ee-4f9918fa377d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Command Ships", null, "LCC" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("bd51fa5b-0724-43eb-83b0-89129325eba7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unclassified Miscellaneous Units", null, "IX" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("6178a577-3203-41b1-a1c1-a7eb79078f8c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Transport docks", null, "LPD" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("42f57b5d-d900-42c1-afc3-d1ad77c6fe27"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minehunters, Coastal", null, "MHC" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("a4895508-4914-4177-9690-b4627ab4f264"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training Submarines", null, "SST" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("64e9c779-53d0-49e4-bf89-987abd2aba52"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrol Craft", null, "PC" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("c836cf48-1faa-4556-92d2-376591e691cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrol Gunboats", null, "PG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("0e306844-d5e7-4ed0-8100-77599ac98baa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrol Combatants - Missile (Hydrofoil)", null, "PHM" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("4c6b1b94-6ca9-4fc6-8889-0a625542a58c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Submarines", null, "SS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("566ccd99-cb24-4452-b192-cdfa0fe61d42"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ballistic Missile Submarines (Nuclear)", null, "SSBN" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("904a2b4b-7c59-4984-8e98-57b936e112e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Submarines (Nuclear)", null, "SSN" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("be9e360d-cea1-4bba-8b65-d4f7966ae41c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ammunition Ships (assigned to Military Sealift Command)", null, "T-AE" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("46552773-570c-4552-a7cd-6f22e89db179"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Combat Store Ships (assigned to Military Sealift Command)", null, "T-AFS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("bfe963f7-7794-44d3-a7ff-e2d53676cc6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oceanographic Research Ships", null, "T-AG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("300cc6e8-42d8-488c-8d9b-3072ad8c84d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oilers (assigned to Military Sealift Command)", null, "T-AO" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("a5336557-a6eb-47e9-8631-1b5d37e7bb4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast Combat Support Ships (assigned to Military Sealift Command)", null, "T-AOE" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("218aeb24-606e-4f9c-b97e-5fe2ec57cb85"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frigates", null, "FF" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("027e12f7-1c3b-49a6-b7a3-fccdd0153643"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salvage Ships (assigned to Military Sealift Command)", null, "T-ARS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("49b3bc1f-79f9-46f4-8399-c32080a690f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ocean Minesweepers", null, "MSO" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("ce8bd60c-02f5-4d78-b3e8-74dad1db25a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guided Missile Frigate (post WWII)", null, "DLG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("d0e57c25-ac96-4064-ba5e-6f13fd95ef51"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Submarine Tenders", null, "AS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("5195c68c-42a4-49cd-9bf7-f5d052856942"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Destroyer Escorts", null, "DE" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("b280e506-7f8a-4ebb-acaf-6c663a3618ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Submarine Tenders (assigned to Military Sealift Command)", null, "T-AS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("60c8eebd-716c-4501-acd1-8c5ac1b43527"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unassigned", null, "XXX" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("83afc0e9-e249-4427-a0a3-2d40713016d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heavy Armored Cruiser - Battleship prototype", null, "ACR" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("bf0cc35c-7dae-43e9-8e88-7b31d23d4f4d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Destroyer Tenders", null, "AD" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("303ccee9-180d-443e-866a-b7d3f896d936"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ammunition Ships", null, "AE" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("6f1ae519-ea07-4ea0-9081-54b640ef111d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oceanographic Research Ships", null, "AG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("6111243c-7dc0-43c6-b470-31319de28675"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miscellaneous Command Ships", null, "AGF" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("a8eca8e5-f87c-4923-8140-4e2eb3f4cb8f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Auxiliary Research Submarines", null, "AGSS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("0114e8f4-b1a7-4a7f-b8a5-6e04884d8fa2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oilers", null, "AO" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("df08533f-c392-461d-9162-e0f4e6d13503"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast Combat Support Ships", null, "AOE" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("a5652d63-338a-4077-83ce-231f4ae73a39"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Replenishment Oilers", null, "AOR" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("32440d61-bfdd-48cb-a8e7-f107d83e563b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "High Speed Transports", null, "APD" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("a4cccd58-5f66-40eb-a4d3-e8fb3454cff6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salvage Ships", null, "ARS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("d2614b5e-3161-468c-bfd2-7e50545d4dac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salvage and Rescue Ships", null, "ATS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("e59a3b74-ee03-427e-bbce-7a9141cfe558"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battleships", null, "BB" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("3f103ff1-89e8-4b00-badd-36d3804dc9da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heavy (Gun) Cruisers", null, "CA" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("1ff7afeb-4a34-471c-9553-3241874c53bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guided Missile Heavy Cruisers", null, "CAG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("5d02cb36-02b6-47cf-a35e-7bdfcb485c1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Large Cruisers", null, "CB" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("7f580920-2f24-4aa1-8c3d-f8286422effa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guided Missile Cruisers", null, "CG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("7b0be334-4d94-4051-90ae-51abf64d51f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guided Missile Cruisers (Nuclear)", null, "CGN" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("abdeafec-0d2d-47de-820a-8915ad194289"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Light (Gun) Cruisers", null, "CL" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("f865600a-2d76-4f8a-91d9-0b57d9f18eaf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Command Cruisers", null, "CLC" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("2fdb851e-0e9d-4fcd-b0de-d6e0597f289b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Light Guided Missile Cruisers", null, "CLG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("5b25ad33-0153-4cc6-9270-a69c92265150"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Multi-Purpose (Fleet) Aircraft Carriers", null, "CV" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("c4bb6b6e-3c7a-48c9-81a3-e843a2295f07"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escort Carriers", null, "CVE" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("6df64ae7-9a63-4b5c-b94b-576e8b956168"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Light Carriers", null, "CVL" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("acc6ef57-0d47-4859-a72a-e913328df084"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Multi-Purpose Aircraft Carriers (Nuclear)", null, "CVN" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("95d45d40-42d7-4e65-8572-54a70940e5f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Destroyers", null, "DD" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("c5d2a991-8cd2-4013-9339-19d7a6c72e3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guided Missile Destroyers", null, "DDG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("c7f1a94d-cd86-4edc-a276-7af6de1288f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post World War II Frigates", null, "DL" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("4b066234-9495-4693-a340-1b051e073e00"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Cargo Ships (assigned to Military Sealift Command)", null, "T-LKA" });
#endregion
            #region Indexes
            migrationBuilder.CreateIndex(
                name: "IX_AircraftDesignationsByDesignation",
                table: "AircraftDesignations",
                columns: new[] { "Designation", "ID" },
                unique: true,
                filter: "[Designation] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_LocationID",
                table: "Books",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_BooksByAlphaSort",
                table: "Books",
                columns: new[] { "AlphaSort", "ID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BooksByAuthor",
                table: "Books",
                columns: new[] { "Author", "ID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BooksByISBN",
                table: "Books",
                columns: new[] { "ISBN", "ID" },
                unique: true,
                filter: "[ISBN] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BooksBySubject",
                table: "Books",
                columns: new[] { "Subject", "ID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BooksByTitle",
                table: "Books",
                columns: new[] { "Title", "ID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BooksByFormat",
                table: "Books",
                columns: new[] { "MediaFormat", "AlphaSort", "ID" },
                unique: true,
                filter: "[MediaFormat] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Collectables_LocationID",
                table: "Collectables",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectablesBySeries",
                table: "Collectables",
                columns: new[] { "Series", "Type", "Reference", "ID" },
                unique: true,
                filter: "[Series] IS NOT NULL AND [Type] IS NOT NULL AND [Reference] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CollectablesByType",
                table: "Collectables",
                columns: new[] { "Type", "Series", "Reference", "ID" },
                unique: true,
                filter: "[Type] IS NOT NULL AND [Series] IS NOT NULL AND [Reference] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CollectablesByName",
                table: "Collectables",
                columns: new[] { "Name", "Series", "Type", "Reference", "ID" },
                unique: true,
                filter: "[Name] IS NOT NULL AND [Series] IS NOT NULL AND [Type] IS NOT NULL AND [Reference] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Decals_LocationID",
                table: "Decals",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_DecalsByManufacturer",
                table: "Decals",
                columns: new[] { "Manufacturer", "ID" },
                unique: true,
                filter: "[Manufacturer] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DecalsByName",
                table: "Decals",
                columns: new[] { "Name", "Scale", "ID" },
                unique: true,
                filter: "[Name] IS NOT NULL AND [Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DecalsByType",
                table: "Decals",
                columns: new[] { "Type", "Scale", "ID" },
                unique: true,
                filter: "[Type] IS NOT NULL AND [Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DecalsByScale",
                table: "Decals",
                columns: new[] { "Scale", "Type", "Manufacturer", "ID" },
                unique: true,
                filter: "[Scale] IS NOT NULL AND [Type] IS NOT NULL AND [Manufacturer] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DecalsByDesignation",
                table: "Decals",
                columns: new[] { "Type", "Designation", "Scale", "ID" },
                unique: true,
                filter: "[Type] IS NOT NULL AND [Designation] IS NOT NULL AND [Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSets_LocationID",
                table: "DetailSets",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSetsByManufacturer",
                table: "DetailSets",
                columns: new[] { "Manufacturer", "ID" },
                unique: true,
                filter: "[Manufacturer] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSetsByName",
                table: "DetailSets",
                columns: new[] { "Name", "Scale", "ID" },
                unique: true,
                filter: "[Name] IS NOT NULL AND [Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSetsByType",
                table: "DetailSets",
                columns: new[] { "Type", "Scale", "ID" },
                unique: true,
                filter: "[Type] IS NOT NULL AND [Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSetsByScale",
                table: "DetailSets",
                columns: new[] { "Scale", "Type", "Manufacturer", "ID" },
                unique: true,
                filter: "[Scale] IS NOT NULL AND [Type] IS NOT NULL AND [Manufacturer] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSetsByDesignation",
                table: "DetailSets",
                columns: new[] { "Type", "Designation", "Scale", "ID" },
                unique: true,
                filter: "[Type] IS NOT NULL AND [Designation] IS NOT NULL AND [Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_LocationID",
                table: "Episodes",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodesBySubject",
                table: "Episodes",
                columns: new[] { "Subject", "ID" },
                unique: true,
                filter: "[Subject] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodesBySeries",
                table: "Episodes",
                columns: new[] { "Series", "Number", "ID" },
                unique: true,
                filter: "[Series] IS NOT NULL AND [Number] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodesByFormat",
                table: "Episodes",
                columns: new[] { "MediaFormat", "Series", "Number", "ID" },
                unique: true,
                filter: "[MediaFormat] IS NOT NULL AND [Series] IS NOT NULL AND [Number] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FinishingProducts_LocationID",
                table: "FinishingProducts",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Kits_DecalID",
                table: "Kits",
                column: "DecalID");

            migrationBuilder.CreateIndex(
                name: "IX_Kits_DetailSetID",
                table: "Kits",
                column: "DetailSetID");

            migrationBuilder.CreateIndex(
                name: "IX_Kits_LocationID",
                table: "Kits",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_KitsByManufacturer",
                table: "Kits",
                columns: new[] { "Manufacturer", "ID" },
                unique: true,
                filter: "[Manufacturer] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KitsByName",
                table: "Kits",
                columns: new[] { "Name", "Scale", "ID" },
                unique: true,
                filter: "[Name] IS NOT NULL AND [Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KitsByType",
                table: "Kits",
                columns: new[] { "Type", "Scale", "ID" },
                unique: true,
                filter: "[Type] IS NOT NULL AND [Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KitsByNationServiceEra",
                table: "Kits",
                columns: new[] { "Nation", "Service", "Era", "ID" },
                unique: true,
                filter: "[Nation] IS NOT NULL AND [Service] IS NOT NULL AND [Era] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KitsByScale",
                table: "Kits",
                columns: new[] { "Scale", "Type", "Manufacturer", "ID" },
                unique: true,
                filter: "[Scale] IS NOT NULL AND [Type] IS NOT NULL AND [Manufacturer] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KitsByDesignation",
                table: "Kits",
                columns: new[] { "Type", "Designation", "Scale", "ID" },
                unique: true,
                filter: "[Type] IS NOT NULL AND [Designation] IS NOT NULL AND [Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Music_LocationID",
                table: "Music",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_MusicByAlphaSort",
                table: "Music",
                columns: new[] { "AlphaSort", "MediaFormat", "ID" },
                unique: true,
                filter: "[AlphaSort] IS NOT NULL AND [MediaFormat] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MusicByArtist",
                table: "Music",
                columns: new[] { "Artist", "Year", "MediaFormat", "ID" },
                unique: true,
                filter: "[Artist] IS NOT NULL AND [Year] IS NOT NULL AND [MediaFormat] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MusicByFormat",
                table: "Music",
                columns: new[] { "MediaFormat", "Artist", "Year", "ID" },
                unique: true,
                filter: "[MediaFormat] IS NOT NULL AND [Artist] IS NOT NULL AND [Year] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MusicByType",
                table: "Music",
                columns: new[] { "Type", "Artist", "Year", "MediaFormat", "ID" },
                unique: true,
                filter: "[Type] IS NOT NULL AND [Artist] IS NOT NULL AND [Year] IS NOT NULL AND [MediaFormat] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rockets_LocationID",
                table: "Rockets",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipClass_ShipClassTypeID",
                table: "ShipClass",
                column: "ShipClassTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipClassesByName",
                table: "ShipClass",
                columns: new[] { "Name", "ID" },
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShipClassTypesByType",
                table: "ShipClassTypes",
                columns: new[] { "TypeCode", "ID" },
                unique: true,
                filter: "[TypeCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_ShipClassID",
                table: "Ships",
                column: "ShipClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_ShipClassTypeID",
                table: "Ships",
                column: "ShipClassTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipsByHullNumber",
                table: "Ships",
                columns: new[] { "HullNumber", "ID" },
                unique: true,
                filter: "[HullNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShipsByName",
                table: "Ships",
                columns: new[] { "Name", "ID" },
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Software_LocationID",
                table: "Software",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareByAlphaSort",
                table: "Software",
                columns: new[] { "AlphaSort", "ID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareByPlatform",
                table: "Software",
                columns: new[] { "Platform", "AlphaSort", "ID" },
                unique: true,
                filter: "[Platform] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareByType",
                table: "Software",
                columns: new[] { "Type", "AlphaSort", "ID" },
                unique: true,
                filter: "[Type] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tools_LocationID",
                table: "Tools",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Trains_LocationID",
                table: "Trains",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_LocationID",
                table: "Videos",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_VideosBySort",
                table: "Videos",
                columns: new[] { "AlphaSort", "MediaFormat", "ID" },
                unique: true,
                filter: "[AlphaSort] IS NOT NULL AND [MediaFormat] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VideosByFormat",
                table: "Videos",
                columns: new[] { "MediaFormat", "AlphaSort", "ID" },
                unique: true,
                filter: "[MediaFormat] IS NOT NULL AND [AlphaSort] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VideosBySubject",
                table: "Videos",
                columns: new[] { "Subject", "Title", "ID" },
                unique: true,
                filter: "[Subject] IS NOT NULL AND [Title] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VideosByTitle",
                table: "Videos",
                columns: new[] { "Title", "MediaFormat", "ID" },
                unique: true,
                filter: "[Title] IS NOT NULL AND [MediaFormat] IS NOT NULL");
            #endregion
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AircraftDesignations");

            migrationBuilder.DropTable(
                name: "BlueAngelsHistory");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Collectables");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "FinishingProducts");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Kits");

            migrationBuilder.DropTable(
                name: "Music");

            migrationBuilder.DropTable(
                name: "Query");

            migrationBuilder.DropTable(
                name: "Rockets");

            migrationBuilder.DropTable(
                name: "Ships");

            migrationBuilder.DropTable(
                name: "Software");

            migrationBuilder.DropTable(
                name: "Tools");

            migrationBuilder.DropTable(
                name: "Trains");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "Decals");

            migrationBuilder.DropTable(
                name: "DetailSets");

            migrationBuilder.DropTable(
                name: "ShipClass");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "ShipClassTypes");
        }
    }
}
