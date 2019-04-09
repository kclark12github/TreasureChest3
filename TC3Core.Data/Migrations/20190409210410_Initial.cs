using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TC3Core.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e1973f98-9ca5-4098-aafb-9dce903d7007"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-7E", "Vought", "Corsair II - U.S.N. Version", null, null, 7.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "E" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("32250876-0bd0-4b20-813e-00b4d3df2833"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-3", "McDonnell", "Demon", null, null, 3.0, null, new DateTime(1956, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("2f0aeb92-cc1d-42fb-9b27-2e8de7529035"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-2", "McDonnell", "Banshee", null, null, 2.0, null, new DateTime(1949, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("1b10ecc0-e168-46ea-8455-576f5a55f616"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F2A", "Brewster (A)", "Buffalo", null, null, 2.0, null, new DateTime(1939, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("99b1f325-7ee1-4111-bd9a-42cedbe112f4"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-1E", "North American", "Fury (See AF-1E, FJ-3, FJ-4 Fury)", null, null, 1.0, null, new DateTime(1953, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "E" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("8ed6f923-ff62-4e7b-83f4-da781e4a002d"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "E-3", "Boeing", "AWACS", null, null, 3.0, null, new DateTime(1976, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("54ffc35c-4681-4b15-94c3-4f85e73ce48a"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "E-2", "Grumman", "Hawkeye", null, null, 2.0, null, new DateTime(1961, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e9de492f-3392-41ab-ae77-06d69ab54666"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "E-1", "Grumman", "Tracer (See S-2 Tracker, C-1A Trader)", null, null, 1.0, null, new DateTime(1954, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("90ed0562-6892-4efe-a46e-462f1fc6fd65"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-141", "Lockheed", "Starlifter", null, null, 141.0, null, new DateTime(1964, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("1c6ce944-1b08-4714-a136-6fa831de01bd"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-135", "Boeing", "Stratolifter", null, null, 135.0, null, new DateTime(1950, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a1629701-1456-4eb1-9e05-11921551555c"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-133", "Douglas", "Cargomaster", null, null, 133.0, null, new DateTime(1957, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7454012d-c7d2-4f5f-8263-617746d59b19"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WC-130", "Lockheed", "Hercules - Weather Version", null, null, 130.0, null, new DateTime(1955, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("0fa66b78-f0b7-492a-9828-433d18750d8b"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KC-130", "Lockheed", "Hercules - Tanker Version", null, null, 130.0, null, new DateTime(1955, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("926fa6a3-e8d5-4e45-b5f7-74abd186f372"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-130", "Lockheed", "Hercules", null, null, 130.0, null, new DateTime(1955, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("ba780086-6ec9-43ce-904c-e01cfc386043"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-119", "Fairchild", "Boxcar (See AC-119 Gunship)", null, null, 119.0, null, new DateTime(1949, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("3467031d-abdc-4c6d-afe7-ae5c4fb45321"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-74", "Douglas", "Globemaster", null, null, 74.0, null, new DateTime(1950, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("2a616c02-07fe-4600-ac71-6ca0145c2141"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-47", "Douglas", "Dakota", null, null, 47.0, null, new DateTime(1938, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e4321243-6daf-4341-972e-87b3d15c3425"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-5A", "Lockheed", "Galaxy", null, null, 5.0, null, new DateTime(1969, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("38093629-8b8f-45a4-913b-18682f6845cd"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F4B", "Boeing (B)", "", null, null, 4.0, null, new DateTime(1928, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".B" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("4c02078d-6992-4f3c-9fb1-7063f00f4eff"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-2A", "Grumman", "Greyhound (See E-2 Hawkeye)", null, null, 2.0, null, new DateTime(1961, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("96743192-b1bf-4d63-922a-3f71f5321bfe"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F4D", "Douglas (D)", "Skyray", null, null, 4.0, null, new DateTime(1956, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("fc092460-b0ac-4253-a661-4a3a8e635517"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F4U", "Vought (U)", "Corsair", null, null, 4.0, null, new DateTime(1942, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".U" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("4c74df5f-95d7-4091-b5bb-7e0aacf9119e"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F8F", "Grumman (F)", "Bearcat", null, null, 8.0, null, new DateTime(1944, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("793a0b4d-de7d-4772-a3f6-e5d09d99fafb"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F7U", "Vought (U)", "Cutlass", null, null, 7.0, null, new DateTime(1954, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".U" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("2e25a7e7-46af-45e2-9d49-4893452eba35"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F7F", "Grumman (F)", "Tigercat", null, null, 7.0, null, new DateTime(1944, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e2f1c9fc-59f7-4d7f-a474-553fdfb5e351"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F4D", "Douglas (D)", "Skyray", null, null, 4.0, null, new DateTime(1956, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("eb0e58f8-b28a-4ffc-9697-a7819e2a1685"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F6F", "Grumman (F)", "Hellcat", null, null, 6.0, null, new DateTime(1942, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("d8a6d08f-f3f1-41be-99e0-7ac3f434a320"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-5", "Martin", "Marlin", null, null, 5.0, null, new DateTime(1951, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("f7e6131f-34a1-4393-bac2-cd8de973c4db"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-5", "Northrop", "Tiger II", null, null, 5.0, null, new DateTime(1959, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("c3e842c7-2df0-40a1-9ad5-0440510b45d2"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4S", "McDonnell Douglas", "Phantom II - Improved USN \"N\" Version", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "S" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("47208d33-0a26-4e78-90a7-51e805ed47af"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4N", "McDonnell Douglas", "Phantom II - Improved USN \"J\" Version", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "N" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("5d4f2875-3c63-4f68-923c-27270eab1c66"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4K", "McDonnell Douglas", "Phantom II - British Version FG.1", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "K" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("68eed05c-9e95-409d-a9f1-bb5393a45e46"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4J", "McDonnell Douglas", "Phantom II - Improved USN \"B\" Version", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "J" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e5e29252-771f-446b-a468-785fe0ecb7c7"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4G", "McDonnell Douglas", "Phantom II - Radar Suppression Version", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "G" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("262e93d3-f468-423d-8dd6-26ea674727ca"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4E", "McDonnell Douglas", "Phantom II - Improved USAF \"D\" Version", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "E" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a829bbf1-f090-4c15-9254-a8b9a3b9b589"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4D", "McDonnell Douglas", "Phantom II - Improved USAF \"C\" Version", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("2ae5dc96-8c26-4b63-945a-020cd15064e1"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4C", "McDonnell Douglas", "Phantom II - First USAF Production Model", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "C" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("8b65e125-5c36-4cf0-bfb0-6e416bb99f10"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4B", "McDonnell Douglas", "Phantom II - First USN Production Model", null, null, 4.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "B" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("d749b08d-af4d-4842-b352-0ff994367cc5"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-4", "McDonnell Douglas", "Phantom II", null, null, 4.0, null, new DateTime(1960, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("5849e166-642b-448f-b4eb-05a6d6f61b5f"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F4F", "Grumman (F)", "Wildcat (British Martlet)", null, null, 4.0, null, new DateTime(1940, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("78bd8197-ec0c-4f32-a6bf-2355f671d4d7"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-8", "Vought", "Crusader", null, null, 8.0, null, new DateTime(1957, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a971151e-40de-4b06-87c5-8f25551f2705"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-1A", "Grumman", "Trader (See S-2 Tracker, E-1 Tracer)", null, null, 1.0, null, new DateTime(1954, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("d7fa7740-8d0c-42a4-bab0-0d3cf96c15c6"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-58", "Convair", "Hustler", null, null, 58.0, null, new DateTime(1959, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("fe7b7dbc-c656-477f-872a-df77b10b7a56"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SBD", "Douglas (D)", "Dauntless (See A-24)", null, null, null, null, new DateTime(1940, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SBD" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7c213471-6321-482f-bb36-658cc9fa6c25"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SB2C", "Curtiss (C)", "Helldiver", null, null, null, null, new DateTime(1942, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SB2C" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("10cacbd0-05f1-4eb0-9043-9ccadd720555"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-30", "Martin", "Baltimore", null, null, 30.0, null, new DateTime(1941, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("df8deea3-6910-4218-8f4c-055059354715"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-26", "Douglas", "Invader", null, null, 26.0, null, new DateTime(1943, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("edfd18b5-ed38-49ab-8f22-72da49625fcd"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-25", "Curtiss", "Helldiver (Marines)", null, null, 25.0, null, new DateTime(1942, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("ae4236f9-21da-498a-ba1c-ae37a1208b55"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-24", "Douglas", "Dauntless (Land Based - Army)", null, null, 24.0, null, new DateTime(1940, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("01a8b4f2-8e57-4950-b80a-277aaf744471"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-20", "Douglas", "Boston (See P-70)", null, null, 20.0, null, new DateTime(1940, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("bb7771f1-d736-4b4a-b128-9a843b93fb0a"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-11", "Lockheed", "Blackbird (CIA)", null, null, 11.0, null, new DateTime(1964, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("dcc301e1-c860-4791-b361-0e759ba94874"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-10", "Fairchild/Republic", "Thunderbolt II (Tank Killer)", null, null, 10.0, null, new DateTime(1974, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("d78ca31e-b478-4f55-a7d2-006f80d66613"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-7D", "Vought", "Corsair II - U.S.A.F. Version", null, null, 7.0, null, new DateTime(1966, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("40146b21-6c52-4872-aa5a-e82db58b6d07"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-6 (A2F)", "Grumman", "Intruder (See KA-6, EA-6B Prowler)", null, null, 6.0, null, new DateTime(1963, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a80d0186-e0cf-4b77-b3b2-4994d72ad8df"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KA-6D", "Grumman", "Intruder - Tanker Version", null, null, 6.0, null, new DateTime(1963, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("909db767-e9d2-4fae-b0ee-0d5ba8dca170"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EA-6B", "Grumman", "Prowler - Electronic Warfare (Intruder)", null, null, 6.0, null, new DateTime(1968, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "B" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("144f198f-9973-4980-87e7-37a4cd0291da"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-5 (A3J)", "Rockwell", "Vigilante", null, null, 5.0, null, new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("51fb7aa3-81f2-4bef-aeb9-a203297f4eed"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-4 (A4D)", "McDonnell Douglas", "Skyhawk", "The Scooter, Heinemann's Hot Rod, Bantam Bomber, Tinker Toy, Mighty Mite", null, 4.0, null, new DateTime(1956, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("859ea92f-11ff-4e11-ad67-ce6fc11bf3b2"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-3 (A3D, B-66)", "Douglas", "Skywarrior (See B-66 Destroyer)", "All Three Dead, Whale, Whistling Shitcan", null, 3.0, null, new DateTime(1954, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a73b544f-0ab7-431d-8934-50506c18c7e7"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A-1 (AD)", "Douglas", "Skyraider", "Sandy, SPAD, Able Dog", null, 1.0, null, new DateTime(1946, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("cb1e56bf-238e-4243-91bf-d0271f0be056"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AC-047", "Douglas", "\"Puff the Magic Dragon\" Gunship (See C-47)", null, null, 47.0, null, new DateTime(1938, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("358d05a9-efe1-4be5-b8e8-7d752028f128"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-66", "Douglas", "Destroyer (See A-3 Skywarrior)", null, null, 66.0, null, new DateTime(1954, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e8db91bf-d014-43cb-9813-9ddad998e654"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AC-119", "Fairchild", "Gunship (See C-119 Boxcar)", null, null, 119.0, null, new DateTime(1949, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("b00cff33-1099-47b8-bfe4-48627db99eea"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AF-1E", "North American", "Fury (See F-1E, FJ-3, FJ-4 Fury)", null, null, 1.0, null, new DateTime(1953, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "E" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a6d6e11b-2d22-453e-9297-f74a61fe46fb"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RB-57", "Martin/General Dynamics", "Canberra - Reconnaissance Version", null, null, 57.0, null, new DateTime(1953, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7165d696-3797-4744-acb7-6de561c58d04"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-57", "Martin/General Dynamics", "Canberra (See RB-57 Canberra)", null, null, 57.0, null, new DateTime(1953, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("49941d25-9b98-4ca0-9508-8bd3f160ad38"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-52", "Boeing", "Stratofortress", null, null, 52.0, null, new DateTime(1955, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("755f0667-ae6a-40ac-8a7e-1ca6ad3f6524"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-50", "Boeing", "Superfortress", null, null, 50.0, null, new DateTime(1947, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("2f856643-9f31-4119-bcd3-3bd42b65a36b"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-47", "Boeing", "Stratojet", null, null, 47.0, null, new DateTime(1950, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("f9e5ecc5-a3db-4e28-9d7e-93a68192eaaa"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-36", "Convair", "Peacemaker", null, null, 36.0, null, new DateTime(1947, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("3ee3a6c6-4408-46d0-8f78-32bee423f4f1"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-29", "Boeing", "Super Fortress", null, null, 29.0, null, new DateTime(1943, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("cfea3510-cf63-4b84-b9ee-053d95dead28"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-26", "Martin", "Marauder", null, null, 26.0, null, new DateTime(1941, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e84e45b6-6c0a-4f0a-8f8e-b2d35782c595"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-26", "Douglas", "Invader (after B-26 Marauder was retired)", null, null, 26.0, null, new DateTime(1943, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("fdf570b2-259c-4467-a80e-97055e3ba718"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-25", "North American", "Mitchell (See F-10)", null, null, 25.0, null, new DateTime(1940, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("17a92d62-bc48-43b4-b5b7-dbd9922dee28"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-24", "Consolidated", "Liberator", null, null, 24.0, null, new DateTime(1941, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("84320923-498e-4fe6-85ba-80b58694124c"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-18", "Douglas", "Bolo/Digby-1", null, null, 18.0, null, new DateTime(1937, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("3c9fa083-24b2-4110-a92e-1f6c0892a249"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-17", "Boeing", "Fortress", null, null, 17.0, null, new DateTime(1939, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a0910a9d-b51c-4e4e-a19d-aeed7a204c84"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-14", "Martin", null, null, null, 14.0, null, new DateTime(1932, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("4851f598-8b2c-4602-8ec7-56314a7d82ac"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-12", "Martin", null, null, null, 12.0, null, new DateTime(1932, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("99bdd6e1-5970-4837-9d0b-3f6931edae43"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-10", "Martin", null, null, null, 10.0, null, new DateTime(1932, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("6abea0d7-8395-4e19-8b96-ea1fdc1b8871"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B-1", "Rockwell", null, null, null, 1.0, null, new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("5840535c-2960-4d1f-817a-3ae0b3f8bc27"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AC-130H", "Lockheed", "Hercules (Night Gunship)", null, null, 130.0, null, new DateTime(1955, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "H" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("2d71c95c-a7fb-4776-90bb-0039197bbae8"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F9F-1", "Grumman (F)", "Panther", null, null, 9.0, null, new DateTime(1948, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F-1" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("2269f1f3-d9d3-4df0-af45-417c69cef074"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C-97", "Boeing", "Stratofreighter/Stratotanker", null, null, 97.0, null, new DateTime(1949, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("72efdc6c-85d2-48fa-82d6-492fe0c39f6f"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-10", "North American", "Mitchell (Reconnaissance) (See B-25)", null, null, 10.0, null, new DateTime(1940, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("c554599c-2384-4ce9-a5d3-afaa9c127d3e"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FB-111A", "General Dynamics", "Aardvark - Fighter Bomber Version", null, null, 111.0, null, new DateTime(1967, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FB-A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e5847325-96d5-436c-96b7-c76bc2f2743b"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-111F", "General Dynamics", "Aardvark - Improved Intakes", null, null, 111.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("bed6582a-8912-4eb3-85b5-c05cd0324692"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-111E", "General Dynamics", "Aardvark - \"Triple Plow II\" Intakes", null, null, 111.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "E" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e4c3a07f-1f84-4247-8b5d-e4549dbc522b"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-111D", "General Dynamics", "Aardvark - Improved Intakes", null, null, 111.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("21519d71-8834-495b-9ee2-9580f05e5cd4"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-111C", "General Dynamics", "Aardvark - \"A\" Version w/longer wing", null, null, 111.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "C" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("6fa7ce43-cdd9-4544-8dda-9b39552a4c51"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-111B", "General Dynamics", "U.S. Navy TFX Prototype (Cancelled)", null, null, 111.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "B" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("cf6c3cc4-b135-4887-8521-3f3b2b12ad3c"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FJ-3", "North American", "Fury (See F-1E, AF-1E, FJ-4 Fury)", null, null, null, null, new DateTime(1953, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "J-3" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("5dae260c-2013-4be0-82bd-7e2d9168ad13"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-111A", "General Dynamics", "Aardvark", null, null, 111.0, null, new DateTime(1967, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("65b9722b-3acd-49da-8db1-93c35cf49e48"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-105", "Republic", "Thunderchief", null, null, 105.0, null, new DateTime(1955, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("f657de1b-72ea-4f02-9ae1-4158dc081bf3"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-104", "Lockheed", "Starfighter", null, null, 104.0, null, new DateTime(1956, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("bcea8025-0d99-418f-90bb-71a3c4e86d61"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-102", "Convair", "Delta Dagger", null, null, 102.0, null, new DateTime(1955, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("d4e1dda3-22a3-4cd8-a8a8-01a338e946d9"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RF-101", "McDonnell", "Voodoo  - Reconnaissance Version", null, null, 101.0, null, new DateTime(1957, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("9135111c-5d96-47b2-b7aa-004d51537b51"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-101", "McDonnell", "Voodoo", null, null, 101.0, null, new DateTime(1957, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("525a2d2c-963d-4a42-9225-102423381736"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-100", "North American", "Super Sabre", null, null, 100.0, null, new DateTime(1953, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("e25e5b97-bf6e-4292-af8c-938b381e5696"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-106", "Convair", "Delta Dart", null, null, 106.0, null, new DateTime(1959, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("1202d89b-fc81-4067-aaea-f6ab3cdbd685"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FJ-4", "North American", "Fury (See AF-1E, F-1E, FJ-3 Fury)", null, null, null, null, new DateTime(1954, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "J-4" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("d691cc6d-7b68-4587-b95a-8598f90f9d5a"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OV-1", "Grumman", "Mohawk", null, null, 1.0, null, new DateTime(1961, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("f4421587-2a12-4f8f-9c8b-2091e2944e54"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OV-10", "Rockwell", "Bronco", null, null, 10.0, null, new DateTime(1967, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("b3085e70-b33a-4425-855e-79176e925603"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AD2", "Douglas", "Skyshark", null, null, null, null, new DateTime(1950, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a4ac1258-42ed-461c-827e-35bcecbe7c9a"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TBM", "Eastern Motors/GM (M)", "Avenger", null, null, null, null, new DateTime(1942, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "M" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("c35130ff-46e6-47bd-b891-3567c875be95"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TBF", "Grumman (F)", "Avenger", null, null, null, null, new DateTime(1942, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("cacc4fbc-857f-4ad5-b16b-11c7504fba26"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TBD-1", "Douglas (D)", "Devastator", null, null, null, null, new DateTime(1937, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D-1" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("d3c46ce0-7042-45d1-83c8-ea3355091301"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KC-135", "Boeing", "Stratotanker", null, null, 135.0, null, new DateTime(1950, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("d1dd283a-b7c8-4a9f-9806-82b97011446d"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S-3", "Lockheed", "Viking", null, null, 3.0, null, new DateTime(1973, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("b35605ab-d8f9-4f5b-b8ff-8274e4c3fae8"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-3", "Lockheed", "Orion", null, null, 3.0, null, new DateTime(1961, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("721680bf-85a1-43f2-b7a3-56f64efdadc9"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "S-2", "Grumman", "Tracker (See E-1 Tracer, C-1A Trader)", null, null, 2.0, null, new DateTime(1954, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("52553413-38e7-4248-8a0d-ad62cb24acfb"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-2", "Lockheed", "Neptune", null, null, 2.0, null, new DateTime(1947, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("02ce12fa-cd7d-48c5-a41b-c5d29ff5fcff"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SR-71", "Lockheed", "Blackbird (USAF)", null, null, 71.0, null, new DateTime(1964, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("59899260-1505-4c2d-82d9-b0054e180dbb"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "U-2", "Lockheed", null, null, null, 2.0, null, new DateTime(1956, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("ae94a83d-e047-4f1a-ba7b-121222134bf1"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PBY-5", "Consolidated", "Catalina", null, null, null, null, new DateTime(1936, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Y-5" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("11b11a81-78e1-4b66-afb2-ef2d7fc31031"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PBY-1", "Consolidated", "Catalina", null, null, null, null, new DateTime(1936, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Y-1" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("52e6d526-ed77-4b60-b641-9fcfcd39aee3"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PBM", "Martin", "Mariner", null, null, null, null, new DateTime(1940, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "M" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("abbaacdb-d57b-42b1-9401-0adcf32a4dca"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PB4Y-2", "Consolidated", "Privateer", null, null, 4.0, null, new DateTime(1944, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Y-2" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("c58c992d-5c4b-4a54-a8fa-cea2d5903bb5"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F9F-6", "Grumman (F)", "Cougar", null, null, 9.0, null, new DateTime(1951, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", ".F-6" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("6a9aaac4-0cfb-4950-9b51-ce9c4dbc5b72"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-89", "Northrop", "Scorpion", null, null, 89.0, null, new DateTime(1948, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("1e1847dd-aff6-4b69-bbf5-090fe21244d5"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-94", "Lockheed", "Starfire (See P-80, F-80 Shooting Star)", null, null, 94.0, null, new DateTime(1944, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("15570335-d63a-48bb-b680-1192a6c30fb7"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-86", "North American", "Sabre", null, null, 86.0, null, new DateTime(1948, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("08445f14-d205-4c8f-b571-7944ffefc445"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-16XL", "General Dynamics", "Cranked Arrow Falcon", null, null, 16.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "XL" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("8390ec2a-4ee3-4ddb-82b1-e06656657b13"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-16N", "General Dynamics", "Falcon - Top Gun Aggressor Version", null, null, 16.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "N" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("31918235-5ce4-4b44-ab7b-f0b8d50b2159"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-16D", "General Dynamics", "Falcon - Improved \"B\" Trainer", null, null, 16.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("80d6b116-39e8-4ce5-b7be-488540cce2cc"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-16C", "General Dynamics", "Falcon - w/LANTIRN Night Nav/Targeting", null, null, 16.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "C" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("858739a8-f8cf-456b-8527-893d95df8020"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-16B", "General Dynamics", "Falcon - Two Seat Trainer", null, null, 16.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "B" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("581db248-1de9-4f0d-a83a-67db27af7354"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-16A", "General Dynamics", "Fighting Falcon", null, null, 16.0, null, new DateTime(1978, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("975f8dd3-31dc-4286-94b5-12429c303530"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F/A-18A", "Northrop/McDonnell Douglas", "Hornet", null, null, 18.0, null, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7e4cd9dd-0993-4ae0-baa2-a14c249dd6c3"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-15J", "McDonnell Douglas", "Eagle - Japanese Self Defense Force", null, null, 15.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "J" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("0e2e203d-0988-42b8-9642-691bb66c5739"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-15D", "McDonnell Douglas", "Eagle - Two Seat Trainer", null, null, 15.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("79ade3c9-102c-4237-a3e5-343acae1064e"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-15C", "McDonnell Douglas", "Eagle - Advanced Air Superiority Fighter", null, null, 15.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "C" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("05ba89b1-bbaa-4971-b248-7c4845114725"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-15A", "McDonnell Douglas", "Eagle", null, null, 15.0, null, new DateTime(1974, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a5ca0e7c-724d-4d19-a252-935a01b9bd88"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-14", "Grumman", "Tomcat", null, null, 14.0, null, new DateTime(1972, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("91271156-efb3-42b0-ad14-7f4a25b5c3d0"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-12", "Boeing", "", null, null, 12.0, null, new DateTime(1928, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("f29f5cc8-eb0c-44f9-a672-a4046cc9b33c"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-11", "Grumman", "Tiger", null, null, 11.0, null, new DateTime(1957, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("117f65ad-13a8-47f9-85d9-5cd5645d7be8"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-15E", "McDonnell Douglas", "Strike Eagle", null, null, 15.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "E" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("aaed9652-d07d-4f48-b282-737309b8eea2"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F/A-18C", "Northrop/McDonnell Douglas", "Hornet - Improved \"A\" Version", null, null, 18.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "C" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("b0ad056a-f036-47ef-b45c-cd2bbe336efe"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TF-18A", "McDonnell Douglas", "Hornet - U.S. Navy Two Seat Trainer", null, null, 18.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "A" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("41d0d516-7c9b-495e-92de-b369268b7d63"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RF-18D", "Northrop/McDonnell Douglas", "Hornet - Two Seat Reconnaissance Version", null, null, 18.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("93956171-c567-4d0a-927b-2ada333fbb8a"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-84", "Republic", "Thunderjet", null, null, 84.0, null, new DateTime(1947, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("7a9bba50-bd3b-4868-9723-9ede3c9f0252"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RF-84F", "Republic", "Thunderflash - Reconnaissance Version", null, null, 84.0, null, new DateTime(1947, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("b6c6c263-67e8-43e7-9ff3-f4ac87575001"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-84F", "Republic", "Thunderstreak", null, null, 84.0, null, new DateTime(1947, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "F" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("11c75af5-c9e8-4fe5-a4bd-76e6bd0ca236"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-82", "North American", "Twin Mustang (See F-82)", null, null, 82.0, null, new DateTime(1945, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("4a101323-36f0-4976-8e85-a431387fecbe"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F-82", "North American", "Twin Mustang (See P-82)", null, null, 82.0, null, new DateTime(1945, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("bf294335-57f5-430d-b86d-5282671407bd"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-80", "Lockheed", "Shooting Star (See F-80, F-94 Starfire)", null, null, 80.0, null, new DateTime(1944, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("92a6c420-335b-46ce-a939-525951987cec"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "F/A-18D", "Northrop/McDonnell Douglas", "Hornet - Two Seat Night Attack Version", null, null, 18.0, null, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "D" });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("aea4c18b-4aa3-4286-9a95-0dd766ece33b"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-61", "Northrop", "Black Widow", null, null, 61.0, null, new DateTime(1944, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("84caebf0-687c-484a-bea8-e2d27dad7243"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-70", "Douglas", "Havoc (Army Night Fighter) (See A-20)", null, null, 70.0, null, new DateTime(1940, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("a63e9b26-e393-49e1-a4c0-c7b4704fe24a"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-51", "North American", "Mustang", null, null, 51.0, null, new DateTime(1942, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("8310bacf-695f-4084-8ccd-594bcd2cece1"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-47", "Republic", "Thunderbolt", null, null, 47.0, null, new DateTime(1942, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("f90ddf5d-9294-4238-9f3d-1e242d8a738c"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-40", "Curtiss", "Hawk (Warhawk, Tomahawk, etc)", null, null, 40.0, null, new DateTime(1940, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("c0e16841-f2fa-457c-9a36-5fbe53bd4728"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-39", "Bell", "Airacobra", null, null, 39.0, null, new DateTime(1939, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("c7e635a6-65ff-4c4b-ad25-98c5fb20f94f"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-38", "Lockheed", "Lightning", null, null, 38.0, null, new DateTime(1941, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("5d8f376e-6a1c-4140-ad31-ec56953623ee"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-26", "Boeing", null, null, null, 26.0, null, new DateTime(1934, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "AircraftDesignations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Designation", "Manufacturer", "Name", "Nicknames", "Notes", "Number", "OID", "ServiceDate", "Type", "Version" },
                values: new object[] { new Guid("49504425-b990-47ed-9b57-2f0882d43d28"), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "P-59", "Bell", "Airacomet", null, null, 59.0, null, new DateTime(1944, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("79fb3202-fb73-4089-9b86-eea7d3ca75d5"), "F/A-18A Northrop Hornet", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "72-560", null, "Hasegawa HA-812", null, null, "1987-" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("c8b89c30-2033-495a-aaa8-436d45b2e75e"), "A-4F McDonnell Douglas Skyhawk", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "72-138", null, "Fujimi FU-G19", null, null, "1974-86" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("7fb5bed3-c5c2-4cf2-855b-e0da24ba9415"), "F-4J McDonnell Douglas Phantom II", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N/A", null, "Hasegawa HA-SP51", null, null, "1969-73" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("7861ee9b-604b-4240-808b-0f8b470f3592"), "F11F-1 Grumman Tiger", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N/A", null, "Hasegawa HA-D16", null, null, "1957-61" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("6b8a862e-38d8-4e76-a48e-f1a2e2d01077"), "F9F-5 Grumman Panther", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N/A", null, "matchbox PK-124", null, null, "1952-54" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("e51d8b50-dcfe-482e-98e4-e9cf08b89134"), "F9F-8 Grumman Cougar", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N/A", null, "Hasegawa HA-D12", null, null, "1955-57" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("b9d3f7e6-8283-4220-a47d-2b727253b568"), "F9F-2 Grumman Panther", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N/A", null, "Hasegawa HA-D11", null, null, "1949-50" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("7cbb14ca-6fe5-4f21-be4b-dc19702ccfef"), "F6F-5 Grumman Hellcat", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "72-217", null, null, null, null, "1946" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("162de733-6fcc-443c-a42e-2d304636d4cc"), "F7U-1 Vought Cutlass (Solo Only)", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N/A", null, "Testers", null, null, "1952" });

            migrationBuilder.InsertData(
                table: "BlueAngelsHistory",
                columns: new[] { "ID", "AircraftType", "DateCreated", "DateModified", "DecalSets", "Decals", "Kits", "Notes", "OID", "ServiceDates" },
                values: new object[] { new Guid("530562db-8a36-48bb-b62b-5f3f98f246eb"), "F8F-1 Grumman Bearcat", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "72-642", null, "Monogram (Germany) MG6789", null, null, "1946-49" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("416a34b3-7abf-4278-9665-7161459608c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "PC Games Box #3", null, "PC Games Box #3 [Closet]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a6b87c1a-7b38-4d90-9f9d-64d365a43b7e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "PC Games Box #2", null, "PC Games Box #2 [Closet]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c971f3e0-354b-4ad8-8d30-4b88d0d7a34a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "PC Games Box #1", null, "PC Games Box #1 [Closet]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("373d0c06-db6a-41bd-808f-55ecd2d15cec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "PB201111.4", null, "PB201111.4 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c5b618fb-0364-460c-b79f-3949dd5ac7ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "PB201110.3", null, "PB201110.3 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a01f7cfc-6edc-4abf-b9f5-e3b4273f1484"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "PB201110.2", null, "PB201110.2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5c59946b-20bb-4638-aa9a-773fe0c46247"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHB", "PB201110.1", null, "PB201110.1 (UHB) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5bcc0551-0604-430f-aaa8-cec3cdb43918"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Part of Compilaton", null, "Part of Compilaton", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("17aee6a8-30fe-4f8b-a26e-9d4f18561f31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "On Order", null, "On Order", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a2c212ff-e854-418c-848a-67011f87c596"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Office", null, "Office", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c9b6f48c-de8a-4a21-a127-62004a180c79"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Nappa Valley Crate #3", null, "Nappa Valley Crate #3 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f2191b72-2a31-4691-9053-e294f9eb4202"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Nappa Valley Crate #2", null, "Nappa Valley Crate #2 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("326e754b-d056-41c2-9927-04e6ae4bbc65"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Nappa Valley Crate #1", null, "Nappa Valley Crate #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("61ec0589-89d7-4627-81d4-59731b8d7eeb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "Music DVDs Box #1", null, "Music DVDs Box #1 (33250) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4409b6c7-95a9-43d8-b589-50519892dfe9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Models #2", null, "Models #2 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3d9144fe-58d8-480b-a58c-feae0bca03b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "PC Games Box #4", null, "PC Games Box #4 [Closet]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b50af89c-d9a7-454b-ac29-c250d74819e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHB", "Sci-Fi Books Box #3", null, "Sci-Fi Books Box #3 (UHB) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6925c718-1d59-483b-90b2-168ba7a95590"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "PC Games Box #4", null, "PC Games Box #4", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e3c1c7d2-5bfc-461e-a7a3-e5ae31bc8c01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Models #1", null, "Models #1 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8c689a48-912a-456c-b410-0662844eea3d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Sci-Fi Books Box #2", null, "Sci-Fi Books Box #2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e306c63b-52d2-4784-96bc-073f9fac2683"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Sci-Fi Books Box #1", null, "Sci-Fi Books Box #1 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("555a3b32-6e3a-431f-9dc3-0e91818ed88a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Science Books Box #14", null, "Science Books Box #14 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("92f1f981-c9cb-48dd-818a-5ed4e1a74ae7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Scheduled for Donation", null, "Scheduled for Donation", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a86c7e60-35c4-4aa3-81e4-42c92d537f76"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ready to install", null, "Ready to install", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a8a24693-2a1b-4379-b072-f7e62cee028e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Soundtrack", null, "Public Music\\Soundtrack", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2860b499-e8f8-42c5-8fea-53e1d6cb89a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Rock", null, "Public Music\\Rock", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("13f9c844-1dbf-452f-ac07-466da010c337"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Radio Shows", null, "Public Music\\Radio Shows", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8c4de9fe-84d2-4fc7-ada8-b17b9d486afa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Pop", null, "Public Music\\Pop", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e38c705e-05f7-43c7-b228-1fb4e8f62299"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\New Age", null, "Public Music\\New Age", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("95d2a2f1-a3ee-41db-a2cd-3a28e3755634"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Country", null, "Public Music\\Country", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5a05ac02-7e6e-497d-b355-2c4de33fea69"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Comedy", null, "Public Music\\Comedy", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f4752b76-68a1-4f1b-b475-3c37361a2013"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Classical", null, "Public Music\\Classical", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("05ce516e-d134-4373-90b4-ea76b973431b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Christmas", null, "Public Music\\Christmas", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("53066f5a-767f-4d09-85ec-16f34f510fe8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Public Music\\Books", null, "Public Music\\Books", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("95ea801f-8261-49c8-9cea-a1e5eaff387e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Pre-Ordered", null, "Pre-Ordered", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("46e52b14-81f6-42d6-8314-2b746dabc261"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Prize Box", null, "Prize Box", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f8f0dd6c-11cf-4d24-953d-2a51df6bdf26"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Misc Books Box #01", null, "Misc Books Box #01", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f7d611ca-dc73-43e8-b989-d92e48dde477"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Micro Machines - Titanium  Series Box #10 (BSG) (SMO)", null, "Micro Machines - Titanium  Series Box #10 (BSG) (SMO) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("76a6d481-e573-40fe-8720-526428de6f2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Left in box", null, "Left in box", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("12598533-9250-4ad2-a81c-52833eaf9467"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Left in bag", null, "Left in bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c9998ce7-f406-489c-bf12-f781fd13a074"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Kindle", null, "Kindle", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("27b2bfa8-d622-43d5-ac3f-83d5d35f4d0b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Key Publishing Specials Box", null, "Key Publishing Specials Box [Top of Steps]", "Top of Steps" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5c573c42-7faa-4d36-b3d3-f4700e63cdc0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Room", null, "Ken's Room", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1c25f5eb-b322-43c4-a4bc-5c4085b9e8b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Ken's Hallmark Ornaments Box", null, "Ken's Hallmark Ornaments Box (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d1717c57-97aa-49c9-97d2-e3e349480832"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's DVDs Box #4", null, "Ken's DVDs Box #4 [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e61906b9-074c-4d30-8626-815cfdd0a5c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's DVDs Box #3", null, "Ken's DVDs Box #3 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("14e34156-9622-4751-9e8b-d529d91a5f8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's DVDs Box #2", null, "Ken's DVDs Box #2 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("39018701-c70f-4711-8bec-38ef56019b5a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's DVDs Box #1", null, "Ken's DVDs Box #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f526028e-27fc-4e1b-b610-0c14e93d32fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Desk", null, "Ken's Desk", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c537da7b-e4f0-4d69-a6fc-3b22269dd209"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #14 - Modeling Resources", null, "Ken's Books Box #14 - Modeling Resources [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1eb162cf-e891-4006-89f4-3089983cae84"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #13", null, "Ken's Books Box #13 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5e089373-43bf-43cb-b791-fb3f7ec15da4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Sci-Fi Books Box #4", null, "Sci-Fi Books Box #4 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6c505411-429a-4663-9dfb-37143187a5b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #12", null, "Ken's Books Box #12 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9c689a84-273f-4da5-b149-ab6560bdaa4f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Living Room", null, "Living Room", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8d590131-0a6e-4efa-b8c1-3667d5345779"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Lost", null, "Lost", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("34acec6a-1dc1-45b8-b5ee-1d01514051d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "USPS #13 9x7x4", "M&M's Chocolate M-PIRE Box", null, "M&M's Chocolate M-PIRE Box (USPS #13 9x7x4) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("22eac832-fc71-499e-ad04-a1c9c5c75206"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "USPS #13 9x7x4", "M&M's Chocolate M-PIRE Box", null, "M&M's Chocolate M-PIRE Box [USPS #13 9x7x4]", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4b2706f1-f0d0-48a9-87ea-a9d85758faf2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Micro Machines - Titanium  Series Box #09", null, "Micro Machines - Titanium  Series Box #09 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0c861882-b68b-4aea-a45a-80bb030f734e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Micro Machines - Titanium  Series Box #08", null, "Micro Machines - Titanium  Series Box #08 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a8c67274-63bc-4242-96eb-367c5b0c89e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Micro Machines - Titanium  Series Box #07", null, "Micro Machines - Titanium  Series Box #07 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1f154ecf-d370-435e-8794-5183de6d2b58"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Micro Machines - Titanium  Series Box #06", null, "Micro Machines - Titanium  Series Box #06 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b7027c14-0cdd-4e4f-8198-d78be46d3a7d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Micro Machines - Titanium  Series Box #06", null, "Micro Machines - Titanium  Series Box #06 (ESSS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ce992169-a288-4746-b850-3744dcbba725"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Micro Machines - Titanium  Series Box #05", null, "Micro Machines - Titanium  Series Box #05 (ESSS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d7ed5849-5d83-46a7-93e4-6ae42fad824f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Micro Machines - Titanium  Series Box #03", null, "Micro Machines - Titanium  Series Box #03 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e940632f-119c-48df-9081-cd9618d73f50"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Misc Collectables Box #1", null, "Misc Collectables Box #1 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("281c66c1-ac99-40e1-8f57-a2605af7dfd5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Micro Machines - Titanium  Series Box #02", null, "Micro Machines - Titanium  Series Box #02 (ESSS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("88a50005-0300-4cd7-9e97-a96087f9079c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "MH201110.6", null, "MH201110.6 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5a690943-fc19-4dc3-9959-5db7a09fb46e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "MH201110.5", null, "MH201110.5 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("62993ebd-1c22-460c-b8c9-514214a5ce9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "MH201110.4", null, "MH201110.4 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b880fcb2-57b6-4e46-a5e4-e7da792fbbd4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "MH201110.3", null, "MH201110.3 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("792e9819-6f28-448b-9d5c-98b07a02b2c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "MH201110.2", null, "MH201110.2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ba77bcd3-dcf9-4ef1-bf75-5295e4c1bf52"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "MH201110.1", null, "MH201110.1 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e7672b78-3012-4770-a68a-6a4a294b3548"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Master Bedroom", null, "Master Bedroom", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ccb5c7ac-5ab8-4031-9ff1-ed844caaf04d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Micro Machines - Titanium  Series Box #01", null, "Micro Machines - Titanium  Series Box #01 (ESSS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c18757bf-a830-424b-ae91-c1ee84dcc024"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "SciFi Box #1", null, "SciFi Box #1 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0c05c966-7b1c-49da-8792-586c6dbf9426"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", null, "", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("25ff1927-64fe-42c1-a33a-b891ade80d89"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHL", "SciFi Box #2", null, "SciFi Box #2 (UHL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ff884fe3-780c-4315-812e-0328c9056798"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unboxed", null, "Unboxed [Carol's Room]", "Carol's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d647b18e-86d3-405c-9afe-cff7f8f81c48"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unboxed", null, "Unboxed [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("671bdea9-466b-4fb4-ace3-19a778389bed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Transition", null, "Transition", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e0ee0158-35b8-42db-8fb9-02624950de2d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Train Stuff", null, "Train Stuff", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a1a8c742-21e4-4505-8bc3-a66c964159f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps Cowboys Box #01", null, "Topps Cowboys Box #01 [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d5f1f9e8-cc57-4813-89c4-624ef7566598"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps 2008 Football Complete Set Box", null, "Topps 2008 Football Complete Set Box [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("753d7e97-30ac-4778-acef-e33f3c42b526"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps 2008 Football #1", null, "Topps 2008 Football #1 [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("64160dd6-37cd-4f7e-a445-061c32546730"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps 2007 Football Complete Set Box", null, "Topps 2007 Football Complete Set Box [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bab73f45-ca03-4694-a090-88678429849a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps 2006 Football #3", null, "Topps 2006 Football #3 [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a19bedcf-1037-4241-a7d2-cb460206a1f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps 2006 Football #2", null, "Topps 2006 Football #2 [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f0ceb0a8-e0fa-4b6f-89bc-1c2dee018299"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Football Cards Box #1 (ESSS)", "Topps 2006 Football #1", null, "Topps 2006 Football #1 [Football Cards Box #1 (ESSS) [Closet]]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a8c26604-6c32-46c4-a10b-b616fedc9229"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Tom Clancy Book Box #9", null, "Tom Clancy Book Box #9 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7aa08337-e323-4d00-a664-da7bb29405a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "TimeLife Books Box #3", null, "TimeLife Books Box #3 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("34b93aa0-9aa3-47f1-b7d2-7884bc8a24a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "TimeLife Books Box #2", null, "TimeLife Books Box #2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("48780e6f-e830-4721-92b3-7ad5c832eb83"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "TimeLife Books Box #1", null, "TimeLife Books Box #1 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cb927b65-cdf2-4a5c-901e-703642e4fbd5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unboxed", null, "Unboxed [Ken's Room - Near Front Wall]", "Ken's Room - Near Front Wall" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9dfe050c-de3c-4393-b758-bc8c1dda947f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Text Books Box #16", null, "Text Books Box #16 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c2a5d3d8-d45a-4cf4-96cd-ae2437fe8cdc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unboxed", null, "Unboxed [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("472b0601-c1ff-4b51-a60b-b9b601c351f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unboxed Atop Bookcase B", null, "Unboxed Atop Bookcase B [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("598bf402-ff26-4ad8-a875-48795de2ded0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #11", null, "Ken's Books Box #11 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b531bd75-259e-4e2b-89ce-a8ea25ac5974"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "WishList", null, "WishList", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("77e32ccb-65c0-471b-8fbb-8ce0c5769a6b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Undetermined", null, "Undetermined", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("dd28b4d8-a807-4567-b59a-bfb80a010560"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Topps 2006 Football #1", null, "Topps 2006 Football #1", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ff0928a2-ee8e-4470-ad15-723d9de9bc02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Self-Compiled", null, "Self-Compiled", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7ddd9aca-d628-49d5-8a5e-893d86ce1cdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "EB Games.com", null, "EB Games.com", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("fbd02bf0-8d68-4553-824a-5808b760fc4f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Canceled", null, "Canceled", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b9938b3f-3a67-42ec-ab84-8fdc651bca17"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Workbench", null, "Workbench", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("acb7e9c9-291c-4fe0-99a2-daa6736f958b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Work Books 20080910.1", null, "Work Books 20080910.1 (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("54b58801-cbee-4b65-8ba0-2fe87a266109"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Wire Rack", null, "Wire Rack (Top Shelf) [Ken's Room East Wall]", "Ken's Room East Wall (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("53f09bd9-aa8f-4af2-885d-7eae112c9570"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Web Access", null, "Web Access", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ce0f9f82-0286-48e5-8830-ddbcd4d35bbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unspecified", null, "Unspecified", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5c59c9ba-0261-4f85-9505-de8edc08f9ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unknown", null, "Unknown", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b47807ee-dd40-4c8d-b3a2-d80fcd5129ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unknown - Possible Duplicate", null, "Unknown - Possible Duplicate", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("819db6cf-08e7-4bad-a0d7-efb416f73cfb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Undecided (Carol)", null, "Undecided (Carol)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("24d75495-3721-44d0-b9ec-26a4fb154786"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unboxed Atop Bookcase A", null, "Unboxed Atop Bookcase A [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cae249eb-ef49-4fac-a380-841b75809ad0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sterilite Flip-Top Box #5", null, "Sterilite Flip-Top Box #5 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b80cab38-c012-4222-a3c9-1c56bc002ef4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sterilite Flip-Top Box #4", null, "Sterilite Flip-Top Box #4 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("110489e0-513e-4fd4-8dd6-087ba79d0171"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sterilite Flip-Top Box #3", null, "Sterilite Flip-Top Box #3 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d6a7d0e6-bed6-443c-bbb1-21c5839f4109"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Sports Books Box #15", null, "Sports Books Box #15 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("32792d9b-9ee9-46b1-b5d4-6b47c46ec078"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Spares", null, "Spares", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4ac91959-4151-4e42-b27f-20381d5f63ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sealed with detail set included in kit", null, "Sealed with detail set included in kit", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("dd76ad89-9c43-4eb8-b6ba-e64b5a93bb91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sealed in package", null, "Sealed in package", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("053d80af-cb15-4313-bf08-bbac2a70c6a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #7 Ziploc bag", null, "SciFi Box #7 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2dd7e6e0-025a-458d-a2ec-082ee6477445"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "SciFi Box #7", null, "SciFi Box #7 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9bb73f3d-bb53-4c6d-b4e7-a3cc4964875a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #6 Ziploc bag", null, "SciFi Box #6 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bb84109a-c41c-41e0-8f0b-c409480ee25a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "SciFi Box #6", null, "SciFi Box #6 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5d7a6b23-9f08-4f0e-99cf-e51b5e11ea1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #5 Ziploc bag", null, "SciFi Box #5 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d5bec67d-7820-4679-b938-0d7bbf899b0f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "SciFi Box #5", null, "SciFi Box #5 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f4a72ae1-6054-4032-9f43-47a0ee5bcec0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #4 Ziploc bag", null, "SciFi Box #4 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f3dba414-4367-4cfb-a6eb-3b1aaca8187d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "SciFi Box #4", null, "SciFi Box #4 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a6d9c0c7-1aab-4b16-97fa-40e6de94132e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #3 Ziploc bag", null, "SciFi Box #3 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("53be9a21-6653-4bf2-b803-b8785f24ed07"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHL", "SciFi Box #3", null, "SciFi Box #3 (UHL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4119cfdc-f37e-41dd-be05-f2819aba1064"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #2 Ziploc bag", null, "SciFi Box #2 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0a257780-93d8-4911-90a7-93b9ca0dc289"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plano 993179", "Star Trek Attack Wing Case #01", null, "Star Trek Attack Wing Case #01 [Plano 993179]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("371e5687-56c8-48df-aab6-3f45db4e480f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plano 993179", "Star Trek Attack Wing Case #02", null, "Star Trek Attack Wing Case #02 [Plano 993179]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f2cd81b4-2f9e-481e-9665-96c95bfe9074"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 18x14x10", "Star Wars Armada Box", null, "Star Wars Armada Box (Unmarked 18x14x10) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("872b0239-0fed-42f4-97f2-a6071c3aa6dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Star Wars Collectables Box #2", null, "Star Wars Collectables Box #2 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("08043864-6946-49dc-bc36-cca3e781489f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sterilite Flip-Top Box #2", null, "Sterilite Flip-Top Box #2 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a2b0274c-82dd-47ad-92ec-24b886c68214"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sterilite Flip-Top Box #1", null, "Sterilite Flip-Top Box #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("74f5f41c-1d04-4274-944d-0988ff60f3d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Starfighter Shipyards Box #1", null, "Starfighter Shipyards Box #1", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3f4a8ad5-543a-4c4f-b7d4-d59c1acdd03f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Star Wars X-Wing Box", null, "Star Wars X-Wing Box [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7582212d-72af-4844-8f1b-4df190e53516"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Star Wars Vehicles Box #3", null, "Star Wars Vehicles Box #3 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("79957b27-f064-461d-beef-5063a2db32c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Star Wars Vehicles Box #2", null, "Star Wars Vehicles Box #2 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a91bd9fb-07c4-4474-beee-fd46ffb5aabe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Star Wars Vehicles Box #1", null, "Star Wars Vehicles Box #1 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("68a39b15-20cc-47fb-9aba-f07fd157efcc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "SciFi Box #1 Ziploc bag", null, "SciFi Box #1 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9fc1285a-8dfb-478c-9671-1cd1cf618caa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Star Wars Sterilite Flip-Top Box", null, "Star Wars Sterilite Flip-Top Box [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a2b5e6e4-8603-4343-bd71-91d34b0909f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Star Wars Collectables Box #9", null, "Star Wars Collectables Box #9 (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8a52c5b6-7400-4055-bc05-e5c9b5e24b68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Star Wars Collectables Box #8", null, "Star Wars Collectables Box #8 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("619ab4bf-f0dc-4d20-8153-2fc6a652ff0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Star Wars Collectables Box #7", null, "Star Wars Collectables Box #7 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e3f6bded-c6e0-4976-9135-e12ab1801d89"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EE 18x12x12", "Star Wars Collectables Box #6", null, "Star Wars Collectables Box #6 (EE 18x12x12) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("17826c66-34e3-4afd-ae70-f4a71e15ded5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Star Wars Collectables Box #5", null, "Star Wars Collectables Box #5 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("67d2b4ce-0c97-4d89-bad4-bff5a3ae681e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Star Wars Collectables Box #4", null, "Star Wars Collectables Box #4 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6c4c3df9-281e-4665-94b8-5bec00d9fede"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Star Wars Collectables Box #3", null, "Star Wars Collectables Box #3 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6008cfd4-dfec-43ef-9c6c-3109aa1170ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Star Wars Collectables Box", null, "Star Wars Collectables Box (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("427d0cd8-10b5-43d9-a2e6-3bcb78345cc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #10", null, "Ken's Books Box #10 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f6e4f11b-faeb-47ed-90d6-c9d3fbbad613"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Micro Machines - Titanium  Series Box #04", null, "Micro Machines - Titanium  Series Box #04 (ESSS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("345ec341-3cb4-4ecd-9215-9d94d716dd70"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #08", null, "Ken's Books Box #08 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5d1f850e-9d03-46fd-abcb-1dcc6e708c68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Box #72-05", null, "Box #72-05 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ed89e6ff-2ee0-4de8-9c16-6e88f2af3bac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Box #72-06", null, "Box #72-06 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("564bc18a-d4fe-440a-94ac-bf5bf43435d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Box #72-07", null, "Box #72-07 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4e57bedc-c4cf-4003-9764-5ed7a45c6c21"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Box #72-08", null, "Box #72-08 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("14f3a585-5fbb-454e-ba0c-d8b954747a69"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Box #72-09", null, "Box #72-09 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c02eb8f6-9883-4a38-a74f-d13bed6d2e6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-1 Ziploc bag", null, "Box #72-1 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("684616f7-750f-4f9b-baf7-9de37915e553"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Box #72-10", null, "Box #72-10 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c30daa54-6710-48c5-b68d-58d26592e7f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Box #72-04", null, "Box #72-04 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8e7eb95a-cdd3-44bf-ae71-6d8729240aa0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-10 Ziploc bag", null, "Box #72-10 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ab49c876-634c-4c34-92ca-747e0c492651"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL-Old", "Box #72-11", null, "Box #72-11 (UHXL-Old) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7a6c2c69-e88c-4c1f-bc51-71052616550f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-11 Ziploc bag", null, "Box #72-11 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d13dbe69-b9b7-4896-a967-51de1d4f0e60"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Box #72-12", null, "Box #72-12 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5490350c-aa44-441d-b816-75ccc84dddb1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-12 Ziploc bag", null, "Box #72-12 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c56736dc-2648-41a3-a541-de2da5b2edd5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM-Old", "Box #72-13", null, "Box #72-13 (UHM-Old) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("522090fc-1f8b-41c6-90ef-9a7c22a2696f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-13 Ziploc bag", null, "Box #72-13 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b74ca289-6a44-470c-b165-991b722edf78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Box #72-14", null, "Box #72-14 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7c4f9116-0aff-4e78-9ee3-75e9abf6169b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHL-Old", "Box #72-11", null, "Box #72-11 (UHL-Old) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9d5d877d-3287-448d-8a6a-d2f222e28a80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-14 Ziploc bag", null, "Box #72-14 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("833b6d05-b282-4ebe-ad02-209ec380abdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Box #72-03", null, "Box #72-03 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f13522f3-8dbc-4120-a135-1751c038811b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Box #72-01", null, "Box #72-01 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("46a38700-74d8-4c4b-986b-6b826554c1d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Box #144-2", null, "Box #144-2 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b9d59769-3fda-4a35-9230-072aee70760e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #144-2 Ziploc bag", null, "Box #144-2 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5d5c2bcc-8859-49fc-ad5c-19ee4a8ea96e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #3 Ziploc bag", null, "Box #3 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("87e45132-fe51-4f21-842a-0c4bb9c58dfb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHL", "Box #350-1", null, "Box #350-1 (UHL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d78ff67e-fafe-4153-b864-bea51e7f6ae9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #350-1 Ziploc bag", null, "Box #350-1 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ecd492ac-8ed0-40e6-91eb-0415958f9126"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Box #350-2", null, "Box #350-2 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("35d604f5-c640-44e1-8312-2f82e47f62a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #350-2 Ziploc bag", null, "Box #350-2 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6c36ff63-d95a-42e9-aa69-64689a178615"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM-Old", "Box #72-02", null, "Box #72-02 (UHM-Old) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a13f3d9e-aec6-4939-9c85-38b0c403eb19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM-Old", "Box #700-1", null, "Box #700-1 (UHM-Old) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2f2bef03-8015-44d9-b62a-f6b2d0a3272a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHL", "Box #700-2", null, "Box #700-2 (UHL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d43c02c6-a3e5-4474-97b9-3bf2a4275f6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #700-2 Ziploc bag", null, "Box #700-2 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("fd9ed0e3-b82f-4b22-967b-0493fe12b561"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #700-2 Ziploc bag\\par", null, "Box #700-2 Ziploc bag\\par", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("25cbd02d-560d-4985-a5bd-00f13c44885f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Box #700-3", null, "Box #700-3 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0c3cffe2-e55c-42b6-a610-f8301ff28416"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #700-3 Ziploc bag", null, "Box #700-3 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6c1356fa-e079-44bb-adab-628f408f5f47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 15x12x8", "Box #700-4", null, "Box #700-4 (Unmarked 15x12x8) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("70cd7974-8df7-4bf7-a0f5-d377e51f5ba4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #700-4 Ziploc bag", null, "Box #700-4 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("55d22bfa-cb06-4da4-a15c-abb9872cd2f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #700-1 Ziploc bag", null, "Box #700-1 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("399f6fad-4bbe-4a86-b92e-9e9f7ecc3b1c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #144-1 Ziploc bag", null, "Box #144-1 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6d28a8a1-f4ea-420c-98a8-9d1c12376c1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-2 Ziploc bag", null, "Box #72-2 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b6f5e88e-7ff1-4649-9d53-a9313b40abd8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-5 Ziploc bag (2nd set, with wheels, left in box)", null, "Box #72-5 Ziploc bag (2nd set, with wheels, left in box)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c0efa4b3-9747-4167-aef6-9297fd6412c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "CD Box #2", null, "CD Box #2 (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c7dd02f8-3777-4c1c-b35e-e0b51ae861cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "CD Box #3", null, "CD Box #3 (ESSS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("240d1238-59f7-4355-ab15-aa40b82b04cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "CD Box #4", null, "CD Box #4 (ESSS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e82605f2-949a-4bb6-ae26-99b5e6d860b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "CD Box #5", null, "CD Box #5 (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("22c981f1-1fa6-4b8e-b8f9-844440d6ad28"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "CD Box #6", null, "CD Box #6 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("453d12e2-8e86-465e-a595-2314ad16f395"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "CD Box #7", null, "CD Box #7 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a9008fa8-f34d-4ea5-a774-26fdb78bea92"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "CD Box #8", null, "CD Box #8 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("07c83daa-c888-46ec-8708-8c4f50b18203"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "CD Box #1", null, "CD Box #1 (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("dd23674e-13f3-4e38-98f6-65dffb86ddaf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - Arcade", null, "CD Rack - Arcade [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c828e7ab-5b3a-4249-90ad-3f5b191e7598"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - FPS", null, "CD Rack - FPS [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("13356aa4-32b2-4a58-8c81-7fc99f1470b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - RPG/Strategy", null, "CD Rack - RPG/Strategy [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("37750408-a267-4b05-9acf-24ddcddfe520"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - Star Trek/Space Sim", null, "CD Rack - Star Trek/Space Sim [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f446a1b7-6ffa-481c-acba-c1ce91a9dda0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - Star Wars", null, "CD Rack - Star Wars [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("22dd975e-5073-4351-9a1a-2a43966c2550"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - Strategy (C&C)", null, "CD Rack - Strategy (C&C) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5dcbf18c-af52-4cb3-885a-7e86867b2014"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - Strategy (Civilization)", null, "CD Rack - Strategy (Civilization) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("579d5306-f832-46aa-9f11-962aca548d8c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack", null, "CD Rack [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3c365435-d135-43f0-bba1-18701c1a772a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack - Flight Sims", null, "CD Rack - Flight Sims [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("be81fd00-55c3-448a-bc1d-88fae7fd7173"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-4 Ziploc bag", null, "Box #72-4 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2730ea2d-3926-42d2-a55b-c81c0cb12ef8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Carol's Room", null, "Carol's Room", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9f41a071-3807-4f8b-a97c-dbdd48012c25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Carol's Books HB Fiction", null, "Carol's Books HB Fiction", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c2bea135-6e27-44e0-a453-1b2f47726c38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-5 Ziploc bag", null, "Box #72-5 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8a5b34da-36ba-41b2-a9e0-60589834e106"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-6 Ziploc bag", null, "Box #72-6 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("96b118f1-b1bb-4203-b9d2-5afea9daeb73"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-7 Ziploc bag", null, "Box #72-7 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("765f5a54-84ad-4985-9f01-e40564e8cd8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-8 Ziploc bag", null, "Box #72-8 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d09189d6-35d6-4b42-bf3b-b0f8a3d3c5a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #72-9 Ziploc bag", null, "Box #72-9 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f856fed4-f1b0-4fbf-9af3-9baaf4662df8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #TB-1", null, "Box #TB-1", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2a5f00cb-6f10-49f7-bc81-ff4b24b477e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #TB-2", null, "Box #TB-2", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6ae75f7d-91fb-4ec0-98aa-973759ed4a9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Carol's Office", null, "Carol's Office", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d9bf3558-3125-494d-a5ed-91b0e8c520fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #09", null, "Ken's Books Box #09 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7086750a-7a80-4d56-9e57-5923cd9acf26"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "C200809.2", null, "C200809.2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3bceefe5-fddc-4e4f-bf39-192fe3d73f05"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "C200809.3", null, "C200809.3 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("53a85d49-9b2b-4761-952a-18970738e815"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "C200810.1", null, "C200810.1 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("039d91b2-6a9a-44cb-a4a0-66202e1cbeb8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "C200810.2", null, "C200810.2 (UHS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cfd838fa-a765-4e93-9107-14cd87af111d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Car Box #1 Ziploc bag", null, "Car Box #1 Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("145c5c33-f093-4356-b556-0c1d219bb5b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHM", "Car Collectables Box #01", null, "Car Collectables Box #01 (UHM) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f2c1f70d-c973-4be1-af4a-9510f183bca5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHXL", "Car Models Box #1", null, "Car Models Box #1 (UHXL) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d961e2de-1b76-4852-88e3-6a2f2f9c18ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "C200809.1", null, "C200809.1 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0c450499-b5ce-416b-aaa2-03ec24c06ecc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "CD Rack", null, "CD Rack", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b6aa3e4d-6fa5-4165-8e37-599d8b8287e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS-Old", "Box #144-1", null, "Box #144-1 (UHS-Old) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("40fe1ca5-6aa5-4beb-82be-4ad9eebaa370"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Borrowed", null, "Borrowed", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5fcb34c8-0af3-4894-aa9c-57be05b01c98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Delta\\Public\\Shared TV\\SciFi", null, "\\\\Delta\\Public\\Shared TV\\SciFi", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("77c9ec28-e99a-4854-bda5-8e4828c78d67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Delta\\Public\\Shared TV\\War", null, "\\\\Delta\\Public\\Shared TV\\War", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("adc31093-21d6-4b5c-ba3d-5c773952b4d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Delta\\Public\\Shared TV\\Western", null, "\\\\Delta\\Public\\Shared TV\\Western", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("290667cb-3362-4f33-9cf9-6185fa4fa65f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\Animation", null, "\\\\Echo\\Public\\Shared TV\\Animation", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("90b0bb56-0193-4813-8146-64ecaed02fe1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\Comedy", null, "\\\\Echo\\Public\\Shared TV\\Comedy", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7190ad1c-1e93-4ea4-8b05-5adf6cd6eedb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\Documentary", null, "\\\\Echo\\Public\\Shared TV\\Documentary", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("13241927-7b5e-474f-9076-0118b7edc503"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\Documentary\\NFL Films", null, "\\\\Echo\\Public\\Shared TV\\Documentary\\NFL Films", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d0129493-bf28-418d-950d-d6596b775516"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Delta\\Public\\Shared TV\\Drama", null, "\\\\Delta\\Public\\Shared TV\\Drama", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3b491358-d44a-4266-a8e9-7a58dff949e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\Drama", null, "\\\\Echo\\Public\\Shared TV\\Drama", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("777b4027-8f34-481d-8b70-1dca65520862"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\War", null, "\\\\Echo\\Public\\Shared TV\\War", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2150bfca-ccc3-420f-b58b-6a5bbb278965"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Foxtrot\\Public\\Shared TV\\Horror", null, "\\\\Foxtrot\\Public\\Shared TV\\Horror", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("68e3f8fe-4b87-4943-b48e-5ea3dd4459be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Foxtrot\\Public\\Shared TV\\SciFi", null, "\\\\Foxtrot\\Public\\Shared TV\\SciFi", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d57dbb5e-788e-4428-bee6-3e693a1304a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Foxtrot\\Public\\Shared Videos\\Exercise", null, "\\\\Foxtrot\\Public\\Shared Videos\\Exercise", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b339469a-3778-49d3-b5e0-bf71c8c9404f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Foxtrot\\Public\\Shared Videos\\Music Videos", null, "\\\\Foxtrot\\Public\\Shared Videos\\Music Videos", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d78c4a90-1d19-420e-b95a-4bb4c31f146b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Foxtrot\\Public\\Shared\\Videos\\Music Videos", null, "\\\\Foxtrot\\Public\\Shared\\Videos\\Music Videos", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7f2b2f91-44e1-42a1-b5b8-b5438d475d46"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Apple Software Box", null, "Apple Software Box", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("36c54fdb-490a-49f2-bf66-0ab6fa800b81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Echo\\Public\\Shared TV\\SciFi", null, "\\\\Echo\\Public\\Shared TV\\SciFi", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("285d6d1d-5adb-4ec5-8391-2528310b6c23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Applied", null, "Applied", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7f0d3997-d156-4448-8cc1-7734eb3b3274"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Delta\\Public\\Shared TV\\Comedy", null, "\\\\Delta\\Public\\Shared TV\\Comedy", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9cc296a7-5174-40d0-8715-aa4ac11f1403"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Western", null, "\\\\Charlie\\Public\\Shared Movies\\Western", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("65e07f34-5cc7-4bf8-924a-de9fd60c7f90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "?? Ziploc bag", null, "?? Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c8ebe1c1-ad1f-41fc-9da5-d0d01aec06cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "@ Large", null, "@ Large", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8cdeff85-ed7b-4a6a-92e6-e38c96fd388c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Action", null, "\\\\Charlie\\Public\\Shared Movies\\Action", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e756d044-0380-42b1-acf0-37a12fe4c4e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Adventure", null, "\\\\Charlie\\Public\\Shared Movies\\Adventure", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7f4fe1a0-f60c-4f31-9641-939a77b4a759"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Cartoon-CG", null, "\\\\Charlie\\Public\\Shared Movies\\Cartoon-CG", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("827a8293-8323-477c-ac8f-0f36792fa27f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Christmas", null, "\\\\Charlie\\Public\\Shared Movies\\Christmas", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("048c1509-8c33-47b9-a30d-023e1226b987"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Comedy", null, "\\\\Charlie\\Public\\Shared Movies\\Comedy", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c3d96ed9-4991-4fbf-a1eb-8f7ce683d71e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Delta\\Public\\Shared TV\\Animation", null, "\\\\Delta\\Public\\Shared TV\\Animation", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e53644ce-7388-46a4-ba99-11aecd161b55"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Documentary", null, "\\\\Charlie\\Public\\Shared Movies\\Documentary", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("089725c0-c84e-4d37-b2b7-c29abe7c89b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Fantasy", null, "\\\\Charlie\\Public\\Shared Movies\\Fantasy", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("beb09a65-f5a1-4f9c-9ac6-971044a2cdb2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Horror", null, "\\\\Charlie\\Public\\Shared Movies\\Horror", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6b60d226-7a44-41ce-93ee-0ad1a2e20628"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Musical", null, "\\\\Charlie\\Public\\Shared Movies\\Musical", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("272d8111-fcfa-453d-8038-76f798d7950d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Mystery", null, "\\\\Charlie\\Public\\Shared Movies\\Mystery", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e8fc33b5-a282-4ee0-8020-6e517f88a28c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Science Fiction", null, "\\\\Charlie\\Public\\Shared Movies\\Science Fiction", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b0d01d42-1686-4d76-b9d3-f174dfb047e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Sports", null, "\\\\Charlie\\Public\\Shared Movies\\Sports", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("fe96ae7e-5ea5-412c-aaca-5627d78f7d4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\War", null, "\\\\Charlie\\Public\\Shared Movies\\War", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e7bfefde-fb20-407d-a28a-4849c8e7c152"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "\\\\Charlie\\Public\\Shared Movies\\Drama", null, "\\\\Charlie\\Public\\Shared Movies\\Drama", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7e620285-9524-402d-8e03-17cbb0c61281"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #? Ziploc bag", null, "Box #? Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cf4c5179-05a2-4760-b69d-fe1d08f9e6d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Art Books Box #7", null, "Art Books Box #7 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c7758e1b-7b9a-4b29-a972-f489b16c89a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Aurora USS Enterprise Box", null, "Aurora USS Enterprise Box [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f489ab76-7777-49bd-926d-5897ba6fbe0f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase A", null, "Bookcase A (Top Shelf) [Ken's Room - West Wall By Door]", "Ken's Room - West Wall By Door (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("822e2047-8937-4ba6-af4f-32ee4a14db99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase B", null, "Bookcase B (Bottom Shelf) [Ken's Room - West Wall Back]", "Ken's Room - West Wall Back (Bottom Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("86bc47cb-fc0e-4e68-b02d-8ac2ad6a3c10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase B", null, "Bookcase B (Second Shelf) [Ken's Room - West Wall Back]", "Ken's Room - West Wall Back (Second Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("646d9081-54e1-4e53-8af4-d5cb813bd238"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase B", null, "Bookcase B (Third Shelf) [Ken's Room - West Wall Back]", "Ken's Room - West Wall Back (Third Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e72345e2-ecd6-46b4-8dfc-cabc7989d1a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase B", null, "Bookcase B (Top Shelf) [Ken's Room - West Wall Back]", "Ken's Room - West Wall Back (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7bc1b469-41bb-4b72-9085-88dd340a5a7e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase C", null, "Bookcase C (Bottom Shelf) [Ken's Room - West Wall By Closet]", "Ken's Room - West Wall By Closet (Bottom Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("21e196dd-8e21-4b07-93ba-8de8d4cde1f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase C", null, "Bookcase C (Second Shelf) [Ken's Room - West Wall By Closet]", "Ken's Room - West Wall By Closet (Second Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d6bbff83-4544-4cb0-8d90-bf0453104346"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase A", null, "Bookcase A (Third Shelf) [Ken's Room - West Wall By Door]", "Ken's Room - West Wall By Door (Third Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("408282c5-10b8-4d9c-82c0-0d07bcf70b07"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase C", null, "Bookcase C (Third Shelf) [Ken's Room - West Wall By Closet]", "Ken's Room - West Wall By Closet (Third Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("55629cbf-d3eb-4c51-a95c-b07fad568e11"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase F", null, "Bookcase F (Second Shelf) [Ken's Room - Front Wall]", "Ken's Room - Front Wall (Second Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("40ef9fdf-382a-4884-ba9b-4f22cbcd0050"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase F", null, "Bookcase F (Top Shelf) [Ken's Room - Front Wall]", "Ken's Room - Front Wall (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2f096314-2386-4cb3-9cb5-eb9d45155d73"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookshelf", null, "Bookshelf (Bottom Shelf) [Ken's Room - Back Wall]", "Ken's Room - Back Wall (Bottom Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f875e621-7e57-45c2-b2c2-45a0284eaa73"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookshelf", null, "Bookshelf (Bottom Shelf) [Ken's Room - East Wall]", "Ken's Room - East Wall (Bottom Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e9bbee9a-a8b3-4d14-92e0-b4ab3109222f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookshelf", null, "Bookshelf (Top Shelf) [Ken's Room - Back Wall]", "Ken's Room - Back Wall (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8165bed1-e9cb-4c07-95dc-c400aca10193"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookshelf", null, "Bookshelf (Top Shelf) [Ken's Room - East Wall]", "Ken's Room - East Wall (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("27eb4c48-0111-4984-8cef-9af7f27ef911"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookshelf", null, "Bookshelf", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d1869152-1777-4c1a-bea3-3128a5eb62ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase C", null, "Bookcase C (Top Shelf) [Ken's Room - West Wall By Closet]", "Ken's Room - West Wall By Closet (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ba24c6c2-6c79-484b-833b-13a48d202e3f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Attic", null, "Attic", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b47bb208-4689-4aed-a17c-8be62fb930eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase A", null, "Bookcase A (Second Shelf) [Ken's Room - West Wall By Door]", "Ken's Room - West Wall By Door (Second Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("abb3e112-e2eb-4df8-8b49-6a7484312fc3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase #1", null, "Bookcase #1 (Top Shelf) [Carol's Room - East Wall]", "Carol's Room - East Wall (Top Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9bfa3478-8c86-45cc-80db-3b21f4d98d30"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea - Allies Case", null, "Axis&Allies War at Sea - Allies Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("79ae66c6-0444-461e-a718-33abe65e8c3f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea - Axis Case", null, "Axis&Allies War at Sea - Axis Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("244dc62b-4d36-4016-b856-5453980c1a8c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea Condition Zebra Case", null, "Axis&Allies War at Sea Condition Zebra Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("26e8b081-fd7b-485e-8dec-075343ab85f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea Flank Speed Case", null, "Axis&Allies War at Sea Flank Speed Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("62790b1e-2b8c-4a68-8112-8a13cb7b4dbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea Fleet Command Case", null, "Axis&Allies War at Sea Fleet Command Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("df5a3168-a093-425d-9170-ad795481c22b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea Surface Action Case", null, "Axis&Allies War at Sea Surface Action Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b6f448b3-6190-4da7-8a84-ab0bdacf65c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea Task Force - Allies Case", null, "Axis&Allies War at Sea Task Force - Allies Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8da4cd16-549f-4bf7-8a49-4ae8671d8b30"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase A", null, "Bookcase A (Bottom Shelf) [Ken's Room - West Wall By Door]", "Ken's Room - West Wall By Door (Bottom Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c67da726-8314-4eb2-b4f8-68e0909eaafe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Axis&Allies War at Sea Task Force - Axis Case", null, "Axis&Allies War at Sea Task Force - Axis Case", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c79f9afa-a71b-406b-9ee7-cb792d5cc9e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Basement Toolbox", null, "Basement Toolbox", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("012024eb-2fa6-4447-947d-f6dfdbd503fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Basement Workbench", null, "Basement Workbench", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("386bde6e-8482-4084-97a5-e3c597947195"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Basement", null, "Basement", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("dc3cba45-916c-43e2-8ee5-4b5d76776de1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Battlestar Galactica Raptor Armament Set", null, "Battlestar Galactica Raptor Armament Set", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8d1af83f-8592-4974-8ec6-3e7089811800"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase #1", null, "Bookcase #1 (Atop) [Carol's Room - East Wall]", "Carol's Room - East Wall (Atop)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("fd7ee7be-e840-491f-80a2-02f2a121dd83"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase #1", null, "Bookcase #1 (Second Shelf Shelf) [Carol's Room - East Wall]", "Carol's Room - East Wall (Second Shelf Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7437d49e-d09c-4f58-81cb-e21b13fb63c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Bookcase #1", null, "Bookcase #1 (Third Shelf Shelf) [Carol's Room - East Wall]", "Carol's Room - East Wall (Third Shelf Shelf)" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d3223346-c775-404d-997a-e57059efc2c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESSS", "Baseball Cards Box #1", null, "Baseball Cards Box #1 (ESSS) [Closet]", "Closet" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4a360e2b-aa1b-492c-b090-21a28d407b78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Christmas CDs", null, "Christmas CDs", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("98fc29d0-c554-48aa-99f9-93bc55cf0e35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Box #TB-3", null, "Box #TB-3", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6173d8aa-3dbb-41ac-b6e2-aa9a9cd172cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Closet", null, "Closet", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ba7d7966-f3dc-4c43-ba87-a35e711d63d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon K3", "Hot Wheels Box #2014B", null, "Hot Wheels Box #2014B (Amazon K3) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("fc3c3e6f-8d9c-480c-abce-c040e1e6ae9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x12.5x6", "Hot Wheels Box #2014C", null, "Hot Wheels Box #2014C (Unmarked 16x12.5x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6fa07aed-bb96-4159-a493-f975c9f3bbbd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 11x8x6", "Hot Wheels Box #2014D", null, "Hot Wheels Box #2014D (Unmarked 11x8x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9f4f17a2-a86a-4398-9ad8-19af5bcc2ad3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 1AE", "Hot Wheels Box #2016A", null, "Hot Wheels Box #2016A (Amazon 1AE) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("700c6918-d1ba-4e18-a400-5f1eb17014e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 1AE", "Hot Wheels Box #2016B", null, "Hot Wheels Box #2016B (Amazon 1AE) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("efbb5a43-ffc0-470c-a636-9f60e39d1bae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 1AE", "Hot Wheels Box #2016C", null, "Hot Wheels Box #2016C (Amazon 1AE) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("26d5bc45-dcfb-4aec-926d-e8be20c78f29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x14x9", "Hot Wheels Box #2017A", null, "Hot Wheels Box #2017A (Unmarked 14x14x9) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cb42aa04-a223-4149-9917-1efdf47a4ea9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FantasyFlight", "Hot Wheels Box #2014A", null, "Hot Wheels Box #2014A (FantasyFlight) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ef55fed4-6705-4902-a260-4505031b5694"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 17x13x6", "Hot Wheels Box #2017B", null, "Hot Wheels Box #2017B (Unmarked 17x13x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f6cb349b-675f-4911-92ec-f6a3317b3b1c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Christmas DVDs", null, "Christmas DVDs", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9c7efefa-0df1-4e2d-93a1-95e5ae918d99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 1A5", "Hot Wheels Box #2018B", null, "Hot Wheels Box #2018B (Amazon 1A5) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a6112fd3-9a00-4304-8e69-c47b4f190b35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x12x8", "Hot Wheels Box #2018C", null, "Hot Wheels Box #2018C (Unmarked 16x12x8) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8fbfa14f-8b2b-4d39-8195-8c9933fe7332"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x8x6", "Hot Wheels Box #2018D", null, "Hot Wheels Box #2018D (Unmarked 16x8x6) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d67bb279-2553-48df-a48c-f2b2a171e95a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 13x9x5.25", "Hot Wheels Box #21", null, "Hot Wheels Box #21 (Unmarked 13x9x5.25) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("392ded00-ac07-49b9-9c07-77d129450867"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel L2593 Case", "Hot Wheels Box #22", null, "Hot Wheels Box #22 (Mattel L2593 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("896fc337-6ac6-4c2a-b9be-60f6f0b93b91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x12x8", "Hot Wheels Box #23", null, "Hot Wheels Box #23 (Unmarked 16x12x8) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f643f191-f6a4-440e-bff8-d6e68dc67977"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x8x7", "Hot Wheels Box #2017C", null, "Hot Wheels Box #2017C (Unmarked 16x8x7) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("fd8d8ce9-32ee-47f1-8dc8-eb01123744d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "USPS Priority Mail Medium", "Hot Wheels Box #24", null, "Hot Wheels Box #24 (USPS Priority Mail Medium) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("61189a64-19a4-41af-a570-c9555d15cf9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 18x10x4", "Hot Wheels Box #20", null, "Hot Wheels Box #20 (Unmarked 18x10x4) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cdb6e28d-87e0-40c3-84a8-bfaea3918627"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x12x6", "Hot Wheels Box #18", null, "Hot Wheels Box #18 (Unmarked 14x12x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bf78b735-0363-45cf-ad0a-0c4217c17675"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 12x9x6", "Hot Wheels Box #02", null, "Hot Wheels Box #02 (Amazon 12x9x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c1533953-96d8-4a35-a731-e9519e438161"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Hot Wheels Box #03", null, "Hot Wheels Box #03 (ESSS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("297db47b-c57b-4f11-a94b-12c8957369ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESS", "Hot Wheels Box #04", null, "Hot Wheels Box #04 (ESSS) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ff2b885c-af03-4994-85a2-2c45340b67a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Hot Wheels Box #05", null, "Hot Wheels Box #05 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a5a62626-5401-43a9-8214-effa051dbba3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Hot Wheels Box #06", null, "Hot Wheels Box #06 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e0024070-23f7-449d-92f0-9357f7191d96"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x12x6", "Hot Wheels Box #07", null, "Hot Wheels Box #07 (Unmarked 14x12x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2c089a2f-50c5-4415-b313-788e89f1316b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B&N 13x11x6", "Hot Wheels Box #08", null, "Hot Wheels Box #08 (B&N 13x11x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7f33a401-85e9-4e1f-b42a-d05a45901380"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel X8308 Case", "Hot Wheels Box #19", null, "Hot Wheels Box #19 (Mattel X8308 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9803ee30-382b-4706-b3dd-edb84d6b09d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 12x9x6", "Hot Wheels Box #09", null, "Hot Wheels Box #09 (Unmarked 12x9x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("12b91759-a8f1-499a-9e54-f44dc2c5d0bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x12.5x6", "Hot Wheels Box #11", null, "Hot Wheels Box #11 (Unmarked 16x12.5x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("da74f107-0828-4c7c-bde6-52ef1e8f2450"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 13x11x5", "Hot Wheels Box #12", null, "Hot Wheels Box #12 (Unmarked 13x11x5) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5c4c8b8d-5aab-4ef4-9466-b6018f046776"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel L2593 Case", "Hot Wheels Box #13", null, "Hot Wheels Box #13 (Mattel L2593 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("494300dd-edde-41d7-9749-833b9eb0c491"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x10x6", "Hot Wheels Box #14", null, "Hot Wheels Box #14 (Unmarked 14x10x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a9499a0a-a08d-424b-9420-a0268f4dc81e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 10x8x6", "Hot Wheels Box #15", null, "Hot Wheels Box #15 (Unmarked 10x8x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ba3b51f3-28b3-4d71-aba2-7c23da7e4583"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel BDT77 Case", "Hot Wheels Box #16", null, "Hot Wheels Box #16 (Mattel BDT77 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("dd382c39-e59b-43c6-9e7b-d9e66ec26216"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel X8893 Case", "Hot Wheels Box #17", null, "Hot Wheels Box #17 (Mattel X8893 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2a3945c3-4702-4291-ac03-cfe73b870419"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel L2593 Case", "Hot Wheels Box #10", null, "Hot Wheels Box #10 (Mattel L2593 Case) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("23447374-b236-4a38-bef1-8711b8389d23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Wheels Box #01", null, "Hot Wheels Box #01", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f8a3372f-2ab3-45ca-9a8a-c56f67bfdb70"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 16x12x12", "Hot Wheels Box #25", null, "Hot Wheels Box #25 (Unmarked 16x12x12) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c760386b-e4c1-4270-afdf-2c150aa01a4e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B&N.com 14x11x6", "Hot Wheels Box #27", null, "Hot Wheels Box #27 (B&N.com 14x11x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cbf6529e-9c43-49a5-9c62-8d7cf626113c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Inside E-2C Hawkeye Box (Revell 03945 Kit #2640)", null, "Inside E-2C Hawkeye Box (Revell 03945 Kit #2640)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cea316d9-4327-4aab-9234-0143a43836a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Inside Kit Box (Revell 03945 Kit #2640)", null, "Inside Kit Box (Revell 03945 Kit #2640)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("191677e6-3e14-4f56-b11b-d446c8691280"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Inside Kit Box (Revell 04882 Kit #2619)", null, "Inside Kit Box (Revell 04882 Kit #2619)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d790c912-84b5-481d-87ad-f9db381b09e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Inside Kit Box (Trumpeter 05711 Kit #2731)", null, "Inside Kit Box (Trumpeter 05711 Kit #2731)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("484c6565-43b2-4952-9f3e-383a5b91da10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Inside Kit Box (Trumpeter 05712 Kit #2732)", null, "Inside Kit Box (Trumpeter 05712 Kit #2732)", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("dfb87e5d-4563-433a-9152-3fb08649afe6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Inside Kit Box", null, "Inside Kit Box", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cefddc2f-8d8f-4336-8fa5-7d374234671f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Installed", null, "Installed", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7d161d69-516f-40ef-af6f-a8803a8036ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Included in kit", null, "Included in kit", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8bcbe21b-e182-4e75-a39f-e530d69c88e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "JVC CH-200 Box Ziploc bag", null, "JVC CH-200 Box Ziploc bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("fe339dc5-c056-4679-a548-1b580b511c84"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #01", null, "Ken's Books Box #01 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("53e12108-b948-40be-8243-3448e6ececd0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #02", null, "Ken's Books Box #02 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("72908aee-ee5e-4581-859c-252bd89d3909"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #03", null, "Ken's Books Box #03 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("dad8cce7-de8d-4c1e-821d-14854b016e1e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #04", null, "Ken's Books Box #04 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("223be192-8783-4043-af65-b539f9150c8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #05", null, "Ken's Books Box #05 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("66d95c77-ab63-44eb-9b2a-4314440e8748"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #06", null, "Ken's Books Box #06 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1dd34364-e262-479a-8be9-063b3a74fd07"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ken's Books Box #07", null, "Ken's Books Box #07 [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("099ebbc3-d1fb-4017-9acc-805e228ebd33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "JVC CH-X200 Box", null, "JVC CH-X200 Box [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5f8a9382-be69-46b6-89cc-6007d1044eaa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 1A7", "Hot Wheels Box #26", null, "Hot Wheels Box #26 (Amazon 1A7) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8052bda2-1f6a-4b5e-b08e-68f25b7b63ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Husky Tools Organizer #1", null, "Husky Tools Organizer #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6f914c38-9b53-4970-acef-4703383680af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 20x20x6.5", "Hot Wheels Star Wars C-Cars Box #1", null, "Hot Wheels Star Wars C-Cars Box #1 (Unmarked 20x20x6.5) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a3cf5994-ee02-405f-a88d-fc6e221f4b20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked Priority Mail 16x12x4", "Hot Wheels Box #28", null, "Hot Wheels Box #28 (Unmarked Priority Mail 16x12x4) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("52876700-611f-4c9b-adff-c6b18f14028d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x14x6.5", "Hot Wheels Box #29", null, "Hot Wheels Box #29 (Unmarked 14x14x6.5) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f114c6e6-d560-4142-bde0-e13721248124"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14.5x11x6.5", "Hot Wheels Box #30", null, "Hot Wheels Box #30 (Unmarked 14.5x11x6.5) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c2e25a3e-2633-4148-8168-792c302a0728"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x10.5x7", "Hot Wheels Box #31", null, "Hot Wheels Box #31 (Unmarked 14x10.5x7) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0e6bd7e4-8570-4d40-b0ff-a781d67d3fe9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked Priority Mail 14x10x6", "Hot Wheels Box #32", null, "Hot Wheels Box #32 (Unmarked Priority Mail 14x10x6) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f4893801-6b98-41b8-a17d-1f02b0ae252d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amazon 1B4", "Hot Wheels Box #33", null, "Hot Wheels Box #33 (Amazon 1B4) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ee6abedc-fb17-4c87-b467-f7b75bacfcf7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel MD28", "Hot Wheels Box #34", null, "Hot Wheels Box #34 (Mattel MD28) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("d11540fa-77ee-4bc5-ac1b-22788c9c083f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Husky Supplies Organizer #1", null, "Husky Supplies Organizer #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("dcce2a95-43bb-4bdf-af8a-cdccaf56d1a6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel BDT77 Case", "Hot Wheels Box #Retro 13D", null, "Hot Wheels Box #Retro 13D (Mattel BDT77 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f77870db-19dc-4a1e-bbaa-9c6e0d87bdba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel X8893", "Hot Wheels Box #Retro13B", null, "Hot Wheels Box #Retro13B (Mattel X8893) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("487c96c3-d80e-431c-97fb-7a25609a62a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel X8893", "Hot Wheels Box #Retro13C", null, "Hot Wheels Box #Retro13C (Mattel X8893) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("56a2a640-30fc-435c-acfe-dcb3484b64b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DLB45", "Hot Wheels Pop Culture - Peanuts Box", null, "Hot Wheels Pop Culture - Peanuts Box (DLB45) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("37ac937b-4b8d-4cf3-a45f-def8705664da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DLB45", "Hot Wheels Pop Culture - Star Wars McQuarrie Box", null, "Hot Wheels Pop Culture - Star Wars McQuarrie Box (DLB45) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("52a04857-b9c9-42b8-8b56-fd5605c33fc5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Wheels Sizzlers Box #01", null, "Hot Wheels Sizzlers Box #01 [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("344c70bc-4908-4342-a3c2-38fe00063241"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 14x14x8.5", "Hot Wheels Star Wars Carships Box #1", null, "Hot Wheels Star Wars Carships Box #1 (Unmarked 14x14x8.5) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cf0c93f3-bbc5-44d8-98bf-4cf96c287b3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel FBB72 Case", "Hot Wheels Star Wars Carships Box #2", null, "Hot Wheels Star Wars Carships Box #2 (Mattel FBB72 Case) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("cc9e1fa5-5526-4e2d-b704-79ef8c137cdb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Squadron 18x12x6", "Hot Wheels Box #Retro13", null, "Hot Wheels Box #Retro13 (Squadron 18x12x6) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4f9538df-cd2d-469d-a192-8b76029d9f50"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Wheels 48 Car Case #02", null, "Hot Wheels 48 Car Case #02 [Car Collectables Box #01]", "Car Collectables Box #01" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bdef568f-776a-4341-a5a6-e2987e774127"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattel L2593 Case", "Hot Wheels Box #2018A", null, "Hot Wheels Box #2018A (Mattel L2593 Case) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a0fa202b-36da-494c-a34a-d34e9d0102f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #09", null, "Hot Cases #09 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b4a445e6-8423-4774-ae6a-ace1ae66beed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #03 - Waiting for WMV", null, "DVD Box #03 (UHS) [Attic] - Waiting for WMV", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a81e4ff3-88b3-49f1-bc81-f3495101c8e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #03", null, "DVD Box #03 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("054a2320-7f42-423a-b861-77b6c1543b32"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "#03325", "DVD Box #05", null, "DVD Box #05 (#03325) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("18c43d5c-d5ca-4088-b89e-72c230aa9cad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #06", null, "DVD Box #06 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("90841891-2d8d-4bda-b561-80b6536ef422"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #07", null, "DVD Box #07 [UHS Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1b40e06b-cc6b-4852-9c5d-baa64ad143b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #08", null, "DVD Box #08 [UHS Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("eed47f96-86f1-4af7-aa9e-d5fa5d181ee4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #09", null, "DVD Box #09 [UHS Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("05c9e98d-1e0e-42b8-97f9-0c41c7ded49f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #02", null, "DVD Box #02 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c8f708ae-3a51-4020-ba5f-8dd9f7de32a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #10", null, "DVD Box #10 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("13561880-b257-4f9b-8952-d19add0bb2f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #12", null, "DVD Box #12 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("83523ab3-6bb4-4764-9bc0-f4c02c598b3d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #13", null, "DVD Box #13 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("0224a9e6-aeb4-42f0-a702-418bf5d3bff6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #14", null, "DVD Box #14 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("aeb44c58-ab3f-402e-ac75-4c4c945ed406"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #15", null, "DVD Box #15 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("02266d51-520b-461a-b327-a3d3d9115e55"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #16", null, "DVD Box #16 (33250) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("17c6bcce-d5f7-49de-a383-bfa863764e18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #17", null, "DVD Box #17 (33250) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5511fc27-93d0-4391-81c2-d08af6a67bb4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #18", null, "DVD Box #18 (33250) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1452361d-780a-49ae-a19d-e0f089fe3e96"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #11", null, "DVD Box #11 (33250) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("88a91729-6e67-4e6c-97de-eee9d0ae64d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #19", null, "DVD Box #19 (33250) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5a1e2a67-1467-4fad-89ca-cdb80e396c53"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVD Box #02 - Waiting for WMV", null, "DVD Box #02 (UHS) [Attic] - Waiting for WMV", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5003728b-79af-40ac-9f9c-7934da2757b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Donated", null, "Donated", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a882c98f-54cb-4f9a-97e8-f723a1694589"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Combat Aircraft 2012-2014", null, "Combat Aircraft 2012-2014 [Top of Steps]", "Top of Steps" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("fd19f993-f608-40d3-89f1-62f96aaecf12"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Combat Aircraft 2015-2018", null, "Combat Aircraft 2015-2018 [Top of Steps]", "Top of Steps" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a3c8d652-efd5-4e34-a85d-a70815f49e25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Computer Books Box #01", null, "Computer Books Box #01 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c0befdf1-e0ec-4e16-ab37-8a9c61d2d7ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Computer Books Box #02", null, "Computer Books Box #02 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2f685f36-8fa3-44f8-afc3-076ed9ac5cc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Computer Books Box #03", null, "Computer Books Box #03 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e06b3252-54f6-4bb0-86b0-19f7dcde2524"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "CS20101219.1", null, "CS20101219.1 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("91f3c178-52d1-4f57-911b-4abefee49888"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "CS20101219.2", null, "CS20101219.2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("6f5007fd-77e2-45e4-a9bc-d0adc6444799"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Doorway PB Stack", null, "Doorway PB Stack [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2265e6e3-4dd8-45e0-bb79-a332e4afb69e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Wheels 48 Car Case #01", null, "Hot Wheels 48 Car Case #01 [Car Collectables Box #01]", "Car Collectables Box #01" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("545a61d1-7b85-4735-bd34-1f77dc82a400"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Decals salvaged", null, "Decals salvaged", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("19a1e23b-8871-4e00-bd4d-aba175c79f1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Desk", null, "Desk", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("156622b5-b8e0-4bf1-a95a-c8b681fa02a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Destroyed", null, "Destroyed", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9caca452-e91f-4177-ad26-6289f1c63aba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "18x13x11", "Detail Sets Box", null, "Detail Sets Box (18x13x11) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9f038a5d-27fb-4fb9-bc9e-4bec953e57bd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Die Cast Collectables Box #1", null, "Die Cast Collectables Box #1 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8fc15b73-475a-44b1-880e-00b2a34ac462"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Digital Download", null, "Digital Download", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ca130f51-dc68-44eb-af5e-7ce766da13ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Dining Room", null, "Dining Room", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7caff686-ad65-4f5a-a9a0-3ea01e129ad6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Decals left with detail set included in kit", null, "Decals left with detail set included in kit", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e726158c-7e3f-4eb3-9f36-22a707ecc4db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #20 - Waiting for WMV", null, "DVD Box #20 (33250) [Ken's Room] - Waiting for WMV", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("8ba1ea8a-a9a6-4aa7-8710-dccb1cd5daf6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Decals left in bag", null, "Decals left in bag", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("637a3051-e777-4d98-8c5e-ba34d06af68e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #21", null, "DVD Box #21 (33250) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("922e8718-3a6d-4bc2-a600-3d50207df5eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #3", null, "FreeTime Box #3 (Ken's Room)", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5f799e6c-588c-4277-9424-a8e58b07b2d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #3", null, "FreeTime Box #3 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a75fd275-f423-47ee-a09e-ea32d84724a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #4", null, "FreeTime Box #4 (Ken's Room)", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("9c108bf1-cf95-4d57-b65d-2720a517f701"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #5", null, "FreeTime Box #5 (Ken's Room)", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("3391c4b9-7eed-43c8-b021-a6b22fec93f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #5", null, "FreeTime Box #5 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c3cff0bd-bb9f-45fd-bdec-5cfda516eeb7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "HALO Box #1", null, "HALO Box #1 (UHS) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("7ab2e68d-afea-45b2-a58f-68981d8f752f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "History Books Box #10", null, "History Books Box #10 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("1be6796a-7340-42bb-8e83-80466f3d0d5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #2", null, "FreeTime Box #2 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("db888073-db60-4af4-90d1-7c01be0db85b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "History Books From Ken's Desk", null, "History Books From Ken's Desk (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("10197af8-9a80-4c24-a0e6-7d53697ee5c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #02", null, "Hot Cases #02 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("41311e91-96e9-4929-abe6-24dd683a44a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #03", null, "Hot Cases #03 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a9445812-df7c-4634-a1bb-616068127cb5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #05", null, "Hot Cases #05 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2e99c844-c06d-4607-bc0d-8791d1f7ce4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #06", null, "Hot Cases #06 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5913c130-a126-4efc-bc14-06faddae74e6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #07", null, "Hot Cases #07 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a04ac5e4-01ce-4c42-9a71-312f4c22e820"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #08", null, "Hot Cases #08 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("2d422b85-32d3-4fe8-8716-00a560d74361"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #20", null, "DVD Box #20 (33250) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("07b3755a-77fe-45c0-8df7-ead87c417bf3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #01", null, "Hot Cases #01 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("25355729-4379-4e44-8fbe-4677286f2b0e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #2", null, "FreeTime Box #2 (Ken's Room)", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("96a50efa-d6d7-4e5e-9a41-35a583ce773c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Hot Cases #04", null, "Hot Cases #04 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("a55ecc41-6cae-4961-91db-61e4f696abee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unmarked 20x14x7", "Forbidden Planet Box", null, "Forbidden Planet Box (Unmarked 20x14x7) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("241eef5f-c4ce-4648-87ef-7babceac94a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #1", null, "FreeTime Box #1 (Ken's Room)", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ffc2b491-1ad8-4d5a-a6e7-08e2e47ca8b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #23", null, "DVD Box #23 (33250) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("b9d38726-127f-494b-a0ea-6ec5a03a041e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #24", null, "DVD Box #24 (33250) [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bca72425-69e8-488d-9082-019bbf4d9cdd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "33250", "DVD Box #22", null, "DVD Box #22 (33250) [Attic]", "Attic" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("17f593fa-e0a5-4e78-a556-67ff3e96ac33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "DVDs - General Box #1", null, "DVDs - General Box #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("e4ac88c7-052a-40d0-bd40-a110b6062209"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "DVDs - General Box #2", null, "DVDs - General Box #2 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ff3a985d-0c55-4cb8-96a1-e1e6e65ff71f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVDs - General Box #2", null, "DVDs - General Box #2 [UHS Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("bd6d813d-2a9a-4881-9db8-fef6908f9e9c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Entertainment Center Shelf", null, "Entertainment Center Shelf", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("216184d0-cf1b-4266-b32d-3f220b9f9943"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "DVDs - General", null, "DVDs - General [UHS Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("c524436f-782b-4b94-a84a-a753a7062f68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Federation Box #1", null, "Federation Box #1 [Ken's Room]", "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("59570c8b-3749-404d-91bd-17b4aec95916"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Fiction Books Box #2", null, "Fiction Books Box #2 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("5db6706a-6cac-4916-896b-54bcae40d08d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Fiction Books Box #3", null, "Fiction Books Box #3 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("ff65aacc-d850-45d7-b102-3b2e1a7da29e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Fiction Books Box #6", null, "Fiction Books Box #6 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("f0cfb626-d592-44ca-b66b-8f2c4d5fb64f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UHS", "Fiction Books Box #8", null, "Fiction Books Box #8 (UHS) [Basement]", "Basement" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("707205ec-1d65-433c-b348-4ea9e2f4c48e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "File Entry", null, "File Entry", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("4c1ffcea-7770-4504-84de-ddb98bef1607"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Ether", null, "Ether", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "OName", "PhysicalLocation" },
                values: new object[] { new Guid("719f0e3e-e6b7-4656-b854-3768b934dcf5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESSS", "Football Cards Box #1", null, "Football Cards Box #1 (ESSS) [Closet]", "Closet" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("701600f0-367a-4047-8c9a-c3652b31c72d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guided Missile Frigates", null, "FFG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("f0236a08-68ad-4891-9b39-a3e19d980250"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mine Countermeasures Support Ships", null, "MCS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("f14a5426-5946-4fa0-84c1-a98954bd39f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mine Countermeasures Ships", null, "MCM" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("dc4b25c6-7929-4df2-8d5a-3b30f8e57c34"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tank Landing Ships", null, "LST" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("65ef2141-a6eb-424a-a95d-fdd5eb9fee0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dock Landing Ships", null, "LSD" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("8c24eaeb-1e00-44ac-be78-91b85bdd6714"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Assault Ships (Helicopter)", null, "LPH" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("f4eb547c-fd36-4962-854a-c75f191875c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Assault Ships (general purpose)", null, "LHA" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("69e3c91e-a2de-484e-867a-66b0b28a1960"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Cargo Ships", null, "LKA" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("243cfe4c-f261-422a-857a-2eee77b657ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Assault Ships (multi-purpose)", null, "LHD" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("bd383ea2-924b-4fce-a0eb-217e6d2bd1e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Littoral Combat Ship", null, "LCS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("64822b20-89dc-4dc8-bf8a-03ad55b1ac1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Command Ships", null, "LCC" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("ac518938-b74c-484e-a496-19aeb121757e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unclassified Miscellaneous Units", null, "IX" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("0db24e33-e790-47a3-b92d-fc971fdb3c1c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Transport docks", null, "LPD" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("51e19cfe-b23c-4288-9288-969e93358cf8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minehunters, Coastal", null, "MHC" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("c046f339-8ebe-4124-b706-314407d5074d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training Submarines", null, "SST" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("e9a6b06d-3d32-4cf1-8f21-e7edd27f582d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrol Craft", null, "PC" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("0d1e16a1-c605-41ae-a7fa-c86fb3103128"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrol Gunboats", null, "PG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("f84367a2-1822-450f-bf8d-99efe7b5568a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patrol Combatants - Missile (Hydrofoil)", null, "PHM" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("3b85f6a0-07b0-4453-8d5a-1baba696e9bd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Submarines", null, "SS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("03ec3bf8-a596-4180-a29e-e9c0cfd02e94"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ballistic Missile Submarines (Nuclear)", null, "SSBN" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("9f0a2cae-a333-4f87-9e53-b5db3ac642a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Submarines (Nuclear)", null, "SSN" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("bc3bd562-1ddc-4911-9510-02a185f05d3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ammunition Ships (assigned to Military Sealift Command)", null, "T-AE" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("6611c640-9f18-40b0-af46-de4c45681ddb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Combat Store Ships (assigned to Military Sealift Command)", null, "T-AFS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("a1b77762-b705-4605-a6cc-9f73ce2e9266"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oceanographic Research Ships", null, "T-AG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("3738fa9f-9a7a-4ce7-bf2c-e4bfe9fb81f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oilers (assigned to Military Sealift Command)", null, "T-AO" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("47087be3-658f-46ab-82e3-cb786370f639"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast Combat Support Ships (assigned to Military Sealift Command)", null, "T-AOE" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("2b7fcf37-767d-4dbe-9b0b-0424732b2390"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frigates", null, "FF" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("c10cb992-99ab-4d11-b532-aa761d0a17d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salvage Ships (assigned to Military Sealift Command)", null, "T-ARS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("f1458df6-750b-454c-b8eb-e98a82d7a056"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ocean Minesweepers", null, "MSO" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("9640289c-4fef-4ac1-8c9a-69eecd89e7d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guided Missile Frigate (post WWII)", null, "DLG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("7edd19f5-231a-4713-b9ec-a1d95581c980"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Submarine Tenders", null, "AS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("d9fa3990-c85f-4b82-93f1-4628e24f43df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Destroyer Escorts", null, "DE" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("8bd0af19-08a5-4ba7-bf19-57a4d90817e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Submarine Tenders (assigned to Military Sealift Command)", null, "T-AS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("59837210-92d5-4573-8d15-f39a541dacb2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unassigned", null, "XXX" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("8e4e50d4-184f-4cde-8159-3e20119f0e04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heavy Armored Cruiser - Battleship prototype", null, "ACR" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("6c3b15f5-6b54-4d9b-9d82-419beab04c86"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Destroyer Tenders", null, "AD" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("f36312f7-1b15-41ee-8bc4-6ad26a47622b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ammunition Ships", null, "AE" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("9e8d8f09-7c7b-4042-b901-28cb453ab3b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oceanographic Research Ships", null, "AG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("a9cabb18-0b89-4a5a-b345-b36c23f84f78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miscellaneous Command Ships", null, "AGF" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("603fdbd9-b459-45d3-9555-a5fe6dc17a54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Auxiliary Research Submarines", null, "AGSS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("bd38f905-7e1d-42ad-b050-1eb60ac90c2a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oilers", null, "AO" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("634767ee-cae5-4519-bf5f-eee6935a9a62"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast Combat Support Ships", null, "AOE" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("9c57c926-fe33-4424-b47e-213ab327f9fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Replenishment Oilers", null, "AOR" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("88ff000e-553a-45c6-b11b-2984078a8c31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "High Speed Transports", null, "APD" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("b63333ef-2188-4498-a790-a4188dbfe64e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salvage Ships", null, "ARS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("b049c717-70d8-4249-bff9-6d6b20391660"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salvage and Rescue Ships", null, "ATS" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("7b27e466-6a73-406a-bade-7c36c54c8fc3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battleships", null, "BB" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("6d7bafc7-af26-4768-98ed-26a0198602f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heavy (Gun) Cruisers", null, "CA" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("17594b36-58c9-4034-abe6-667c1290943b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guided Missile Heavy Cruisers", null, "CAG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("28d6f15e-518f-456d-8634-5a369eee595e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Large Cruisers", null, "CB" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("9e67f4d3-888e-457d-bd1f-a77845d3fe88"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guided Missile Cruisers", null, "CG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("3af19e39-7dee-478e-a558-4cf7c71e6d4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guided Missile Cruisers (Nuclear)", null, "CGN" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("a6f194f6-ec6b-4477-9441-3c00e05936a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Light (Gun) Cruisers", null, "CL" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("416b1857-e03b-4d78-b3ee-38ea1ff17f5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Command Cruisers", null, "CLC" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("7115f45b-acc4-4482-a52b-487a81e7cb56"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Light Guided Missile Cruisers", null, "CLG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("156ac082-e0cc-4707-8f2e-50f2f4542919"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Multi-Purpose (Fleet) Aircraft Carriers", null, "CV" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("6ee60c0a-b704-46a4-92ef-d04f39178d38"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escort Carriers", null, "CVE" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("0431226a-dbea-4f4a-b070-7068976afb8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Light Carriers", null, "CVL" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("70a97a16-4be8-41dd-be6d-d9fae9c69a53"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Multi-Purpose Aircraft Carriers (Nuclear)", null, "CVN" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("8f5f340d-4cea-4e98-ba54-5eb339b1c29d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Destroyers", null, "DD" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("3f72c543-90ca-44dd-bb42-b9fbb9c1f10e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guided Missile Destroyers", null, "DDG" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("79cfb009-a962-4d20-b6ae-7c7c588c49ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Post World War II Frigates", null, "DL" });

            migrationBuilder.InsertData(
                table: "ShipClassTypes",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "OID", "TypeCode" },
                values: new object[] { new Guid("6e0a89dc-26f7-466e-a09a-86ef4033c904"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amphibious Cargo Ships (assigned to Military Sealift Command)", null, "T-LKA" });

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
