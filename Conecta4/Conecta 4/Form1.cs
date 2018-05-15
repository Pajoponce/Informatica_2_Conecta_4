using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conecta_4
{
    public partial class Form1 : Form
    {

        ILogica logica;
        public Form1()
        {
            logica = new Logica();
            InitializeComponent();
            logica.limpiar();
            Render();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Render()
        {
            button44.Text = logica.Marca_O.ToString();
            button45.Text = logica.Marca_X.ToString();
            button1.Text = logica.GetString(0, 0);
            button2.Text = logica.GetString(0, 1);
            button3.Text = logica.GetString(0, 2);
            button4.Text = logica.GetString(0, 3);
            button5.Text = logica.GetString(0, 4);
            button6.Text = logica.GetString(0, 5);
            button7.Text = logica.GetString(0, 6);
            button8.Text = logica.GetString(1, 0);
            button9.Text = logica.GetString(1, 1);
            button10.Text = logica.GetString(1, 2);
            button11.Text = logica.GetString(1, 3);
            button12.Text = logica.GetString(1, 4);
            button13.Text = logica.GetString(1, 5);
            button14.Text = logica.GetString(1, 6);
            button15.Text = logica.GetString(2, 0);
            button16.Text = logica.GetString(2, 1);
            button17.Text = logica.GetString(2, 2);
            button18.Text = logica.GetString(2, 3);
            button19.Text = logica.GetString(2, 4);
            button20.Text = logica.GetString(2, 5);
            button21.Text = logica.GetString(2, 6);
            button22.Text = logica.GetString(3, 0);
            button23.Text = logica.GetString(3, 1);
            button24.Text = logica.GetString(3, 2);
            button25.Text = logica.GetString(3, 3);
            button26.Text = logica.GetString(3, 4);
            button27.Text = logica.GetString(3, 5);
            button28.Text = logica.GetString(3, 6);
            button29.Text = logica.GetString(4, 0);
            button30.Text = logica.GetString(4, 1);
            button31.Text = logica.GetString(4, 2);
            button32.Text = logica.GetString(4, 3);
            button33.Text = logica.GetString(4, 4);
            button34.Text = logica.GetString(4, 5);
            button35.Text = logica.GetString(4, 6);
            button36.Text = logica.GetString(5, 0);
            button37.Text = logica.GetString(5, 1);
            button38.Text = logica.GetString(5, 2);
            button39.Text = logica.GetString(5, 3);
            button40.Text = logica.GetString(5, 4);
            button41.Text = logica.GetString(5, 5);
            button42.Text = logica.GetString(5, 6);
            button46.Text = logica.turno;
        }
        public void vr(int n)
        {
            if (logica.VerificaGanador(n))
            {
                logica.Marcador(n);
                MessageBox.Show("Felicidades! Ganador: " + logica.turnotemp);
                logica.limpiar();
                Render();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                if (logica.ColocarFicha(0))
                {
                    Render();
                    vr(0);
                    checkBox1.Checked = false;
                }

            }
        }
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (logica.ColocarFicha(1))
                {
                    Render();
                    vr(1);
                    checkBox2.Checked = false;
                }

            }
        }
        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox3.Checked)
            {
                if (logica.ColocarFicha(2))
                {
                    Render();
                    vr(2);
                    checkBox3.Checked = false;
                }

            }
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (logica.ColocarFicha(3))
                {
                    Render();
                    vr(3);
                    checkBox4.Checked = false;

                }

            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                if (logica.ColocarFicha(4))
                {
                    Render();
                    vr(4);
                    checkBox5.Checked = false;
                }

            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                if (logica.ColocarFicha(5))
                {
                    Render();
                    vr(5);
                    checkBox6.Checked = false;
                }

            }
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                if (logica.ColocarFicha(6))
                {
                    Render();
                    vr(6);
                    checkBox7.Checked = false;
                }

            }
        }
        private void button43_Click(object sender, EventArgs e)
        {
            logica.limpiar();
            logica.ReiniciarMarcador();
            Render();
        }
        private void button42_Click(object sender, EventArgs e)
        {

        }
        private void button44_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private void button44_Click_1(object sender, EventArgs e)
        {
        }

        private void button45_Click(object sender, EventArgs e)
        {
        }

        private void button42_Click_1(object sender, EventArgs e)
        {

        }
    }
}