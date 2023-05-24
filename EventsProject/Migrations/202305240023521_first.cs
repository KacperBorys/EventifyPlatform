namespace EventsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Accounts", "PersonId", "dbo.People");
            DropIndex("dbo.Accounts", new[] { "PersonId" });
            DropTable("dbo.Accounts");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.accountID);
            
            CreateIndex("dbo.Accounts", "PersonId");
            AddForeignKey("dbo.Accounts", "PersonId", "dbo.People", "Id");
        }
    }
}
