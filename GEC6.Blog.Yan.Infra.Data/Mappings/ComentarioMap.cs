using GEC6.Blog.Yan.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEC6.Blog.Yan.Infra.Data.Mappings
{
    public class ComentarioMap : EntityTypeConfiguration<Comentario>
    {
        public ComentarioMap()
        {
            ToTable("Comentarios");

            HasKey(c => c.ComentarioId);

            Property(c => c.Conteudo).IsRequired().HasMaxLength(1000);

            Property(c => c.Ativo).IsRequired();

            Property(c => c.DataDoComentario).IsRequired();

            Property(c => c.UserId).IsRequired();
        }
    }
}
