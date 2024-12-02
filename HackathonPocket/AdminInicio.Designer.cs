namespace HackathonPocket
{
    partial class AdminInicio
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
            editarBt = new Button();
            criarBt = new Button();
            menuStrip1 = new MenuStrip();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // editarBt
            // 
            editarBt.Location = new Point(12, 102);
            editarBt.Name = "editarBt";
            editarBt.Size = new Size(457, 33);
            editarBt.TabIndex = 3;
            editarBt.Text = "Visualizar/Editar/Excluir Peça";
            editarBt.UseVisualStyleBackColor = true;
            editarBt.Click += editarBt_Click;
            // 
            // criarBt
            // 
            criarBt.Location = new Point(12, 41);
            criarBt.Name = "criarBt";
            criarBt.Size = new Size(457, 33);
            criarBt.TabIndex = 4;
            criarBt.Text = "Criar Peça";
            criarBt.UseVisualStyleBackColor = true;
            criarBt.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(481, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // AdminInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gwerutgawe9uyoifoie4rhgiuhfoi;
            ClientSize = new Size(481, 301);
            Controls.Add(criarBt);
            Controls.Add(editarBt);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminInicio";
            Text = "Admin - Início";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button editarBt;
        private Button criarBt;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem voltarToolStripMenuItem;
    }
}