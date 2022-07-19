using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClubFutbol
{
    public partial class FormCargaApp : Form
    {

        private Random random;

        public FormCargaApp()
        {
            InitializeComponent();
            random = new Random();
        }

        private void FormCargaApp_Load(object sender, EventArgs e)
        {
            //Hilo
            Task.Run(() => CargaApp(pb_cargaApp, lb_carga));
        }




        //METODO

        /// <summary>
        /// Calcula las estadisitcas y completa la carga al finalizar
        /// </summary>
        /// <param name="progressBar"></param>
        /// <param name="label"></param>
        private void CargaApp(ProgressBar progressBar, Label label)
        {
            while (progressBar.Value < progressBar.Maximum)
            {
                Thread.Sleep(random.Next(50, 250));
                IncrementarBarraProgreso(progressBar, label);
            }
        }

        private async void IncrementarBarraProgreso(ProgressBar progressBar, Label label)
        {
            if (InvokeRequired)
            {
                Action<ProgressBar, Label> delegado = IncrementarBarraProgreso;
                Object[] parametros = new Object[] { progressBar, label };
                Invoke(delegado, parametros);
            }
            else
            {
                progressBar.Increment(5);
                lb_carga.Text = $"Cargando... {progressBar.Value}%";

                if (progressBar.Value == 100)
                {
                    lb_carga.Text = "CARGA COMPLETADA";
                    picture_carga.Visible = false;
                    pictureBox2.Visible = true;
                    lbl_hola.Visible = true;
                    await Task.Delay(2500);
                    this.Close();
                    FormMenuPrincipal formMenuPrincipal = new();
                    formMenuPrincipal.ShowDialog();
                }
            }
        }
    }
}
