using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaSD.Datos;
using PruebaSD.Entidades;
using PruebaSD.Negocio;

namespace PruebaSD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly PruebaSDContext _context;
        private UsuarioNegocio ObjetoNegocio = new UsuarioNegocio();

        public UsuariosController(PruebaSDContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public IEnumerable<Usuario> GetUsuario()
        {
            return ObjetoNegocio.GetUsuarioNegocio();
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public Usuario GetUsuario(decimal id)
        {
          
            Usuario usuario = ObjetoNegocio.GetUsuario(id);

            return usuario;
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public void PutUsuario(decimal id, Usuario usuario)
        {
            ObjetoNegocio.ActualizarUsuarioNegocio(id, usuario);

          
        }

        // POST: api/Usuarios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public void PostUsuario(Usuario usuario)
        {                   

            ObjetoNegocio.PostUsuario(usuario);

            //return CreatedAtAction("GetUsuario", new { id = miUsuario.UsuId }, miUsuario);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public void DeleteUsuario(decimal id)
        {

            ObjetoNegocio.EliminarUsuarioNegocio(id);
        
        }
        /*
        private bool UsuarioExists(decimal id)
        {
            return _context.Usuario.Any(e => e.UsuId == id);
        }*/
    }
}
