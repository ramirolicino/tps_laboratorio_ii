namespace FormClubFutbol
{
    partial class FormEstadisticas
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
            this.bt_cerrar = new System.Windows.Forms.Button();
            this.rtb_estadisticas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cerrar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_cerrar.Location = new System.Drawing.Point(12, 525);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(557, 45);
            this.bt_cerrar.TabIndex = 34;
            this.bt_cerrar.Text = "CERRAR";
            this.bt_cerrar.UseVisualStyleBackColor = false;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // rtb_estadisticas
            // 
            this.rtb_estadisticas.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rtb_estadisticas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_estadisticas.Location = new System.Drawing.Point(12, 12);
            this.rtb_estadisticas.Name = "rtb_estadisticas";
            this.rtb_estadisticas.Size = new System.Drawing.Size(557, 491);
            this.rtb_estadisticas.TabIndex = 35;
            this.rtb_estadisticas.Text = "";
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(585, 573);
            this.Controls.Add(this.rtb_estadisticas);
            this.Controls.Add(this.bt_cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstadisticas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTADISTICAS";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_cerrar;
        private System.Windows.Forms.RichTextBox rtb_estadisticas;
    }
}