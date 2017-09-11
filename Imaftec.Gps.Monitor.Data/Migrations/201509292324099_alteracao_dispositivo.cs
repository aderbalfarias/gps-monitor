namespace Imaftec.Gps.Monitor.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteracao_dispositivo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Dispositivo", "Localizacao_LocalizacaoId", "dbo.Localizacao");
            DropIndex("dbo.Dispositivo", new[] { "Localizacao_LocalizacaoId" });
            DropColumn("dbo.Dispositivo", "Localizacao_LocalizacaoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dispositivo", "Localizacao_LocalizacaoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Dispositivo", "Localizacao_LocalizacaoId");
            AddForeignKey("dbo.Dispositivo", "Localizacao_LocalizacaoId", "dbo.Localizacao", "LocalizacaoId");
        }
    }
}
