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
    public partial class AdminConfirmarSenha : Form
    {
        public AdminConfirmarSenha()
        {
            InitializeComponent();
        }

        private void entrarBt_Click(object sender, EventArgs e)
        {
            if (senhaTbox.Text == "bPABUq3jcqAgoBU0tafLAvXpTNeU9ygmPASh6-OTk1Y4Syz-sTVQhXb0cqc1hZE5")
            {
                AdminInicio adminInicio = new AdminInicio();
                adminInicio.Show();
                this.Hide();
            }
            else
            {
                Inicio f = new Inicio();
                f.Show();
                this.Hide();
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio f = new Inicio();
            f.Show();
            this.Hide();
        }
    }
}
