namespace HackathonPocket
{
    partial class AdminVisualizarEditarPeca
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
            label2 = new Label();
            descricaoRichTbox = new RichTextBox();
            label1 = new Label();
            anoNumeric = new NumericUpDown();
            salvarBt = new Button();
            nomeTbox = new TextBox();
            imgImportar = new PictureBox();
            uploadBt = new Button();
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            nomeBuscar = new TextBox();
            buscarBt = new Button();
            deletarBt = new Button();
            ((System.ComponentModel.ISupportInitialize)anoNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgImportar).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 351);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 49;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 291);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 48;
            label2.Text = "Ano";
            // 
            // descricaoRichTbox
            // 
            descricaoRichTbox.Location = new Point(13, 372);
            descricaoRichTbox.Name = "descricaoRichTbox";
            descricaoRichTbox.Size = new Size(339, 145);
            descricaoRichTbox.TabIndex = 47;
            descricaoRichTbox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 229);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 46;
            label1.Text = "Nome";
            // 
            // anoNumeric
            // 
            anoNumeric.Location = new Point(13, 312);
            anoNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            anoNumeric.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            anoNumeric.Name = "anoNumeric";
            anoNumeric.Size = new Size(339, 23);
            anoNumeric.TabIndex = 45;
            // 
            // salvarBt
            // 
            salvarBt.Enabled = false;
            salvarBt.Location = new Point(13, 527);
            salvarBt.Name = "salvarBt";
            salvarBt.Size = new Size(339, 23);
            salvarBt.TabIndex = 44;
            salvarBt.Text = "Salvar";
            salvarBt.UseVisualStyleBackColor = true;
            salvarBt.Click += salvarBt_Click;
            // 
            // nomeTbox
            // 
            nomeTbox.Location = new Point(13, 250);
            nomeTbox.Name = "nomeTbox";
            nomeTbox.Size = new Size(339, 23);
            nomeTbox.TabIndex = 43;
            // 
            // imgImportar
            // 
            imgImportar.BackColor = Color.White;
            imgImportar.BorderStyle = BorderStyle.FixedSingle;
            imgImportar.ErrorImage = Properties.Resources.nenhum;
            imgImportar.Image = Properties.Resources.nenhum;
            imgImportar.InitialImage = Properties.Resources.nenhum;
            imgImportar.Location = new Point(120, 69);
            imgImportar.Name = "imgImportar";
            imgImportar.Size = new Size(124, 124);
            imgImportar.SizeMode = PictureBoxSizeMode.StretchImage;
            imgImportar.TabIndex = 42;
            imgImportar.TabStop = false;
            // 
            // uploadBt
            // 
            uploadBt.Location = new Point(120, 209);
            uploadBt.Name = "uploadBt";
            uploadBt.Size = new Size(124, 23);
            uploadBt.TabIndex = 41;
            uploadBt.Text = "Upload Foto";
            uploadBt.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(363, 24);
            menuStrip1.TabIndex = 50;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // nomeBuscar
            // 
            nomeBuscar.Location = new Point(13, 27);
            nomeBuscar.Name = "nomeBuscar";
            nomeBuscar.PlaceholderText = "Procure pelo nome...";
            nomeBuscar.Size = new Size(251, 23);
            nomeBuscar.TabIndex = 51;
            // 
            // buscarBt
            // 
            buscarBt.Location = new Point(270, 27);
            buscarBt.Name = "buscarBt";
            buscarBt.Size = new Size(81, 23);
            buscarBt.TabIndex = 52;
            buscarBt.Text = "Buscar";
            buscarBt.UseVisualStyleBackColor = true;
            buscarBt.Click += buscarBt_Click;
            // 
            // deletarBt
            // 
            deletarBt.Enabled = false;
            deletarBt.Location = new Point(13, 556);
            deletarBt.Name = "deletarBt";
            deletarBt.Size = new Size(339, 23);
            deletarBt.TabIndex = 53;
            deletarBt.Text = "Deletar";
            deletarBt.UseVisualStyleBackColor = true;
            deletarBt.Click += deletarBt_Click;
            // 
            // AdminVisualizarEditarPeca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gwerutgawe9uyoifoie4rhgiuhfoi;
            ClientSize = new Size(363, 591);
            Controls.Add(deletarBt);
            Controls.Add(buscarBt);
            Controls.Add(nomeBuscar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descricaoRichTbox);
            Controls.Add(label1);
            Controls.Add(anoNumeric);
            Controls.Add(salvarBt);
            Controls.Add(nomeTbox);
            Controls.Add(imgImportar);
            Controls.Add(uploadBt);
            Controls.Add(menuStrip1);
            Name = "AdminVisualizarEditarPeca";
            Text = "Admin - Visualizar e Editar Peça";
            ((System.ComponentModel.ISupportInitialize)anoNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgImportar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private RichTextBox descricaoRichTbox;
        private Label label1;
        private NumericUpDown anoNumeric;
        private Button salvarBt;
        private TextBox nomeTbox;
        private PictureBox imgImportar;
        private Button uploadBt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private TextBox nomeBuscar;
        private Button buscarBt;
        private Button deletarBt;
    }
}