using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEC6.Blog.Yan.Domain.Entities
{
    public sealed class Postagem
    {
        public Guid PostagemId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string TituloURL { get; set; }
        public DateTime DataDePublicacao { get; set; }
        public bool Ativo { get; set; }
        public bool ComentariosAtivos { get; set; }
        public int TotalDeVisualizacoes { get; set; }
        public string Tags { get; set; }
    }
}
