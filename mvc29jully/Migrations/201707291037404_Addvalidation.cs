namespace mvc29jully.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addvalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Name", c => c.String());
        }
    }
}
