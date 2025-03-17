using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacenamiento_de_datos
{
    public partial class frm_XML : Form
    {
        public frm_XML()
        {
            InitializeComponent();
        }
        string direccion;
        
        private void btn_Archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos XML|*.xml"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                direccion = openFileDialog.FileName;

                DataSet ds = new DataSet();
                ds.ReadXml(direccion);

                dtg_Vxml.DataSource = ds.Tables[0]; 
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("No hay archivo cargado.");
                return;
            }

            try
            {
                DataTable dt = (DataTable)dtg_Vxml.DataSource;

                if (dt != null)
                {
                    dt.WriteXml(direccion);
                    MessageBox.Show("Archivo XML guardado con éxito.");
                }
                else
                {
                    MessageBox.Show("No hay datos para guardar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo XML: " + ex.Message);
            }
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            frm_principal frm_Principal = new frm_principal();
            frm_Principal.Show();
            this.Hide();
        }
    }
}
