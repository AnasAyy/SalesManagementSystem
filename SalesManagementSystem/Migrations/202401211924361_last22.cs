namespace SalesManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class last22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FinancialBonds", "TestId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FinancialBonds", "TestId");
        }
    }
}
