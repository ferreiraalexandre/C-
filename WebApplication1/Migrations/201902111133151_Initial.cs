namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        ClientId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        State = c.String(),
                        City = c.String(),
                        Neighborhood = c.String(),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.ServiceProvided",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Type = c.String(),
                        ClientId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Provider",
                c => new
                    {
                        ProviderId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        State = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.ProviderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceProvided", "ClientId", "dbo.Client");
            DropIndex("dbo.ServiceProvided", new[] { "ClientId" });
            DropTable("dbo.Provider");
            DropTable("dbo.ServiceProvided");
            DropTable("dbo.Client");
        }
    }
}
