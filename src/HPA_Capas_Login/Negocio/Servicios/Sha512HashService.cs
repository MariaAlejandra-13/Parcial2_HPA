using System;
using System.Security.Cryptography;
using System.Text;
using Negocio.Interfaces;

namespace Negocio.Servicios
{
    public class Sha512HashService : IHashService
    {
        public byte[] GenerarHash(string password)
        {
            ArgumentNullException.ThrowIfNull(password);

            byte[] contenido = Encoding.UTF8.GetBytes(password);

            using (SHA512 algoritmo = SHA512.Create())
            {
                return algoritmo.ComputeHash(contenido);
            }
        }
    }
}
