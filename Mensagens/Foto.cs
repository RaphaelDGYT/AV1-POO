using AV1_POO.Interfaces;

namespace AV1_POO.Mensagens
{
    public class Foto(string conteudo, string nomeArquivo, string formato) : IMensagem
    {
        public string Conteudo { get; } = conteudo;
        public DateTime Data { get; } = DateTime.Now;
        public string NomeArquivo { get; } = nomeArquivo;
        public string Formato { get; } = formato;

        public void Sobre()
        {
            Console.WriteLine($"[Foto] {Data} - {Conteudo} - {NomeArquivo} - {Formato}");
        }
    }
}