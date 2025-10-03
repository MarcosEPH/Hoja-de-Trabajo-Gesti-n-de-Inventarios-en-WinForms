using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_Trabajo___Gestión_de_Inventarios_en_WinForms.Clases
{
    public enum TipoMovimiento { Entrada, Salida }

    public class Movimiento
    {
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public TipoMovimiento Tipo { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Observacion { get; set; }
    }
}