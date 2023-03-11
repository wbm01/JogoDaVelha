internal class Program
{
    private static void Main(string[] args)
    {
        char[,] tabuleiro = new char[3, 3];
        char simbolo = 'X';
        char simbolo2 = 'O';
        int rodadas = 0;
        string tabelaretorno;
        string nomejogador1, nomejogador2;
        string welcomeMessage = "BEM-VINDO AO JOGO DA VELHA!";
        Welcome();
        void Welcome()
        {
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(400);
                Console.Write(welcomeMessage);
                Thread.Sleep(400);
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(400);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(400);
                Console.Clear();
            }
        }
        {
            Console.Write("Jogador 'X': ");
            nomejogador1 = Console.ReadLine();
            Console.Clear();
            Console.Write("Jogador 'O': ");
            nomejogador2 = Console.ReadLine();
        }
        void UserFirstInterection()
        {
            Console.Clear();
            Console.WriteLine("Iniciando a partida...");
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("JOGO DA VELHA!");
            Console.Clear();
        }
        Console.WriteLine();
        tabelaretorno = DesenhoTabela();
        Console.WriteLine(tabelaretorno);
        string DesenhoTabela()
        {
            //Alimentando tabuleiro
            char contador = '1';
            for (int l = 0; l < tabuleiro.GetLength(0); l++)
            {
                for (int c = 0; c < tabuleiro.GetLength(1); c++)
                {
                    tabuleiro[l, c] = contador;
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
            int jogada = 0;
            if (rodadas % 2 == 0) 
            {

                
                do
                {
                    Console.Write("Escolha o número: ");
                    jogada = int.Parse(Console.ReadLine());
                }
                while (jogada <= 0 || jogada > 10);

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
            }
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
                break;
            }
        }
    }
}











        









