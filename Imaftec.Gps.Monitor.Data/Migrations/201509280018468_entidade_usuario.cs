namespace Imaftec.Gps.Monitor.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entidade_usuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dispositivo",
                c => new
                    {
                        DispositivoId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DispositivoId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .ForeignKey("dbo.Localizacao", t => t.DispositivoId)
                .Index(t => t.DispositivoId)
                .Index(t => t.UsuarioId);
            
            AddColumn("dbo.Localizacao", "DispositivoId", c => c.String(maxLength: 100, unicode: false));
            DropColumn("dbo.Localizacao", "Imei");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Localizacao", "Imei", c => c.String(nullable: false, maxLength: 20, unicode: false));
            DropForeignKey("dbo.Dispositivo", "DispositivoId", "dbo.Localizacao");
            DropForeignKey("dbo.Dispositivo", "UsuarioId", "dbo.Usuario");
            DropIndex("dbo.Dispositivo", new[] { "UsuarioId" });
            DropIndex("dbo.Dispositivo", new[] { "DispositivoId" });
            DropColumn("dbo.Localizacao", "DispositivoId");
            DropTable("dbo.Dispositivo");
        }
    }
}
