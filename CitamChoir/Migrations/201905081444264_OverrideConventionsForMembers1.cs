namespace CitamChoir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForMembers1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "Leader_Id", c => c.Byte());
            CreateIndex("dbo.Members", "Leader_Id");
            AddForeignKey("dbo.Members", "Leader_Id", "dbo.Leaders", "Id");
            DropColumn("dbo.Members", "Leader");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "Leader", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Members", "Leader_Id", "dbo.Leaders");
            DropIndex("dbo.Members", new[] { "Leader_Id" });
            DropColumn("dbo.Members", "Leader_Id");
        }
    }
}
