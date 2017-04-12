using GEC6.Blog.Yan.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEC6.Blog.Yan.Infra.Data.Mappings
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("Autores");

            HasKey(a => a.AutorId);

            Property(a => a.Nome).IsRequired().HasMaxLength(250);

            Property(a => a.Pseudonimo).IsOptional().HasMaxLength(50);
        }
    }
}
