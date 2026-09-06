namespace Tp3_ejercicio7
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
            lblMonto = new Label();
            lblTasa = new Label();
            lblDias = new Label();
            txtMonto = new TextBox();
            txtTasa = new TextBox();
            txtDias = new TextBox();
            btnCalcular = new Button();
            dgvResultado = new DataGridView();
            colMonto = new DataGridViewTextBoxColumn();
            colTasa = new DataGridViewTextBoxColumn();
            colDias = new DataGridViewTextBoxColumn();
            colInterés = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(36, 35);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto";
            lblMonto.Click += label1_Click;
            // 
            // lblTasa
            // 
            lblTasa.AutoSize = true;
            lblTasa.Location = new Point(36, 70);
            lblTasa.Name = "lblTasa";
            lblTasa.Size = new Size(112, 15);
            lblTasa.TabIndex = 1;
            lblTasa.Text = "Tasa Nominal Anual";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(41, 102);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(29, 15);
            lblDias.TabIndex = 2;
            lblDias.Text = "Días";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(156, 35);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 3;
            // 
            // txtTasa
            // 
            txtTasa.Location = new Point(156, 67);
            txtTasa.Name = "txtTasa";
            txtTasa.Size = new Size(100, 23);
            txtTasa.TabIndex = 4;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(156, 102);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(100, 23);
            txtDias.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(324, 46);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // dgvResultado
            // 
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Columns.AddRange(new DataGridViewColumn[] { colMonto, colTasa, colDias, colInterés });
            dgvResultado.Location = new Point(46, 189);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.Size = new Size(464, 150);
            dgvResultado.TabIndex = 7;
            // 
            // colMonto
            // 
            colMonto.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colMonto.HeaderText = "Monto";
            colMonto.Name = "colMonto";
            colMonto.Width = 68;
            // 
            // colTasa
            // 
            colTasa.HeaderText = "Tasa";
            colTasa.Name = "colTasa";
            // 
            // colDias
            // 
            colDias.HeaderText = "Dias";
            colDias.Name = "colDias";
            // 
            // colInterés
            // 
            colInterés.HeaderText = "Interés";
            colInterés.Name = "colInterés";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtDias);
            Controls.Add(txtTasa);
            Controls.Add(txtMonto);
            Controls.Add(lblDias);
            Controls.Add(lblTasa);
            Controls.Add(lblMonto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblTasa;
        private Label lblDias;
        private TextBox txtMonto;
        private TextBox txtTasa;
        private TextBox txtDias;
        private Button btnCalcular;
        private DataGridView dgvResultado;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colTasa;
        private DataGridViewTextBoxColumn colDias;
        private DataGridViewTextBoxColumn colInterés;
    }
}
