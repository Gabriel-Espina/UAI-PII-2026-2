namespace T.PN_8_ejercicio2
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAgregarRaiz = new System.Windows.Forms.Button();
            this.btnAgregarDerecha = new System.Windows.Forms.Button();
            this.btnAgregarIzquierda = new System.Windows.Forms.Button();
            this.btnRecorrerInorden = new System.Windows.Forms.Button();
            this.btnRecorrerPreorden = new System.Windows.Forms.Button();
            this.btnRecorrerPostorden = new System.Windows.Forms.Button();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblNombreNodo = new System.Windows.Forms.Label();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Info;
            this.treeView1.Location = new System.Drawing.Point(25, 31);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(255, 226);
            this.treeView1.TabIndex = 0;
            // 
            // btnAgregarRaiz
            // 
            this.btnAgregarRaiz.BackColor = System.Drawing.Color.Khaki;
            this.btnAgregarRaiz.Location = new System.Drawing.Point(322, 31);
            this.btnAgregarRaiz.Name = "btnAgregarRaiz";
            this.btnAgregarRaiz.Size = new System.Drawing.Size(217, 45);
            this.btnAgregarRaiz.TabIndex = 1;
            this.btnAgregarRaiz.Text = "Agregar Raiz";
            this.btnAgregarRaiz.UseVisualStyleBackColor = false;
            this.btnAgregarRaiz.Click += new System.EventHandler(this.btnAgregarRaiz_Click);
            // 
            // btnAgregarDerecha
            // 
            this.btnAgregarDerecha.BackColor = System.Drawing.Color.Khaki;
            this.btnAgregarDerecha.Location = new System.Drawing.Point(322, 82);
            this.btnAgregarDerecha.Name = "btnAgregarDerecha";
            this.btnAgregarDerecha.Size = new System.Drawing.Size(217, 45);
            this.btnAgregarDerecha.TabIndex = 2;
            this.btnAgregarDerecha.Text = "Agregar Derecha";
            this.btnAgregarDerecha.UseVisualStyleBackColor = false;
            this.btnAgregarDerecha.Click += new System.EventHandler(this.btnAgregarDerecha_Click);
            // 
            // btnAgregarIzquierda
            // 
            this.btnAgregarIzquierda.BackColor = System.Drawing.Color.Khaki;
            this.btnAgregarIzquierda.Location = new System.Drawing.Point(322, 133);
            this.btnAgregarIzquierda.Name = "btnAgregarIzquierda";
            this.btnAgregarIzquierda.Size = new System.Drawing.Size(217, 47);
            this.btnAgregarIzquierda.TabIndex = 3;
            this.btnAgregarIzquierda.Text = "Agregar Izquierda";
            this.btnAgregarIzquierda.UseVisualStyleBackColor = false;
            this.btnAgregarIzquierda.Click += new System.EventHandler(this.btnAgregarIzquierda_Click);
            // 
            // btnRecorrerInorden
            // 
            this.btnRecorrerInorden.BackColor = System.Drawing.Color.Khaki;
            this.btnRecorrerInorden.Location = new System.Drawing.Point(322, 186);
            this.btnRecorrerInorden.Name = "btnRecorrerInorden";
            this.btnRecorrerInorden.Size = new System.Drawing.Size(217, 42);
            this.btnRecorrerInorden.TabIndex = 4;
            this.btnRecorrerInorden.Text = "Recorrer Inorden";
            this.btnRecorrerInorden.UseVisualStyleBackColor = false;
            this.btnRecorrerInorden.Click += new System.EventHandler(this.btnRecorrerInorden_Click);
            // 
            // btnRecorrerPreorden
            // 
            this.btnRecorrerPreorden.BackColor = System.Drawing.Color.Khaki;
            this.btnRecorrerPreorden.Location = new System.Drawing.Point(322, 234);
            this.btnRecorrerPreorden.Name = "btnRecorrerPreorden";
            this.btnRecorrerPreorden.Size = new System.Drawing.Size(217, 53);
            this.btnRecorrerPreorden.TabIndex = 5;
            this.btnRecorrerPreorden.Text = "Recorrer Preorden";
            this.btnRecorrerPreorden.UseVisualStyleBackColor = false;
            this.btnRecorrerPreorden.Click += new System.EventHandler(this.btnRecorrerPreorden_Click);
            // 
            // btnRecorrerPostorden
            // 
            this.btnRecorrerPostorden.BackColor = System.Drawing.Color.Khaki;
            this.btnRecorrerPostorden.Location = new System.Drawing.Point(322, 293);
            this.btnRecorrerPostorden.Name = "btnRecorrerPostorden";
            this.btnRecorrerPostorden.Size = new System.Drawing.Size(217, 47);
            this.btnRecorrerPostorden.TabIndex = 6;
            this.btnRecorrerPostorden.Text = "Recorrer Postorden";
            this.btnRecorrerPostorden.UseVisualStyleBackColor = false;
            this.btnRecorrerPostorden.Click += new System.EventHandler(this.btnRecorrerPostorden_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(21, 405);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(0, 20);
            this.lblAltura.TabIndex = 7;
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(21, 435);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(0, 20);
            this.lblAncho.TabIndex = 8;
            // 
            // lblNombreNodo
            // 
            this.lblNombreNodo.AutoSize = true;
            this.lblNombreNodo.Location = new System.Drawing.Point(25, 320);
            this.lblNombreNodo.Name = "lblNombreNodo";
            this.lblNombreNodo.Size = new System.Drawing.Size(0, 20);
            this.lblNombreNodo.TabIndex = 9;
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.BackColor = System.Drawing.SystemColors.Info;
            this.txtRecorrido.Location = new System.Drawing.Point(322, 399);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(418, 26);
            this.txtRecorrido.TabIndex = 10;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(25, 283);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(147, 20);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Nodo Seleccionado";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(21, 371);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(46, 20);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "Arbol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Recorrido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtRecorrido);
            this.Controls.Add(this.lblNombreNodo);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.btnRecorrerPostorden);
            this.Controls.Add(this.btnRecorrerPreorden);
            this.Controls.Add(this.btnRecorrerInorden);
            this.Controls.Add(this.btnAgregarIzquierda);
            this.Controls.Add(this.btnAgregarDerecha);
            this.Controls.Add(this.btnAgregarRaiz);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAgregarRaiz;
        private System.Windows.Forms.Button btnAgregarDerecha;
        private System.Windows.Forms.Button btnAgregarIzquierda;
        private System.Windows.Forms.Button btnRecorrerInorden;
        private System.Windows.Forms.Button btnRecorrerPreorden;
        private System.Windows.Forms.Button btnRecorrerPostorden;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblNombreNodo;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
    }
}

