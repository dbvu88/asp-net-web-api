namespace OnlineSociety.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Clan_Id", "dbo.Clans");
            DropIndex("dbo.Users", new[] { "Clan_Id" });
            RenameColumn(table: "dbo.Users", name: "Clan_Id", newName: "ClanId");
            AlterColumn("dbo.Users", "ClanId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "ClanId");
            AddForeignKey("dbo.Users", "ClanId", "dbo.Clans", "Id", cascadeDelete: true);
            DropColumn("dbo.Users", "ClantId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "ClantId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Users", "ClanId", "dbo.Clans");
            DropIndex("dbo.Users", new[] { "ClanId" });
            AlterColumn("dbo.Users", "ClanId", c => c.Int());
            RenameColumn(table: "dbo.Users", name: "ClanId", newName: "Clan_Id");
            CreateIndex("dbo.Users", "Clan_Id");
            AddForeignKey("dbo.Users", "Clan_Id", "dbo.Clans", "Id");
        }
    }
}
