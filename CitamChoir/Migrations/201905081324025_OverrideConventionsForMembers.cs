namespace CitamChoir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForMembers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "Voice_Id", "dbo.Voices");
            DropIndex("dbo.Members", new[] { "Voice_Id" });
            AlterColumn("dbo.Members", "Voice_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Members", "Voice_Id");
            AddForeignKey("dbo.Members", "Voice_Id", "dbo.Voices", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Voice_Id", "dbo.Voices");
            DropIndex("dbo.Members", new[] { "Voice_Id" });
            AlterColumn("dbo.Members", "Voice_Id", c => c.Byte());
            CreateIndex("dbo.Members", "Voice_Id");
            AddForeignKey("dbo.Members", "Voice_Id", "dbo.Voices", "Id");
        }
    }
}
