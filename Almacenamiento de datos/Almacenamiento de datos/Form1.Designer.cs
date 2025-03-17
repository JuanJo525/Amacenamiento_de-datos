namespace Almacenamiento_de_datos
{
    partial class frm_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_FormCSV = new System.Windows.Forms.Button();
            this.btn_fTXT = new System.Windows.Forms.Button();
            this.bnt_fXML = new System.Windows.Forms.Button();
            this.lbl__Inicio = new System.Windows.Forms.Label();
            this.btn_fRTF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_FormCSV
            // 
            this.btn_FormCSV.BackColor = System.Drawing.Color.Black;
            this.btn_FormCSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FormCSV.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FormCSV.ForeColor = System.Drawing.Color.White;
            this.btn_FormCSV.Location = new System.Drawing.Point(39, 256);
            this.btn_FormCSV.Name = "btn_FormCSV";
            this.btn_FormCSV.Size = new System.Drawing.Size(155, 76);
            this.btn_FormCSV.TabIndex = 0;
            this.btn_FormCSV.Text = "Archivo CSV";
            this.btn_FormCSV.UseVisualStyleBackColor = false;
            this.btn_FormCSV.Click += new System.EventHandler(this.btn_FormCSV_Click);
            // 
            // btn_fTXT
            // 
            this.btn_fTXT.BackColor = System.Drawing.Color.Black;
            this.btn_fTXT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fTXT.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fTXT.ForeColor = System.Drawing.Color.White;
            this.btn_fTXT.Location = new System.Drawing.Point(225, 257);
            this.btn_fTXT.Name = "btn_fTXT";
            this.btn_fTXT.Size = new System.Drawing.Size(155, 75);
            this.btn_fTXT.TabIndex = 1;
            this.btn_fTXT.Text = "Archivo TXT";
            this.btn_fTXT.UseVisualStyleBackColor = false;
            this.btn_fTXT.Click += new System.EventHandler(this.btn_fTXT_Click);
            // 
            // bnt_fXML
            // 
            this.bnt_fXML.BackColor = System.Drawing.Color.Black;
            this.bnt_fXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnt_fXML.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_fXML.ForeColor = System.Drawing.Color.White;
            this.bnt_fXML.Location = new System.Drawing.Point(408, 257);
            this.bnt_fXML.Name = "bnt_fXML";
            this.bnt_fXML.Size = new System.Drawing.Size(155, 75);
            this.bnt_fXML.TabIndex = 2;
            this.bnt_fXML.Text = "Archivo XML";
            this.bnt_fXML.UseVisualStyleBackColor = false;
            this.bnt_fXML.Click += new System.EventHandler(this.bnt_fXML_Click);
            // 
            // lbl__Inicio
            // 
            this.lbl__Inicio.AutoSize = true;
            this.lbl__Inicio.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__Inicio.Location = new System.Drawing.Point(126, 107);
            this.lbl__Inicio.Name = "lbl__Inicio";
            this.lbl__Inicio.Size = new System.Drawing.Size(544, 104);
            this.lbl__Inicio.TabIndex = 3;
            this.lbl__Inicio.Text = "Que editor desea probar:\r\n\r\n";
            // 
            // btn_fRTF
            // 
            this.btn_fRTF.BackColor = System.Drawing.Color.Black;
            this.btn_fRTF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fRTF.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fRTF.ForeColor = System.Drawing.Color.White;
            this.btn_fRTF.Location = new System.Drawing.Point(604, 257);
            this.btn_fRTF.Name = "btn_fRTF";
            this.btn_fRTF.Size = new System.Drawing.Size(155, 75);
            this.btn_fRTF.TabIndex = 4;
            this.btn_fRTF.Text = "Archivo RTF";
            this.btn_fRTF.UseVisualStyleBackColor = false;
            this.btn_fRTF.Click += new System.EventHandler(this.btn_fRTF_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_fRTF);
            this.Controls.Add(this.lbl__Inicio);
            this.Controls.Add(this.bnt_fXML);
            this.Controls.Add(this.btn_fTXT);
            this.Controls.Add(this.btn_FormCSV);
            this.Name = "frm_principal";
            this.Text = "frm_Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_FormCSV;
        private System.Windows.Forms.Button btn_fTXT;
        private System.Windows.Forms.Button bnt_fXML;
        private System.Windows.Forms.Label lbl__Inicio;
        private System.Windows.Forms.Button btn_fRTF;
    }
}

