namespace CitamChoir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToMember : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "Leader_Id", "dbo.Leaders");
            DropIndex("dbo.Members", new[] { "Leader_Id" });
            RenameColumn(table: "dbo.Members", name: "Leader_Id", newName: "LeaderId");
            RenameColumn(table: "dbo.Members", name: "Occupation_Id", newName: "OccupationId");
            RenameColumn(table: "dbo.Members", name: "Voice_Id", newName: "VoiceId");
            RenameColumn(table: "dbo.Members", name: "VoiceLeader_Id", newName: "VoiceLeaderId");
            RenameIndex(table: "dbo.Members", name: "IX_VoiceLeader_Id", newName: "IX_VoiceLeaderId");
            RenameIndex(table: "dbo.Members", name: "IX_Occupation_Id", newName: "IX_OccupationId");
            RenameIndex(table: "dbo.Members", name: "IX_Voice_Id", newName: "IX_VoiceId");
            AlterColumn("dbo.Members", "LeaderId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Members", "LeaderId");
            AddForeignKey("dbo.Members", "LeaderId", "dbo.Leaders", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "LeaderId", "dbo.Leaders");
            DropIndex("dbo.Members", new[] { "LeaderId" });
            AlterColumn("dbo.Members", "LeaderId", c => c.Byte());
            RenameIndex(table: "dbo.Members", name: "IX_VoiceId", newName: "IX_Voice_Id");
            RenameIndex(table: "dbo.Members", name: "IX_OccupationId", newName: "IX_Occupation_Id");
            RenameIndex(table: "dbo.Members", name: "IX_VoiceLeaderId", newName: "IX_VoiceLeader_Id");
            RenameColumn(table: "dbo.Members", name: "VoiceLeaderId", newName: "VoiceLeader_Id");
            RenameColumn(table: "dbo.Members", name: "VoiceId", newName: "Voice_Id");
            RenameColumn(table: "dbo.Members", name: "OccupationId", newName: "Occupation_Id");
            RenameColumn(table: "dbo.Members", name: "LeaderId", newName: "Leader_Id");
            CreateIndex("dbo.Members", "Leader_Id");
            AddForeignKey("dbo.Members", "Leader_Id", "dbo.Leaders", "Id");
        }
    }
}
