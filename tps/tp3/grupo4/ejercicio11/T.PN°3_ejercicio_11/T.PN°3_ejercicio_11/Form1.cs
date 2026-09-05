using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.PN_3_ejercicio_11
{
    public partial class Form1 : Form
    {
        bool turnoX = true;
        bool hayGanador = false;
        int victoriasX = 0;
        int victoriasO = 0;
        int empates = 0;
        int jugadas = 0;
        public Form1()
        {
            InitializeComponent();
         
          
        }
        private bool HayGanador()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            {
                return true;
            }
            if (btn4.Text != "" && btn4.Text == btn5.Text && btn4.Text == btn6.Text)
            {
                return true;
            }
            if (btn7.Text != "" && btn7.Text == btn8.Text && btn7.Text == btn9.Text)
            {
                return true;
            }
            if (btn1.Text != "" && btn1.Text == btn4.Text && btn1.Text == btn7.Text)
            {
                return true;
            }
            if (btn2.Text != "" && btn2.Text == btn5.Text && btn2.Text == btn8.Text)
            {
                return true;
            }
            if (btn3.Text != "" && btn3.Text == btn6.Text && btn3.Text == btn9.Text)
            {
                return true;
            }
            if (btn1.Text != "" && btn1.Text == btn5.Text && btn1.Text == btn9.Text)
            {
                return true;
            }
            if (btn3.Text != "" && btn3.Text == btn5.Text && btn3.Text == btn7.Text)
            {
                return true;
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
        

        private void btn1_Click(object sender, EventArgs e)
        {
            if (hayGanador)
            {
                return;
            }
            Button btn = (Button)sender;
            if (btn.Text == "")
            {
                if (turnoX)
                {
                    btn.Text = "X";
                    turnoX = false;
                }
                else
                {
                    btn.Text = "O";
                    turnoX = true;
                }
                jugadas++;
            }
            if(HayGanador())
            {
                if (turnoX) 
                {
                    MessageBox.Show("Ganó el jugador O");
                    victoriasO++;
                }
                else
                {
                    MessageBox.Show("Ganó el jugador X");
                    victoriasX++;
                }
                hayGanador = true;
            }else if(jugadas ==9)
            {
                MessageBox.Show("¡Perdieron juntos, es un empate!");
                empates++;
            }
            lblX.Text = "Victorias X: " + victoriasX;
            lblO.Text = "Victorias O: " + victoriasO;
            lblEmpate.Text = "Empates: " + empates;

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            hayGanador = false;
            turnoX = true;
            jugadas = 0;
        }
    }
}
