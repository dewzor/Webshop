namespace Webbshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderInfo2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Address", c => c.String(nullable: false, maxLength: 70));
            AddColumn("dbo.Orders", "Phone", c => c.String(nullable: false, maxLength: 24));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Phone");
            DropColumn("dbo.Orders", "Address");
        }
    }
}
