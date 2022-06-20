using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FormClubFutbol
{
    public partial class FormJugadores : Form
    {
        private SaveFileDialog saveFileDialog;

        public FormJugadores()
        {
            InitializeComponent();

            this.saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (.txt)|*.txt|Archivos XML (.xml)|*.xml|Archivos JSON (.json)|*.json";
            saveFileDialog.Title = "Guardar como...";
            ClubBernaleza.JugadorAlterado += InformarCarga;
            ClubBernaleza.JugadorAlterado += RefrescarListaJugadores;
        }


        private void FormJugadores_Load(object sender, EventArgs e)
        {
            RefrescarListaJugadores();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (GuardarArchivo())
            {
                MessageBox.Show("ARCHIVO GUARDADO EXITOSAMENTE", "GUARDAR", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("ERROR! NO SE PUDO GUARDAR EL ARCHIVO", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bt_agregar_Click(object sender, EventArgs e)
        {
            FormAltaJugador formAltaJugador = new FormAltaJugador(null);
            formAltaJugador.ShowDialog();
            RefrescarListaJugadores();
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            ModificarJugador();
            ClubBernaleza.ActualizarJugadoresActivos();
        }


        private void bt_baja_Click(object sender, EventArgs e)
        {
            BajaJugador();
            ClubBernaleza.ActualizarJugadoresActivos();
        }


        private void bt_inactivos_Click_1(object sender, EventArgs e)
        {
            MostrarJugadoresInactivos();
        }


        private void FormJugadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msj = MessageBox.Show("¿Desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = msj == DialogResult.No;
        }


        private void bt__cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }








        //METODOS

        private void RefrescarListaJugadores()
        {
            dgv_jugadores.DataSource = null;
            dgv_jugadores.DataSource = JugadorDAO.CargaJugadores(1);
            dgv_jugadores.Update();
            dgv_jugadores.Refresh();
            if (dgv_jugadores.Rows.Count > 0)
            {
                dgv_jugadores.Rows[0].Selected = false;
            }
        }

        private void InformarCarga()
        {
            MessageBox.Show($"JUGADOR ALTERADO CORRECTAMENTE", "Confirmación", MessageBoxButtons.OK);
        }


        private void ModificarJugador()
        {
            if (ClubBernaleza.ListaJugadoresActivos.Count > 0 && dgv_jugadores.SelectedRows.Count > 0)
            {
                Jugador jugadorModificar = JugadorSeleccionado();

                FormAltaJugador formAltaJugador = new FormAltaJugador(jugadorModificar);

                formAltaJugador.ShowDialog();
                ClubBernaleza.ActualizarJugadoresActivos();

            }
            else
            {
                MessageBox.Show("PRIMERO SELECCIONE UN JUGADOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Cambia el  estado de un jugador a inactivo
        /// </summary>
        private void BajaJugador()
        {
            if (ClubBernaleza.ListaJugadoresActivos.Count > 0 && dgv_jugadores.SelectedRows.Count > 0)
            {
                Jugador jugadorSel = JugadorSeleccionado();

                DialogResult dialogResult = MessageBox.Show($"Jugador: {jugadorSel.Apellido}", "DAR DE BAJA", MessageBoxButtons.YesNo);
                if (dialogResult is DialogResult.Yes)
                {
                    try
                    {
                        if (ClubBernaleza.BajaJugador(jugadorSel))
                        {
                            MessageBox.Show($"Jugador {jugadorSel.Apellido} fue dado de BAJA exitosamente");
                            ClubBernaleza.ActualizarJugadoresActivos();
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


        /// <summary>
        /// Extrae el jugador seleccionado 
        /// </summary>
        /// <returns></returns>
        private Jugador JugadorSeleccionado()
        {
            Jugador jugador = null;
            int indice;

            foreach (DataGridViewRow row in dgv_jugadores.SelectedRows)
            {
                indice = row.Index;
                jugador = ClubBernaleza.ListaJugadoresActivos[indice];
            }

            return jugador;
        }


        private bool GuardarArchivo()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ruta = saveFileDialog.FileName;

                try
                {
                    switch (Path.GetExtension(ruta))
                    {
                        case ".json":
                            Archivos<List<Jugador>>.GuardarDatosJson(ruta, ClubBernaleza.ListaJugadoresActivos);
                            return true;
                        //break;

                        case ".xml":
                            Archivos<List<Jugador>>.GuardarDatosXml(ruta, ClubBernaleza.ListaJugadoresActivos);
                            return true;
                        //break;

                        case ".txt":
                            Archivos<List<Jugador>>.GuardarDatosTxt(ruta, ClubBernaleza.MostrarJugadores());
                            return true;
                            //break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        private void MostrarJugadoresInactivos()
        {
            FormJugadoresInactivos formJugadoresInactivos = new();
            formJugadoresInactivos.ShowDialog();
        }
    }
}
