using Biblioteca;
using System;
using System.Windows.Forms;

namespace FormClubFutbol
{
    public partial class FormEstadisticas : Form
    {

        private SaveFileDialog saveFileDialog;


        public FormEstadisticas()
        {
            InitializeComponent();
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (.txt)|*.txt|Archivos XML (.xml)|*.xml|Archivos JSON (.json)|*.json";
            saveFileDialog.Title = "Guardar como...";
        }
        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            MostrarEstadisticas();
        }

        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //METODOS

        private void MostrarEstadisticas()
        {
            Estadisticas estadisticas = new Estadisticas();

            rtb_estadisticas.Text = estadisticas.ToString();
        }
    }
}
