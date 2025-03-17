namespace Almacenamiento_de_datos
{
    partial class frm_XML
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
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Archivo = new System.Windows.Forms.Button();
            this.dtg_Vxml = new System.Windows.Forms.DataGridView();
            this.lbl_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vxml)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Regresar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(635, 344);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(115, 53);
            this.btn_Regresar.TabIndex = 7;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Guardar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(635, 251);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(115, 53);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar cambios";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Archivo
            // 
            this.btn_Archivo.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_Archivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Archivo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Archivo.ForeColor = System.Drawing.Color.White;
            this.btn_Archivo.Location = new System.Drawing.Point(635, 161);
            this.btn_Archivo.Name = "btn_Archivo";
            this.btn_Archivo.Size = new System.Drawing.Size(115, 53);
            this.btn_Archivo.TabIndex = 5;
            this.btn_Archivo.Text = "Cargar Archivo";
            this.btn_Archivo.UseVisualStyleBackColor = false;
            this.btn_Archivo.Click += new System.EventHandler(this.btn_Archivo_Click);
            // 
            // dtg_Vxml
            // 
            this.dtg_Vxml.BackgroundColor = System.Drawing.Color.DimGray;
            this.dtg_Vxml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Vxml.Location = new System.Drawing.Point(12, 32);
            this.dtg_Vxml.Name = "dtg_Vxml";
            this.dtg_Vxml.Size = new System.Drawing.Size(567, 383);
            this.dtg_Vxml.TabIndex = 4;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(605, 61);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(167, 66);
            this.lbl_info.TabIndex = 11;
            this.lbl_info.Text = "Editor de archivos: \r\nXML\r\n\r\n";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_XML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Archivo);
            this.Controls.Add(this.dtg_Vxml);
            this.Name = "frm_XML";
            this.Text = "frm_XML";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vxml)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Archivo;
        private System.Windows.Forms.DataGridView dtg_Vxml;
        private System.Windows.Forms.Label lbl_info;
    }
}