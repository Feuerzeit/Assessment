using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEC6.Blog.Yan.Domain.Entities
{
    public sealed class Autor
    {
        public Guid AutorId { get; set; }
        public string Nome { get; set; }
        public string Pseudonimo { get; set; }
    }
}
