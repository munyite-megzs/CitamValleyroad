namespace CitamChoir.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateVoicesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Voices(Id,Name) VALUES (1,'Bass')");
            Sql("INSERT INTO Voices(Id,Name) VALUES (2,'Altor')");
            Sql("INSERT INTO Voices(Id,Name) VALUES (3,'Soprano')");
            Sql("INSERT INTO Voices(Id,Name) VALUES (4,'Tenor')");
            Sql("INSERT INTO Voices(Id,Name) VALUES (5,'Band')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Voices WHERE Id IN (1,2,3,4,5)");
        }
    }
}
