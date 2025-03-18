namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indiceEscolhido = Forca.GerarIndice();

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
