using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HackathonPocket
{
    public partial class TelaConvidado : Form
    {
        int id;
        public TelaConvidado()
        {
            InitializeComponent();
            SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\20231350252\Documents\museuDb.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "SELECT * FROM Peca";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();

            conexao.Open();
            dataAdapter.Fill(dataTable);
            conexao.Close();

            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                buscarBt.Enabled = true;
            }
            catch {
                MessageBox.Show("Erro...");
                buscarBt.Enabled = false;
            }
        }

        private void buscarBt_Click(object sender, EventArgs e)
        {
            TelaPecaEspecificaConvidado f = new TelaPecaEspecificaConvidado(id);
            f.Show();
            this.Hide();
        }
    }
}
