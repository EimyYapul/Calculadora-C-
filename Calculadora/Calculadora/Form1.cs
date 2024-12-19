using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double memoria1;
        double memoria2;
        double resultado;
        int numvec;
        string signo;

        public Form1()
        {
            InitializeComponent();
        }

        public bool existepunto(string cadena)
        {
            int largo; ;
            string cad2 = "";
            bool respuesta = false;
            largo = cadena.Length;
            for (int i = 1; i < largo; i++)
            {
                cad2 = cadena.Substring(i, 1);
                if (cad2 == ",")
                    if (cad2 == ",")
                    {
                        respuesta = true;

                    }

            }
            return respuesta;
        }

        public void calculadora()
        {
            switch (signo)
            {
                case "+":
                    memoria1 = memoria1 + memoria2;
                    textBox1.Text = memoria1.ToString();
                    textBox1.SelectionStart = textBox1.Text.Length + 1;
                    label1.Text = memoria1.ToString();
                    memoria1 = 0;
                    memoria2 = 0;
                    textBox1.Select(textBox1.Text.Length, 0);
                    break;
                //FUNCION SUMAA

                case "-":
                    memoria1 = memoria1 - memoria2;
                    textBox1.Text = memoria1.ToString();
                    textBox1.SelectionStart = textBox1.Text.Length + 1;
                    label1.Text = memoria1.ToString();
                    memoria1 = 0;
                    memoria2 = 0;
                    textBox1.Select(textBox1.Text.Length, 0);
                    break;
                //FUNCION RESTA

                case "*":
                    memoria1 = memoria1 * memoria2;
                    textBox1.Text = memoria1.ToString();
                    textBox1.SelectionStart = textBox1.Text.Length + 1;
                    label1.Text = memoria1.ToString();
                    memoria1 = 0;
                    memoria2 = 0;
                    textBox1.Select(textBox1.Text.Length, 0);
                    break;
                //FUNCION MULTIPLICACION

                case "/":
                    if (memoria2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0 cabron");
                    }
                    memoria1 = memoria1 / memoria2;
                    textBox1.Text = memoria1.ToString();
                    textBox1.SelectionStart = textBox1.Text.Length + 1;
                    label1.Text = memoria1.ToString();
                    memoria1 = 0;
                    memoria2 = 0;
                    textBox1.Select(textBox1.Text.Length, 0);
                    break;

                   //FUNCION DIVISION
                case "mod":
                    memoria1 = memoria1 % memoria2;
                    textBox1.Text = memoria1.ToString();
                    textBox1.SelectionStart = textBox1.Text.Length + 1;
                    label1.Text = memoria1.ToString();
                    memoria1 = 0;
                    memoria2 = 0;
                    textBox1.Select(textBox1.Text.Length, 0);
                    break;
                //FUNCION MOD
 
                case "√":
                    resultado = Math.Sqrt(memoria1);
                    textBox1.Text = resultado.ToString();
                    label1.Text = resultado.ToString();
                    break;
                //FUCION RAIZ CUADRADA

                case "%":
                    memoria1 = memoria1 * memoria2 / 100;
                    textBox1.Text = memoria1.ToString();
                    textBox1.SelectionStart = textBox1.Text.Length + 1;
                    label1.Text = memoria1.ToString();
                    memoria1 = 0;
                    memoria2 = 0;
                    textBox1.Select(textBox1.Text.Length, 0);
                    break;
                //FUNCION POR CIENTO  

                case "^":
                    memoria1 = Math.Pow(memoria1, memoria2);
                    textBox1.Text = memoria1.ToString();
                    textBox1.SelectionStart = textBox1.Text.Length + 1;
                    label1.Text = memoria1.ToString();
                    memoria1 = 0;
                    memoria2 = 0;
                    textBox1.Select(textBox1.Text.Length, 0);
                    break;
                //FUNCION EXPONENCIACION

               

            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            label1.Text = label1.Text + "9";
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            label1.Text = label1.Text + "1";
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            this.ActiveControl = textBox1;
            textBox1.Select();
            label1.Text = "";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar)) || e.KeyChar == 8 || e.KeyChar == '.';

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            label1.Text = label1.Text + "2";
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            label1.Text = label1.Text + "3";
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            label1.Text = label1.Text + "4";
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            label1.Text = label1.Text + "5";
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            label1.Text = label1.Text + "6";
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            label1.Text = label1.Text + "7";
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            label1.Text = label1.Text + "8";
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            label1.Text = label1.Text + "0";
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0.";
                label1.Text = "0.";

            }
            else if (existepunto(textBox1.Text) == false)
            {
                textBox1.Text = textBox1.Text + ".";
                label1.Text = label1.Text + ".";
                textBox1.Select();
                textBox1.Select(textBox1.Text.Length, 0);
            }

        }

        //suma

        private void button16_Click(object sender, EventArgs e)
        {
            memoria1 = memoria2 + float.Parse(textBox1.Text);
            signo = "+";
            label1.Text = label1.Text + "+";
            textBox1.Clear();
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);



        }

        //Mutiplicacion 

        private void button12_Click(object sender, EventArgs e)
        {

            memoria1 = memoria2 + float.Parse(textBox1.Text);
            signo = "*";
            label1.Text = label1.Text + "x";
            textBox1.Clear();
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        //resta

        private void button13_Click(object sender, EventArgs e)
        {
            memoria1 = memoria1 + float.Parse(textBox1.Text);
            signo = "-";
            label1.Text = label1.Text + "-";
            textBox1.Clear();
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        //Division
        private void button9_Click(object sender, EventArgs e)
        {
            memoria1 = memoria1 + float.Parse(textBox1.Text);
            signo = "/";
            label1.Text = label1.Text + "÷";
            textBox1.Clear();
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);

        }


        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            /*memoria2 =doubleParse(texbox1.Text);
             calculadora();*/

            try
            {
                {
                    if ((textBox1.Text != "") && memoria1 != 0.0)
                    {
                        memoria2 = float.Parse(textBox1.Text);
                        textBox1.Clear();
                        calculadora();
                    }
                    if ((signo == "v") && (memoria1 != 0.0))
                    {
                        calculadora();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Info del error: " + ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            memoria1 = memoria1 + float.Parse(textBox1.Text);
            signo = "mod";
            label1.Text = label1.Text + "MOD";
            textBox1.Clear();
            textBox1.Select();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    memoria1 = float.Parse(textBox1.Text);
                    memoria1 = Math.Sqrt(memoria1);
                    //signo = "√";
                    //label1.Text = "√" + label1.Text;
                    label1.Text = memoria1.ToString();
                    textBox1.Clear();
                }
                else { MessageBox.Show("La caja de texto no puede estar vacia"); }
            }

            catch (Exception ex)
            { 
                MessageBox.Show("Informacion de el error" + ex.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    memoria1 = float.Parse(textBox1.Text);
                    signo = "%";
                    label1.Text = label1.Text + "%";
                    textBox1.Clear();
                }
                else { MessageBox.Show("La caja de texto no puede estar vacia"); }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Informacion de el error" + ex.Message);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    memoria1 = float.Parse(textBox1.Text);
                    signo = "^";
                    label1.Text = label1.Text + "^";
                    textBox1.Clear();
                }
                else { MessageBox.Show("La caja de texto no puede estar vacia"); }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Informacion de el error" + ex.Message);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    label1.Text = (Math.Pow(float.Parse(textBox1.Text), 2)).ToString();
                    textBox1.Text = label1.Text;
                }

                else
                {
                    MessageBox.Show("La caja de texto no puede estar vacia");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Informacion de el error" + ex.Message);
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    label1.Text = (Math.Pow(float.Parse(textBox1.Text), 3)).ToString();
                    textBox1.Text = label1.Text;
                }

                else
                {
                    MessageBox.Show("La caja de texto no puede estar vacia");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Informacion de el error" + ex.Message);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    label1.Text = (Math.Log(float.Parse(textBox1.Text))).ToString();
                    textBox1.Text = label1.Text;
                }

                else
                {
                    MessageBox.Show("La caja de texto no puede estar vacia");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Informacion de el error" + ex.Message);
            }
        }

     

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    label1.Text = (Math.Cos(float.Parse(textBox1.Text))).ToString();
                    textBox1.Text = label1.Text;
                }

                else
                {
                    MessageBox.Show("La caja de texto no puede estar vacia");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Informacion de el error" + ex.Message);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    label1.Text = (Math.Sin(float.Parse(textBox1.Text))).ToString();
                    textBox1.Text = label1.Text;
                }

                else
                {
                    MessageBox.Show("La caja de texto no puede estar vacia");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Informacion de el error" + ex.Message);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    label1.Text = (Math.Tan(float.Parse(textBox1.Text))).ToString();
                    textBox1.Text = label1.Text;
                }

                else
                {
                    MessageBox.Show("La caja de texto no puede estar vacia");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Informacion de el error" + ex.Message);
            }
        }


        private void button32_Click(object sender, EventArgs e)
        {
            long binario = 0;
            int numero;
            numero = int.Parse(textBox2.Text);
            const int DIVISOR = 2;
            long digito = 0;

            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                binario += digito * (long)Math.Pow(10, j);
            }

            textBox2.Text = binario.ToString();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar)) || e.KeyChar == 8 || e.KeyChar == '.';
        }
    }
}
