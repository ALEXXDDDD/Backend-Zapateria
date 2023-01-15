using Microsoft.EntityFrameworkCore;
using PRUEBA02.Database;

namespace PRUEBA02.repositorio
{
    public class PersonaRepositorio
    {
      m_matosDbContext db = new m_matosDbContext ();
        public List<Persona> getAll()
        {
            List<Persona> list = db.Personas.ToList ();
            return list;
        }
        public List<Persona>getAllComplete()
        {
            List <Persona> list = db.Personas.
                Include(x=> x.Usuarios)
                
                .ToList ();
            return list;
        }
        public Persona getById(int id)
        {
            Persona registro = db.Personas.Find(id);
            return registro;
        }
        public Persona create (Persona request)
        {
            db.Personas.Add(request);
            db.SaveChanges();
            return request;

        }
        public Persona update(Persona request)
        {
            db.Personas.Update(request);
            db.SaveChanges();
            return request;

        }
        public int delete (int id)
        {
            Persona registro = db.Personas.Find(id);
            db.Personas.Remove(registro);
            return db.SaveChanges();
        }
    }
}
