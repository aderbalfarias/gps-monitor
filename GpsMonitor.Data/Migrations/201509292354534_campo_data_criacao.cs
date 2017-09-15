namespace GpsMonitor.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class campo_data_criacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Localizacao", "Data", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Localizacao", "Data");
        }
    }
}
