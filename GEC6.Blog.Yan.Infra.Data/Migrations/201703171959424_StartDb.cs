namespace GEC6.Blog.Yan.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autores",
                c => new
                    {
                        AutorId = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        Pseudonimo = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.AutorId);
            
            CreateTable(
                "dbo.Comentarios",
                c => new
                    {
                        ComentarioId = c.Guid(nullable: false),
                        Conteudo = c.String(nullable: false, maxLength: 1000, unicode: false),
                        PostagemId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataDoComentario = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ComentarioId);
            
            CreateTable(
                "dbo.Postagens",
                c => new
                    {
                        PostagemId = c.Guid(nullable: false),
                        Titulo = c.String(maxLength: 8000, unicode: false),
                        Conteudo = c.String(nullable: false, maxLength: 8000, unicode: false),
                        TituloURL = c.String(maxLength: 8000, unicode: false),
                        DataDePublicacao = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        ComentariosAtivos = c.Boolean(nullable: false),
                        TotalDeVisualizacoes = c.Int(nullable: false),
                        Tags = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.PostagemId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Postagens");
            DropTable("dbo.Comentarios");
            DropTable("dbo.Autores");
        }
    }
}
