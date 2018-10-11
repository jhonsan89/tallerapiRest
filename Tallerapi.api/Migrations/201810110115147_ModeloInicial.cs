namespace Tallerapi.api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publicacion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false, maxLength: 50),
                        Descripccion = c.String(nullable: false, maxLength: 250),
                        FechaPublicaion = c.DateTime(nullable: false),
                        MeGusta = c.Int(nullable: false),
                        MeDisgusta = c.Int(nullable: false),
                        VecesCompartido = c.Int(nullable: false),
                        EsPrivada = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Publicacion");
        }
    }
}
