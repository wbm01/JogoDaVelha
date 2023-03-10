internal class Program
{
    private static void Main(string[] args)
    {
        string[,] tabuleiro = new string[3, 3];
        string simbolo = "X";
        string simbolo2 = "O";
        int rodadas = 0;
        string tabelaretorno;

        Console.WriteLine("JOGO DA VELHA");
        Console.WriteLine("\nPRIMEIRO JOGADOR: X | SEGUNDO JOGADOR: O");
        Console.WriteLine();

        tabelaretorno = DesenhoTabela();

        Console.WriteLine(tabelaretorno);

        string DesenhoTabela()
        {
            //Alimentando tabuleiro
            int contador = 1;
            for (int l = 0; l < tabuleiro.GetLength(0); l++)
            {
                for (int c = 0; c < tabuleiro.GetLength(1); c++)
                {
                    tabuleiro[l, c] = contador.ToString();
                    contador++;
                }

            }

            string tabela = "";
            for (int l = 0; l < tabuleiro.GetLength(0); l++)
            {
                for (int c = 0; c < tabuleiro.GetLength(1); c++)
                {
                    Console.Write(tabuleiro[l, c] + " ");
                }
                Console.WriteLine();
            }
            return tabela;
        }

        while (rodadas < 9)
        {
            if (rodadas % 2 == 0)
            {
                Console.Write("Escolha o número: ");
                //int jogada= int.Parse(Console.ReadLine());
                string jogada = Console.ReadLine();
                Console.WriteLine();


                    for (int l = 0; l < tabuleiro.GetLength(0); l++)
                    {
                        for (int c = 0; c < tabuleiro.GetLength(1); c++)
                        {
                            if (jogada == tabuleiro[l, c])
                            {
                                tabuleiro[l, c] = simbolo;
                            }
                        }
                    }
                    for (int l = 0; l < tabuleiro.GetLength(0); l++)
                    {

                        for (int c = 0; c < tabuleiro.GetLength(1); c++)
                        {
                            Console.Write(tabuleiro[l, c] + " ");
                        }
                        Console.WriteLine();
                    }
                    rodadas++;
                    Console.WriteLine();
            }
            else
            {
                Console.Write("Escolha o número: ");
                string jogada = Console.ReadLine();
                Console.WriteLine();

                    for (int l = 0; l < tabuleiro.GetLength(0); l++)
                    {
                        for (int c = 0; c < tabuleiro.GetLength(1); c++)
                        {
                            if (jogada == tabuleiro[l, c])
                            {
                                tabuleiro[l, c] = simbolo2;
                            }
                        }
                    }
                    for (int l = 0; l < tabuleiro.GetLength(0); l++)
                    {
                        for (int c = 0; c < tabuleiro.GetLength(1); c++)
                        {
                            Console.Write(tabuleiro[l, c] + " ");
                        }
                        Console.WriteLine();
                    }
                    rodadas++;
                    Console.WriteLine();

                if (tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[1, 0] ==
                tabuleiro[2, 0] || tabuleiro[0, 1] == tabuleiro[1, 1] &&
                tabuleiro[1, 1] == tabuleiro[2, 1] || tabuleiro[0, 2] == tabuleiro[1, 2] &&
                tabuleiro[1, 2] == tabuleiro[2, 2] || tabuleiro[0, 0] == tabuleiro[0, 1] &&
                tabuleiro[0, 1] == tabuleiro[0, 2] || tabuleiro[1, 0] == tabuleiro[1, 1] &&
                tabuleiro[1, 1] == tabuleiro[1, 2] || tabuleiro[2, 0] == tabuleiro[2, 1] &&
                tabuleiro[2, 1] == tabuleiro[2, 2] || tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] ==
                tabuleiro[2, 2] || tabuleiro[0, 2] == tabuleiro[1, 1] &&
                tabuleiro[1, 1] == tabuleiro[2, 0])
                {
                    Console.WriteLine();
                    Console.WriteLine("Fim de jogo!");
                    break;
                }
                if (rodadas == 8)
                {
                    Console.WriteLine("Deu velha, fim de jogo!");
                }
            }
        }
    }
}






