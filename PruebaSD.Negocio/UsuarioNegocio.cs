using PruebaSD.Datos;
using PruebaSD.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSD.Negocio
{
    public class UsuarioNegocio
    {
        UsuarioDatos LogicaDatos = new UsuarioDatos();
        public IEnumerable<Usuario> GetUsuarioNegocio()
        {
            var usuario = LogicaDatos.GetUsuarios();
            return usuario;
        }

        public void PostUsuario(Usuario usuario)
        {
            LogicaDatos.PostUsuarios(usuario);
            
        }

        public Usuario GetUsuario(decimal id)
        {
            Usuario miUsuario = LogicaDatos.GetUsuario(id);
            return miUsuario;
        }

        public void ActualizarUsuarioNegocio(decimal id, Usuario usuario)
        {
            var miUsuario = LogicaDatos.GetUsuario(id);
            
            if (id == miUsuario.UsuId)
            {
                miUsuario.Apellido = usuario.Apellido;
                miUsuario.Nombre = usuario.Nombre;

                LogicaDatos.ActualizarUsuarioDatos(miUsuario);

            }

        }

        public void EliminarUsuarioNegocio(decimal id)
        {
            var miUsuario = LogicaDatos.GetUsuario(id);
            LogicaDatos.EliminarUsuarioDatos(miUsuario);
        }
    }
}
