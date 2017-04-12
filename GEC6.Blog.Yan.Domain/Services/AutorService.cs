using GEC6.Blog.Yan.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEC6.Blog.Yan.Domain.Entities;
using GEC6.Blog.Yan.Domain.Interfaces.Repositories;

namespace GEC6.Blog.Yan.Domain.Services
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _autorRepository;

        public AutorService(IAutorRepository autorRepository)
        {
            this._autorRepository = autorRepository;
        }

        public void Adicionar(Autor autor)
        {
            this._autorRepository.Adicionar(autor);
        }

        public void Alterar(Autor autor)
        {
            this._autorRepository.Alterar(autor);
        }

        public Autor ObterPorId(Guid? id)
        {
            return this._autorRepository.ObterPorId(id);
        }

        public IEnumerable<Autor> ObterTodos()
        {
            return this._autorRepository.ObterTodos();
        }

        public void Remover(Autor autor)
        {
            this._autorRepository.Remover(autor);
        }

        public void Remover(Guid? id)
        {
            this._autorRepository.Remover(id);
        }
    }
}
