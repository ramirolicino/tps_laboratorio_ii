using System;
using System.Windows.Forms;

namespace FormClubFutbol
{
    public partial class FormIngreso : Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void bt_ingresar_Click_1(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string pass = txt_pass.Text;

            if (usuario is "user_RamirOlicino" && pass is "123456789")
            {
                FormCargaApp formCargaApp = new();

                formCargaApp.ShowDialog();
            }
            else
            {
                MessageBox.Show("INGRESE NUEVAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormIngreso_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult msj = MessageBox.Show("¿Desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = msj == DialogResult.No;
        }


        private void bt_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void bt_rellenarUsuario_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "user_RamirOlicino";
            txt_pass.Text = "123456789";
        }
    }
}
