namespace EventsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        accountID = c.Int(nullable: false, identity: true),
                        login = c.String(),
                        password = c.String(),
                        PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.accountID)
                .ForeignKey("dbo.People", t => t.PersonId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        rate = c.Int(nullable: false),
                        text = c.String(),
                        PersonId = c.Int(),
                        EventId = c.Int(),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Events", t => t.EventId)
                .ForeignKey("dbo.People", t => t.PersonId)
                .Index(t => t.PersonId)
                .Index(t => t.EventId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        EventDate = c.DateTime(nullable: false),
                        EventPlace = c.String(),
                        EventDescription = c.String(),
                        EventPriceNormal = c.Double(nullable: false),
                        EventPriceReduced = c.Double(nullable: false),
                        EventCategory = c.Int(nullable: false),
                        EventAvailableSeats = c.Int(nullable: false),
                        EventStartTime = c.Time(nullable: false, precision: 7),
                        EventTargetAudience = c.Int(nullable: false),
                        ImgSrc = c.String(),
                        LocalizationId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Localizations", t => t.LocalizationId)
                .Index(t => t.LocalizationId);
            
            CreateTable(
                "dbo.Localizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        Town = c.String(),
                        Street = c.String(),
                        IsInside = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsNormal = c.Boolean(nullable: false),
                        WhenBought = c.DateTime(nullable: false),
                        PersonId = c.Int(),
                        EventId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId)
                .ForeignKey("dbo.People", t => t.PersonId)
                .Index(t => t.PersonId)
                .Index(t => t.EventId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "PersonId", "dbo.People");
            DropForeignKey("dbo.Tickets", "EventId", "dbo.Events");
            DropForeignKey("dbo.Accounts", "PersonId", "dbo.People");
            DropForeignKey("dbo.Reviews", "PersonId", "dbo.People");
            DropForeignKey("dbo.Reviews", "EventId", "dbo.Events");
            DropForeignKey("dbo.Events", "LocalizationId", "dbo.Localizations");
            DropIndex("dbo.Tickets", new[] { "EventId" });
            DropIndex("dbo.Tickets", new[] { "PersonId" });
            DropIndex("dbo.Events", new[] { "LocalizationId" });
            DropIndex("dbo.Reviews", new[] { "EventId" });
            DropIndex("dbo.Reviews", new[] { "PersonId" });
            DropIndex("dbo.Accounts", new[] { "PersonId" });
            DropTable("dbo.Tickets");
            DropTable("dbo.Localizations");
            DropTable("dbo.Events");
            DropTable("dbo.Reviews");
            DropTable("dbo.People");
            DropTable("dbo.Accounts");
        }
    }
}
