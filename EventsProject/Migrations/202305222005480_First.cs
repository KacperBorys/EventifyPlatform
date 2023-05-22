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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "PersonId", "dbo.People");
            DropIndex("dbo.Accounts", new[] { "PersonId" });
            DropTable("dbo.Accounts");
        }
    }
}
