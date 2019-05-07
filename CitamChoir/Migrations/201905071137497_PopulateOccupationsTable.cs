namespace CitamChoir.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateOccupationsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Occupations(Name) VALUES ('Medical')");
            Sql("INSERT INTO Occupations(Name) VALUES ('SelfEmployed')");
            Sql("INSERT INTO Occupations(Name) VALUES ('Cooporate')");
            Sql("INSERT INTO Occupations(Name) VALUES ('NGO')");
            Sql("INSERT INTO Occupations(Name) VALUES ('Community Based')");
            Sql("INSERT INTO Occupations(Name) VALUES ('Teacher/Lecturer')");
            Sql("INSERT INTO Occupations(Name) VALUES ('None')");
            Sql("INSERT INTO Occupations(Name) VALUES ('Finance Institution')");
            Sql("INSERT INTO Occupations(Name) VALUES ('Civil Servant')");
            Sql("INSERT INTO Occupations(Name) VALUES ('Student')");
            Sql("INSERT INTO Occupations(Name) VALUES ('Media')");
            Sql("INSERT INTO Occupations(Name) VALUES ('Legal')");
            Sql("INSERT INTO Occupations(Name) VALUES ('Hospitality/Tourism')");
            Sql("INSERT INTO Occupations(Name) VALUES ('Insuarance')");
            Sql("INSERT INTO Occupations(Name) VALUES ('International Organization')");
            Sql("INSERT INTO Occupations(Name) VALUES ('ICT/Telecommunications')");
            Sql("INSERT INTO Occupations(Name) VALUES ('Other')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Occupations WHERE Id IN (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17)");
        }
    }
}
