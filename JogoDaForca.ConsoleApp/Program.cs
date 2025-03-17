namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random geradorDeNumeros = new Random();
            int indiceEscolhido = geradorDeNumeros.Next(28);

            string palavraEscolhida = Forca.SelecionarPalavra(indiceEscolhido);

            char[] letrasEncontradas = new char[palavraEscolhida.Length];

            for (int i = 0; i < letrasEncontradas.Length; i++)
            {
                letrasEncontradas[i] = '_';
            }

            Forca.MostrarForca(letrasEncontradas, palavraEscolhida);
        }
    }
}
