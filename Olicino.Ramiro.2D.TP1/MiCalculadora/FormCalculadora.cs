using Entidades;
using System;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void bt_operar_Click(object sender, EventArgs e)
        {
            string num1 = txt_num1.Text;
            string num2 = txt_num2.Text;
            string operador = cb_operadores.Text;
            double rta = Operar(num1, num2, operador);
            lbl_resultado.Text = rta.ToString();

            if (num1 == string.Empty)
            {
                num1 = "0";
            }
            if (num2 == string.Empty)
            {
                num2 = "0";
            }
            if (operador == " ")
            {
                operador = "+";
            }


            lst_resultados.Items.Add($"{num1} {operador} {num2} = {rta}");
        }

        private void bt_binario_Click(object sender, EventArgs e)
        {
            string rta = lbl_resultado.Text;

            if (double.TryParse(rta, out double aux))
            {
                Operando operando = new Operando(rta);
                string numeroBinario = operando.DecimalBinario(rta);
                if (aux >= 0)
                {
                    lst_resultados.Items.Add($"Dec {rta} Bin {numeroBinario}");
                }

                lbl_resultado.Text = numeroBinario;
            }
            else
            {
                MessageBox.Show("Ingese valor valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_decimal_Click(object sender, EventArgs e)
        {
            string rta = lbl_resultado.Text;

            if (double.TryParse(rta, out double num))
            {
                Operando operador = new Operando(rta);
                string numeroDecimal = operador.BinarioDecimal(rta);
                if (int.TryParse(numeroDecimal, out int num2))
                {
                    lst_resultados.Items.Add($"Dec {rta} Bin {numeroDecimal}");
                }

                lbl_resultado.Text = numeroDecimal;
            }
            else
            {
                MessageBox.Show("Ingese valor valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //METODOS

        /// <summary>
        /// Realiza la operacion determinada con los numeros ingersados 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de la operacion realizada </returns>
        private static double Operar(string num1, string num2, string operador)
        {
            Operando operador1 = new Operando(num1);
            Operando operador2 = new Operando(num2);
            char operadorChar = char.Parse(operador);

            return Calculadora.Operar(operador1, operador2, operadorChar);
        }

        /// <summary>
        /// Refresca los campos, dejandolos sin asignaciones
        /// </summary>
        private void Limpiar()
        {
            txt_num1.Clear();
            txt_num2.Clear();
            cb_operadores.SelectedIndex = 0;
            lbl_resultado.Text = "0";
        }
    }
}
