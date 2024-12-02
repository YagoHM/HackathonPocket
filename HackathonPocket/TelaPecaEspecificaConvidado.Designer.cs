namespace HackathonPocket
{
    partial class TelaPecaEspecificaConvidado
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
            label3 = new Label();
            anoLabel = new Label();
            descricaoRichTbox = new RichTextBox();
            nomeLabel = new Label();
            imgImportar = new PictureBox();
            menuStrip1 = new MenuStrip();
            voltartToolStripMenuItem = new ToolStripMenuItem();
            qrCode = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgImportar).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qrCode).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 47;
            label3.Text = "Descrição";
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new Point(142, 66);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new Size(29, 15);
            anoLabel.TabIndex = 46;
            anoLabel.Text = "Ano";
            // 
            // descricaoRichTbox
            // 
            descricaoRichTbox.Location = new Point(12, 199);
            descricaoRichTbox.Name = "descricaoRichTbox";
            descricaoRichTbox.Size = new Size(339, 145);
            descricaoRichTbox.TabIndex = 45;
            descricaoRichTbox.Text = "";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(142, 39);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(40, 15);
            nomeLabel.TabIndex = 44;
            nomeLabel.Text = "Nome";
            // 
            // imgImportar
            // 
            imgImportar.BackColor = Color.White;
            imgImportar.BorderStyle = BorderStyle.FixedSingle;
            imgImportar.ErrorImage = Properties.Resources.nenhum;
            imgImportar.Image = Properties.Resources.nenhum;
            imgImportar.InitialImage = Properties.Resources.nenhum;
            imgImportar.Location = new Point(12, 39);
            imgImportar.Name = "imgImportar";
            imgImportar.Size = new Size(124, 124);
            imgImportar.SizeMode = PictureBoxSizeMode.StretchImage;
            imgImportar.TabIndex = 41;
            imgImportar.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltartToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(363, 24);
            menuStrip1.TabIndex = 48;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltartToolStripMenuItem
            // 
            voltartToolStripMenuItem.Name = "voltartToolStripMenuItem";
            voltartToolStripMenuItem.Size = new Size(49, 20);
            voltartToolStripMenuItem.Text = "Voltar";
            voltartToolStripMenuItem.Click += voltartToolStripMenuItem_Click;
            // 
            // qrCode
            // 
            qrCode.BackColor = Color.White;
            qrCode.BorderStyle = BorderStyle.FixedSingle;
            qrCode.ErrorImage = Properties.Resources.nenhum;
            qrCode.Image = Properties.Resources.nenhum;
            qrCode.InitialImage = Properties.Resources.nenhum;
            qrCode.Location = new Point(111, 378);
            qrCode.Name = "qrCode";
            qrCode.Size = new Size(124, 124);
            qrCode.SizeMode = PictureBoxSizeMode.StretchImage;
            qrCode.TabIndex = 49;
            qrCode.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 360);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 50;
            label1.Text = "Mais Informações:";
            // 
            // TelaPecaEspecificaConvidado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gwerutgawe9uyoifoie4rhgiuhfoi;
            ClientSize = new Size(363, 517);
            Controls.Add(label1);
            Controls.Add(qrCode);
            Controls.Add(label3);
            Controls.Add(anoLabel);
            Controls.Add(descricaoRichTbox);
            Controls.Add(nomeLabel);
            Controls.Add(imgImportar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(379, 556);
            MinimumSize = new Size(379, 556);
            Name = "TelaPecaEspecificaConvidado";
            Text = "Peça";
            Load += TelaPecaEspecificaConvidado_Load;
            ((System.ComponentModel.ISupportInitialize)imgImportar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)qrCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label anoLabel;
        private RichTextBox descricaoRichTbox;
        private Label nomeLabel;
        private PictureBox imgImportar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltartToolStripMenuItem;
        private PictureBox qrCode;
        private Label label1;
    }
}