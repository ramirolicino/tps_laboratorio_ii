using Entidades;
using System;
using System.Windows.Forms;

namespace FormClubFutbol
{

    public partial class FormEstadisticas : Form
    {
        private Estadisticas estadisticas;

        public FormEstadisticas()
        {
            InitializeComponent();
            estadisticas = new Estadisticas();
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            MostrarEstadisticas();
        }

        private void bt_cargaSQL_Click(object sender, EventArgs e)
        {
            CargaSQL(estadisticas);
        }


        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        //METODOS


        /// <summary>
        /// Muestra las estadisticas del club/jugadores
        /// </summary>
        private void MostrarEstadisticas()
        {
            dgv_estadisticas.DataSource = null;
            dgv_estadisticas.DataSource = EstadisticasDAO.CargarEstadisticas();
            dgv_estadisticas.Update();
            dgv_estadisticas.Refresh();
            if (dgv_estadisticas.Rows.Count > 0)
            {
                dgv_estadisticas.Rows[0].Selected = false;
            }
        }


        /// <summary>
        /// Carga las estadisticas a la db
        /// </summary>
        /// <param name="e"></param>
        private void CargaSQL(Estadisticas e)
        {

            if (EstadisticasDAO.AgregarEstadisticas(estadisticas))
            {
                MessageBox.Show("SQL CARGADO EXITOSAMENTE", "GUARDAR", MessageBoxButtons.OK);
                MostrarEstadisticas();
            }
            else
            {
                MessageBox.Show("ERROR! NO SE PUDO CARGADO SQL", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
