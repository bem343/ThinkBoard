using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ThinkBoard.Classes
{
    /// <summary>
    /// Esta classe contém funções genéricas para uso em formulários WindowsForm.
    /// </summary>
    public static class FuncoesGenericas_Form
    {
        private const string _vlAtvPadrao = "S";
        private const string _vlDesPadrao = "E";

        /// <summary>
        /// Altera o modo de edição (propriedade 'Enabled') de uma caixa de texto a partir do clique de um botão.
        /// </summary>
        /// <param name="btn">Botão responsável por ativar/desativar o modo de edição.</param>
        /// <param name="txt">Caixa de texto que sofrerá a alteração.</param>
        /// <param name="cnt">Controle que receberá o foco ao sair do modo de edição.</param>
        /// <param name="vlAtv">Valor do texto do botão quando a caixa de texto entra em modo de edição.</param>
        /// <param name="vlDes">Valor do texto do botão quando a caixa de texto sai do modo de edição.</param>
        /// <returns>
        /// Um valor booleano que indica se a edição da caixa de texto foi ativada nesta alteração:
        /// <para>true: A caixa de texto foi ativada nesta alteração;</para>
        /// <para>false: A caixa de texto não foi ativada nesta alteração;</para>
        /// <para>null: Não houve alteração no modo por conta da validação de vazio.</para>
        /// </returns>
        public static bool? AltereModoEdicao_Simples(Button btn, TextBox txt, Control cnt, string vlAtv = _vlAtvPadrao, string vlDes = _vlDesPadrao, bool validaVazio = true)
        {
            var modoEdicao = !txt.Enabled;
            if (!modoEdicao && txt.Text.Trim() == string.Empty && validaVazio) return null;
            btn.Text = modoEdicao ? vlAtv : vlDes;
            btn.TabStop = modoEdicao;
            txt.Enabled = modoEdicao;
            txt.TabStop = modoEdicao;
            if (modoEdicao) txt.Focus(); else cnt.Focus();
            return modoEdicao;
        }

        /// <summary>
        /// Altera o modo de edição (propriedade 'Enabled') de uma caixa de texto a partir do clique de um botão, além de mostrar um ToolStrip com mais opções de personalização no modo de edição.
        /// </summary>
        /// <param name="btn">Botão responsável por ativar/desativar o modo de edição.</param>
        /// <param name="txt">Caixa de texto que sofrerá a alteração.</param>
        /// <param name="cnt">Controle que receberá o foco ao sair do modo de edição.</param>
        /// <param name="ts">ToolStrip que será exibido no modo de edição.</param>
        /// <param name="vlAtv">Valor do texto do botão quando a caixa de texto entra em modo de edição.</param>
        /// <param name="vlDes">Valor do texto do botão quando a caixa de texto sai do modo de edição.</param>
        /// <returns>
        /// Um valor booleano que indica se a edição da caixa de texto foi ativada nesta alteração:
        /// <para>true: A caixa de texto foi ativada nesta alteração;</para>
        /// <para>false: A caixa de texto não foi ativada nesta alteração;</para>
        /// <para>null: Não houve alteração no modo por conta da validação de vazio.</para>
        /// </returns>
        public static bool? AltereModoEdicao_Simples(Button btn, TextBox txt, Control cnt, ToolStrip ts, string vlAtv = _vlAtvPadrao, string vlDes = _vlDesPadrao, bool validaVazio = true)
        {
            var modoEdicao = !txt.Enabled;
            if (!modoEdicao && txt.Text.Trim() == string.Empty && validaVazio) return null;
            btn.Text = modoEdicao ? vlAtv : vlDes;
            btn.TabStop = modoEdicao;
            txt.Enabled = modoEdicao;
            txt.TabStop = modoEdicao;
            ts.Visible = modoEdicao;
            if (modoEdicao) txt.Focus(); else cnt.Focus();
            return modoEdicao;
        }

        /// <summary>
        /// Altera as cores dos controles de uma janela de forma simplificada.
        /// </summary>
        /// <remarks>
        /// Observações:
        /// <para>Marque o controle com a tag 'P' para que ele seja alterado com as cores principais;</para>
        /// <para>Marque o controle com a tag 'A' para que ele seja alterado com as cores alternativas;</para>
        /// <para>Marque o controle com a tag 'E' para garantir que ele se mantenha estático;</para>
        /// <para>Não marque o controle com tag alguma, caso não queria alterá-los.</para>
        /// </remarks>
        /// <param name="BC_Principal">Cor de fundo principal.</param>
        /// <param name="BC_Alternativo">Cor de fundo alternativa.</param>
        /// <param name="FC_Principal">Cor dos textos principal.</param>
        /// <param name="FC_Alternativo">Cor dos textos alternativa.</param>
        /// <param name="Controles">Controles do formulário que sofrerá a alteração.</param>
        /// <returns>O número total de controles que foram afetados.</returns>
        public static int AltereCoresControles_Simples(Color BC_Principal, Color BC_Alternativo, Color FC_Principal, Color FC_Alternativo, IEnumerable<Control> Controles, bool AltereControleOriginal = true)
        {
            var _ControlesAfetados = 0;
            var _ControlesEstaticos = new List<Control>();

            void ExploreControles(IEnumerable<Control> _Controles)
            {
                foreach (Control Controle in _Controles)
                {
                    if (Controle.HasChildren)
                        ExploreControles(Controle.Controls.Cast<Control>());

                    switch (Controle.Tag.ToString().ToUpper())
                    {
                        case "P": //Principal
                            Controle.BackColor = BC_Principal;
                            Controle.ForeColor = FC_Principal;
                            _ControlesAfetados++;
                            break;
                        case "A": //Alternativo
                            Controle.BackColor = BC_Alternativo;
                            Controle.ForeColor = FC_Alternativo;
                            _ControlesAfetados++;
                            break;
                        case "E": //Estático
                            _ControlesEstaticos.Add(Controle);
                            break;
                    }
                }
            }

            void ReajusteControlesEstaticos(IEnumerable<Control> _Controles)
            {
                foreach (Control Controle in _Controles)
                {
                    if (Controle.HasChildren)
                        ReajusteControlesEstaticos(Controle.Controls.Cast<Control>());

                    if (Controle.Tag.ToString().ToUpper() == "E") //Estático
                    {
                        var ControleOriginal = _ControlesEstaticos.First();
                        Controle.BackColor = ControleOriginal.BackColor;
                        Controle.ForeColor = ControleOriginal.ForeColor;
                        _ControlesEstaticos.Remove(ControleOriginal);
                    }
                }
            }

            if (Controles != null && Controles.Count() > 0)
            {
                ExploreControles(Controles);

                if (AltereControleOriginal)
                {
                    var original = Controles.First().Parent;
                    if (original != null)
                    {
                        original.BackColor = BC_Principal;
                        original.ForeColor = FC_Principal;
                        _ControlesAfetados++;
                    }
                }

                if (_ControlesEstaticos.Count > 0)
                    ReajusteControlesEstaticos(Controles);
            }

            return _ControlesAfetados;
        }
    }
}
