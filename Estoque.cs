using System.Runtime.InteropServices;

public class Estoque
{
    Produto[] produtos = new Produto[0];

    public void Adicionar(Produto produto)
    {
        Produto[] novoVetor = new Produto[produtos.Length + 1];
        for (int pos = 0; pos < produtos.Length;  pos++)
        {
            Produto item = produtos[pos];
            novoVetor[pos] = item;            
        }
        novoVetor[novoVetor.Length - 1] = produto;

        produtos = novoVetor;
    }
    public void Listar()
    {
        int cont = 1;
        foreach (Produto item in produtos)
        {
            Console.WriteLine($"{cont} - {item.Nome}, (R$ {item.Preco}), {item.estoque} unidade(s) no estoque");
            cont ++;
        }

    }
    public void Entrada(int pos, int qtd)
    {
        Produto produto = produtos[pos -1];
        produto.estoque += qtd;
    }
    public void Remover(int pos)
    
    {
        if (pos >= 1 && pos <= produtos.Length)
    {
           Produto[] novoVetor = new Produto[produtos.Length - 1];
        int novaPosicao = 0;

        for (int i = 0; i < produtos.Length; i++)
        {
            if (i != pos - 1)
            {
                novoVetor[novaPosicao] = produtos[i];
                novaPosicao++;
            }
        }
         produtos = novoVetor;
        Console.WriteLine("\nItem excluído com sucesso!!!");
    }
    else
    {
        Console.WriteLine("\nÍndice inválido! Por favor, tente novamente.");
    }
}
    public void Saida(int pos, int qtd)
    {
        int index = pos -1;

        if (index >= 0 && index < produtos.Length)
    {
        Produto produto = produtos[index];
        produto.estoque -= qtd;
        Console.WriteLine("\nSaída registrada com sucesso. \n");
    }
    else
    {
        Console.WriteLine("\nPosição inválida! Por favor, tente novamente.\n");
        }

    }

}