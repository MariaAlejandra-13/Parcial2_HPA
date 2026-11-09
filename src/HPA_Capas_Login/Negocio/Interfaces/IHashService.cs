namespace Negocio.Interfaces
{
    public interface IHashService
    {
        byte[] GenerarHash(string password);
    }
}