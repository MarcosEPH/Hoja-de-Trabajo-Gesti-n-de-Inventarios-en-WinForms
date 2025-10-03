namespace Hoja_de_Trabajo___Gestión_de_Inventarios_en_WinForms
{
    partial class FormDashboard
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
            lblTotalProductos = new Label();
            lblTotalCategorias = new Label();
            lblValorInventario = new Label();
            lblProductoMayorStock = new Label();
            SuspendLayout();
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Location = new Point(34, 32);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(0, 20);
            lblTotalProductos.TabIndex = 0;
            // 
            // lblTotalCategorias
            // 
            lblTotalCategorias.AutoSize = true;
            lblTotalCategorias.Location = new Point(34, 70);
            lblTotalCategorias.Name = "lblTotalCategorias";
            lblTotalCategorias.Size = new Size(0, 20);
            lblTotalCategorias.TabIndex = 1;
            // 
            // lblValorInventario
            // 
            lblValorInventario.AutoSize = true;
            lblValorInventario.Location = new Point(34, 109);
            lblValorInventario.Name = "lblValorInventario";
            lblValorInventario.Size = new Size(0, 20);
            lblValorInventario.TabIndex = 2;
            // 
            // lblProductoMayorStock
            // 
            lblProductoMayorStock.AutoSize = true;
            lblProductoMayorStock.Location = new Point(34, 148);
            lblProductoMayorStock.Name = "lblProductoMayorStock";
            lblProductoMayorStock.Size = new Size(0, 20);
            lblProductoMayorStock.TabIndex = 3;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblProductoMayorStock);
            Controls.Add(lblValorInventario);
            Controls.Add(lblTotalCategorias);
            Controls.Add(lblTotalProductos);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormDashboard";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalProductos;
        private Label lblTotalCategorias;
        private Label lblValorInventario;
        private Label lblProductoMayorStock;
    }
}