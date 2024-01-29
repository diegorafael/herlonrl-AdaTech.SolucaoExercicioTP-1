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


            while (fila.Count > 1)
            {
                int passesAteExplodir = random.Next(1, 101);
                Console.WriteLine($"Número de jogadores: {fila.Count}");
                Console.WriteLine($"Passes até a batata explodir: {passesAteExplodir}");

                // Pelo nome da variável, o número sorteado estaria contido nos limites.
                // Ex.: Com 10 jogadores, o número sorteado foi 8. Na implementação anterior o jogador nº 8 sairia do jogo
                //    mas a batata durou somente 7 passes, explodindo no 8. Após a mudança na lógica, a batata explode após o 8º passe
                for (int i = 1; i <= passesAteExplodir; i++)
                {
                    int jogadorAtual = fila.Dequeue();
                    fila.Enqueue(jogadorAtual); 
                }

                int jogadorEliminado = fila.Dequeue();
                Console.WriteLine($"Jogador {jogadorEliminado} foi eliminado!");
            }

            int jogadorVencedor = fila.Dequeue();
            Console.WriteLine($"Jogador {jogadorVencedor} é o vencedor!");
        }
    }
}
