using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmeTeste
{

    public partial class LayoutForm : Form

    {
        private bool blnAlarme = false;
        private bool blnDespertando = false;

        public LayoutForm()
        {
            InitializeComponent();
        }

        private void lblRelogio_Click(object sender, EventArgs e)
        {

        }

        private void mtbProgram_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtbProgram.Text = DateTime.Now.ToString("hh:mm");
        }

        private void btnProgramar_Click(object sender, EventArgs e)
        {
            blnAlarme = true;
            btnParar.Enabled = true;

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            blnDespertando = false; 
            blnAlarme = false ;
            btnParar.Enabled = false;
            btnProgramar.Enabled = true;
            mtbProgram.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString("hh:mm:ss");

            if (blnAlarme == true && mtbProgram.Text == DateTime.Now.ToString("hh:mm"))
            {
                blnDespertando = true;
                btnParar.Enabled = true;
                btnProgramar.Enabled = false;
                mtbProgram.Enabled = false;
            };
            if (blnDespertando == true)
            {
                lblRelogio.Text = "TOCANDO";
            };
        }
    }
}
