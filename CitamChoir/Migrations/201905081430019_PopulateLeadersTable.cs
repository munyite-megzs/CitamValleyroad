namespace CitamChoir.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateLeadersTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Leaders(Id,Name) VALUES (1,'NONE')");
            Sql("INSERT INTO Leaders(Id,Name) VALUES (2,'BassLeader')");
            Sql("INSERT INTO Leaders(Id,Name) VALUES (3,'AltorLeader')");
            Sql("INSERT INTO Leaders(Id,Name) VALUES (4,'SopranoLeader')");
            Sql("INSERT INTO Leaders(Id,Name) VALUES (5,'TenorLeader')");
            Sql("INSERT INTO Leaders(Id,Name) VALUES (6,'BandLeader')");
            Sql("INSERT INTO Leaders(Id,Name) VALUES (7,'PrayerLeader')");
            Sql("INSERT INTO Leaders(Id,Name) VALUES (8,'Logistics')");
            Sql("INSERT INTO Leaders(Id,Name) VALUES (9,'HOD')");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM Voices WHERE Id IN (1,2,3,4,5,6,7,8,9)");
        }
    }
}
