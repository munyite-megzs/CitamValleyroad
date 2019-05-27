namespace CitamChoir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdtedTblAttenncesAddedPhonenumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendances", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attendances", "PhoneNumber");
        }
    }
}
