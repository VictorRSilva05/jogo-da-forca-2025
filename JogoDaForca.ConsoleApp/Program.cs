namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavraEscolhida = "MELANCIA";

            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int i = 0; i < letrasEncontradas.Length; i++)
            {
                letrasEncontradas[i] = '_';
            }

            int quantidadeErros = default;
            bool jogadorGanhou = false;
            bool jogadorPerdeu = false;

            do
            {
                string cabecaDoDesenho = quantidadeErros >= 1 ? " o " : "";
                string troncoDoDesenho = quantidadeErros >= 2 ? "x" : "" ;
                string troncoInferiorDoDesenho = quantidadeErros >= 2 ? " x " : "";
                string bracoEsquerdoDoDesenho = quantidadeErros >= 3 ? "/" : "";
                string bracoDireitoDoDesenho = quantidadeErros >= 4 ? "\\" : "";
                string pernasDoDesenho = quantidadeErros >= 5 ? "/" : "";

                Console.Clear();

                Console.WriteLine("------------------------------");
                Console.WriteLine("Jogo da forca");
                Console.WriteLine("------------------------------");
                Console.WriteLine(" ___________        ");
                Console.WriteLine(" |/        |        ");
                Console.WriteLine(" |        {0}       ", cabecaDoDesenho);
                Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdoDoDesenho, troncoDoDesenho, bracoDireitoDoDesenho);
                Console.WriteLine(" |        {0}          ", troncoInferiorDoDesenho);
                Console.WriteLine(" |        {0}         ", pernasDoDesenho);
                Console.WriteLine(" |                  ");
                Console.WriteLine(" |                  ");
                Console.WriteLine("_|____              ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Palavra escolhida: " + String.Join(" ", letrasEncontradas));
                Console.WriteLine("------------------------------");
                Console.WriteLine("Erros do jogador: " + quantidadeErros);
                Console.WriteLine("------------------------------");

                Console.Write("\nDigite uma letra válida: ");
                string entradaInicial = Console.ReadLine().ToUpper();

                if (entradaInicial.Length > 1)
                {
                    Console.WriteLine("Informe apenas um caractere.");
                    Console.ReadKey();
                    continue;
                }

                char chute = entradaInicial[0];

                bool letraFoiEncontrada = false;

                for (int i = 0; i < palavraEscolhida.Length; i++)
                {
                    char caractereAtual = palavraEscolhida[i];

                    if (chute == caractereAtual)
                    {
                        letrasEncontradas[i] = caractereAtual;
                        letraFoiEncontrada = true;
                    }
                }

                if (letraFoiEncontrada == false)
                    quantidadeErros++; 

                string palavraEncontradaCompleta = String.Join("", letrasEncontradas);
                jogadorGanhou = palavraEncontradaCompleta == palavraEscolhida;

                if (jogadorGanhou)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"Você acertou a palavra {palavraEscolhida}, parabéns!");
                    Console.WriteLine("------------------------------");
                }

                jogadorPerdeu = quantidadeErros > 5;

                if (jogadorPerdeu)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"A palavra correta era {palavraEscolhida}, mais sorte na próxima...");
                    Console.WriteLine("------------------------------");
                }
            }
            while (jogadorGanhou != true && jogadorPerdeu != true);
        }
    }
}
