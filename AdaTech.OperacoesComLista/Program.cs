namespace AdaTech.OperacoesComLista
{
    class Program
    {
        static void Main()
        {
            var input = new List<string>
            {
                "Idiossincrasia",
                "Ambivalente",
                "Quimérica",
                "Perpendicular",
                "Efêmero",
                "Pletora",
                "Obnubilado",
                "Xilografia",
                "Quixote",
                "Inefável"
            };

            List<string> result = FiltrarStringsPorTamanho(input, 10);

            Console.WriteLine("Palavras (strings) com 10 ou mais caracteres:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static List<string> FiltrarStringsPorTamanho(List<string> lista, int tamanhoMinimo)
        {
            List<string> resultado = new();

            foreach (var str in lista)
            {
                if (str.Length >= tamanhoMinimo)
                {
                    resultado.Add(str);
                }
            }

            return resultado;
        }
    }
}
