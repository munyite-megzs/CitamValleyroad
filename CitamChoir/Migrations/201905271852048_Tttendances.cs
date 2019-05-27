namespace CitamChoir.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tttendances : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Attendances", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Attendances", "DateTime", c => c.String(nullable: false));
        }
    }
}
