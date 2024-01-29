﻿namespace OpecacoesComDicionario
{
    class Program
    {
        static void Main()
        {
            string input = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla auctor porta velit a tincidunt. Nam efficitur iaculis placerat. Aenean lectus dui, sollicitudin id rhoncus tristique, aliquet sed quam. Phasellus blandit magna at elementum consequat. Nam vitae nunc vehicula, blandit felis a, placerat augue. Quisque bibendum a ipsum at scelerisque. Duis molestie turpis quis orci vehicula aliquam. Duis non elementum erat. Phasellus et dui odio. Nunc vitae leo sem. Curabitur nec enim id mi aliquet commodo at et sapien. Fusce sit amet nisi elit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Duis vitae dolor at sem ultrices euismod. Morbi aliquet, felis et mattis congue, justo nunc pharetra lectus, a lobortis mauris eros et nulla. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Maecenas sollicitudin posuere nibh malesuada suscipit. Nam a sapien ex. Donec mollis justo est, quis tempus mi pharetra at. Cras fringilla enim eu egestas scelerisque. Praesent tristique imperdiet consectetur. Donec interdum pulvinar nulla vel pharetra. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Aliquam interdum finibus mi, in tempus lorem. Cras diam magna, viverra vitae ante eget, scelerisque sodales velit. Aliquam erat volutpat. Mauris consectetur sapien mi, vel euismod quam consectetur id.";

            Dictionary<string, int> contadorPalavras = ContarPalavras(input);

            Console.WriteLine("Contagem de Palavras e Ocorrência:");
            foreach (var par in contadorPalavras)
            {
                Console.WriteLine($"{par.Key}: {par.Value}");
            }
        }

        static Dictionary<string, int> ContarPalavras(string texto)
        {
            // Mudando a operação de formatar para que seja aplicado direto no texto antes do split, teremos somente 1 execução
            // da operação ao invés de 1 x Nº de palavras ;P
            string[] palavras = texto.ToLower().Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> contador = new();

            foreach (string palavra in palavras)
            {
                if (contador.ContainsKey(palavra))
                {
                    contador[palavra]++;
                }
                else
                {
                    contador[palavra] = 1;
                }
            }

            return contador;
        }
    }
}
