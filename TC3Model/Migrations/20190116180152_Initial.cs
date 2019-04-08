using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TC3Model.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OID = table.Column<int>(nullable: true),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Column = table.Column<string>(maxLength: 32, nullable: true),
                    DateChanged = table.Column<DateTime>(nullable: false),
                    OriginalValue = table.Column<string>(nullable: true),
                    RecordID = table.Column<int>(nullable: false),
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
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OID = table.Column<int>(nullable: true),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 80, nullable: true),
                    Image = table.Column<byte[]>(type: "image", nullable: true),
                    FileName = table.Column<string>(maxLength: 80, nullable: true),
                    URL = table.Column<string>(maxLength: 132, nullable: true),
                    Height = table.Column<int>(nullable: true),
                    Width = table.Column<int>(nullable: true),
                    Category = table.Column<string>(maxLength: 80, nullable: true),
                    AlphaSort = table.Column<string>(maxLength: 132, nullable: true),
                    TableName = table.Column<string>(maxLength: 32, nullable: true),
                    RecordID = table.Column<int>(nullable: true),
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
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OID = table.Column<int>(nullable: true),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 1024, nullable: true),
                    Name = table.Column<string>(maxLength: 1024, nullable: true),
                    PhysicalLocation = table.Column<string>(maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Query",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OID = table.Column<int>(nullable: true),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
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
                name: "ReferenceBase",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OID = table.Column<int>(nullable: true),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(maxLength: 32, nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 72, nullable: true),
                    Name = table.Column<string>(maxLength: 72, nullable: true),
                    Nicknames = table.Column<string>(maxLength: 80, nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Number = table.Column<double>(nullable: true),
                    ServiceDate = table.Column<DateTime>(nullable: true),
                    Type = table.Column<string>(maxLength: 32, nullable: true),
                    Version = table.Column<string>(maxLength: 32, nullable: true),
                    ServiceDates = table.Column<string>(maxLength: 80, nullable: true),
                    AircraftType = table.Column<string>(maxLength: 80, nullable: true),
                    Decals = table.Column<string>(nullable: true),
                    DecalSets = table.Column<string>(nullable: true),
                    Kits = table.Column<string>(nullable: true),
                    BlueAngelsHistory_Notes = table.Column<string>(nullable: true),
                    Account = table.Column<string>(maxLength: 32, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Code = table.Column<string>(maxLength: 32, nullable: true),
                    Company_Name = table.Column<string>(maxLength: 72, nullable: true),
                    Phone = table.Column<string>(maxLength: 14, nullable: true),
                    ProductType = table.Column<string>(maxLength: 32, nullable: true),
                    ShortName = table.Column<string>(maxLength: 32, nullable: true),
                    WebSite = table.Column<string>(nullable: true),
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
                    Ship_Name = table.Column<string>(maxLength: 80, nullable: true),
                    Ship_Notes = table.Column<string>(nullable: true),
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
                    Ship_Number = table.Column<double>(nullable: true),
                    Status = table.Column<string>(maxLength: 80, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 18, nullable: true),
                    ShipClassID = table.Column<int>(nullable: true),
                    ShipClassTypeID = table.Column<int>(nullable: true),
                    ShipClass_Aircraft = table.Column<string>(nullable: true),
                    ShipClass_ASWWeapons = table.Column<string>(nullable: true),
                    ShipClass_Beam = table.Column<string>(nullable: true),
                    ShipClass_Boilers = table.Column<string>(nullable: true),
                    ShipClass_Description = table.Column<string>(nullable: true),
                    ShipClass_Displacement = table.Column<string>(nullable: true),
                    ShipClass_Draft = table.Column<string>(nullable: true),
                    ShipClass_EW = table.Column<string>(nullable: true),
                    ShipClass_FireControl = table.Column<string>(nullable: true),
                    ShipClass_Guns = table.Column<string>(nullable: true),
                    ShipClass_Length = table.Column<string>(nullable: true),
                    ShipClass_Manning = table.Column<string>(nullable: true),
                    ShipClass_Missiles = table.Column<string>(nullable: true),
                    ShipClass_Name = table.Column<string>(maxLength: 80, nullable: true),
                    ShipClass_Notes = table.Column<string>(nullable: true),
                    ShipClass_Propulsion = table.Column<string>(nullable: true),
                    ShipClass_Radars = table.Column<string>(nullable: true),
                    ShipClass_Speed = table.Column<string>(maxLength: 132, nullable: true),
                    ShipClass_Sonars = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: true),
                    ShipClassTypeID1 = table.Column<int>(nullable: true),
                    ShipClassType_Description = table.Column<string>(maxLength: 80, nullable: true),
                    TypeCode = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceBase", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReferenceBase_ReferenceBase_ShipClassID",
                        column: x => x.ShipClassID,
                        principalTable: "ReferenceBase",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReferenceBase_ReferenceBase_ShipClassTypeID",
                        column: x => x.ShipClassTypeID,
                        principalTable: "ReferenceBase",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReferenceBase_ReferenceBase_ShipClassTypeID1",
                        column: x => x.ShipClassTypeID1,
                        principalTable: "ReferenceBase",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StashBase",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OID = table.Column<int>(nullable: true),
                    RowID = table.Column<byte[]>(rowVersion: true, nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Cataloged = table.Column<bool>(nullable: true),
                    DateInventoried = table.Column<DateTime>(nullable: true),
                    DatePurchased = table.Column<DateTime>(nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    LocationID = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true),
                    Value = table.Column<decimal>(type: "money", nullable: true),
                    WishList = table.Column<bool>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    AlphaSort = table.Column<string>(maxLength: 80, nullable: true),
                    Author = table.Column<string>(maxLength: 80, nullable: true),
                    MediaFormat = table.Column<string>(maxLength: 80, nullable: true),
                    ISBN = table.Column<string>(maxLength: 24, nullable: true),
                    Misc = table.Column<string>(maxLength: 32, nullable: true),
                    Subject = table.Column<string>(maxLength: 80, nullable: true),
                    Title = table.Column<string>(maxLength: 132, nullable: true),
                    Condition = table.Column<string>(maxLength: 80, nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 80, nullable: true),
                    Name = table.Column<string>(maxLength: 132, nullable: true),
                    OutOfProduction = table.Column<bool>(nullable: true),
                    Reference = table.Column<string>(maxLength: 32, nullable: true),
                    Series = table.Column<string>(maxLength: 80, nullable: true),
                    Type = table.Column<string>(maxLength: 80, nullable: true),
                    Designation = table.Column<string>(maxLength: 132, nullable: true),
                    Decal_Manufacturer = table.Column<string>(maxLength: 132, nullable: true),
                    Decal_Name = table.Column<string>(maxLength: 256, nullable: true),
                    Nation = table.Column<string>(maxLength: 132, nullable: true),
                    ProductCatalog = table.Column<string>(maxLength: 132, nullable: true),
                    Decal_Reference = table.Column<string>(maxLength: 132, nullable: true),
                    Scale = table.Column<string>(maxLength: 12, nullable: true),
                    Decal_Type = table.Column<string>(maxLength: 132, nullable: true),
                    DetailSet_Designation = table.Column<string>(maxLength: 132, nullable: true),
                    DetailSet_Manufacturer = table.Column<string>(maxLength: 132, nullable: true),
                    DetailSet_Name = table.Column<string>(maxLength: 256, nullable: true),
                    DetailSet_Nation = table.Column<string>(maxLength: 132, nullable: true),
                    DetailSet_ProductCatalog = table.Column<string>(maxLength: 132, nullable: true),
                    DetailSet_Reference = table.Column<string>(maxLength: 132, nullable: true),
                    DetailSet_Scale = table.Column<string>(maxLength: 12, nullable: true),
                    DetailSet_Type = table.Column<string>(maxLength: 132, nullable: true),
                    Distributor = table.Column<string>(maxLength: 80, nullable: true),
                    Episode_MediaFormat = table.Column<string>(maxLength: 80, nullable: true),
                    Number = table.Column<string>(maxLength: 32, nullable: true),
                    DateReleased = table.Column<DateTime>(nullable: true),
                    Episode_Series = table.Column<string>(maxLength: 80, nullable: true),
                    StoreBought = table.Column<bool>(nullable: true),
                    Episode_Subject = table.Column<string>(maxLength: 80, nullable: true),
                    Taped = table.Column<bool>(nullable: true),
                    Episode_Title = table.Column<string>(maxLength: 80, nullable: true),
                    WMV = table.Column<bool>(nullable: true),
                    Count = table.Column<double>(nullable: true),
                    FinishingProduct_Manufacturer = table.Column<string>(maxLength: 80, nullable: true),
                    FinishingProduct_Name = table.Column<string>(maxLength: 72, nullable: true),
                    FinishingProduct_ProductCatalog = table.Column<string>(maxLength: 80, nullable: true),
                    FinishingProduct_Reference = table.Column<string>(maxLength: 32, nullable: true),
                    FinishingProduct_Type = table.Column<string>(maxLength: 32, nullable: true),
                    Kit_Condition = table.Column<string>(maxLength: 132, nullable: true),
                    DecalID = table.Column<int>(nullable: true),
                    Kit_Designation = table.Column<string>(maxLength: 132, nullable: true),
                    DetailSetID = table.Column<int>(nullable: true),
                    Era = table.Column<string>(maxLength: 80, nullable: true),
                    Kit_Manufacturer = table.Column<string>(maxLength: 132, nullable: true),
                    Kit_Name = table.Column<string>(maxLength: 256, nullable: true),
                    Kit_Nation = table.Column<string>(maxLength: 132, nullable: true),
                    Kit_OutOfProduction = table.Column<bool>(nullable: true),
                    Kit_ProductCatalog = table.Column<string>(maxLength: 132, nullable: true),
                    Kit_Reference = table.Column<string>(maxLength: 132, nullable: true),
                    Kit_Scale = table.Column<string>(maxLength: 12, nullable: true),
                    Service = table.Column<string>(maxLength: 132, nullable: true),
                    Kit_Type = table.Column<string>(maxLength: 132, nullable: true),
                    Movie_AlphaSort = table.Column<string>(maxLength: 80, nullable: true),
                    Movie_Distributor = table.Column<string>(maxLength: 80, nullable: true),
                    Movie_MediaFormat = table.Column<string>(maxLength: 80, nullable: true),
                    Movie_DateReleased = table.Column<DateTime>(nullable: true),
                    Movie_StoreBought = table.Column<bool>(nullable: true),
                    Movie_Subject = table.Column<string>(maxLength: 80, nullable: true),
                    Movie_Title = table.Column<string>(maxLength: 80, nullable: true),
                    Movie_WMV = table.Column<bool>(nullable: true),
                    Artist = table.Column<string>(maxLength: 80, nullable: true),
                    Music_AlphaSort = table.Column<string>(maxLength: 80, nullable: true),
                    Music_MediaFormat = table.Column<string>(maxLength: 80, nullable: true),
                    Music_Title = table.Column<string>(maxLength: 80, nullable: true),
                    Music_Type = table.Column<string>(maxLength: 80, nullable: true),
                    Year = table.Column<int>(nullable: true),
                    Rocket_Designation = table.Column<string>(maxLength: 32, nullable: true),
                    Rocket_Manufacturer = table.Column<string>(maxLength: 80, nullable: true),
                    Rocket_Name = table.Column<string>(maxLength: 72, nullable: true),
                    Rocket_Nation = table.Column<string>(maxLength: 32, nullable: true),
                    Rocket_ProductCatalog = table.Column<string>(maxLength: 80, nullable: true),
                    Rocket_Reference = table.Column<string>(maxLength: 32, nullable: true),
                    Rocket_Scale = table.Column<string>(maxLength: 12, nullable: true),
                    Rocket_Type = table.Column<string>(maxLength: 32, nullable: true),
                    Software_AlphaSort = table.Column<string>(maxLength: 132, nullable: true),
                    CDkey = table.Column<string>(maxLength: 80, nullable: true),
                    Software_DateReleased = table.Column<DateTime>(nullable: true),
                    Developer = table.Column<string>(maxLength: 80, nullable: true),
                    Software_ISBN = table.Column<string>(maxLength: 24, nullable: true),
                    Software_MediaFormat = table.Column<string>(maxLength: 80, nullable: true),
                    Platform = table.Column<string>(maxLength: 32, nullable: true),
                    Publisher = table.Column<string>(maxLength: 80, nullable: true),
                    Software_Title = table.Column<string>(maxLength: 80, nullable: true),
                    Software_Type = table.Column<string>(maxLength: 32, nullable: true),
                    Version = table.Column<string>(maxLength: 32, nullable: true),
                    Special_AlphaSort = table.Column<string>(maxLength: 80, nullable: true),
                    Special_Distributor = table.Column<string>(maxLength: 80, nullable: true),
                    Special_MediaFormat = table.Column<string>(maxLength: 80, nullable: true),
                    Special_DateReleased = table.Column<DateTime>(nullable: true),
                    Special_StoreBought = table.Column<bool>(nullable: true),
                    Special_Subject = table.Column<string>(maxLength: 80, nullable: true),
                    Special_Title = table.Column<string>(maxLength: 80, nullable: true),
                    Special_WMV = table.Column<bool>(nullable: true),
                    Tool_Manufacturer = table.Column<string>(maxLength: 80, nullable: true),
                    Tool_Name = table.Column<string>(maxLength: 132, nullable: true),
                    Tool_ProductCatalog = table.Column<string>(maxLength: 80, nullable: true),
                    Tool_Reference = table.Column<string>(maxLength: 32, nullable: true),
                    Line = table.Column<string>(maxLength: 72, nullable: true),
                    Train_Manufacturer = table.Column<string>(maxLength: 80, nullable: true),
                    Train_Name = table.Column<string>(maxLength: 132, nullable: true),
                    Train_ProductCatalog = table.Column<string>(maxLength: 80, nullable: true),
                    Train_Reference = table.Column<string>(maxLength: 32, nullable: true),
                    Train_Scale = table.Column<string>(maxLength: 12, nullable: true),
                    Train_Type = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StashBase", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StashBase_StashBase_DecalID",
                        column: x => x.DecalID,
                        principalTable: "StashBase",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StashBase_StashBase_DetailSetID",
                        column: x => x.DetailSetID,
                        principalTable: "StashBase",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StashBase_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReferenceImages",
                columns: table => new
                {
                    ReferenceID = table.Column<int>(nullable: false),
                    ImageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceImages", x => new { x.ReferenceID, x.ImageID });
                    table.ForeignKey(
                        name: "FK_ReferenceImages_Images_ImageID",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReferenceImages_ReferenceBase_ReferenceID",
                        column: x => x.ReferenceID,
                        principalTable: "ReferenceBase",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StashImages",
                columns: table => new
                {
                    StashID = table.Column<int>(nullable: false),
                    ImageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StashImages", x => new { x.StashID, x.ImageID });
                    table.ForeignKey(
                        name: "FK_StashImages_Images_ImageID",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StashImages_StashBase_StashID",
                        column: x => x.StashID,
                        principalTable: "StashBase",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ValidationRuleMessage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PropertyName = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    HistoryID = table.Column<int>(nullable: true),
                    ImageID = table.Column<int>(nullable: true),
                    LocationID = table.Column<int>(nullable: true),
                    QueryID = table.Column<int>(nullable: true),
                    ReferenceBaseID = table.Column<int>(nullable: true),
                    StashBaseID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidationRuleMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValidationRuleMessage_History_HistoryID",
                        column: x => x.HistoryID,
                        principalTable: "History",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ValidationRuleMessage_Images_ImageID",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ValidationRuleMessage_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ValidationRuleMessage_Query_QueryID",
                        column: x => x.QueryID,
                        principalTable: "Query",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ValidationRuleMessage_ReferenceBase_ReferenceBaseID",
                        column: x => x.ReferenceBaseID,
                        principalTable: "ReferenceBase",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ValidationRuleMessage_StashBase_StashBaseID",
                        column: x => x.StashBaseID,
                        principalTable: "StashBase",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unknown", null, "Unknown" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-9 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Car Box #1 Ziploc bag", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Decals left in bag", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Decals left with detail set included in kit", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Decals salvaged", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #2 [Ken's Room]", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "FreeTime Box #3 [Ken's Room]", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Included in kit", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Inside E-2C Hawkeye Box (Revell 03945 Kit #2640)", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "JVC CH-200 Box Ziploc bag", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-8 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Left in bag", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "SciFi Box #1 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "SciFi Box #2 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "SciFi Box #3 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "SciFi Box #4 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "SciFi Box #5 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "SciFi Box #6 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "SciFi Box #7 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sealed in package", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Sealed with detail set included in kit", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unboxed [Ken's Room]", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Left in box", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-7 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "On Order", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-5 Ziploc bag (2nd set, with wheels, left in box)", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-6 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Unspecified", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "?? Ziploc bag", null, "Unknown" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Applied to Kit", "Applied", null, "N/A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #? Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #144-1 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #3 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #350-1 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #350-2 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #700-1 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #700-2 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #144-2 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #700-3 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-5 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #700-2 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-4 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-2 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-14 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-12 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-13 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-11 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-10 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #72-1 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "DateCreated", "DateModified", "Description", "Name", "OID", "PhysicalLocation" },
                values: new object[] { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ziploc Bag", "Box #700-4 Ziploc bag", null, "Ken's Room" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Amphibious Transport docks", "LPD" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Dock Landing Ships", "LSD" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Mine Countermeasures Ships", "MCM" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Amphibious Assault Ships (Helicopter)", "LPH" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Tank Landing Ships", "LST" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Amphibious Cargo Ships", "LKA" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Unclassified Miscellaneous Units", "IX" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Amphibious Assault Ships (general purpose)", "LHA" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Littoral Combat Ship", "LCS" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Amphibious Command Ships", "LCC" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Mine Countermeasures Support Ships", "MCS" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Guided Missile Frigates", "FFG" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Amphibious Assault Ships (multi-purpose)", "LHD" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Minehunters, Coastal", "MHC" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Oilers (assigned to Military Sealift Command)", "T-AO" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Patrol Craft", "PC" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Patrol Gunboats", "PG" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Patrol Combatants - Missile (Hydrofoil)", "PHM" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Submarines", "SS" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Ballistic Missile Submarines (Nuclear)", "SSBN" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Submarines (Nuclear)", "SSN" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Training Submarines", "SST" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Ammunition Ships (assigned to Military Sealift Command)", "T-AE" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Combat Store Ships (assigned to Military Sealift Command)", "T-AFS" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Oceanographic Research Ships", "T-AG" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Fast Combat Support Ships (assigned to Military Sealift Command)", "T-AOE" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Salvage Ships (assigned to Military Sealift Command)", "T-ARS" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Frigates", "FF" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Ocean Minesweepers", "MSO" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Guided Missile Frigate (post WWII)", "DLG" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Miscellaneous Command Ships", "AGF" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Destroyer Escorts", "DE" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Unassigned", "XXX" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Heavy Armored Cruiser - Battleship prototype", "ACR" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Destroyer Tenders", "AD" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Ammunition Ships", "AE" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Oceanographic Research Ships", "AG" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Submarine Tenders (assigned to Military Sealift Command)", "T-AS" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Auxiliary Research Submarines", "AGSS" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Oilers", "AO" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Fast Combat Support Ships", "AOE" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Replenishment Oilers", "AOR" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "High Speed Transports", "APD" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Salvage Ships", "ARS" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Submarine Tenders", "AS" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Salvage and Rescue Ships", "ATS" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Battleships", "BB" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Heavy (Gun) Cruisers", "CA" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Guided Missile Heavy Cruisers", "CAG" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Large Cruisers", "CB" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Guided Missile Cruisers", "CG" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Guided Missile Cruisers (Nuclear)", "CGN" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Light (Gun) Cruisers", "CL" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Command Cruisers", "CLC" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Light Guided Missile Cruisers", "CLG" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Multi-Purpose (Fleet) Aircraft Carriers", "CV" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Escort Carriers", "CVE" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Light Carriers", "CVL" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Multi-Purpose Aircraft Carriers (Nuclear)", "CVN" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Destroyers", "DD" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Guided Missile Destroyers", "DDG" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Post World War II Frigates", "DL" });

            migrationBuilder.InsertData(
                table: "ReferenceBase",
                columns: new[] { "ID", "DateCreated", "DateModified", "Discriminator", "OID", "ShipClassType_Description", "TypeCode" },
                values: new object[] { 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ShipClassType", null, "Amphibious Cargo Ships (assigned to Military Sealift Command)", "T-LKA" });

            migrationBuilder.CreateIndex(
                name: "IX_HistoryByDate",
                table: "History",
                columns: new[] { "DateChanged", "TableName", "RecordID", "Column" },
                unique: true,
                filter: "[Column] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryByRecord",
                table: "History",
                columns: new[] { "TableName", "RecordID", "DateChanged", "Column" },
                unique: true,
                filter: "[Column] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ImageByRecord",
                table: "Images",
                columns: new[] { "TableName", "RecordID" },
                unique: true,
                filter: "[TableName] IS NOT NULL AND [RecordID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AircraftDesignationsByDesignation",
                table: "ReferenceBase",
                columns: new[] { "Designation", "ID" },
                unique: true,
                filter: "[Designation] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceBase_ShipClassID",
                table: "ReferenceBase",
                column: "ShipClassID");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceBase_ShipClassTypeID",
                table: "ReferenceBase",
                column: "ShipClassTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ShipsByHullNumber",
                table: "ReferenceBase",
                columns: new[] { "HullNumber", "ID" },
                unique: true,
                filter: "[HullNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShipsByName",
                table: "ReferenceBase",
                columns: new[] { "Ship_Name", "ID" },
                unique: true,
                filter: "[Ship_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceBase_ShipClassTypeID1",
                table: "ReferenceBase",
                column: "ShipClassTypeID1");

            migrationBuilder.CreateIndex(
                name: "IX_ShipClassesByName",
                table: "ReferenceBase",
                columns: new[] { "ShipClass_Name", "ID" },
                unique: true,
                filter: "[ShipClass_Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShipClassTypesByName",
                table: "ReferenceBase",
                columns: new[] { "ShipClassType_Description", "ID" },
                unique: true,
                filter: "[ShipClassType_Description] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShipClassTypesByType",
                table: "ReferenceBase",
                columns: new[] { "TypeCode", "ID" },
                unique: true,
                filter: "[TypeCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceImages_ImageID",
                table: "ReferenceImages",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_BooksByAlphaSort",
                table: "StashBase",
                columns: new[] { "AlphaSort", "ID" },
                unique: true,
                filter: "[AlphaSort] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BooksByAuthor",
                table: "StashBase",
                columns: new[] { "Author", "ID" },
                unique: true,
                filter: "[Author] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BooksByISBN",
                table: "StashBase",
                columns: new[] { "ISBN", "ID" },
                unique: true,
                filter: "[ISBN] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BooksBySubject",
                table: "StashBase",
                columns: new[] { "Subject", "ID" },
                unique: true,
                filter: "[Subject] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BooksByTitle",
                table: "StashBase",
                columns: new[] { "Title", "ID" },
                unique: true,
                filter: "[Title] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BooksByFormat",
                table: "StashBase",
                columns: new[] { "MediaFormat", "AlphaSort", "ID" },
                unique: true,
                filter: "[MediaFormat] IS NOT NULL AND [AlphaSort] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CollectablesBySeries",
                table: "StashBase",
                columns: new[] { "Series", "Type", "Reference", "ID" },
                unique: true,
                filter: "[Series] IS NOT NULL AND [Type] IS NOT NULL AND [Reference] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CollectablesByType",
                table: "StashBase",
                columns: new[] { "Type", "Series", "Reference", "ID" },
                unique: true,
                filter: "[Type] IS NOT NULL AND [Series] IS NOT NULL AND [Reference] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CollectablesByName",
                table: "StashBase",
                columns: new[] { "Name", "Series", "Type", "Reference", "ID" },
                unique: true,
                filter: "[Name] IS NOT NULL AND [Series] IS NOT NULL AND [Type] IS NOT NULL AND [Reference] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DecalsByManufacturer",
                table: "StashBase",
                columns: new[] { "Decal_Manufacturer", "ID" },
                unique: true,
                filter: "[Decal_Manufacturer] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DecalsByName",
                table: "StashBase",
                columns: new[] { "Decal_Name", "Scale", "ID" },
                unique: true,
                filter: "[Decal_Name] IS NOT NULL AND [Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DecalsByType",
                table: "StashBase",
                columns: new[] { "Decal_Type", "Scale", "ID" },
                unique: true,
                filter: "[Decal_Type] IS NOT NULL AND [Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DecalsByScale",
                table: "StashBase",
                columns: new[] { "Scale", "Decal_Type", "Decal_Manufacturer", "ID" },
                unique: true,
                filter: "[Scale] IS NOT NULL AND [Decal_Type] IS NOT NULL AND [Decal_Manufacturer] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DecalsByDesignation",
                table: "StashBase",
                columns: new[] { "Decal_Type", "Designation", "Scale", "ID" },
                unique: true,
                filter: "[Decal_Type] IS NOT NULL AND [Designation] IS NOT NULL AND [Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSetsByManufacturer",
                table: "StashBase",
                columns: new[] { "DetailSet_Manufacturer", "ID" },
                unique: true,
                filter: "[DetailSet_Manufacturer] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSetsByName",
                table: "StashBase",
                columns: new[] { "DetailSet_Name", "DetailSet_Scale", "ID" },
                unique: true,
                filter: "[DetailSet_Name] IS NOT NULL AND [DetailSet_Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSetsByType",
                table: "StashBase",
                columns: new[] { "DetailSet_Type", "DetailSet_Scale", "ID" },
                unique: true,
                filter: "[DetailSet_Type] IS NOT NULL AND [DetailSet_Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSetsByScale",
                table: "StashBase",
                columns: new[] { "DetailSet_Scale", "DetailSet_Type", "DetailSet_Manufacturer", "ID" },
                unique: true,
                filter: "[DetailSet_Scale] IS NOT NULL AND [DetailSet_Type] IS NOT NULL AND [DetailSet_Manufacturer] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSetsByDesignation",
                table: "StashBase",
                columns: new[] { "DetailSet_Type", "DetailSet_Designation", "DetailSet_Scale", "ID" },
                unique: true,
                filter: "[DetailSet_Type] IS NOT NULL AND [DetailSet_Designation] IS NOT NULL AND [DetailSet_Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodesBySubject",
                table: "StashBase",
                columns: new[] { "Episode_Subject", "ID" },
                unique: true,
                filter: "[Episode_Subject] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodesBySeries",
                table: "StashBase",
                columns: new[] { "Episode_Series", "Number", "ID" },
                unique: true,
                filter: "[Episode_Series] IS NOT NULL AND [Number] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodesByFormat",
                table: "StashBase",
                columns: new[] { "Episode_MediaFormat", "Episode_Series", "Number", "ID" },
                unique: true,
                filter: "[Episode_MediaFormat] IS NOT NULL AND [Episode_Series] IS NOT NULL AND [Number] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StashBase_DecalID",
                table: "StashBase",
                column: "DecalID");

            migrationBuilder.CreateIndex(
                name: "IX_StashBase_DetailSetID",
                table: "StashBase",
                column: "DetailSetID");

            migrationBuilder.CreateIndex(
                name: "IX_KitsByManufacturer",
                table: "StashBase",
                columns: new[] { "Kit_Manufacturer", "ID" },
                unique: true,
                filter: "[Kit_Manufacturer] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KitsByName",
                table: "StashBase",
                columns: new[] { "Kit_Name", "Kit_Scale", "ID" },
                unique: true,
                filter: "[Kit_Name] IS NOT NULL AND [Kit_Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KitsByType",
                table: "StashBase",
                columns: new[] { "Kit_Type", "Kit_Scale", "ID" },
                unique: true,
                filter: "[Kit_Type] IS NOT NULL AND [Kit_Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KitsByNationServiceEra",
                table: "StashBase",
                columns: new[] { "Kit_Nation", "Service", "Era", "ID" },
                unique: true,
                filter: "[Kit_Nation] IS NOT NULL AND [Service] IS NOT NULL AND [Era] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KitsByScale",
                table: "StashBase",
                columns: new[] { "Kit_Scale", "Kit_Type", "Kit_Manufacturer", "ID" },
                unique: true,
                filter: "[Kit_Scale] IS NOT NULL AND [Kit_Type] IS NOT NULL AND [Kit_Manufacturer] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KitsByDesignation",
                table: "StashBase",
                columns: new[] { "Kit_Type", "Kit_Designation", "Kit_Scale", "ID" },
                unique: true,
                filter: "[Kit_Type] IS NOT NULL AND [Kit_Designation] IS NOT NULL AND [Kit_Scale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesBySort",
                table: "StashBase",
                columns: new[] { "Movie_AlphaSort", "Movie_MediaFormat", "ID" },
                unique: true,
                filter: "[Movie_AlphaSort] IS NOT NULL AND [Movie_MediaFormat] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesByFormat",
                table: "StashBase",
                columns: new[] { "Movie_MediaFormat", "Movie_AlphaSort", "ID" },
                unique: true,
                filter: "[Movie_MediaFormat] IS NOT NULL AND [Movie_AlphaSort] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesBySubject",
                table: "StashBase",
                columns: new[] { "Movie_Subject", "Movie_Title", "ID" },
                unique: true,
                filter: "[Movie_Subject] IS NOT NULL AND [Movie_Title] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesByTitle",
                table: "StashBase",
                columns: new[] { "Movie_Title", "Movie_MediaFormat", "ID" },
                unique: true,
                filter: "[Movie_Title] IS NOT NULL AND [Movie_MediaFormat] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MusicByAlphaSort",
                table: "StashBase",
                columns: new[] { "Music_AlphaSort", "ID" },
                unique: true,
                filter: "[Music_AlphaSort] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MusicByArtist",
                table: "StashBase",
                columns: new[] { "Artist", "Year", "Music_MediaFormat", "ID" },
                unique: true,
                filter: "[Artist] IS NOT NULL AND [Year] IS NOT NULL AND [Music_MediaFormat] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MusicByFormat",
                table: "StashBase",
                columns: new[] { "Music_MediaFormat", "Artist", "Year", "ID" },
                unique: true,
                filter: "[Music_MediaFormat] IS NOT NULL AND [Artist] IS NOT NULL AND [Year] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MusicByType",
                table: "StashBase",
                columns: new[] { "Music_Type", "Artist", "Year", "Music_MediaFormat", "ID" },
                unique: true,
                filter: "[Music_Type] IS NOT NULL AND [Artist] IS NOT NULL AND [Year] IS NOT NULL AND [Music_MediaFormat] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareByAlphaSort",
                table: "StashBase",
                columns: new[] { "Software_AlphaSort", "ID" },
                unique: true,
                filter: "[Software_AlphaSort] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareByPlatform",
                table: "StashBase",
                columns: new[] { "Platform", "Software_AlphaSort", "ID" },
                unique: true,
                filter: "[Platform] IS NOT NULL AND [Software_AlphaSort] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareByType",
                table: "StashBase",
                columns: new[] { "Software_Type", "Software_AlphaSort", "ID" },
                unique: true,
                filter: "[Software_Type] IS NOT NULL AND [Software_AlphaSort] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialsBySort",
                table: "StashBase",
                columns: new[] { "Special_AlphaSort", "Special_MediaFormat", "ID" },
                unique: true,
                filter: "[Special_AlphaSort] IS NOT NULL AND [Special_MediaFormat] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialsByFormat",
                table: "StashBase",
                columns: new[] { "Special_MediaFormat", "Special_AlphaSort", "ID" },
                unique: true,
                filter: "[Special_MediaFormat] IS NOT NULL AND [Special_AlphaSort] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialsBySubject",
                table: "StashBase",
                columns: new[] { "Special_Subject", "Special_Title", "ID" },
                unique: true,
                filter: "[Special_Subject] IS NOT NULL AND [Special_Title] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialsByTitle",
                table: "StashBase",
                columns: new[] { "Special_Title", "Special_MediaFormat", "ID" },
                unique: true,
                filter: "[Special_Title] IS NOT NULL AND [Special_MediaFormat] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StashBase_LocationID",
                table: "StashBase",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_StashImages_ImageID",
                table: "StashImages",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationRuleMessage_HistoryID",
                table: "ValidationRuleMessage",
                column: "HistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationRuleMessage_ImageID",
                table: "ValidationRuleMessage",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationRuleMessage_LocationID",
                table: "ValidationRuleMessage",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationRuleMessage_QueryID",
                table: "ValidationRuleMessage",
                column: "QueryID");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationRuleMessage_ReferenceBaseID",
                table: "ValidationRuleMessage",
                column: "ReferenceBaseID");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationRuleMessage_StashBaseID",
                table: "ValidationRuleMessage",
                column: "StashBaseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReferenceImages");

            migrationBuilder.DropTable(
                name: "StashImages");

            migrationBuilder.DropTable(
                name: "ValidationRuleMessage");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Query");

            migrationBuilder.DropTable(
                name: "ReferenceBase");

            migrationBuilder.DropTable(
                name: "StashBase");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
