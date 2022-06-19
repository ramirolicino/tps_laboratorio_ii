using System;
using System.IO;
using System.Windows.Forms;

namespace FormClubFutbol
{
    public partial class FormMenuPrincipal : Form
    {
        private string rutaEscritorio;
        private string rutaJson;


        public FormMenuPrincipal()
        {
            InitializeComponent();
            rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            rutaJson = Path.Combine(rutaEscritorio, "ClubBernaleza.json");
        }


        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msj = MessageBox.Show("¿Desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = msj == DialogResult.No;
        }

        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_jugadores_Click(object sender, EventArgs e)
        {
            FormPlantilla formPlantilla = new(rutaJson);

            formPlantilla.ShowDialog();
        }

        private void bt_estadisticas_Click(object sender, EventArgs e)
        {
            FormEstadisticas formEstadisticas = new();

            formEstadisticas.Show();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
