using AV1_POO.Interfaces;

namespace AV1_POO.Canais
{
    public enum TelegramIdTipo
    {
        Usuario,
        NumeroTelefone
    }

    public class Telegram : ICanal
    {
        public string Id { get; }
        public TelegramIdTipo IdTipo { get; }

        public Telegram(string id, TelegramIdTipo idTipo)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Identificador inválido.");

            IdTipo = idTipo;
            Id = id;
        }

        public void EnviarMensagem(IMensagem mensagem)
        {
            var tipo = IdTipo == TelegramIdTipo.Usuario ? "Usuário" : "Número";
            Console.WriteLine($"Telegram ({tipo}) -> {Id}");
            mensagem.Sobre();
        }
    }
}