namespace HackathonPocket
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void adminBt_Click(object sender, EventArgs e)
        {
            AdminConfirmarSenha adminConfirmarSenha = new AdminConfirmarSenha();
            adminConfirmarSenha.Show();
            this.Hide();
        }

        private void convidadoBt_Click(object sender, EventArgs e)
        {
            TelaConvidado t = new TelaConvidado();
            t.Show();
            this.Hide();
        }
    }
}
