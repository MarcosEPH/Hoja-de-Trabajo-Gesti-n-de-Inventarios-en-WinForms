using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_Trabajo___Gestión_de_Inventarios_en_WinForms.Clases
{
    public static class Repositorio
    {
        public static List<Categoria> Categorias { get; } = new List<Categoria>();
        public static List<Producto> Productos { get; } = new List<Producto>();
        public static List<Movimiento> Movimientos { get; } = new List<Movimiento>();

        private static int nextCat = 1;
        private static int nextProd = 1;
        private static int nextMov = 1;

        static Repositorio()
        {
  
            AgregarCategoria(new Categoria { Nombre = "Abarrotes" });
            AgregarCategoria(new Categoria { Nombre = "Limpieza" });
            AgregarCategoria(new Categoria { Nombre = "Electrónicos" });

            AgregarProducto(new Producto { Nombre = "Detergente Ariel", Categoria = Categorias[1], PrecioUnitario = 35m, Stock = 150 });
            AgregarProducto(new Producto { Nombre = "Celular X", Categoria = Categorias[2], PrecioUnitario = 2500m, Stock = 5 });
        }


        public static Categoria AgregarCategoria(Categoria c)
        {
            c.Id = nextCat++;
            Categorias.Add(c);
            return c;
        }
        public static void EditarCategoria(Categoria c)
        {
            var exist = Categorias.FirstOrDefault(x => x.Id == c.Id);
            if (exist != null) exist.Nombre = c.Nombre;
        }
        public static bool EliminarCategoria(int id)
        {

            if (Productos.Any(p => p.Categoria != null && p.Categoria.Id == id))
                return false;
            var cat = Categorias.FirstOrDefault(x => x.Id == id);
            if (cat != null) Categorias.Remove(cat);
            return true;
        }

        public static Producto AgregarProducto(Producto p)
        {
            p.Id = nextProd++;
            Productos.Add(p);
            return p;
        }
        public static void EditarProducto(Producto p)
        {
            var exist = Productos.FirstOrDefault(x => x.Id == p.Id);
            if (exist != null)
            {
                exist.Nombre = p.Nombre;
                exist.Categoria = p.Categoria;
                exist.PrecioUnitario = p.PrecioUnitario;
            
            }
        }
        public static void EliminarProducto(int id)
        {
            var exist = Productos.FirstOrDefault(x => x.Id == id);
            if (exist != null) Productos.Remove(exist);
        }

    
        public static (bool ok, string message) RegistrarMovimiento(int productoId, TipoMovimiento tipo, int cantidad, string observacion = "")
        {
            var prod = Productos.FirstOrDefault(p => p.Id == productoId);
            if (prod == null) return (false, "Producto no encontrado.");
            if (cantidad <= 0) return (false, "La cantidad debe ser mayor que cero.");

            if (tipo == TipoMovimiento.Salida && prod.Stock < cantidad)
                return (false, "No hay suficiente stock para realizar esta salida.");

         
            if (tipo == TipoMovimiento.Entrada) prod.Stock += cantidad;
            else prod.Stock -= cantidad;

            var mov = new Movimiento
            {
                Id = nextMov++,
                Producto = prod,
                Tipo = tipo,
                Cantidad = cantidad,
                Fecha = DateTime.Now,
                Observacion = observacion
            };
            Movimientos.Add(mov);
            return (true, "Movimiento registrado.");
        }

        public static int TotalProductos() => Productos.Count;
        public static int TotalCategorias() => Categorias.Count;
        public static decimal ValorInventario() => Productos.Sum(p => p.PrecioUnitario * p.Stock);
        public static Producto ProductoMayorStock() => Productos.OrderByDescending(p => p.Stock).FirstOrDefault();
    }
}
