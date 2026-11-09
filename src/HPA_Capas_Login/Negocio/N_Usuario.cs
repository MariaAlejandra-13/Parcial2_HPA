using System;
using Datos;
using Entidades;
using Negocio.Interfaces;

namespace Negocio
{
    public class N_Usuario
    {
        private readonly D_Usuario datos;
        private readonly IVerificarHashService verificarHashService;

        public N_Usuario(
            D_Usuario datos,
            IVerificarHashService verificarHashService)
        {
            if (datos == null)
            {
                throw new ArgumentNullException(nameof(datos));
            }

            if (verificarHashService == null)
            {
                throw new ArgumentNullException(
                    nameof(verificarHashService));
            }

            this.datos = datos;
            this.verificarHashService = verificarHashService;
        }

        public E_Usuario IniciarSesion(
            string nombreUsuario, string password)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                throw new ArgumentException(
                    "Escribe el nombre de usuario.");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException(
                    "Escribe la contraseña.");
            }

            nombreUsuario = nombreUsuario.Trim();

            if (nombreUsuario.Length > 50)
            {
                throw new ArgumentException(
                    "El usuario no puede superar los 50 caracteres.");
            }

            E_Usuario usuario =
                datos.ObtenerPorNombre(nombreUsuario);

            if (usuario == null || usuario.dsEstado != "1")
            {
                return null;
            }

            bool passwordCorrecto =
                verificarHashService.VerificarHash(
                    password, usuario.dsPassword);

            if (!passwordCorrecto)
            {
                return null;
            }

            // El formulario no necesita recibir el hash.
            usuario.dsPassword = null;

            return usuario;
        }
    }
}
