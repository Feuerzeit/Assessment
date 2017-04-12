using GEC6.Blog.Yan.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEC6.Blog.Yan.Domain.Entities;
using GEC6.Blog.Yan.Infra.Data.Contexts;
using System.Data.Entity;

namespace GEC6.Blog.Yan.Infra.Data.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private Blog4EntitiesDb db = new Blog4EntitiesDb();

        public void Adicionar(Autor autor)
        {
            autor.AutorId = Guid.NewGuid();
            db.Autores.Add(autor);
            db.SaveChanges();
        }

        public void Alterar(Autor autor)
        {
            db.Entry(autor).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Autor ObterPorId(Guid? id)
        {
            return db.Autores.Find(id);
        }

        public IEnumerable<Autor> ObterTodos()
        {
            return db.Autores.ToList();
        }

        public void Remover(Autor autor)
        {
            db.Autores.Remove(autor);
            db.SaveChanges();
        }

        public void Remover(Guid? id)
        {
            Autor autor = db.Autores.Find(id);
            if (autor != null)
            {
                db.Autores.Remove(autor);
                db.SaveChanges();
            }
        }
    }
}
