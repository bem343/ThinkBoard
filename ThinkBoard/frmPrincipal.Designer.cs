namespace ThinkBoard
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slFormatoJanela = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoElementoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModoTela = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTelaCheia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiNotasExternas = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slFormatoJanela});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slFormatoJanela
            // 
            this.slFormatoJanela.AccessibleDescription = "Definida como: \'Normal\' ou \'Tela Cheia\'.";
            this.slFormatoJanela.AccessibleName = "Formato da Janela";
            this.slFormatoJanela.Name = "slFormatoJanela";
            this.slFormatoJanela.Size = new System.Drawing.Size(85, 17);
            this.slFormatoJanela.Text = "Modo: Normal";
            this.slFormatoJanela.ToolTipText = "Teste";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.tsmConfig});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoElementoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoElementoToolStripMenuItem
            // 
            this.novoElementoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notaToolStripMenuItem});
            this.novoElementoToolStripMenuItem.Name = "novoElementoToolStripMenuItem";
            this.novoElementoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.novoElementoToolStripMenuItem.Text = "Novo Elemento...";
            // 
            // notaToolStripMenuItem
            // 
            this.notaToolStripMenuItem.Name = "notaToolStripMenuItem";
            this.notaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D1)));
            this.notaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.notaToolStripMenuItem.Text = "Nota";
            this.notaToolStripMenuItem.Click += new System.EventHandler(this.notaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.sairToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tsmConfig
            // 
            this.tsmConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModoTela,
            this.toolStripMenuItem2,
            this.tsmiNotasExternas});
            this.tsmConfig.Name = "tsmConfig";
            this.tsmConfig.Size = new System.Drawing.Size(96, 20);
            this.tsmConfig.Text = "Configurações";
            // 
            // tsmiModoTela
            // 
            this.tsmiModoTela.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNormal,
            this.tsmiTelaCheia});
            this.tsmiModoTela.Name = "tsmiModoTela";
            this.tsmiModoTela.Size = new System.Drawing.Size(152, 22);
            this.tsmiModoTela.Text = "Modo de tela";
            // 
            // tsmiNormal
            // 
            this.tsmiNormal.Checked = true;
            this.tsmiNormal.CheckOnClick = true;
            this.tsmiNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiNormal.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.tsmiNormal.MergeIndex = 1;
            this.tsmiNormal.Name = "tsmiNormal";
            this.tsmiNormal.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiNormal.Size = new System.Drawing.Size(146, 22);
            this.tsmiNormal.Text = "Normal";
            this.tsmiNormal.Click += new System.EventHandler(this.tsmiNormal_Click);
            // 
            // tsmiTelaCheia
            // 
            this.tsmiTelaCheia.CheckOnClick = true;
            this.tsmiTelaCheia.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.tsmiTelaCheia.MergeIndex = 0;
            this.tsmiTelaCheia.Name = "tsmiTelaCheia";
            this.tsmiTelaCheia.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.tsmiTelaCheia.Size = new System.Drawing.Size(146, 22);
            this.tsmiTelaCheia.Text = "Tela Cheia";
            this.tsmiTelaCheia.Click += new System.EventHandler(this.tsmiTelaCheia_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmiNotasExternas
            // 
            this.tsmiNotasExternas.CheckOnClick = true;
            this.tsmiNotasExternas.Name = "tsmiNotasExternas";
            this.tsmiNotasExternas.Size = new System.Drawing.Size(152, 22);
            this.tsmiNotasExternas.Text = "Notas externas";
            this.tsmiNotasExternas.Click += new System.EventHandler(this.tsmiNotasExternas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThinkBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.frmPrincipal_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slFormatoJanela;
        private System.Windows.Forms.ToolStripMenuItem tsmConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmiModoTela;
        private System.Windows.Forms.ToolStripMenuItem tsmiNormal;
        private System.Windows.Forms.ToolStripMenuItem tsmiTelaCheia;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoElementoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiNotasExternas;
    }
}

