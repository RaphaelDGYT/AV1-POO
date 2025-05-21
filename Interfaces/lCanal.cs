namespace AV1_POO.Interfaces
{
    public interface ICanal
    {
        string Id { get; }
        void EnviarMensagem(IMensagem mensagem);
    }
}