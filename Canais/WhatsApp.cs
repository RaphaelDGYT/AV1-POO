using AV1_POO.Interfaces;

namespace AV1_POO.Canais
{
    public class WhatsApp(string numeroTelefone) : ICanal
    {
        public string Id { get; } = numeroTelefone;

        public void EnviarMensagem(IMensagem mensagem)
        {
            Console.WriteLine($"Enviando para {Id} através do WhatsApp!");
            mensagem.Sobre();
        }
    }
}