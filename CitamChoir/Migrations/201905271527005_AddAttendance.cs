namespace CitamChoir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        AttendanceId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        OtherName = c.String(nullable: false, maxLength: 50),
                        DateTime = c.String(nullable: false),
                        Remarks = c.String(nullable: false, maxLength: 250),
                        Attended = c.Boolean(nullable: false),
                        LeaderId = c.Byte(nullable: false),
                        VoiceId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.AttendanceId)
                .ForeignKey("dbo.Leaders", t => t.LeaderId, cascadeDelete: true)
                .ForeignKey("dbo.Voices", t => t.VoiceId, cascadeDelete: true)
                .Index(t => t.LeaderId)
                .Index(t => t.VoiceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "VoiceId", "dbo.Voices");
            DropForeignKey("dbo.Attendances", "LeaderId", "dbo.Leaders");
            DropIndex("dbo.Attendances", new[] { "VoiceId" });
            DropIndex("dbo.Attendances", new[] { "LeaderId" });
            DropTable("dbo.Attendances");
        }
    }
}
