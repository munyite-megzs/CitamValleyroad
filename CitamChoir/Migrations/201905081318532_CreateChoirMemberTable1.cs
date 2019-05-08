namespace CitamChoir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateChoirMemberTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "Voice_Id", c => c.Byte());
            CreateIndex("dbo.Members", "Voice_Id");
            AddForeignKey("dbo.Members", "Voice_Id", "dbo.Voices", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Voice_Id", "dbo.Voices");
            DropIndex("dbo.Members", new[] { "Voice_Id" });
            DropColumn("dbo.Members", "Voice_Id");
        }
    }
}
