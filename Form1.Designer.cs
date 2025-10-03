namespace Hoja_de_Trabajo___Gestión_de_Inventarios_en_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDashboard = new Button();
            btnCategorias = new Button();
            btnProductos = new Button();
            btnMovimientos = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(409, 135);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(94, 29);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(155, 135);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(94, 29);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorías";
            btnCategorias.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = SystemColors.ButtonHighlight;
            btnProductos.Location = new Point(39, 135);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(94, 29);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnMovimientos
            // 
            btnMovimientos.Location = new Point(275, 135);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(113, 29);
            btnMovimientos.TabIndex = 3;
            btnMovimientos.Text = "Movimientos";
            btnMovimientos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(52, 36);
            label1.Name = "label1";
            label1.Size = new Size(434, 40);
            label1.TabIndex = 4;
            label1.Text = "Gestion de inventarios";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(552, 289);
            Controls.Add(label1);
            Controls.Add(btnMovimientos);
            Controls.Add(btnProductos);
            Controls.Add(btnCategorias);
            Controls.Add(btnDashboard);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDashboard;
        private Button btnCategorias;
        private Button btnProductos;
        private Button btnMovimientos;
        private Label label1;
    }
}
