namespace Migraciones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.PersonaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personas");
        }
    }
}
