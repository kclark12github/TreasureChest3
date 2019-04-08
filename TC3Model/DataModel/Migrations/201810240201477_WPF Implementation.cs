namespace TC3Model.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WPFImplementation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "WishList", c => c.Boolean());
            AlterColumn("dbo.Collectables", "WishList", c => c.Boolean());
            AlterColumn("dbo.Decals", "WishList", c => c.Boolean());
            AlterColumn("dbo.Kits", "WishList", c => c.Boolean());
            AlterColumn("dbo.DetailSets", "WishList", c => c.Boolean());
            AlterColumn("dbo.Episodes", "WishList", c => c.Boolean());
            AlterColumn("dbo.FinishingProducts", "WishList", c => c.Boolean());
            AlterColumn("dbo.Movies", "WishList", c => c.Boolean());
            AlterColumn("dbo.Music", "WishList", c => c.Boolean());
            AlterColumn("dbo.Rockets", "WishList", c => c.Boolean());
            AlterColumn("dbo.Software", "WishList", c => c.Boolean());
            AlterColumn("dbo.Specials", "WishList", c => c.Boolean());
            AlterColumn("dbo.Tools", "WishList", c => c.Boolean());
            AlterColumn("dbo.Trains", "WishList", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trains", "WishList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Tools", "WishList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Specials", "WishList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Software", "WishList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Rockets", "WishList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Music", "WishList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Movies", "WishList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FinishingProducts", "WishList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Episodes", "WishList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.DetailSets", "WishList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Kits", "WishList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Decals", "WishList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Collectables", "WishList", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Books", "WishList", c => c.Boolean(nullable: false));
        }
    }
}
