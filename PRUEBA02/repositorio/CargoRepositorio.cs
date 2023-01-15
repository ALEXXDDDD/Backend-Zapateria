using PRUEBA02.Database;
using System.Security.Cryptography;

namespace PRUEBA02.repositorio
{
    public class CargoRepositorio
    {
        m_matosDbContext db =  new m_matosDbContext();
        public List<Cargo> getAll()
        {
            List<Cargo> cargoList = db.Cargos.ToList();
            return cargoList;
        }
        public Cargo getById(int id)
        {
            Cargo regisro  = db.Cargos.Find(id) ;
            return regisro;
        }
        public Cargo create(Cargo request)
        {
            db.Cargos.Add( request);
            db.SaveChanges();
            return request;
        }
        public Cargo update(Cargo request)
        {
            db.Cargos.Update(request);
            db.SaveChanges();
            return request;

        }
        public int delete(int id)
        {
           Cargo cargo = db.Cargos.Find(id);
            db.Cargos.Remove(cargo);
            return db.SaveChanges();

        }

    }
}
