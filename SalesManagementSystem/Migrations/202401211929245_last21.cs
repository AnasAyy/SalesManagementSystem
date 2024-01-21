namespace SalesManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class last21 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.FinancialBonds", "TestId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FinancialBonds", "TestId", c => c.Int(nullable: false));
        }
    }
}
