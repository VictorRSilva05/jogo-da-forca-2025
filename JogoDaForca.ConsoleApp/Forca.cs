using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.ConsoleApp
{
    public static class Forca
    {
        static string[] palavras = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

        static int quantidadeErros = default;
        static bool jogadorGanhou = false;
        static bool jogadorPerdeu = false;

        public static string SelecionarPalavra(int indiceEscolhido)
        {
            string palavraEscolhida = palavras[indiceEscolhido];
            return palavraEscolhida;
        }

        public static void MostrarForca(char[] letrasEncontradas, string palavraEscolhida)
        {
            do
            {
                string cabecaDoDesenho = quantidadeErros >= 1 ? " o " : " ";
                string troncoDoDesenho = quantidadeErros >= 2 ? "x" : " ";
                string troncoInferiorDoDesenho = quantidadeErros >= 2 ? " x " : " ";
                string bracoEsquerdoDoDesenho = quantidadeErros >= 3 ? "/" : " ";
                string bracoDireitoDoDesenho = quantidadeErros >= 4 ? "\\" : " ";
                string pernasDoDesenho = quantidadeErros >= 5 ? "/ \\" : " ";

                Console.Clear();

                Console.WriteLine("------------------------------");
                Console.WriteLine("Jogo da forca");
                Console.WriteLine("------------------------------");
                Console.WriteLine(" ___________        ");
                Console.WriteLine(" |/        |        ");
                Console.WriteLine(" |        {0}       ", cabecaDoDesenho);
                Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdoDoDesenho, troncoDoDesenho, bracoDireitoDoDesenho);
                Console.WriteLine(" |        {0}       ", troncoInferiorDoDesenho);
                Console.WriteLine(" |        {0}       ", pernasDoDesenho);
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
            } while (jogadorGanhou != true && jogadorPerdeu != true);

        }

        public static int GerarIndice()
        {
            Random geradorDeNumeros = new Random();
            int indiceEscolhido = geradorDeNumeros.Next(palavras.Length);
            return indiceEscolhido;
        }

    }

}


