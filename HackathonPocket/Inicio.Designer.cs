namespace HackathonPocket
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            adminBt = new Button();
            convidadoBt = new Button();
            SuspendLayout();
            // 
            // adminBt
            // 
            adminBt.Location = new Point(12, 19);
            adminBt.Name = "adminBt";
            adminBt.Size = new Size(457, 33);
            adminBt.TabIndex = 0;
            adminBt.Text = "Admin";
            adminBt.UseVisualStyleBackColor = true;
            adminBt.Click += adminBt_Click;
            // 
            // convidadoBt
            // 
            convidadoBt.Location = new Point(12, 58);
            convidadoBt.Name = "convidadoBt";
            convidadoBt.Size = new Size(457, 33);
            convidadoBt.TabIndex = 1;
            convidadoBt.Text = "Convidado";
            convidadoBt.UseVisualStyleBackColor = true;
            convidadoBt.Click += convidadoBt_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gwerutgawe9uyoifoie4rhgiuhfoi;
            ClientSize = new Size(481, 110);
            Controls.Add(convidadoBt);
            Controls.Add(adminBt);
            MinimumSize = new Size(497, 149);
            Name = "Inicio";
            Text = "Início";
            ResumeLayout(false);
        }

        #endregion

        private Button adminBt;
        private Button convidadoBt;
    }
}
