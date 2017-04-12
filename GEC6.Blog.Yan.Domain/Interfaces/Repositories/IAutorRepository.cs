using GEC6.Blog.Yan.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEC6.Blog.Yan.Domain.Interfaces.Repositories
{
    public interface IAutorRepository
    {
        IEnumerable<Autor> ObterTodos();

        Autor ObterPorId(Guid? id);

        void Adicionar(Autor autor);

        void Alterar(Autor autor);

        void Remover(Autor autor);

        void Remover(Guid? id);
    }

}
