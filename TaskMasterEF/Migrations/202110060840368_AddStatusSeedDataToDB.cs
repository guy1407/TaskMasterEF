namespace TaskMasterEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusSeedDataToDB : DbMigration
    {
        public override void Up()
        {

         Sql("INSERT INTO Status (Name) VALUES ('To Do');");
         Sql("INSERT INTO Status (Name) VALUES ('IN Progress');");
         Sql("INSERT INTO Status (Name) VALUES ('Done');");

      }
        
        public override void Down()
        {
         Sql("TRUNCATE TABLE Status;");
      }
    }
}
