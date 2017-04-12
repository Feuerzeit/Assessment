using GEC6.Blog.Yan.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEC6.Blog.Yan.Infra.Data.Mappings
{
    public class PostagemMap : EntityTypeConfiguration<Postagem>
    {
        public PostagemMap()
        {
            ToTable("Postagens");
            HasKey(p => p.PostagemId);
            Property(p => p.Conteudo).IsRequired().HasMaxLength(8000);
        }
    }
}
