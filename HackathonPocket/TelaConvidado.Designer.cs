﻿namespace HackathonPocket
{
    partial class TelaConvidado
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
            dataGridView1 = new DataGridView();
            buscarBt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 404);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buscarBt
            // 
            buscarBt.Enabled = false;
            buscarBt.Location = new Point(12, 422);
            buscarBt.Name = "buscarBt";
            buscarBt.Size = new Size(776, 23);
            buscarBt.TabIndex = 1;
            buscarBt.Text = "Detalhes";
            buscarBt.UseVisualStyleBackColor = true;
            buscarBt.Click += buscarBt_Click;
            // 
            // TelaConvidado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gwerutgawe9uyoifoie4rhgiuhfoi;
            ClientSize = new Size(800, 450);
            Controls.Add(buscarBt);
            Controls.Add(dataGridView1);
            Name = "TelaConvidado";
            Text = "Tela - Convidado";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buscarBt;
    }
}