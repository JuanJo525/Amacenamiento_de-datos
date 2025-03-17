namespace Almacenamiento_de_datos
{
    partial class frm_CSV
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
            this.dtg_Vista = new System.Windows.Forms.DataGridView();
            this.btn_Archivo = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vista)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Vista
            // 
            this.dtg_Vista.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtg_Vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Vista.Location = new System.Drawing.Point(12, 32);
            this.dtg_Vista.Name = "dtg_Vista";
            this.dtg_Vista.Size = new System.Drawing.Size(567, 383);
            this.dtg_Vista.TabIndex = 0;
            this.dtg_Vista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Vista_CellContentClick);
            // 
            // btn_Archivo
            // 
            this.btn_Archivo.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_Archivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Archivo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Archivo.ForeColor = System.Drawing.Color.White;
            this.btn_Archivo.Location = new System.Drawing.Point(638, 164);
            this.btn_Archivo.Name = "btn_Archivo";
            this.btn_Archivo.Size = new System.Drawing.Size(115, 53);
            this.btn_Archivo.TabIndex = 1;
            this.btn_Archivo.Text = "Cargar Archivo";
            this.btn_Archivo.UseVisualStyleBackColor = false;
            this.btn_Archivo.Click += new System.EventHandler(this.btn_Archivo_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Guardar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(638, 254);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(115, 53);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar cambios";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Regresar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(638, 347);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(115, 53);
            this.btn_Regresar.TabIndex = 3;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(611, 61);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(167, 44);
            this.lbl_info.TabIndex = 11;
            this.lbl_info.Text = "Editor de archivos: \r\nCSV\r\n";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_CSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Archivo);
            this.Controls.Add(this.dtg_Vista);
            this.Name = "frm_CSV";
            this.Text = "frm_CSV";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Vista;
        private System.Windows.Forms.Button btn_Archivo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Label lbl_info;
    }
}