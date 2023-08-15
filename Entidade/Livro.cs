using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGL.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Título { get; set; }
        public string Autor { get; set; }
        public DateTime AnoPublicacao { get; set; }

        public Livro() { }

        public Livro(int id, string título, string autor, DateTime anoPublicacao)
        {
            Id = id;
            Título = título;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
        }


    }
}
