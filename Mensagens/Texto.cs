using AV1_POO.Interfaces;

namespace AV1_POO.Mensagens
{
    public class Texto(string mensagem) : IMensagem
    {
        public string Conteudo { get; } = mensagem;
        public DateTime Data { get; } = DateTime.Now;

        public void Sobre()
        {
            Console.WriteLine($"[Texto] {Data} - {Conteudo}");
        }

    }

}