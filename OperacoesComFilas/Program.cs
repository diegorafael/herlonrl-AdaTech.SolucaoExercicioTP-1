namespace OperacoesComFilas
{
    class Program
    {
        static void Main()
        {
            int numeroDeJogadores = 10; 
            SimularJogoBatataQuente(numeroDeJogadores);
        }

        static void SimularJogoBatataQuente(int numeroDeJogadores)
        {
            Queue<int> fila = new Queue<int>();

 
            for (int i = 1; i <= numeroDeJogadores; i++)
            {
                fila.Enqueue(i);
            }

            Random random = new Random();
            int passesAteExplodir = random.Next(1, 101);

            Console.WriteLine($"Número de jogadores: {numeroDeJogadores}");
            Console.WriteLine($"Passes até a batata explodir: {passesAteExplodir}");

            while (fila.Count > 1)
            {
                for (int i = 1; i < passesAteExplodir; i++)
                {
                    int jogadorAtual = fila.Dequeue();
                    fila.Enqueue(jogadorAtual); 
                }

                int jogadorEliminado = fila.Dequeue();
                Console.WriteLine($"Jogador {jogadorEliminado} foi eliminado!");

                
                passesAteExplodir = random.Next(1, 101);
                Console.WriteLine($"Passes até a batata explodir: {passesAteExplodir}");
            }

            int jogadorVencedor = fila.Dequeue();
            Console.WriteLine($"Jogador {jogadorVencedor} é o vencedor!");
        }
    }
}
