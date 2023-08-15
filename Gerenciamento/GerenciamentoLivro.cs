using SGL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGL.Gerenciamento
{
    public class GerenciamentoLivro
    {

        public List<Livro> livros = new List<Livro>();
        public void AdicionarLivro()
        {
            Console.Write("Digite o Id do Livro:");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o Titulo do Livro:");
            var titulo = Console.ReadLine();
            Console.Write("Digite o Autor do Livro:");
            var autor = Console.ReadLine();
            Console.Write("Digite o Ano de Publicacao(dd/mm/aaaa do Livro:");
            var anoPublicacao = Convert.ToDateTime(Console.ReadLine());

            Livro livro = new Livro(id, titulo, autor, anoPublicacao);
            livros.Add(livro);
        }
        public void SelecionaLivro()
        {
            Console.WriteLine("Informe o id do livro:");
            var id = Convert.ToInt32(Console.ReadLine());
            Livro livro = new Livro();
            // livros = livros.Where(x => x.Id == id).FirstOrDefault();
            if (livros.Any())
            {
                foreach (Livro livr in livros)
                {
                    if (livr.Id == id)
                    {
                        Console.WriteLine($"\n" +
                            $"ID: {livr.Id.ToString()};\n" +
                            $"TITULO: {livr.Título.ToString()}\n" +
                            $"AUTOR: {livr.Autor.ToString()}\n" +
                            $"ANO DE PUBLICAÇÃO: {livr.AnoPublicacao.ToString()}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Não existem livros cadastrados!");
            }
           
            
        }
        public void AtualizarLivro()
        {
            DeletaLivro();
            Console.WriteLine("Atualize os dados:");
            AdicionarLivro();
            Console.WriteLine("Informações atualizadas!");
        }
        public void ListaLivros()
        {

            if (livros.Any())
            {
                for (int i = 0; i < livros.Count; i++)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine($"\n" +
                            $"ID: {livros[i].Id.ToString()};\n" +
                            $"TITULO: {livros[i].Título.ToString()}\n" +
                            $"AUTOR: {livros[i].Autor.ToString()}\n" +
                            $"ANO DE PUBLICAÇÃO: {livros[i].AnoPublicacao.ToString()}");
                    Console.WriteLine("-------------------------");
                }
            }
        }
        public void DeletaLivro()
        {
            Console.WriteLine("Informe o id do livro para deletar:");
            var id = Convert.ToInt32(Console.ReadLine());
            var livro = livros.FirstOrDefault(x=>x.Id == id);
            if (livro != null)
            {
                livros.Remove(livro);
                Console.WriteLine("Livro removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }
    }
}
