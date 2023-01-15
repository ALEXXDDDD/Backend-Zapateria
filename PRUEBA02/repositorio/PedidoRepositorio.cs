using Microsoft.EntityFrameworkCore;
using PRUEBA02.Database;

namespace PRUEBA02.repositorio
{
    public class PedidoRepositorio
    {
        m_matosDbContext db = new m_matosDbContext();
        public List<Pedido> listarPedido ()
        {
            List<Pedido> pedidos = db.Pedidos.ToList();
            return pedidos;
        }
        public List<Pedido> gettAllComplete ()
        {
            List<Pedido> listPedido = db.Pedidos
                .Include(x => x.ProductoIdProducto)
                .ToList();
            return listPedido;
        }
        public Pedido crearPedido(Pedido request)
        {
            db.Pedidos.Add(request);
            db.SaveChanges();
            return request;
        }
    }
}
