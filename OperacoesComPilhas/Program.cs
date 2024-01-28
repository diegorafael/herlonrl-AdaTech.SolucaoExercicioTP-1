namespace OperacoesComPilhas
{
    class Program
    {
        static void Main()
        {
            string expressaoBalanceada = "(2+1)*80/(7-[√9 + {4² * 0}])";
            string expressaoNaoBalanceada = "([{35 - 2} + 5*3} + 0 / 15) - [3 + 5³] * 11)";

            Console.WriteLine("Expressão Balanceada: " + VerificarBalanceamento(expressaoBalanceada));
            Console.WriteLine("Expressão Não Balanceada: " + VerificarBalanceamento(expressaoNaoBalanceada));
        }

        static bool VerificarBalanceamento(string expressao)
        {
            Stack<char> pilha = new Stack<char>();

            foreach (char caractere in expressao)
            {
                if (caractere == '(' || caractere == '[' || caractere == '{')
                {
                    pilha.Push(caractere);
                }
                else if (caractere == ')' || caractere == ']' || caractere == '}')
                {
                    if (pilha.Count == 0)
                    {
                        return false; 
                    }

                    char topoPilha = pilha.Pop();

                    if (!SaoParesCorrespondentes(topoPilha, caractere))
                    {
                        return false; 
                    }
                }
            }

            return pilha.Count == 0; 
        }

        static bool SaoParesCorrespondentes(char abertura, char fechamento)
        {
            return (abertura == '(' && fechamento == ')') ||
                   (abertura == '[' && fechamento == ']') ||
                   (abertura == '{' && fechamento == '}');
        }
    }
}
