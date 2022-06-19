using System;
using System.Windows.Forms;

namespace FormClubFutbol
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }


        private void bt_estadisticas_Click(object sender, EventArgs e)
        {
            FormEstadisticas formEstadisticas = new();
            formEstadisticas.Show();
        }

        private void bt_jugadores_Click(object sender, EventArgs e)
        {
            FormJugadores formJugadores = new();
            formJugadores.ShowDialog();
        }

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
