namespace CitamChoir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedAttenansTabl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attendances", "LeaderId", "dbo.Leaders");
            DropForeignKey("dbo.Attendances", "VoiceId", "dbo.Voices");
            DropIndex("dbo.Attendances", new[] { "LeaderId" });
            DropIndex("dbo.Attendances", new[] { "VoiceId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Attendances", "VoiceId");
            CreateIndex("dbo.Attendances", "LeaderId");
            AddForeignKey("dbo.Attendances", "VoiceId", "dbo.Voices", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Attendances", "LeaderId", "dbo.Leaders", "Id", cascadeDelete: true);
        }
    }
}
