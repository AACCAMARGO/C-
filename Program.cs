using System.IO.Compression;

namespace PTI2;

class Program
{
    static void Main(string[] args)
    {
       Estoque estoque = new Estoque();

    int menu = 0;
    do{
        Console.WriteLine("\n## Estoque Mercado ##\n");
        Console.WriteLine("O que deseja realizar?\n");
        Console.WriteLine("[1] Cadastrar Produto");
        Console.WriteLine("[2] Listar Produtos");
        Console.WriteLine("[3] Remover Produto");
        Console.WriteLine("[4] Entrada de Estoque");
        Console.WriteLine("[5] Saída de Estoque");
        Console.WriteLine("[0] Sair\n");
        menu = Convert.ToInt32(Console.ReadLine());

        if (menu == 1 )
        {
            Produto novoProduto = new Produto();

            Console.WriteLine("\nDigite o nome do produto:");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine("\nPreço: ");
            novoProduto.Preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nQuantidade: ");
            novoProduto.estoque = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nMarca: ");
            novoProduto.Marca = Console.ReadLine();

            Console.WriteLine("\nCategoria: ");
            novoProduto.Cat = Console.ReadLine();

            Console.WriteLine("\nCor: ");
            novoProduto.Cor = Console.ReadLine();

            estoque.Adicionar(novoProduto);


        }
        else if (menu == 2 )
        {
            estoque.Listar();   
        }
        else if (menu == 3 )
        {
            Console.WriteLine("\nItens no Estoque: ");
            estoque.Listar();    

            Console.WriteLine("\nDigite o produto que deseja remover: ");
            int indiceProduto = Convert.ToInt32(Console.ReadLine());

            estoque.Remover(indiceProduto);
            Console.WriteLine("\nEstoque Atualizado: " );
            estoque.Listar(); 

        }
        else if (menu == 4 )
        {
            Console.WriteLine("\nItens no Estoque: ");
            estoque.Listar();

            Console.WriteLine("\nPosição do Produto: ");
            int pos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nQuantidade de Entrada: ");
            int qtd = Convert.ToInt32(Console.ReadLine());

            estoque.Entrada(pos, qtd);

        }
        else if (menu == 5 )
        {   
            Console.WriteLine("\nItens no Estoque: ");
            estoque.Listar();

            Console.WriteLine("\nPosição do Produto: ");
            int pos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nQuantidade de Saída: ");
            int qtd = Convert.ToInt32(Console.ReadLine());
            
            estoque.Saida(pos, qtd);

        }
    }
    while (menu !=0);

       


    }
}
