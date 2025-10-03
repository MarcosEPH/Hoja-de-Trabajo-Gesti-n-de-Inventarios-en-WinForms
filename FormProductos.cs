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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
            Load += (s, e) => Refrescar();
            btnAgregar.Click += BtnAgregar_Click;
            btnEditar.Click += BtnEditar_Click;
            btnEliminar.Click += BtnEliminar_Click;
        }

        private void Refrescar()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Repositorio.Productos.Select(p => new
            {
                p.Id,
                p.Nombre,
                Categoria = p.Categoria?.Nombre ?? "",
                p.PrecioUnitario,
                p.Stock
            }).ToList();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
     
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Nombre del producto:");
            if (string.IsNullOrWhiteSpace(nombre)) return;

     
            var categorias = Repositorio.Categorias;
            var lista = string.Join(Environment.NewLine, categorias.Select(c => $"{c.Id}: {c.Nombre}"));
            string idCatStr = Microsoft.VisualBasic.Interaction.InputBox("Ingrese ID de categoría:\n" + lista);
            if (!int.TryParse(idCatStr, out int idCat)) return;
            var cat = categorias.FirstOrDefault(c => c.Id == idCat);
            if (cat == null) { MessageBox.Show("Categoría inválida."); return; }

            string precioStr = Microsoft.VisualBasic.Interaction.InputBox("Precio unitario:");
            if (!decimal.TryParse(precioStr, out decimal precio) || precio <= 0) { MessageBox.Show("Precio inválido."); return; }

            string stockStr = Microsoft.VisualBasic.Interaction.InputBox("Cantidad inicial en existencia (>= 0):");
            if (!int.TryParse(stockStr, out int stock) || stock < 0) { MessageBox.Show("Stock inválido."); return; }

            var p = new Producto { Nombre = nombre.Trim(), Categoria = cat, PrecioUnitario = precio, Stock = stock };
            Repositorio.AgregarProducto(p);
  
            if (stock > 0) Repositorio.RegistrarMovimiento(p.Id, TipoMovimiento.Entrada, stock, "Stock inicial");

            Refrescar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) { MessageBox.Show("Seleccione un producto."); return; }
            int id = (int)dgvProductos.CurrentRow.Cells["Id"].Value;
            var p = Repositorio.Productos.First(x => x.Id == id);

            string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox("Nombre:", "Editar", p.Nombre);
            if (string.IsNullOrWhiteSpace(nuevoNombre)) return;

            string precioStr = Microsoft.VisualBasic.Interaction.InputBox("Precio unitario:", "Editar", p.PrecioUnitario.ToString());
            if (!decimal.TryParse(precioStr, out decimal precio) || precio <= 0) { MessageBox.Show("Precio inválido."); return; }

  
            var categorias = Repositorio.Categorias;
            var lista = string.Join(Environment.NewLine, categorias.Select(c => $"{c.Id}: {c.Nombre}"));
            string idCatStr = Microsoft.VisualBasic.Interaction.InputBox("ID categoría:\n" + lista, "Editar", p.Categoria?.Id.ToString());
            if (!int.TryParse(idCatStr, out int idCat)) return;
            var cat = categorias.FirstOrDefault(c => c.Id == idCat);
            if (cat == null) { MessageBox.Show("Categoría inválida."); return; }

            p.Nombre = nuevoNombre.Trim();
            p.PrecioUnitario = precio;
            p.Categoria = cat;
            Repositorio.EditarProducto(p);
            Refrescar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) { MessageBox.Show("Seleccione un producto."); return; }
            int id = (int)dgvProductos.CurrentRow.Cells["Id"].Value;
            Repositorio.EliminarProducto(id);
            Refrescar();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
