namespace HackathonPocket
{
    partial class AdminNovaPeca
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
            uploadBt = new Button();
            imgImportar = new PictureBox();
            nomeTbox = new TextBox();
            criarBt = new Button();
            anoNumeric = new NumericUpDown();
            label1 = new Label();
            descricaoRichTbox = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)imgImportar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)anoNumeric).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // uploadBt
            // 
            uploadBt.Location = new Point(120, 175);
            uploadBt.Name = "uploadBt";
            uploadBt.Size = new Size(124, 23);
            uploadBt.TabIndex = 30;
            uploadBt.Text = "Upload Foto";
            uploadBt.UseVisualStyleBackColor = true;
            uploadBt.Click += uploadBt_Click;
            // 
            // imgImportar
            // 
            imgImportar.BackColor = Color.White;
            imgImportar.BorderStyle = BorderStyle.FixedSingle;
            imgImportar.ErrorImage = Properties.Resources.nenhum;
            imgImportar.Image = Properties.Resources.nenhum;
            imgImportar.InitialImage = Properties.Resources.nenhum;
            imgImportar.Location = new Point(120, 35);
            imgImportar.Name = "imgImportar";
            imgImportar.Size = new Size(124, 124);
            imgImportar.SizeMode = PictureBoxSizeMode.StretchImage;
            imgImportar.TabIndex = 31;
            imgImportar.TabStop = false;
            // 
            // nomeTbox
            // 
            nomeTbox.Location = new Point(13, 216);
            nomeTbox.Name = "nomeTbox";
            nomeTbox.Size = new Size(339, 23);
            nomeTbox.TabIndex = 32;
            // 
            // criarBt
            // 
            criarBt.Location = new Point(13, 489);
            criarBt.Name = "criarBt";
            criarBt.Size = new Size(339, 23);
            criarBt.TabIndex = 33;
            criarBt.Text = "Criar";
            criarBt.UseVisualStyleBackColor = true;
            criarBt.Click += criarBt_Click;
            // 
            // anoNumeric
            // 
            anoNumeric.Location = new Point(13, 278);
            anoNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            anoNumeric.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            anoNumeric.Name = "anoNumeric";
            anoNumeric.Size = new Size(339, 23);
            anoNumeric.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 195);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 36;
            label1.Text = "Nome";
            // 
            // descricaoRichTbox
            // 
            descricaoRichTbox.Location = new Point(13, 338);
            descricaoRichTbox.Name = "descricaoRichTbox";
            descricaoRichTbox.Size = new Size(339, 145);
            descricaoRichTbox.TabIndex = 37;
            descricaoRichTbox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 257);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 38;
            label2.Text = "Ano";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 317);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 39;
            label3.Text = "Descrição";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(363, 24);
            menuStrip1.TabIndex = 40;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // AdminNovaPeca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gwerutgawe9uyoifoie4rhgiuhfoi;
            ClientSize = new Size(363, 517);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descricaoRichTbox);
            Controls.Add(label1);
            Controls.Add(anoNumeric);
            Controls.Add(criarBt);
            Controls.Add(nomeTbox);
            Controls.Add(imgImportar);
            Controls.Add(uploadBt);
            Controls.Add(menuStrip1);
            Location = new Point(379, 556);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(379, 556);
            MinimumSize = new Size(379, 556);
            Name = "AdminNovaPeca";
            Text = "Admin - Nova Peça";
            ((System.ComponentModel.ISupportInitialize)imgImportar).EndInit();
            ((System.ComponentModel.ISupportInitialize)anoNumeric).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uploadBt;
        private PictureBox imgImportar;
        private TextBox nomeTbox;
        private Button criarBt;
        private NumericUpDown anoNumeric;
        private Label label1;
        private RichTextBox descricaoRichTbox;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltarToolStripMenuItem;
    }
}