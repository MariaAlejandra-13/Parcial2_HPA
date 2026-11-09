namespace Negocio.Interfaces
{
    public interface IVerificarHashService
    {
        bool VerificarHash(string password, byte[] hashAlmacenado);
    }
}
