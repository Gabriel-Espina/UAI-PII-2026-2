namespace T.PN_3_Ejercicio10
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbInicial = new System.Windows.Forms.ComboBox();
            this.cmbFinal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbInicial
            // 
            this.cmbInicial.FormattingEnabled = true;
            this.cmbInicial.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin",
            "Rankine"});
            this.cmbInicial.Location = new System.Drawing.Point(489, 214);
            this.cmbInicial.Name = "cmbInicial";
            this.cmbInicial.Size = new System.Drawing.Size(191, 28);
            this.cmbInicial.TabIndex = 0;
            // 
            // cmbFinal
            // 
            this.cmbFinal.FormattingEnabled = true;
            this.cmbFinal.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin",
            "Rankine"});
            this.cmbFinal.Location = new System.Drawing.Point(784, 214);
            this.cmbFinal.Name = "cmbFinal";
            this.cmbFinal.Size = new System.Drawing.Size(206, 28);
            this.cmbFinal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad a Transformar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escala inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Escala final";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(670, 298);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(110, 44);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(489, 122);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(501, 26);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCantidad,
            this.colInicial,
            this.colFinal,
            this.colResultado});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(416, 260);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Valor Ingresado";
            this.colCantidad.MinimumWidth = 8;
            this.colCantidad.Name = "colCantidad";
            // 
            // colInicial
            // 
            this.colInicial.HeaderText = "Escala Inicial";
            this.colInicial.MinimumWidth = 8;
            this.colInicial.Name = "colInicial";
            // 
            // colFinal
            // 
            this.colFinal.HeaderText = "Escala Final";
            this.colFinal.MinimumWidth = 8;
            this.colFinal.Name = "colFinal";
            // 
            // colResultado
            // 
            this.colResultado.HeaderText = "Resultado";
            this.colResultado.MinimumWidth = 8;
            this.colResultado.Name = "colResultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFinal);
            this.Controls.Add(this.cmbInicial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbInicial;
        private System.Windows.Forms.ComboBox cmbFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultado;
    }
}

