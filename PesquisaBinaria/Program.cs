int[] lista = new int[] { 1, 2, 6, 7, 9, 12, 16, 22, 27 };
int? posicao;

// Solicita ao usuário um valor para buscar no array
Console.Write("Digite o valor que deseja buscar no array: ");
posicao = PesquisaBinaria(lista, int.Parse(Console.ReadLine()));

// Exibe a posição do valor encontrado ou uma mensagem de valor não encontrado:
if (posicao != null) Console.WriteLine("Valor encontrado na posição: " + posicao);
else Console.WriteLine("Valor não encontrado.");

// Método de Pesquisa Binária:
static int? PesquisaBinaria(int[] lista, int item)
{
    int baixo = 0;
    int alto = lista.Length - 1;
    int meio, chute;

    while (baixo <= alto) // Enquanto os limites de busca são válidos
    {
        meio = (alto + baixo) / 2; // Encontra posição central
        chute = lista[meio];

        if (chute == item) return meio; // Chute igual a item == Valor encontrado
        else if (chute > item) alto = meio - 1; // Chute alto
        else baixo = meio + 1; // Chute baixo
    }

    return null; // retorna nulo caso o item não exista no array.
}