namespace mvc29jully.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addvalidation1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Qualification", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Status", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Status", c => c.String());
            AlterColumn("dbo.Students", "Qualification", c => c.String());
            AlterColumn("dbo.Students", "Email", c => c.String());
        }
    }
}
