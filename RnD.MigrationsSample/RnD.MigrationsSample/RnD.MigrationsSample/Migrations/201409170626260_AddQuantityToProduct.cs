namespace RnD.MigrationsSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuantityToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Quantity");
        }
    }
}
