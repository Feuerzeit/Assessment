using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEC6.Blog.Yan.Domain.Entities
{
    public sealed class Comentario
    {
        public Guid ComentarioId { get; set; }
        public string Conteudo { get; set; }
        public Guid PostagemId { get; set; }
        public Guid UserId { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataDoComentario { get; set; }
    }
}
