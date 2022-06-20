using Entidades;
using System;
using System.Windows.Forms;
using static Entidades.Jugador;

namespace FormClubFutbol
{
    public partial class FormAltaJugador : Form
    {
        private Jugador jugador;


        public FormAltaJugador(Jugador jugador)
        {
            InitializeComponent();
            this.jugador = jugador;
        }

        private void FormAltaJugador_Load(object sender, EventArgs e)
        {
            DeterminarFuncion(jugador);
            CargaCMB();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (jugador is not null)
            {
                GuardarJugadorModificar();
            }
            else
            {
                GuardarJugadorNuevo();
            }
        }

        private void FormAltaJugador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msj = MessageBox.Show("¿Desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = msj == DialogResult.No;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }











        //METODOS

        /// <summary>
        /// Determina si se utiliza para agregar o midificar un jugador 
        /// </summary>
        /// <param name="j"></param>
        private void DeterminarFuncion(Jugador j)
        {
            if (j is null)
            {
                Text = "Agregar Jugador";
                lbl_id.Text = "ID: Sin asignacion";
            }
            else
            {
                Text = "Modificar Jugador";
                lbl_id.Text = $"ID:{jugador.ID.ToString()}";
                txt_Dni.Text = jugador.Dni;
                txt_Nombre.Text = jugador.Nombre;
                txt_Apellido.Text = jugador.Apellido;
                cb_posisiones.Text = jugador.Posision.ToString();
            }
        }

        private void CargaCMB()
        {
            cb_posisiones.Items.Add("");
            cb_posisiones.Items.Add("Arquero");
            cb_posisiones.Items.Add("Defensor");
            cb_posisiones.Items.Add("Mediocampista");
            cb_posisiones.Items.Add("Delantero");
        }




        private void GuardarJugadorNuevo()
        {
            string dni = txt_Dni.Text;
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;
            bool activo = true;


            if (!string.IsNullOrWhiteSpace(dni) &&
               !string.IsNullOrWhiteSpace(nombre) &&
               !string.IsNullOrWhiteSpace(apellido) &&
               cb_posisiones.Text != string.Empty)
            {
                string posicion = cb_posisiones.SelectedItem.ToString();

                jugador = new Jugador(DateTime.Today, dni, nombre, apellido, posicion, activo);

                if (ClubBernaleza.AgregarJugador(jugador))
                {
                    MessageBox.Show("Datos guardados correctamente", "Confirmar", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"Debe completar el/los campo/s", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void GuardarJugadorModificar()
        {
            string dni = txt_Dni.Text;
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;
            bool activo = true;


            if (!string.IsNullOrWhiteSpace(dni) &&
               !string.IsNullOrWhiteSpace(nombre) &&
               !string.IsNullOrWhiteSpace(apellido) &&
               cb_posisiones.Text != string.Empty)
            {
                TipoPosiciones posicion = (TipoPosiciones)cb_posisiones.SelectedIndex;

                jugador = new Jugador(jugador.ID, DateTime.Today, dni, nombre, apellido, ClubBernaleza.CargaPuestoString(posicion), activo);

                if (ClubBernaleza.ModificarJugador(jugador))
                {
                    MessageBox.Show("Datos guardados correctamente", "Confirmar", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"Debe completar el/los campo/s", "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
