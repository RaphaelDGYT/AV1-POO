using AV1_POO.Interfaces;

namespace AV1_POO.Canais
{
    public class Instagram(string usuario) : ICanal
    {
        public string Id { get; } = usuario;

        public void EnviarMensagem(IMensagem mensagem)
        {
            Console.WriteLine($"Enviando para {Id} através do Instagram!");
            mensagem.Sobre();
        }
    }
}