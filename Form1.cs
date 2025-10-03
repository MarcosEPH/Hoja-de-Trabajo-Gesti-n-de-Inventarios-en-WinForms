namespace Hoja_de_Trabajo___Gestión_de_Inventarios_en_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnDashboard.Click += (s, e) => new FormDashboard().ShowDialog();
            btnCategorias.Click += (s, e) => new FormCategorias().ShowDialog();
            btnProductos.Click += (s, e) => new FormProductos().ShowDialog();
            btnMovimientos.Click += (s, e) => new FormMovimientos().ShowDialog();
        }
    }
}