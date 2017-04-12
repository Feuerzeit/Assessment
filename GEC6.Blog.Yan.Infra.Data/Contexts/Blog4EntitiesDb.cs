using GEC6.Blog.Yan.Domain.Entities;
using GEC6.Blog.Yan.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEC6.Blog.Yan.Infra.Data.Contexts
{
    public class Blog4EntitiesDb : DbContext
    {
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // Conventions
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        //    modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

        //    // General Custom Context Properties
        //    modelBuilder.Properties()
        //        .Configure(p => p.HasDatabaseGeneratedOption
        //        (DatabaseGeneratedOption.None));

        //    modelBuilder.Properties<string>()
        //        .Configure(p => p.HasColumnType("varchar"));

        //    AddConfigMap(modelBuilder);

        //    base.OnModelCreating(modelBuilder);
        //}

        private void AddConfigMap(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PostagemMap());
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new ComentarioMap());
        }
    }
}
