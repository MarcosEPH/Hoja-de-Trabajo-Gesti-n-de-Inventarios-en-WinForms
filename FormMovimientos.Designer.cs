namespace Hoja_de_Trabajo___Gestión_de_Inventarios_en_WinForms
{
    partial class FormMovimientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbProductos = new ComboBox();
            cbTipo = new ComboBox();
            nudCantidad = new NumericUpDown();
            btnRegistrar = new Button();
            dgvHistorial = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // cbProductos
            // 
            cbProductos.FormattingEnabled = true;
            cbProductos.Items.AddRange(new object[] { "Sillon", "Mesa", "Television", "Monitor", "Mouse", "Teclado", "Cargador", "Ventilador" });
            cbProductos.Location = new Point(12, 12);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new Size(151, 28);
            cbProductos.TabIndex = 0;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(169, 12);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(151, 28);
            cbTipo.TabIndex = 1;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(326, 13);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(150, 27);
            nudCantidad.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(155, 321);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(155, 80);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(561, 209);
            dgvHistorial.TabIndex = 4;
            // 
            // FormMovimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvHistorial);
            Controls.Add(btnRegistrar);
            Controls.Add(nudCantidad);
            Controls.Add(cbTipo);
            Controls.Add(cbProductos);
            Name = "FormMovimientos";
            Text = "FormMovimientos";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbProductos;
        private ComboBox cbTipo;
        private NumericUpDown nudCantidad;
        private Button btnRegistrar;
        private DataGridView dgvHistorial;
    }
}