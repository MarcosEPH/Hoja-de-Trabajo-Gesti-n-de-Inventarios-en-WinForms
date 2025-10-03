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
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
            Load += (s, e) => Refrescar();
            btnAgregar.Click += BtnAgregar_Click;
            btnEditar.Click += BtnEditar_Click;
            btnEliminar.Click += BtnEliminar_Click;
        }

        private void Refrescar()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = Repositorio.Categorias.Select(c => new { c.Id, c.Nombre }).ToList();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Nombre de la categoría:");
            if (string.IsNullOrWhiteSpace(nombre)) return;
            Repositorio.AgregarCategoria(new Categoria { Nombre = nombre.Trim() });
            Refrescar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null) { MessageBox.Show("Seleccione una categoría."); return; }
            int id = (int)dgvCategorias.CurrentRow.Cells["Id"].Value;
            var cat = Repositorio.Categorias.FirstOrDefault(c => c.Id == id);
            string nuevo = Microsoft.VisualBasic.Interaction.InputBox("Nuevo nombre:", "Editar", cat.Nombre);
            if (string.IsNullOrWhiteSpace(nuevo)) return;
            cat.Nombre = nuevo.Trim();
            ReposcarYRefrescar();
            Refrescar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null) { MessageBox.Show("Seleccione una categoría."); return; }
            int id = (int)dgvCategorias.CurrentRow.Cells["Id"].Value;
            bool ok = Repositorio.EliminarCategoria(id);
            if (!ok) MessageBox.Show("No se puede eliminar: existen productos asociados.");
            Refrescar();
        }

        private void ReposcarYRefrescar() { /* placeholder */ }
    }
}