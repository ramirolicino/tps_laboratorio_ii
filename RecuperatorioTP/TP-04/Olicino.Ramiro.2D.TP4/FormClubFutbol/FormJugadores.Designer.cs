namespace FormClubFutbol
{
    partial class FormJugadores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_baja = new System.Windows.Forms.Button();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt__cerrar = new System.Windows.Forms.Button();
            this.dgv_jugadores = new System.Windows.Forms.DataGridView();
            this.bt_inactivos = new System.Windows.Forms.Button();
            this.bt_carga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_agregar
            // 
            this.bt_agregar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_agregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_agregar.Location = new System.Drawing.Point(12, 512);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(168, 41);
            this.bt_agregar.TabIndex = 11;
            this.bt_agregar.Text = "AGREGAR";
            this.bt_agregar.UseVisualStyleBackColor = false;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // bt_baja
            // 
            this.bt_baja.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_baja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_baja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_baja.Location = new System.Drawing.Point(207, 573);
            this.bt_baja.Name = "bt_baja";
            this.bt_baja.Size = new System.Drawing.Size(168, 41);
            this.bt_baja.TabIndex = 10;
            this.bt_baja.Text = "BAJA";
            this.bt_baja.UseVisualStyleBackColor = false;
            this.bt_baja.Click += new System.EventHandler(this.bt_baja_Click);
            // 
            // bt_modificar
            // 
            this.bt_modificar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_modificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_modificar.Location = new System.Drawing.Point(12, 573);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(168, 41);
            this.bt_modificar.TabIndex = 9;
            this.bt_modificar.Text = "MODIFICAR";
            this.bt_modificar.UseVisualStyleBackColor = false;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_guardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_guardar.Location = new System.Drawing.Point(940, 512);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(168, 41);
            this.bt_guardar.TabIndex = 8;
            this.bt_guardar.Text = "GUARDAR";
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // bt__cerrar
            // 
            this.bt__cerrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt__cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt__cerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt__cerrar.Location = new System.Drawing.Point(1114, 573);
            this.bt__cerrar.Name = "bt__cerrar";
            this.bt__cerrar.Size = new System.Drawing.Size(168, 41);
            this.bt__cerrar.TabIndex = 7;
            this.bt__cerrar.Text = "CERRAR";
            this.bt__cerrar.UseVisualStyleBackColor = false;
            this.bt__cerrar.Click += new System.EventHandler(this.bt__cerrar_Click);
            // 
            // dgv_jugadores
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgv_jugadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_jugadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_jugadores.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_jugadores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jugadores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_jugadores.GridColor = System.Drawing.SystemColors.Info;
            this.dgv_jugadores.Location = new System.Drawing.Point(12, 12);
            this.dgv_jugadores.Name = "dgv_jugadores";
            this.dgv_jugadores.ReadOnly = true;
            this.dgv_jugadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_jugadores.RowTemplate.Height = 25;
            this.dgv_jugadores.Size = new System.Drawing.Size(1270, 479);
            this.dgv_jugadores.TabIndex = 6;
            // 
            // bt_inactivos
            // 
            this.bt_inactivos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_inactivos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_inactivos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_inactivos.Location = new System.Drawing.Point(418, 573);
            this.bt_inactivos.Name = "bt_inactivos";
            this.bt_inactivos.Size = new System.Drawing.Size(311, 41);
            this.bt_inactivos.TabIndex = 12;
            this.bt_inactivos.Text = "JUGADORES INACTIVOS";
            this.bt_inactivos.UseVisualStyleBackColor = false;
            this.bt_inactivos.Click += new System.EventHandler(this.bt_inactivos_Click_1);
            // 
            // bt_carga
            // 
            this.bt_carga.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_carga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_carga.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_carga.Location = new System.Drawing.Point(1114, 512);
            this.bt_carga.Name = "bt_carga";
            this.bt_carga.Size = new System.Drawing.Size(168, 41);
            this.bt_carga.TabIndex = 13;
            this.bt_carga.Text = "CARGA JUGADORES";
            this.bt_carga.UseVisualStyleBackColor = false;
            this.bt_carga.Click += new System.EventHandler(this.bt_carga_Click);
            // 
            // FormJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1294, 628);
            this.Controls.Add(this.bt_carga);
            this.Controls.Add(this.bt_inactivos);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.bt_baja);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.bt__cerrar);
            this.Controls.Add(this.dgv_jugadores);
            this.Name = "FormJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JUGADORES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJugadores_FormClosing);
            this.Load += new System.EventHandler(this.FormJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_baja;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Button bt__cerrar;
        private System.Windows.Forms.DataGridView dgv_jugadores;
        private System.Windows.Forms.Button bt_inactivos;
        private System.Windows.Forms.Button bt_carga;
    }
}