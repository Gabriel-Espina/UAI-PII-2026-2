namespace ejercicio_7_listas
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
            cmdAgregarAlPrincipio = new Button();
            cmdAgregarAlFinal = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            listaNodos = new ListBox();
            btnQuitarPrimero = new Button();
            btnQuitarUltimo = new Button();
            btnQuitarSeleccionado = new Button();
            btnIntercambiarDerecha = new Button();
            btnIntercambiarIzquierda = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            btnIntercambiar = new Button();
            SuspendLayout();
            // 
            // cmdAgregarAlPrincipio
            // 
            cmdAgregarAlPrincipio.Location = new Point(47, 104);
            cmdAgregarAlPrincipio.Name = "cmdAgregarAlPrincipio";
            cmdAgregarAlPrincipio.Size = new Size(124, 23);
            cmdAgregarAlPrincipio.TabIndex = 0;
            cmdAgregarAlPrincipio.Text = "Agregar al principio";
            cmdAgregarAlPrincipio.UseVisualStyleBackColor = true;
            cmdAgregarAlPrincipio.Click += cmdAgregarAlPrincipio_Click;
            // 
            // cmdAgregarAlFinal
            // 
            cmdAgregarAlFinal.Location = new Point(189, 104);
            cmdAgregarAlFinal.Name = "cmdAgregarAlFinal";
            cmdAgregarAlFinal.Size = new Size(121, 23);
            cmdAgregarAlFinal.TabIndex = 1;
            cmdAgregarAlFinal.Text = "Agregar al final";
            cmdAgregarAlFinal.UseVisualStyleBackColor = true;
            cmdAgregarAlFinal.Click += cmdAgregarAlFinal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Número";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 162);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "Lista de nodos";
            // 
            // listaNodos
            // 
            listaNodos.FormattingEnabled = true;
            listaNodos.Location = new Point(49, 203);
            listaNodos.Name = "listaNodos";
            listaNodos.Size = new Size(261, 94);
            listaNodos.TabIndex = 5;
            // 
            // btnQuitarPrimero
            // 
            btnQuitarPrimero.Location = new Point(48, 315);
            btnQuitarPrimero.Name = "btnQuitarPrimero";
            btnQuitarPrimero.Size = new Size(115, 23);
            btnQuitarPrimero.TabIndex = 6;
            btnQuitarPrimero.Text = "Quitar primero";
            btnQuitarPrimero.UseVisualStyleBackColor = true;
            btnQuitarPrimero.Click += btnQuitarPrimero_Click_1;
            // 
            // btnQuitarUltimo
            // 
            btnQuitarUltimo.Location = new Point(189, 315);
            btnQuitarUltimo.Name = "btnQuitarUltimo";
            btnQuitarUltimo.Size = new Size(121, 23);
            btnQuitarUltimo.TabIndex = 7;
            btnQuitarUltimo.Text = "Quitar último";
            btnQuitarUltimo.UseVisualStyleBackColor = true;
            btnQuitarUltimo.Click += btnQuitarUltimo_Click_1;
            // 
            // btnQuitarSeleccionado
            // 
            btnQuitarSeleccionado.Location = new Point(48, 359);
            btnQuitarSeleccionado.Name = "btnQuitarSeleccionado";
            btnQuitarSeleccionado.Size = new Size(196, 23);
            btnQuitarSeleccionado.TabIndex = 8;
            btnQuitarSeleccionado.Text = "Quitar seleccionado";
            btnQuitarSeleccionado.UseVisualStyleBackColor = true;
            btnQuitarSeleccionado.Click += btnQuitarSeleccionado_Click_1;
            // 
            // btnIntercambiarDerecha
            // 
            btnIntercambiarDerecha.Location = new Point(47, 413);
            btnIntercambiarDerecha.Name = "btnIntercambiarDerecha";
            btnIntercambiarDerecha.Size = new Size(195, 23);
            btnIntercambiarDerecha.TabIndex = 9;
            btnIntercambiarDerecha.Text = "Intercambiar derecha";
            btnIntercambiarDerecha.UseVisualStyleBackColor = true;
            btnIntercambiarDerecha.Click += btnIntercambiarDerecha_Click_1;
            // 
            // btnIntercambiarIzquierda
            // 
            btnIntercambiarIzquierda.Location = new Point(47, 460);
            btnIntercambiarIzquierda.Name = "btnIntercambiarIzquierda";
            btnIntercambiarIzquierda.Size = new Size(197, 23);
            btnIntercambiarIzquierda.TabIndex = 10;
            btnIntercambiarIzquierda.Text = "Intercambiar izquierda";
            btnIntercambiarIzquierda.UseVisualStyleBackColor = true;
            btnIntercambiarIzquierda.Click += btnIntercambiarIzquierda_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 508);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 11;
            label3.Text = "Segundo número:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 505);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 12;
            // 
            // btnIntercambiar
            // 
            btnIntercambiar.Location = new Point(55, 557);
            btnIntercambiar.Name = "btnIntercambiar";
            btnIntercambiar.Size = new Size(187, 23);
            btnIntercambiar.TabIndex = 13;
            btnIntercambiar.Text = "Intercambiar";
            btnIntercambiar.UseVisualStyleBackColor = true;
            btnIntercambiar.Click += btnIntercambiar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 610);
            Controls.Add(btnIntercambiar);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(btnIntercambiarIzquierda);
            Controls.Add(btnIntercambiarDerecha);
            Controls.Add(btnQuitarSeleccionado);
            Controls.Add(btnQuitarUltimo);
            Controls.Add(btnQuitarPrimero);
            Controls.Add(listaNodos);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(cmdAgregarAlFinal);
            Controls.Add(cmdAgregarAlPrincipio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAgregarAlPrincipio;
        private Button cmdAgregarAlFinal;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ListBox listaNodos;
        private Button btnQuitarPrimero;
        private Button btnQuitarUltimo;
        private Button btnQuitarSeleccionado;
        private Button btnIntercambiarDerecha;
        private Button btnIntercambiarIzquierda;
        private Label label3;
        private TextBox textBox2;
        private Button btnIntercambiar;
    }
}
