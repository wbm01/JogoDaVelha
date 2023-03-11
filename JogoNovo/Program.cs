internal class Program
{
    private static void Main(string[] args)
    {
        string[,] tabuleiro = new string[3, 3];
        string simbolo = "X";
        int rodadas = 0;
        string tabelaretorno;
        string jogada;
        List<string> numeros = new List<string> {"1", "2", "3", "4", "5", "6",
           "7", "8", "9"};
        bool verifica = false;

        void VerificaVitoria()
        {
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
                verifica = true;
            }
            if (rodadas > 7 && verifica == false)
            {
                Console.WriteLine("\nDeu velha, fim de jogo!");
                verifica = true;
            }
        }

        void TrocaSimbolo()
        {
            if (simbolo == "X")
            {
                simbolo = "O";
            }
            else
            {
                simbolo = "X";
            }
        }

        void Bemvindo()
        {
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(150);
                Console.Write("**BEM-VINDO AO JOGO DA VELHA**");
                Thread.Sleep(150);
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(150);
                Console.ForegroundColor = ConsoleColor.Gray;
                Thread.Sleep(150);
                Console.Clear();
            }
        }
        void Interacao()
        {
            Console.Clear();
            Console.WriteLine("Iniciando a partida...");
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("JOGO DA VELHA!");
            Console.Clear();
        }

        Bemvindo();
        Interacao();

        Console.WriteLine("PRIMEIRO JOGADOR: X | SEGUNDO JOGADOR: O");
        Console.WriteLine();

        //Alimentando tabuleiro
        int contador = 1;
            for (int l = 0; l < tabuleiro.GetLength(0); l++)
            {
                for (int c = 0; c < tabuleiro.GetLength(1); c++)
                {
                    tabuleiro[l, c] = contador.ToString();
                    numeros.Add(contador.ToString());
                    contador++;
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
        

        Console.Write("\nJogue {0} na posição desejada: ",simbolo);
        jogada = Console.ReadLine();
        Console.Clear();

        while (!numeros.Contains(jogada))
        {
            Console.Write("Jogada inválida, tente novamente: ");
            jogada = Console.ReadLine();
        }

        while (rodadas < 9)
        {
            while (!numeros.Contains(jogada))
            {
                Console.Write("Jogada inválida, tente novamente: ");
                jogada = Console.ReadLine();
            }
            Console.WriteLine("PRIMEIRO JOGADOR: X | SEGUNDO JOGADOR: O");
            Console.WriteLine();

            for (int l = 0; l < tabuleiro.GetLength(0); l++)
            {
                for (int c = 0; c < tabuleiro.GetLength(1); c++)
                {
                    if (tabuleiro[l, c] == jogada && numeros.Contains(jogada) && tabuleiro[l,c]!= "O")
                    {
                        tabuleiro[l, c] = simbolo;
                        numeros.Remove(jogada);
                        TrocaSimbolo();
                        
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

            VerificaVitoria();

            if(verifica == true)
            {
                break;
            }

            Console.Write("\nJogue {0} na posição desejada: ", simbolo);
            jogada = Console.ReadLine();

            rodadas++;

            VerificaVitoria();

            if (verifica == true)
            {
                break;
            }

            while (!numeros.Contains(jogada))
            {
                Console.Write("Jogada inválida, tente novamente: ");
                jogada = Console.ReadLine();
                rodadas--;
            }

            Console.Clear();
        }
    }
}
