namespace SalesManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class last24 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FinancialBonds", "ExpenseType", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FinancialBonds", "ExpenseType");
        }
    }
}
