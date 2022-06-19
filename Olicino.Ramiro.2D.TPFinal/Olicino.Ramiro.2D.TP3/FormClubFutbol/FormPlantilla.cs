using Biblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FormClubFutbol
{
    public partial class FormPlantilla : Form
    {
        private string rutaJson;
        private SaveFileDialog saveFileDialog;


        public FormPlantilla(string ruta)
        {
            InitializeComponent();
            this.rutaJson = ruta;
            this.saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (.txt)|*.txt|Archivos XML (.xml)|*.xml|Archivos JSON (.json)|*.json";
            saveFileDialog.Title = "Guardar como...";
        }

        private void FormPlantilla_Load(object sender, EventArgs e)
        {
            ActualizarPlantilla();
        }


        private void bt_agregar_Click(object sender, EventArgs e)
        {
            FormAltaJugador formAltaJugador = new(null);

            formAltaJugador.ShowDialog();
            ActualizarPlantilla();
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


        private void bt_modificar_Click(object sender, EventArgs e)
        {
            ModificarJugador();
        }


        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            EliminarJugador(rutaJson);
        }

        private void FormPlantilla_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msj = MessageBox.Show("¿Desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = msj == DialogResult.No;
        }

        private void bt__cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        //METODOS


        /// <summary>
        /// Actualiza la plantilla de jugadores
        /// </summary>
        private void ActualizarPlantilla()
        {
            dgv_jugadores.DataSource = null;
            dgv_jugadores.DataSource = ClubBernaleza.ListaJugadores;
            dgv_jugadores.Update();
            dgv_jugadores.Refresh();
            if (dgv_jugadores.Rows.Count > 0)
            {
                dgv_jugadores.Rows[0].Selected = false;
            }
        }


        private void ModificarJugador()
        {
            if (ClubBernaleza.ListaJugadores.Count > 0 && dgv_jugadores.SelectedRows.Count > 0)
            {
                Jugador jugadorModificar = JugadorSeleccionado();

                FormAltaJugador formAltaJugador = new FormAltaJugador(jugadorModificar);

                formAltaJugador.ShowDialog();
                ActualizarPlantilla();
            }
            else
            {
                MessageBox.Show("PRIMERO SELECCIONE UN JUGADOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EliminarJugador(string ruta)
        {
            if (ClubBernaleza.ListaJugadores.Count > 0 && dgv_jugadores.SelectedRows.Count > 0)
            {
                Jugador jugadorEliminar = JugadorSeleccionado();

                DialogResult dialogResult = MessageBox.Show($"Jugador a eliminar: {jugadorEliminar.Apellido}", "ELIMINAR", MessageBoxButtons.YesNo);
                if (dialogResult is DialogResult.Yes)
                {
                    try
                    {
                        ClubBernaleza.EliminarJugador(jugadorEliminar);
                        ActualizarPlantilla();
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
                jugador = ClubBernaleza.ListaJugadores[indice];
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
                            Archivos<List<Jugador>>.GuardarDatosJson(ruta, ClubBernaleza.ListaJugadores);
                            return true;
                        //break;

                        case ".xml":
                            Archivos<List<Jugador>>.GuardarDatosXml(ruta, ClubBernaleza.ListaJugadores);
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
    }
}
