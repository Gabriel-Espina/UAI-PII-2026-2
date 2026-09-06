namespace tp3_Ejercicio9
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
            lblTiradas = new Label();
            txtTiradas = new TextBox();
            btnTirar = new Button();
            dgvResultados = new DataGridView();
            colNumero = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPorcentaje = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // lblTiradas
            // 
            lblTiradas.AccessibleRole = AccessibleRole.ScrollBar;
            lblTiradas.AutoSize = true;
            lblTiradas.Location = new Point(90, 45);
            lblTiradas.Name = "lblTiradas";
            lblTiradas.Size = new Size(109, 15);
            lblTiradas.TabIndex = 0;
            lblTiradas.Text = "Cantidad de tiradas";
            // 
            // txtTiradas
            // 
            txtTiradas.Location = new Point(231, 45);
            txtTiradas.Name = "txtTiradas";
            txtTiradas.Size = new Size(100, 23);
            txtTiradas.TabIndex = 1;
            // 
            // btnTirar
            // 
            btnTirar.Location = new Point(231, 88);
            btnTirar.Name = "btnTirar";
            btnTirar.Size = new Size(100, 26);
            btnTirar.TabIndex = 2;
            btnTirar.Text = "Tirar dados";
            btnTirar.UseVisualStyleBackColor = true;
            btnTirar.Click += btnTirar_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colNumero, colCantidad, colPorcentaje });
            dgvResultados.Location = new Point(43, 131);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(343, 150);
            dgvResultados.TabIndex = 3;
            // 
            // colNumero
            // 
            colNumero.HeaderText = "Número";
            colNumero.Name = "colNumero";
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            // 
            // colPorcentaje
            // 
            colPorcentaje.HeaderText = "Porcentaje";
            colPorcentaje.Name = "colPorcentaje";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResultados);
            Controls.Add(btnTirar);
            Controls.Add(txtTiradas);
            Controls.Add(lblTiradas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTiradas;
        private TextBox txtTiradas;
        private Button btnTirar;
        private DataGridView dgvResultados;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPorcentaje;
    }
}
