using System;
using System.Linq;

internal class Program
{
    static int[] arrayEntradaCenario1 = new int[] { 3, 2, 1, 6, 0, 5 };
    static int[] arrayEntradaCenario2 = new int[] { 7, 5, 13, 9, 1, 6, 4 };

    public static void Main()
    {
        int posicaoRaiz = 0;
        for (int i = 0; i <= arrayEntradaCenario2.Length - 1; i++)
        {
            if (arrayEntradaCenario2[i] > arrayEntradaCenario2[posicaoRaiz])
            {
                posicaoRaiz = i;
            }
        }

        var arrEsq = BuscarValoresAEsquerda(posicaoRaiz);
        var arrDir = BuscarValoresADireita(posicaoRaiz);

        Console.WriteLine("Raiz: " + arrayEntradaCenario2[posicaoRaiz]);

        for (int i = 0; i <= arrayEntradaCenario2.Length - 1; i++)
        {
            if (arrEsq.Length > i)
            {
                Console.Write("Valor a esquerda da raiz: ");
                Console.WriteLine(arrEsq[i]);
            }

            if (arrDir.Length > i)
            {
                Console.Write("Valor a direita da raiz: ");
                Console.WriteLine(arrDir[i]);
            }
        }
    }
    private static int[] BuscarValoresAEsquerda(int posicaoRaiz)
    {
        int[]? abc = arrayEntradaCenario2.Take(posicaoRaiz).ToArray();
        abc = abc.OrderByDescending(c => c).ToArray();
        return abc;
    }

    private static int[] BuscarValoresADireita(int posicaoRaiz)
    {
        int[]? abc = arrayEntradaCenario2.TakeLast(arrayEntradaCenario2.Length - posicaoRaiz - 1).ToArray();
        abc = abc.OrderByDescending(c => c).ToArray();
        return abc;
    }
}