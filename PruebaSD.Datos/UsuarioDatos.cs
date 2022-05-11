using Microsoft.EntityFrameworkCore;
using PruebaSD.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSD.Datos
{
    public class UsuarioDatos
    {
        PruebaSDContext context = new PruebaSDContext();

        public IEnumerable<Usuario> GetUsuarios()
        {
            IEnumerable<Usuario> usuarios = context.Usuario;
            return usuarios;
        }

        public void PostUsuarios(Usuario usuario)
        {
            try
            {

            context.Usuario.Add(usuario);
            context.SaveChanges();
            
             }
             catch (Exception ex)
             {
                 string text = ex.Message;
                 return; 
             }   


        }

        public Usuario GetUsuario(decimal id)
        {
            Usuario usuario = new Usuario();
            try
            {

                usuario = context.Usuario.Find(id);
                return usuario;
            }
            catch (Exception ex)
            {
                string test = ex.Message;
                return usuario;
            }


        }

        public void ActualizarUsuarioDatos(Usuario usuario)
        {
            try
            {
                context.Usuario.Update(usuario);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string test = ex.Message;
                return;
            }
            ;
        }

        public void EliminarUsuarioDatos(Usuario usuario)
        {
            try
            {
                context.Usuario.Remove(usuario);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                string test = ex.Message;
                return;
            }

            
        }
    }
}
