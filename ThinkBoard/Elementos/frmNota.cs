using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static ThinkBoard.Classes.FuncoesGenericas_Form;

namespace ThinkBoard.Elementos
{
    public partial class frmNota : Form
    {

        public static List<frmNota> lstNotas = new List<frmNota>();
        private static int qtMaxNotas = 0;
        private static int qtNotasAtivas = 0;
        private int nNota = 0;
        public bool icExcluida = false;

        #region Construtores
        public frmNota()
        {
            InitializeComponent();
            nNota = ++qtMaxNotas; qtNotasAtivas++;
            this.Text = "Nota" + nNota.ToString();
            txtTituloNota.Text = "Nota" + nNota.ToString();
            tsbCorA.PerformClick();
            lstNotas.Add(this);
        }
        #endregion

        #region Movimentação da janela
        // Constantes para mensagens do Windows
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        // Importar a função SendMessage do user32.dll
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Importar a função ReleaseCapture do user32.dll
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        // Manipulador de eventos MouseDown para começar a mover a janela
        private void MenuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = Cursors.SizeAll;
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                this.Cursor = Cursors.SizeAll;
            }
        }

        // Manipulador de eventos MouseMove para continuar a mover a janela
        private void MenuStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = Cursors.SizeAll;
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                this.Cursor = Cursors.SizeAll;
            }
            else
            {
                this.Cursor = Cursors.Arrow;
            }
        }
        #endregion

        #region Botões da janela
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!AltereModoEdicao_Simples(btnEditar, txtTituloNota, rtbTextoNota, toolStrip1) == true)
                this.Text = txtTituloNota.Text = txtTituloNota.Text.Trim();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            rtbTextoNota.Focus();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region SubFormatação do RichTextBox
        private void aplicaFormatacao(string delimitador, FontStyle estilo)
        {
            var cursorPos = rtbTextoNota.SelectionStart;
            if (cursorPos > 1)
            {
                var text = rtbTextoNota.Text;
                var end = text.LastIndexOf(delimitador, cursorPos - 1);
                if (end > 0)
                {
                    var start = text.LastIndexOf(delimitador, end - 1);
                    if (start != -1 && start < end)
                    {
                        var diff = text
                                    .Substring(start, end - start + 1)
                                    .Replace(delimitador, "")
                                    .Replace("\n", "")
                                    .Trim().Length;

                        if (diff > 0)
                        {
                            Font fonteOriginal = rtbTextoNota.SelectionFont;
                            rtbTextoNota.SelectionStart = start;
                            rtbTextoNota.SelectionLength = end - start + 1;
                            rtbTextoNota.SelectionFont = new Font(rtbTextoNota.SelectionFont, estilo);
                            rtbTextoNota.SelectedText = rtbTextoNota.SelectedText.Replace(delimitador, "");
                            rtbTextoNota.SelectionStart = end - 1;
                            rtbTextoNota.SelectionLength = 0;
                            rtbTextoNota.SelectionFont = fonteOriginal;
                        }
                    }
                }
            }
        }

        private void rtbTextoNota_TextChanged(object sender, EventArgs e)
        {
            aplicaFormatacao("*", FontStyle.Bold);
            aplicaFormatacao("_", FontStyle.Italic);
            aplicaFormatacao("~", FontStyle.Strikeout);
        }

        private void rtbTextoNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' && !rtbTextoNota.SelectionBullet)
            {
                var cursorPos = rtbTextoNota.SelectionStart;
                if (cursorPos > 0)
                {
                    var lastChar = rtbTextoNota.Text[cursorPos - 1];
                    if (lastChar == '*')
                    {
                        rtbTextoNota.SelectionStart = cursorPos - 1;
                        rtbTextoNota.SelectionLength = 1;
                        rtbTextoNota.SelectedText = "";
                        rtbTextoNota.SelectionStart = cursorPos - 1;
                        rtbTextoNota.SelectionBullet = true;
                        e.Handled = true;
                    }
                }
            }

            if (e.KeyChar == 27)
            {
                rtbTextoNota.SelectionFont = new Font(rtbTextoNota.SelectionFont, FontStyle.Regular);
                rtbTextoNota.SelectionStart = rtbTextoNota.SelectionStart + rtbTextoNota.SelectionLength;
                rtbTextoNota.SelectionLength = 0;
            }
        }
        #endregion

        #region Botões do ToolStrip
        private void tsbCorA_Click(object sender, EventArgs e)
        {
            AltereCoresControles_Simples(Color.Khaki, SystemColors.Info, SystemColors.WindowFrame, SystemColors.WindowFrame, this.Controls.Cast<Control>());
        }

        private void tsbCorB_Click(object sender, EventArgs e)
        {
            AltereCoresControles_Simples(SystemColors.ActiveBorder, SystemColors.Control, Color.White, SystemColors.WindowFrame, this.Controls.Cast<Control>());
        }

        private void tsbCorC_Click(object sender, EventArgs e)
        {
            AltereCoresControles_Simples(Color.Salmon, Color.MistyRose, Color.White, SystemColors.WindowFrame, this.Controls.Cast<Control>());
        }

        private void tsbCorD_Click(object sender, EventArgs e)
        {
            AltereCoresControles_Simples(Color.Thistle, Color.LavenderBlush, SystemColors.WindowFrame, SystemColors.WindowFrame, this.Controls.Cast<Control>());
        }
        #endregion

        #region Pequenas automações
        private void frmNota_Activated(object sender, EventArgs e)
        {
            rtbTextoNota.Focus();
        }

        private void frmNota_Enter(object sender, EventArgs e)
        {
            rtbTextoNota.Focus();
        }

        private void frmNota_Leave(object sender, EventArgs e)
        {
            if (txtTituloNota.Enabled)
                if (!AltereModoEdicao_Simples(btnEditar, txtTituloNota, rtbTextoNota, toolStrip1) == true)
                    this.Text = txtTituloNota.Text = txtTituloNota.Text.Trim();
        }

        private void rtbTextoNota_Enter(object sender, EventArgs e)
        {
            if (txtTituloNota.Enabled)
                if (!AltereModoEdicao_Simples(btnEditar, txtTituloNota, rtbTextoNota, toolStrip1) == true)
                    this.Text = txtTituloNota.Text = txtTituloNota.Text.Trim();
        }

        private void txtTituloNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                if (!AltereModoEdicao_Simples(btnEditar, txtTituloNota, rtbTextoNota, toolStrip1) == true)
                    this.Text = txtTituloNota.Text = txtTituloNota.Text.Trim();
        }
        #endregion

        private void frmNota_FormClosed(object sender, FormClosedEventArgs e)
        {
            icExcluida = true;
            qtNotasAtivas--;
        }

        #region Alterar dimensões da nota
        private const int BorderSize = 5; // Tamanho da área sensível ao redimensionamento
        private bool resizing = false;
        private Point lastMousePosition;
        private int resizeDirection = 0;

        private void FrmResizable_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && resizeDirection != 0)
            {
                resizing = true;
                lastMousePosition = e.Location;
            }
        }

        private void FrmResizable_MouseMove(object sender, MouseEventArgs e)
        {
            if (resizing)
            {
                int dx = e.X - lastMousePosition.X;
                int dy = e.Y - lastMousePosition.Y;

                if ((resizeDirection & 1) != 0) // Esquerda
                {
                    this.Width -= dx;
                    this.Left += dx;
                }
                if ((resizeDirection & 2) != 0) // Direita
                {
                    this.Width += dx;
                }
                if ((resizeDirection & 4) != 0) // Topo
                {
                    this.Height -= dy;
                    this.Top += dy;
                }
                if ((resizeDirection & 8) != 0) // Base
                {
                    this.Height += dy;
                }

                lastMousePosition = e.Location;
            }
            else
            {
                resizeDirection = GetResizeDirection(e.Location);
                switch (resizeDirection)
                {
                    case 1: case 2:
                        this.Cursor = Cursors.SizeWE; break;
                    case 4: case 8:
                        this.Cursor = Cursors.SizeNS; break;
                    case 5: case 10:
                        this.Cursor = Cursors.SizeNWSE; break;
                    case 6: case 9:
                        this.Cursor = Cursors.SizeNESW; break;
                    default:
                        this.Cursor = Cursors.Arrow; break;
                }
            }
            Application.DoEvents();
        }

        private void FrmResizable_MouseUp(object sender, MouseEventArgs e)
        {
            resizing = false;
            this.Cursor = Cursors.Arrow;
        }

        private int GetResizeDirection(Point mousePos)
        {
            int direction = 0;
            if (mousePos.X <= BorderSize) direction |= 1;  // Esquerda
            if (mousePos.X >= this.Width - BorderSize) direction |= 2;  // Direita
            if (mousePos.Y <= BorderSize) direction |= 4;  // Topo
            if (mousePos.Y >= this.Height - BorderSize) direction |= 8;  // Base
            return direction;
        }
        #endregion

        private void rtbTextoNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D0)
            {
                rtbTextoNota.ZoomFactor = 2f;
                rtbTextoNota.ZoomFactor = 1f;
                e.SuppressKeyPress = true;
            }
        }

        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void tsbCorA_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

    }
}
