namespace EventsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "ImgSrc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "ImgSrc");
        }
    }
}
