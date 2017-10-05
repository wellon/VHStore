namespace VHStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdateToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '01/01/1980' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
