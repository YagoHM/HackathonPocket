using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonPocket
{
    public partial class AdminInicio : Form
    {
        public AdminInicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminNovaPeca f = new AdminNovaPeca();
            f.Show();
            this.Hide();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio f = new Inicio();
            f.Show();
            this.Hide();
        }

        private void editarBt_Click(object sender, EventArgs e)
        {
            AdminVisualizarEditarPeca f = new AdminVisualizarEditarPeca();
            f.Show();
            this.Hide();
        }
    }
}
