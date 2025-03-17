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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_FormCSV_Click(object sender, EventArgs e)
        {
            frm_CSV frm_CSV = new frm_CSV();
            frm_CSV.Show();
            this.Hide();
        }

        private void btn_fRTF_Click(object sender, EventArgs e)
        {
            frm__fRTF frm__fRTF = new frm__fRTF();
            frm__fRTF.Show();
            this.Hide();
        }

        private void bnt_fXML_Click(object sender, EventArgs e)
        {
            frm_XML frm_XML = new frm_XML();
            frm_XML.Show();
            this.Hide();
        }

        private void btn_fTXT_Click(object sender, EventArgs e)
        {
            frm_TXT frm_TXT = new frm_TXT();
            frm_TXT.Show();
            this.Hide();
        }
    }
}
