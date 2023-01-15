using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRUEBA02.Database;

namespace PRUEBA02.repositorio
{
    public class UsuarioRepositorio
    {
        m_matosDbContext db = new m_matosDbContext();
        public List<Usuario> Llamar()
        {
            List<Usuario> listaUsuario = db.Usuarios.ToList();
            return listaUsuario;
        }
        public List<Usuario> nombreCompleto()
        {
            List<Usuario> nombreCompleto = db.Usuarios
                .Include(x => x.PersonaIdPersona)
                .ToList();
            return nombreCompleto;
        }
        public Usuario buscarID(int id)
        {
            Usuario idUsuario = db.Usuarios.Find(id);
            return idUsuario;
        } 
        public Usuario crearUsuario( Usuario request)
        {
            db.Usuarios.Add(request);
            return request;

        }
        public Usuario actualizarUsuario (Usuario request)
        {
            db.Usuarios.Update(request);
            db.SaveChanges();
            return request;
        }
        public int eliminar(int id)
        {
            Usuario usuario = db.Usuarios.Find(id); 
            db.Usuarios.Remove(usuario);
            return db.SaveChanges();
        }

    }
}
