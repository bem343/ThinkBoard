namespace ThinkBoard.Elementos
{
    partial class frmNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNota));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.txtTituloNota = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlAreaTextoNota = new System.Windows.Forms.Panel();
            this.pnlTextoNota = new System.Windows.Forms.Panel();
            this.rtbTextoNota = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCorA = new System.Windows.Forms.ToolStripButton();
            this.tsbCorB = new System.Windows.Forms.ToolStripButton();
            this.tsbCorC = new System.Windows.Forms.ToolStripButton();
            this.tsbCorD = new System.Windows.Forms.ToolStripButton();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlAreaTextoNota.SuspendLayout();
            this.pnlTextoNota.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Tag = "P";
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuStrip_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStrip_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinimizar.Location = new System.Drawing.Point(199, 2);
            this.btnMinimizar.MaximumSize = new System.Drawing.Size(24, 24);
            this.btnMinimizar.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 24);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Tag = "A";
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // txtTituloNota
            // 
            this.txtTituloNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTituloNota.BackColor = System.Drawing.Color.Thistle;
            this.txtTituloNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTituloNota.Enabled = false;
            this.txtTituloNota.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloNota.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTituloNota.Location = new System.Drawing.Point(6, 6);
            this.txtTituloNota.Margin = new System.Windows.Forms.Padding(0);
            this.txtTituloNota.Name = "txtTituloNota";
            this.txtTituloNota.Size = new System.Drawing.Size(164, 16);
            this.txtTituloNota.TabIndex = 1;
            this.txtTituloNota.TabStop = false;
            this.txtTituloNota.Tag = "P";
            this.txtTituloNota.Text = "Nota1";
            this.txtTituloNota.WordWrap = false;
            this.txtTituloNota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTituloNota_KeyDown);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEditar.Location = new System.Drawing.Point(174, 2);
            this.btnEditar.MaximumSize = new System.Drawing.Size(24, 24);
            this.btnEditar.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(24, 24);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.TabStop = false;
            this.btnEditar.Tag = "A";
            this.btnEditar.Text = "E";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlAreaTextoNota
            // 
            this.pnlAreaTextoNota.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAreaTextoNota.Controls.Add(this.pnlTextoNota);
            this.pnlAreaTextoNota.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlAreaTextoNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAreaTextoNota.Location = new System.Drawing.Point(2, 26);
            this.pnlAreaTextoNota.Name = "pnlAreaTextoNota";
            this.pnlAreaTextoNota.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.pnlAreaTextoNota.Size = new System.Drawing.Size(246, 222);
            this.pnlAreaTextoNota.TabIndex = 6;
            this.pnlAreaTextoNota.Tag = "A";
            // 
            // pnlTextoNota
            // 
            this.pnlTextoNota.BackColor = System.Drawing.SystemColors.Info;
            this.pnlTextoNota.Controls.Add(this.rtbTextoNota);
            this.pnlTextoNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextoNota.Location = new System.Drawing.Point(10, 8);
            this.pnlTextoNota.Name = "pnlTextoNota";
            this.pnlTextoNota.Size = new System.Drawing.Size(226, 204);
            this.pnlTextoNota.TabIndex = 7;
            this.pnlTextoNota.Tag = "A";
            // 
            // rtbTextoNota
            // 
            this.rtbTextoNota.AcceptsTab = true;
            this.rtbTextoNota.BackColor = System.Drawing.Color.LavenderBlush;
            this.rtbTextoNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTextoNota.BulletIndent = 15;
            this.rtbTextoNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTextoNota.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTextoNota.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rtbTextoNota.Location = new System.Drawing.Point(0, 0);
            this.rtbTextoNota.Margin = new System.Windows.Forms.Padding(0);
            this.rtbTextoNota.Name = "rtbTextoNota";
            this.rtbTextoNota.Size = new System.Drawing.Size(226, 204);
            this.rtbTextoNota.TabIndex = 8;
            this.rtbTextoNota.TabStop = false;
            this.rtbTextoNota.Tag = "A";
            this.rtbTextoNota.Text = "";
            this.rtbTextoNota.TextChanged += new System.EventHandler(this.rtbTextoNota_TextChanged);
            this.rtbTextoNota.Enter += new System.EventHandler(this.rtbTextoNota_Enter);
            this.rtbTextoNota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbTextoNota_KeyDown);
            this.rtbTextoNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbTextoNota_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCorA,
            this.tsbCorB,
            this.tsbCorC,
            this.tsbCorD});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(2, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(246, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Tag = "A";
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            this.toolStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseMove);
            // 
            // tsbCorA
            // 
            this.tsbCorA.BackColor = System.Drawing.Color.Khaki;
            this.tsbCorA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsbCorA.Image = ((System.Drawing.Image)(resources.GetObject("tsbCorA.Image")));
            this.tsbCorA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCorA.Name = "tsbCorA";
            this.tsbCorA.Size = new System.Drawing.Size(23, 22);
            this.tsbCorA.Text = "Amarelo";
            this.tsbCorA.Click += new System.EventHandler(this.tsbCorA_Click);
            this.tsbCorA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tsbCorA_MouseMove);
            // 
            // tsbCorB
            // 
            this.tsbCorB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tsbCorB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsbCorB.Image = ((System.Drawing.Image)(resources.GetObject("tsbCorB.Image")));
            this.tsbCorB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCorB.Name = "tsbCorB";
            this.tsbCorB.Size = new System.Drawing.Size(23, 22);
            this.tsbCorB.Text = "Cinza";
            this.tsbCorB.Click += new System.EventHandler(this.tsbCorB_Click);
            this.tsbCorB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tsbCorA_MouseMove);
            // 
            // tsbCorC
            // 
            this.tsbCorC.BackColor = System.Drawing.Color.Salmon;
            this.tsbCorC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsbCorC.Image = ((System.Drawing.Image)(resources.GetObject("tsbCorC.Image")));
            this.tsbCorC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCorC.Name = "tsbCorC";
            this.tsbCorC.Size = new System.Drawing.Size(23, 22);
            this.tsbCorC.Text = "Vermelho";
            this.tsbCorC.Click += new System.EventHandler(this.tsbCorC_Click);
            this.tsbCorC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tsbCorA_MouseMove);
            // 
            // tsbCorD
            // 
            this.tsbCorD.BackColor = System.Drawing.Color.Thistle;
            this.tsbCorD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsbCorD.Image = ((System.Drawing.Image)(resources.GetObject("tsbCorD.Image")));
            this.tsbCorD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCorD.Name = "tsbCorD";
            this.tsbCorD.Size = new System.Drawing.Size(23, 22);
            this.tsbCorD.Text = "Roxo";
            this.tsbCorD.Click += new System.EventHandler(this.tsbCorD_Click);
            this.tsbCorD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tsbCorA_MouseMove);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Salmon;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.Location = new System.Drawing.Point(224, 2);
            this.btnFechar.MaximumSize = new System.Drawing.Size(24, 24);
            this.btnFechar.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.TabStop = false;
            this.btnFechar.Tag = "";
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(250, 250);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlAreaTextoNota);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtTituloNota);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(200, 70);
            this.Name = "frmNota";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nota1";
            this.Activated += new System.EventHandler(this.frmNota_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNota_FormClosed);
            this.Enter += new System.EventHandler(this.frmNota_Enter);
            this.Leave += new System.EventHandler(this.frmNota_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmResizable_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmResizable_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmResizable_MouseUp);
            this.pnlAreaTextoNota.ResumeLayout(false);
            this.pnlTextoNota.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.TextBox txtTituloNota;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnlAreaTextoNota;
        private System.Windows.Forms.Panel pnlTextoNota;
        private System.Windows.Forms.RichTextBox rtbTextoNota;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCorA;
        private System.Windows.Forms.ToolStripButton tsbCorB;
        private System.Windows.Forms.ToolStripButton tsbCorC;
        private System.Windows.Forms.ToolStripButton tsbCorD;
        private System.Windows.Forms.Button btnFechar;
    }
}