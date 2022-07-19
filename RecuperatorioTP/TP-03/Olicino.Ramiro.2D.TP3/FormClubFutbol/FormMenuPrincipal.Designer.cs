namespace FormClubFutbol
{
    partial class FormMenuPrincipal
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
            this.bt_jugadores = new System.Windows.Forms.Button();
            this.bt_estadisticas = new System.Windows.Forms.Button();
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_jugadores
            // 
            this.bt_jugadores.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_jugadores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_jugadores.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_jugadores.Location = new System.Drawing.Point(61, 245);
            this.bt_jugadores.Name = "bt_jugadores";
            this.bt_jugadores.Size = new System.Drawing.Size(206, 81);
            this.bt_jugadores.TabIndex = 0;
            this.bt_jugadores.Text = "JUGADORES";
            this.bt_jugadores.UseVisualStyleBackColor = false;
            this.bt_jugadores.Click += new System.EventHandler(this.bt_jugadores_Click);
            // 
            // bt_estadisticas
            // 
            this.bt_estadisticas.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_estadisticas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_estadisticas.Location = new System.Drawing.Point(327, 245);
            this.bt_estadisticas.Name = "bt_estadisticas";
            this.bt_estadisticas.Size = new System.Drawing.Size(206, 81);
            this.bt_estadisticas.TabIndex = 1;
            this.bt_estadisticas.Text = "ESTADISTICAS";
            this.bt_estadisticas.UseVisualStyleBackColor = false;
            this.bt_estadisticas.Click += new System.EventHandler(this.bt_estadisticas_Click);
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cerrar.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_cerrar.Location = new System.Drawing.Point(61, 362);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(472, 93);
            this.bt_cerrar.TabIndex = 2;
            this.bt_cerrar.Text = "CERRAR";
            this.bt_cerrar.UseVisualStyleBackColor = false;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormClubFutbol.Properties.Resources.club;
            this.pictureBox1.Location = new System.Drawing.Point(167, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(607, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_cerrar);
            this.Controls.Add(this.bt_estadisticas);
            this.Controls.Add(this.bt_jugadores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_jugadores;
        private System.Windows.Forms.Button bt_estadisticas;
        private System.Windows.Forms.Button bt_cerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}