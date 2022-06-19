namespace FormClubFutbol
{
    partial class FormJugadoresInactivos
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
            this.bt_alta = new System.Windows.Forms.Button();
            this.dgv_jugadoresInactivos = new System.Windows.Forms.DataGridView();
            this.bt_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadoresInactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_alta
            // 
            this.bt_alta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_alta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_alta.Location = new System.Drawing.Point(225, 528);
            this.bt_alta.Name = "bt_alta";
            this.bt_alta.Size = new System.Drawing.Size(168, 41);
            this.bt_alta.TabIndex = 12;
            this.bt_alta.Text = "ALTA";
            this.bt_alta.UseVisualStyleBackColor = false;
            this.bt_alta.Click += new System.EventHandler(this.bt_alta_Click);
            // 
            // dgv_jugadoresInactivos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgv_jugadoresInactivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_jugadoresInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_jugadoresInactivos.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_jugadoresInactivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_jugadoresInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jugadoresInactivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_jugadoresInactivos.GridColor = System.Drawing.SystemColors.Info;
            this.dgv_jugadoresInactivos.Location = new System.Drawing.Point(12, 12);
            this.dgv_jugadoresInactivos.Name = "dgv_jugadoresInactivos";
            this.dgv_jugadoresInactivos.ReadOnly = true;
            this.dgv_jugadoresInactivos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_jugadoresInactivos.RowTemplate.Height = 25;
            this.dgv_jugadoresInactivos.Size = new System.Drawing.Size(1270, 475);
            this.dgv_jugadoresInactivos.TabIndex = 11;
            // 
            // bt_cerrar
            // 
            this.bt_cerrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_cerrar.Location = new System.Drawing.Point(12, 528);
            this.bt_cerrar.Name = "bt_cerrar";
            this.bt_cerrar.Size = new System.Drawing.Size(168, 41);
            this.bt_cerrar.TabIndex = 13;
            this.bt_cerrar.Text = "CERRAR";
            this.bt_cerrar.UseVisualStyleBackColor = false;
            this.bt_cerrar.Click += new System.EventHandler(this.bt_cerrar_Click);
            // 
            // FormJugadoresInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1294, 581);
            this.Controls.Add(this.bt_cerrar);
            this.Controls.Add(this.bt_alta);
            this.Controls.Add(this.dgv_jugadoresInactivos);
            this.Name = "FormJugadoresInactivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JUGADORES INACTIVOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJugadoresInactivos_FormClosing);
            this.Load += new System.EventHandler(this.FormJugadoresInactivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadoresInactivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_alta;
        private System.Windows.Forms.DataGridView dgv_jugadoresInactivos;
        private System.Windows.Forms.Button bt_cerrar;
    }
}