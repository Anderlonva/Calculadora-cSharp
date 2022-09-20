namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        float numero1, numero2, resultado;
        string operacion;

        private void button15_Click(object sender, EventArgs e)
        {
            //numero 3 falta refactorizar
            string num = "3";
            txtPrincipal.Text += num;
        }

        private void btn_n0_Click(object sender, EventArgs e)
        {
            string num = "0";
            txtPrincipal.Text += num;
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            string num = "1";
            txtPrincipal.Text += num;
        }

        private void btn_n2_Click(object sender, EventArgs e)
        {
            string num = "2";
            txtPrincipal.Text += num;
        }

        private void btn_n4_Click(object sender, EventArgs e)
        {
            string num = "4";
            txtPrincipal.Text += num;
        }

        private void btn_n5_Click(object sender, EventArgs e)
        {
            string num = "5";
            txtPrincipal.Text += num;
        }

        private void btn_n6_Click(object sender, EventArgs e)
        {
            string num = "6";
            txtPrincipal.Text += num;
        }

        private void btn_n7_Click(object sender, EventArgs e)
        {
            string num = "7";
            txtPrincipal.Text += num;
        }

        private void btn_n8_Click(object sender, EventArgs e)
        {
            string num = "8";
            txtPrincipal.Text += num;
        }

        private void btn_n9_Click(object sender, EventArgs e)
        {
            string num = "9";
            txtPrincipal.Text += num;
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            string num = ".";
            txtPrincipal.Text += num;
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            numero2 = float.Parse(txtPrincipal.Text);

            if (operacion == "sumar")
            {
              resultado = numero1 + numero2;
                txtPrincipal.Text = Convert.ToString(resultado);
            }
            else if (operacion == "restar")
            {
                resultado = numero1 - numero2;
                txtPrincipal.Text = Convert.ToString(resultado);
            }
            else if (operacion == "multiplicar")
            {
                resultado = numero1 * numero2;
                txtPrincipal.Text = Convert.ToString(resultado);
            }
            else if (operacion == "dividir")
            {
                resultado = numero1 / numero2;
                txtPrincipal.Text = Convert.ToString(resultado);
            }


        }

        private void btn_mas_Click(object sender, EventArgs e)
        {
            numero1 = float.Parse(txtPrincipal.Text);
            txtPrincipal.Text = "";
            operacion = "sumar";
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            numero1 = float.Parse(txtPrincipal.Text);
            txtPrincipal.Text = "";
            operacion = "restar";
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            numero1 = float.Parse(txtPrincipal.Text);
            txtPrincipal.Text = "";
            operacion = "multiplicar";
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            numero1 = float.Parse(txtPrincipal.Text);
            txtPrincipal.Text = "";
            operacion = "dividir";
        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "";
        }


      
    }
}