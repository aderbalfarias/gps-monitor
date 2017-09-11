namespace Imaftec.Gps.Monitor.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entidade_dispositivo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Dispositivo", "DispositivoId", "dbo.Localizacao");
            DropIndex("dbo.Dispositivo", new[] { "DispositivoId" });
            DropPrimaryKey("dbo.Dispositivo");
            AddColumn("dbo.Dispositivo", "Localizacao_LocalizacaoId", c => c.Int(nullable: false));
            AlterColumn("dbo.Dispositivo", "DispositivoId", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AddPrimaryKey("dbo.Dispositivo", "DispositivoId");
            CreateIndex("dbo.Dispositivo", "Localizacao_LocalizacaoId");
            AddForeignKey("dbo.Dispositivo", "Localizacao_LocalizacaoId", "dbo.Localizacao", "LocalizacaoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dispositivo", "Localizacao_LocalizacaoId", "dbo.Localizacao");
            DropIndex("dbo.Dispositivo", new[] { "Localizacao_LocalizacaoId" });
            DropPrimaryKey("dbo.Dispositivo");
            AlterColumn("dbo.Dispositivo", "DispositivoId", c => c.Int(nullable: false));
            DropColumn("dbo.Dispositivo", "Localizacao_LocalizacaoId");
            AddPrimaryKey("dbo.Dispositivo", "DispositivoId");
            CreateIndex("dbo.Dispositivo", "DispositivoId");
            AddForeignKey("dbo.Dispositivo", "DispositivoId", "dbo.Localizacao", "LocalizacaoId");
        }
    }
}
