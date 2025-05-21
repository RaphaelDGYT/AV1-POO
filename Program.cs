using AV1_POO.Mensagens;
using AV1_POO.Canais;

namespace AV1_POO
{
    class Program
    {
        static void Main()
        {
            // Variaveis de mensagens
            var mensagemTexto = new Texto("Olá, tudo bem?");
            var mensagemImagem = new Foto("Imagem de teste de Hamburguer BK",
                "imagem.jpg", "jpg");
            var mensagemArquivo = new Arquivo("Prova AV1 do professor Jose",
                "prova.pdf", "pdf");
            var mensagemVideo = new Video("Video de teste programando em C#",
                "video.mp4", "mp4", 60);


            // Variaveis de canais
            var whatsapp = new WhatsApp("11 98848-3651");
            var telegramUsuario = new Telegram("raphael", TelegramIdTipo.Usuario);
            var telegramNumero = new Telegram("11 98848-3651", TelegramIdTipo.NumeroTelefone);
            var instagram = new Instagram("raphael");
            var facebook = new Facebook("raphael");

            // Envio de mensagens
            whatsapp.EnviarMensagem(mensagemTexto);
            Console.WriteLine("");

            facebook.EnviarMensagem(mensagemImagem);
            Console.WriteLine("");

            telegramUsuario.EnviarMensagem(mensagemArquivo);
            Console.WriteLine("");

            telegramNumero.EnviarMensagem(mensagemVideo);
            Console.WriteLine("");

            instagram.EnviarMensagem(mensagemTexto);
            
        }
    }
}