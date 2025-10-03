using Hoja_de_Trabajo___Gestión_de_Inventarios_en_WinForms.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoja_de_Trabajo___Gestión_de_Inventarios_en_WinForms
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            Load += FormDashboard_Load;
        }

        private void FormDashboard_Load(object sender, EventArgs e) => MostrarKPIs();

        private void MostrarKPIs()
        {
            lblTotalProductos.Text = $"Productos registrados: {Repositorio.TotalProductos()}";
            lblTotalCategorias.Text = $"Categorías registradas: {Repositorio.TotalCategorias()}";
            lblValorInventario.Text = $"Valor total del inventario: Q {Repositorio.ValorInventario():N2}";
            var mayor = Repositorio.ProductoMayorStock();
            lblProductoMayorStock.Text = mayor == null ? "Producto con mayor stock: -"
                : $"Producto con mayor stock: \"{mayor.Nombre}\" ({mayor.Stock} unidades)";
        }
    }
}