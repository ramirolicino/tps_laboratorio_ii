namespace FormClubFutbol
{
    partial class FormAltaJugador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_posisiones = new System.Windows.Forms.ComboBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_posisiones
            // 
            this.cb_posisiones.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cb_posisiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_posisiones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_posisiones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_posisiones.FormattingEnabled = true;
            this.cb_posisiones.Location = new System.Drawing.Point(129, 244);
            this.cb_posisiones.Name = "cb_posisiones";
            this.cb_posisiones.Size = new System.Drawing.Size(150, 28);
            this.cb_posisiones.TabIndex = 32;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelar.Location = new System.Drawing.Point(21, 363);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(148, 41);
            this.btCancelar.TabIndex = 31;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGuardar.Location = new System.Drawing.Point(232, 363);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(148, 41);
            this.btGuardar.TabIndex = 30;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_Nombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Nombre.Location = new System.Drawing.Point(129, 101);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "      Ingrese Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(150, 27);
            this.txt_Nombre.TabIndex = 29;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_Apellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Apellido.Location = new System.Drawing.Point(129, 178);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.PlaceholderText = "     Ingrese Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(150, 27);
            this.txt_Apellido.TabIndex = 28;
            // 
            // txt_Dni
            // 
            this.txt_Dni.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_Dni.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Dni.Location = new System.Drawing.Point(129, 32);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.PlaceholderText = "       Ingrese D.N.I";
            this.txt_Dni.Size = new System.Drawing.Size(150, 27);
            this.txt_Dni.TabIndex = 27;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.Location = new System.Drawing.Point(3, 4);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(41, 21);
            this.lbl_id.TabIndex = 33;
            this.lbl_id.Text = "ID: X";
            // 
            // FormAltaJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(404, 411);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.cb_posisiones);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Dni);
            this.Name = "FormAltaJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAltaJugador_FormClosing);
            this.Load += new System.EventHandler(this.FormAltaJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_posisiones;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.Label lbl_id;
    }
}