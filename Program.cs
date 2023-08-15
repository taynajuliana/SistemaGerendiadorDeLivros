

using SGL.Gerenciamento;
using SGL.Models;

GerenciamentoLivro gl = new GerenciamentoLivro();


while (true)
{
    Console.WriteLine("GERENCIAMENTO DE LIVROS\n ");
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("\n " +
        "1 - Adicionar Livro;\n " +
        "2 - Selecionar Livro;\n " +
        "3 - Listar Livros;\n " +
        "4 - Atualizar Livros;\n " +
        "5 - Deletar Livro \n ");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            gl.AdicionarLivro();
            break;
        case "2":
            gl.SelecionaLivro();
            break;
        case "3":
            gl.ListaLivros();
            break;
        case "4":
            gl.AtualizarLivro();
            break;
        case "5":
            gl.DeletaLivro();
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }
}

