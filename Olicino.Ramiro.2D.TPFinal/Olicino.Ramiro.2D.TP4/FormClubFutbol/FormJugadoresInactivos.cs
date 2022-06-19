using Biblioteca;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormClubFutbol
{
    public partial class FormJugadoresInactivos : Form
    {
        public FormJugadoresInactivos()
        {
            InitializeComponent();
            ClubBernaleza.JugadorAlterado += RefrescarListaJugadores;
            ClubBernaleza.JugadorAlterado += CambioEstadoJugador;
        }

        private void FormJugadoresInactivos_Load(object sender, EventArgs e)
        {
            RefrescarListaJugadores();
        }

        private void bt_alta_Click(object sender, EventArgs e)
        {
            AltaJugador();
        }

        private void FormJugadoresInactivos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msj = MessageBox.Show("¿Desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = msj == DialogResult.No;
        }

        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        //METODOS


        /// <summary>
        /// Acualiza el dataGrid
        /// </summary>
        private void RefrescarListaJugadores()
        {
            dgv_jugadoresInactivos.DataSource = null;
            dgv_jugadoresInactivos.DataSource = JugadorDAO.CargaJugadores(0);
            dgv_jugadoresInactivos.Update();
            dgv_jugadoresInactivos.Refresh();
            if (dgv_jugadoresInactivos.Rows.Count > 0)
            {
                dgv_jugadoresInactivos.Rows[0].Selected = false;
            }
        }


        /// <summary>
        /// Modifica el estado de un jugador, retornando que esta activo 
        /// </summary>
        private void AltaJugador()
        {
            if (ClubBernaleza.ListaJugadoresActivos.Count > 0 && dgv_jugadoresInactivos.SelectedRows.Count > 0)
            {
                Jugador jugadorSel = JugadorSeleccionado();

                DialogResult dialogResult = MessageBox.Show($"Jugador: {jugadorSel.Apellido}", "DAR DE ALTA", MessageBoxButtons.YesNo);
                if (dialogResult is DialogResult.Yes)
                {
                    try
                    {
                        jugadorSel.Estado = true;
                        if (JugadorDAO.EstadoJugador(jugadorSel))
                        {
                            MessageBox.Show($"Jugador {jugadorSel.Apellido} fue dado de ALTA exitosamente");
                            ClubBernaleza.ActualizarJugadoresInactivos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("PRIMERO SELECCIONE UN JUGADOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Jugador JugadorSeleccionado()
        {
            List<Jugador> listaInactivos = JugadorDAO.CargaJugadores(0);

            Jugador jugador = null;
            int indice;

            foreach (DataGridViewRow row in dgv_jugadoresInactivos.SelectedRows)
            {
                indice = row.Index;
                jugador = listaInactivos[indice];
            }

            return jugador;
        }

        private void CambioEstadoJugador()
        {
            MessageBox.Show($"CAMBI0 REALIZADO CORRECTAMENTE", "Confirmación", MessageBoxButtons.OK);
        }
    }
}
