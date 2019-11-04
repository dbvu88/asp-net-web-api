namespace OnlineSociety.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Restricted = c.Boolean(nullable: false),
                        ClantId = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Clan_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clans", t => t.Clan_Id)
                .Index(t => t.Clan_Id);
            
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        Owner_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Owner_Id, cascadeDelete: true)
                .Index(t => t.Owner_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pets", "Owner_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Clan_Id", "dbo.Clans");
            DropIndex("dbo.Pets", new[] { "Owner_Id" });
            DropIndex("dbo.Users", new[] { "Clan_Id" });
            DropTable("dbo.Pets");
            DropTable("dbo.Users");
            DropTable("dbo.Clans");
        }
    }
}
