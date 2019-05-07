namespace CitamChoir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateChoirMemberTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        OtherNames = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 10),
                        Email = c.String(nullable: false, maxLength: 100),
                        Phone = c.String(nullable: false, maxLength: 20),
                        InductionDate = c.DateTime(nullable: false),
                        BGV = c.Boolean(nullable: false),
                        WorshipLeader = c.Boolean(nullable: false),
                        Leader = c.Boolean(nullable: false),
                        Occupation_Id = c.Int(nullable: false),
                        VoiceLeader_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Occupations", t => t.Occupation_Id, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.VoiceLeader_Id, cascadeDelete: true)
                .Index(t => t.Occupation_Id)
                .Index(t => t.VoiceLeader_Id);
            
            CreateTable(
                "dbo.Occupations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "VoiceLeader_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Members", "Occupation_Id", "dbo.Occupations");
            DropIndex("dbo.Members", new[] { "VoiceLeader_Id" });
            DropIndex("dbo.Members", new[] { "Occupation_Id" });
            DropTable("dbo.Occupations");
            DropTable("dbo.Members");
        }
    }
}
