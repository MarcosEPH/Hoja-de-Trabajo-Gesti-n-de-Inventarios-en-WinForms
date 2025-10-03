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
    public partial class FormMovimientos : Form
    {
        public FormMovimientos()
        {
            InitializeComponent();
            Load += FormMovimientos_Load;
            btnRegistrar.Click += BtnRegistrar_Click;
            cbProductos.SelectedIndexChanged += (s, e) => RefrescarHistorial();
        }

        private void FormMovimientos_Load(object sender, EventArgs e)
        {
            cbProductos.DataSource = null;
            cbProductos.DataSource = Repositorio.Productos.ToList();
            cbProductos.DisplayMember = "Nombre";
            cbTipo.DataSource = Enum.GetValues(typeof(TipoMovimiento));
            RefrescarHistorial();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (!(cbProductos.SelectedItem is Producto prod)) { MessageBox.Show("Seleccione un producto."); return; }
            if (!int.TryParse(nudCantidad.Value.ToString(), out int cantidad)) { MessageBox.Show("Cantidad inválida."); return; }
            if (cantidad <= 0) { MessageBox.Show("Cantidad debe ser mayor que cero."); return; }

            var tipo = (TipoMovimiento)cbTipo.SelectedItem;
            var (ok, message) = Repositorio.RegistrarMovimiento(prod.Id, tipo, cantidad);
            if (!ok) MessageBox.Show(message);
            else { MessageBox.Show(message); RefrescarHistorial(); }
        }

        private void RefrescarHistorial()
        {
            Producto filtro = cbProductos.SelectedItem as Producto;
            var list = Repositorio.Movimientos
                .Where(m => filtro == null || m.Producto.Id == filtro.Id)
                .Select(m => new { m.Id, Producto = m.Producto.Nombre, Tipo = m.Tipo.ToString(), m.Cantidad, Fecha = m.Fecha, m.Observacion })
                .OrderByDescending(m => m.Fecha)
                .ToList();

            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = list;
        }
    }
}
