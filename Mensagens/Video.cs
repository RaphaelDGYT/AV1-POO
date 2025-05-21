using AV1_POO.Interfaces;

namespace AV1_POO.Mensagens
{
    public class Video(string conteudo, string nomeArquivo, string formato, int duracao) : IMensagem
    {
        public string Conteudo { get; } = conteudo;
        public DateTime Data { get; } = DateTime.Now;
        public string NomeArquivo { get; } = nomeArquivo;
        public string Formato { get; } = formato;
        public int Duracao { get; } = duracao;

        public void Sobre()
        {
            Console.WriteLine($"[Video] {Data} - {Conteudo}");
            Console.WriteLine($"Nome do arquivo: {NomeArquivo}");
            Console.WriteLine($"Formato: {Formato}");
            Console.WriteLine($"Duração: {Duracao} segundos");
        }
    }
}