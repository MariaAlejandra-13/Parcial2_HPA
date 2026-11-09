using System;
using System.Security.Cryptography;
using Negocio.Interfaces;

namespace Negocio.Servicios
{
    public class Sha512VerificarHashService : IVerificarHashService
    {
        private readonly IHashService hashService;

        public Sha512VerificarHashService(IHashService hashService)
        {
            ArgumentNullException.ThrowIfNull(hashService);
            this.hashService = hashService;
        }

        public bool VerificarHash(string password, byte[] hashAlmacenado)
        {
            if (password == null || hashAlmacenado == null)
            {
                return false;
            }

            byte[] hashCalculado = hashService.GenerarHash(password);

            return CryptographicOperations.FixedTimeEquals(
                hashCalculado, hashAlmacenado);
        }
    }
}
