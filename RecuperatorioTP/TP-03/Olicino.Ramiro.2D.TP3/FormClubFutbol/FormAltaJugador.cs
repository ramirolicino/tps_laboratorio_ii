using Biblioteca;
using System;
using System.Windows.Forms;
using static Biblioteca.Jugador;

namespace FormClubFutbol
{
    public partial class FormAltaJugador : Form
    {
        private Jugador jugador;

        public FormAltaJugador(Jugador j)
        {
            InitializeComponent();
            this.jugador = j;
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
                GuardarJugadorMoificado();
            }
            else
            {
                GuardarJugadorNuevo();
            }
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
            }
            else
            {
                Text = "Modificar Jugador";
                txt_Dni.Text = jugador.Dni;
                txt_Nombre.Text = jugador.Nombre;
                txt_Apellido.Text = jugador.Apellido;
            }
        }

        private void CargaCMB()
        {
            cb_posisiones.Items.Add("");
            cb_posisiones.Items.Add(TipoPosiciones.Arquero);
            cb_posisiones.Items.Add(TipoPosiciones.Defensor);
            cb_posisiones.Items.Add(TipoPosiciones.Mediocampista);
            cb_posisiones.Items.Add(TipoPosiciones.Delantero);
        }


        private void GuardarJugadorMoificado()
        {
            string dni = txt_Dni.Text;
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;


            if (!string.IsNullOrWhiteSpace(dni) &&
               !string.IsNullOrWhiteSpace(nombre) &&
               !string.IsNullOrWhiteSpace(apellido) &&
               cb_posisiones.Text != string.Empty)
            {
                TipoPosiciones posicion = (TipoPosiciones)cb_posisiones.SelectedItem;

                jugador = new Jugador(jugador.FechaIngreso, dni, nombre, apellido, posicion);

                ClubBernaleza.ModificarJugador(jugador);
                DialogResult dialogResult = MessageBox.Show("Datos guardados correctamente", "Confirmar", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show($"Debe completar el/los campo/s", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void GuardarJugadorNuevo()
        {
            string dni = txt_Dni.Text;
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;


            if (!string.IsNullOrWhiteSpace(dni) &&
               !string.IsNullOrWhiteSpace(nombre) &&
               !string.IsNullOrWhiteSpace(apellido) &&
               cb_posisiones.Text != string.Empty)
            {
                TipoPosiciones posicion = (TipoPosiciones)cb_posisiones.SelectedItem;

                jugador = new Jugador(DateTime.Today, dni, nombre, apellido, posicion);

                ClubBernaleza.AgregarJugador(jugador);
                DialogResult dialogResult = MessageBox.Show("Datos guardados correctamente", "Confirmar", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show($"Debe completar el/los campo/s", "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
