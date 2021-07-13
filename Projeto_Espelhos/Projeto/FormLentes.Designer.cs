namespace Projeto
{
    partial class FormLentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLentes));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtO = new System.Windows.Forms.TextBox();
            this.lblF = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.cbTipoLente = new System.Windows.Forms.ComboBox();
            this.lblO = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.pbDivergente = new System.Windows.Forms.PictureBox();
            this.pbDA = new System.Windows.Forms.PictureBox();
            this.pbEAF = new System.Windows.Forms.PictureBox();
            this.pbA = new System.Windows.Forms.PictureBox();
            this.pbEFCO = new System.Windows.Forms.PictureBox();
            this.pbF = new System.Windows.Forms.PictureBox();
            this.tiposDeLentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divergenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convergenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbPrincipal = new System.Windows.Forms.PictureBox();
            this.lblAi = new System.Windows.Forms.Label();
            this.lblFi = new System.Windows.Forms.Label();
            this.lblFo = new System.Windows.Forms.Label();
            this.lblAo = new System.Windows.Forms.Label();
            this.reflexaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDivergente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEAF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEFCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeLentesToolStripMenuItem,
            this.raiosToolStripMenuItem,
            this.utilizaçãoToolStripMenuItem,
            this.reflexaoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(982, 29);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtO);
            this.panel1.Controls.Add(this.lblF);
            this.panel1.Controls.Add(this.lblP);
            this.panel1.Controls.Add(this.lbResultado);
            this.panel1.Controls.Add(this.cbTipoLente);
            this.panel1.Controls.Add(this.lblO);
            this.panel1.Controls.Add(this.txtF);
            this.panel1.Controls.Add(this.txtP);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 132);
            this.panel1.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Black;
            this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(555, 569);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 53);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Black;
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(322, 572);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 50);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtO
            // 
            this.txtO.Location = new System.Drawing.Point(277, 79);
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(55, 20);
            this.txtO.TabIndex = 22;
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.BackColor = System.Drawing.Color.White;
            this.lblF.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.Location = new System.Drawing.Point(42, 11);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(170, 19);
            this.lblF.TabIndex = 21;
            this.lblF.Text = "Distância focal ( f )";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.BackColor = System.Drawing.Color.White;
            this.lblP.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(3, 44);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(261, 19);
            this.lblP.TabIndex = 20;
            this.lblP.Text = "Distância objeto/espelho ( p )";
            // 
            // lbResultado
            // 
            this.lbResultado.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.ForeColor = System.Drawing.SystemColors.Window;
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 15;
            this.lbResultado.Location = new System.Drawing.Point(592, 7);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(271, 124);
            this.lbResultado.TabIndex = 15;
            // 
            // cbTipoLente
            // 
            this.cbTipoLente.BackColor = System.Drawing.SystemColors.InfoText;
            this.cbTipoLente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoLente.ForeColor = System.Drawing.SystemColors.Window;
            this.cbTipoLente.FormattingEnabled = true;
            this.cbTipoLente.Items.AddRange(new object[] {
            "Convergente",
            "Divergente"});
            this.cbTipoLente.Location = new System.Drawing.Point(354, 26);
            this.cbTipoLente.Name = "cbTipoLente";
            this.cbTipoLente.Size = new System.Drawing.Size(219, 26);
            this.cbTipoLente.TabIndex = 6;
            this.cbTipoLente.Text = "Selecione o tipo de lente";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.BackColor = System.Drawing.Color.White;
            this.lblO.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO.Location = new System.Drawing.Point(35, 78);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(209, 19);
            this.lblO.TabIndex = 19;
            this.lblO.Text = "Tamanho do objeto (O)";
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(277, 6);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(55, 20);
            this.txtF.TabIndex = 4;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(277, 45);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(55, 20);
            this.txtP.TabIndex = 3;
            // 
            // pbDivergente
            // 
            this.pbDivergente.Image = ((System.Drawing.Image)(resources.GetObject("pbDivergente.Image")));
            this.pbDivergente.Location = new System.Drawing.Point(39, 176);
            this.pbDivergente.Name = "pbDivergente";
            this.pbDivergente.Size = new System.Drawing.Size(300, 100);
            this.pbDivergente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDivergente.TabIndex = 3;
            this.pbDivergente.TabStop = false;
            this.pbDivergente.Visible = false;
            // 
            // pbDA
            // 
            this.pbDA.Image = ((System.Drawing.Image)(resources.GetObject("pbDA.Image")));
            this.pbDA.Location = new System.Drawing.Point(39, 176);
            this.pbDA.Name = "pbDA";
            this.pbDA.Size = new System.Drawing.Size(699, 302);
            this.pbDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDA.TabIndex = 4;
            this.pbDA.TabStop = false;
            this.pbDA.Visible = false;
            // 
            // pbEAF
            // 
            this.pbEAF.Image = ((System.Drawing.Image)(resources.GetObject("pbEAF.Image")));
            this.pbEAF.Location = new System.Drawing.Point(39, 192);
            this.pbEAF.Name = "pbEAF";
            this.pbEAF.Size = new System.Drawing.Size(736, 316);
            this.pbEAF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEAF.TabIndex = 5;
            this.pbEAF.TabStop = false;
            this.pbEAF.Visible = false;
            // 
            // pbA
            // 
            this.pbA.Image = ((System.Drawing.Image)(resources.GetObject("pbA.Image")));
            this.pbA.Location = new System.Drawing.Point(46, 176);
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(692, 351);
            this.pbA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbA.TabIndex = 6;
            this.pbA.TabStop = false;
            this.pbA.Visible = false;
            // 
            // pbEFCO
            // 
            this.pbEFCO.Image = ((System.Drawing.Image)(resources.GetObject("pbEFCO.Image")));
            this.pbEFCO.Location = new System.Drawing.Point(39, 176);
            this.pbEFCO.Name = "pbEFCO";
            this.pbEFCO.Size = new System.Drawing.Size(715, 351);
            this.pbEFCO.TabIndex = 7;
            this.pbEFCO.TabStop = false;
            this.pbEFCO.Visible = false;
            // 
            // pbF
            // 
            this.pbF.Image = ((System.Drawing.Image)(resources.GetObject("pbF.Image")));
            this.pbF.Location = new System.Drawing.Point(46, 176);
            this.pbF.Name = "pbF";
            this.pbF.Size = new System.Drawing.Size(736, 316);
            this.pbF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbF.TabIndex = 8;
            this.pbF.TabStop = false;
            this.pbF.Visible = false;
            // 
            // tiposDeLentesToolStripMenuItem
            // 
            this.tiposDeLentesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiposDeLentesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.tiposDeLentesToolStripMenuItem.Name = "tiposDeLentesToolStripMenuItem";
            this.tiposDeLentesToolStripMenuItem.Size = new System.Drawing.Size(133, 25);
            this.tiposDeLentesToolStripMenuItem.Text = "Tipos de Lentes";
            this.tiposDeLentesToolStripMenuItem.Click += new System.EventHandler(this.tiposDeLentesToolStripMenuItem_Click);
            // 
            // raiosToolStripMenuItem
            // 
            this.raiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.divergenteToolStripMenuItem,
            this.convergenteToolStripMenuItem});
            this.raiosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.raiosToolStripMenuItem.Name = "raiosToolStripMenuItem";
            this.raiosToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.raiosToolStripMenuItem.Text = "Raios";
            // 
            // utilizaçãoToolStripMenuItem
            // 
            this.utilizaçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilizaçãoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.utilizaçãoToolStripMenuItem.Name = "utilizaçãoToolStripMenuItem";
            this.utilizaçãoToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.utilizaçãoToolStripMenuItem.Text = " Utilização";
            this.utilizaçãoToolStripMenuItem.Click += new System.EventHandler(this.utilizaçãoToolStripMenuItem_Click);
            // 
            // divergenteToolStripMenuItem
            // 
            this.divergenteToolStripMenuItem.Name = "divergenteToolStripMenuItem";
            this.divergenteToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.divergenteToolStripMenuItem.Text = "Convergente";
            this.divergenteToolStripMenuItem.Click += new System.EventHandler(this.divergenteToolStripMenuItem_Click);
            // 
            // convergenteToolStripMenuItem
            // 
            this.convergenteToolStripMenuItem.Name = "convergenteToolStripMenuItem";
            this.convergenteToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.convergenteToolStripMenuItem.Text = "Divergente";
            this.convergenteToolStripMenuItem.Click += new System.EventHandler(this.convergenteToolStripMenuItem_Click);
            // 
            // pbPrincipal
            // 
            this.pbPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pbPrincipal.Image")));
            this.pbPrincipal.Location = new System.Drawing.Point(12, 162);
            this.pbPrincipal.Name = "pbPrincipal";
            this.pbPrincipal.Size = new System.Drawing.Size(859, 405);
            this.pbPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrincipal.TabIndex = 23;
            this.pbPrincipal.TabStop = false;
            this.pbPrincipal.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblAi
            // 
            this.lblAi.AutoSize = true;
            this.lblAi.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblAi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAi.ForeColor = System.Drawing.Color.White;
            this.lblAi.Location = new System.Drawing.Point(732, 285);
            this.lblAi.Name = "lblAi";
            this.lblAi.Size = new System.Drawing.Size(50, 39);
            this.lblAi.TabIndex = 26;
            this.lblAi.Text = "Ai";
            // 
            // lblFi
            // 
            this.lblFi.AutoSize = true;
            this.lblFi.BackColor = System.Drawing.Color.Black;
            this.lblFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFi.ForeColor = System.Drawing.Color.White;
            this.lblFi.Location = new System.Drawing.Point(548, 285);
            this.lblFi.Name = "lblFi";
            this.lblFi.Size = new System.Drawing.Size(48, 39);
            this.lblFi.TabIndex = 23;
            this.lblFi.Text = "Fi";
            // 
            // lblFo
            // 
            this.lblFo.AutoSize = true;
            this.lblFo.BackColor = System.Drawing.Color.Black;
            this.lblFo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFo.ForeColor = System.Drawing.Color.White;
            this.lblFo.Location = new System.Drawing.Point(228, 378);
            this.lblFo.Name = "lblFo";
            this.lblFo.Size = new System.Drawing.Size(59, 39);
            this.lblFo.TabIndex = 23;
            this.lblFo.Text = "Fo";
            // 
            // lblAo
            // 
            this.lblAo.AutoSize = true;
            this.lblAo.BackColor = System.Drawing.Color.Black;
            this.lblAo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAo.ForeColor = System.Drawing.Color.White;
            this.lblAo.Location = new System.Drawing.Point(51, 378);
            this.lblAo.Name = "lblAo";
            this.lblAo.Size = new System.Drawing.Size(61, 39);
            this.lblAo.TabIndex = 23;
            this.lblAo.Text = "Ao";
            // 
            // reflexaoToolStripMenuItem
            // 
            this.reflexaoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflexaoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reflexaoToolStripMenuItem.Name = "reflexaoToolStripMenuItem";
            this.reflexaoToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.reflexaoToolStripMenuItem.Text = "Reflexão";
            this.reflexaoToolStripMenuItem.Click += new System.EventHandler(this.reflexaoToolStripMenuItem_Click);
            // 
            // FormLentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 634);
            this.Controls.Add(this.lblAo);
            this.Controls.Add(this.lblFo);
            this.Controls.Add(this.lblFi);
            this.Controls.Add(this.lblAi);
            this.Controls.Add(this.pbPrincipal);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pbF);
            this.Controls.Add(this.pbEFCO);
            this.Controls.Add(this.pbA);
            this.Controls.Add(this.pbEAF);
            this.Controls.Add(this.pbDA);
            this.Controls.Add(this.pbDivergente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormLentes";
            this.Text = "FormLentes";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDivergente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEAF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEFCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.ComboBox cbTipoLente;
        private System.Windows.Forms.ListBox lbResultado;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.TextBox txtO;
        private System.Windows.Forms.PictureBox pbDivergente;
        private System.Windows.Forms.PictureBox pbDA;
        private System.Windows.Forms.PictureBox pbEAF;
        private System.Windows.Forms.PictureBox pbA;
        private System.Windows.Forms.PictureBox pbEFCO;
        private System.Windows.Forms.PictureBox pbF;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ToolStripMenuItem tiposDeLentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divergenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convergenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizaçãoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbPrincipal;
        private System.Windows.Forms.Label lblAi;
        private System.Windows.Forms.Label lblFi;
        private System.Windows.Forms.Label lblFo;
        private System.Windows.Forms.Label lblAo;
        private System.Windows.Forms.ToolStripMenuItem reflexaoToolStripMenuItem;
    }
}