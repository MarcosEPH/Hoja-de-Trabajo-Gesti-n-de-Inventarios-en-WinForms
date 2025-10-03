using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_Trabajo___Gestión_de_Inventarios_en_WinForms.Clases
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public override string ToString() => Nombre;
    }
}