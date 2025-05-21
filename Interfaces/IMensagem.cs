namespace AV1_POO.Interfaces
{
    public interface IMensagem
    {
        string Conteudo { get; }
        DateTime Data { get; }
        void Sobre();
    }
}