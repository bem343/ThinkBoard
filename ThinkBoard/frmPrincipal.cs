using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkBoard.Elementos;

namespace ThinkBoard
{
    public partial class frmPrincipal : Form
    {

        #region Contrutores
        public frmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        private void frmPrincipal_SizeChanged(object sender, EventArgs e)
        {
            slFormatoJanela.Text = (this.WindowState == FormWindowState.Maximized && this.FormBorderStyle == FormBorderStyle.None) ? "Modo: Tela Cheia" : "Modo: Normal";
        }

        private void tsmiNormal_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            tsmiNormal.Checked = true;
            tsmiTelaCheia.Checked = false;
        }

        private void tsmiTelaCheia_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            tsmiTelaCheia.Checked = true;
            tsmiNormal.Checked = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNota Nota = new frmNota();
            Nota.MdiParent = tsmiNotasExternas.Checked ? null : this;
            Nota.Show();
        }

        private void tsmiNotasExternas_Click(object sender, EventArgs e)
        {
            if (tsmiNotasExternas.Checked)
            {
                foreach (var nota in this.MdiChildren.OfType<frmNota>())
                {
                    nota.MdiParent = null;
                }
            }
            else
            {
                foreach (var nota in this.MdiChildren.OfType<frmNota>())
                {
                    nota.Close();
                }

                foreach (var nota in frmNota.lstNotas.Where(x => x.icExcluida == false))
                {
                    nota.MdiParent = tsmiNotasExternas.Checked ? null : this;
                    nota.Show();
                }
            }
        }
    }
}
