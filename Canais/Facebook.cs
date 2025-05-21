using AV1_POO.Interfaces;

namespace AV1_POO.Canais
{
    public class Facebook(string usuario) : ICanal
    {
        public string Id { get; } = usuario;

        public void EnviarMensagem(IMensagem mensagem)
        {
            Console.WriteLine($"Enviando para {Id} através do Facebook!");
            mensagem.Sobre();
        }
    }
}