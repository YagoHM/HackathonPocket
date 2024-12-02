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
    public partial class AdminNovaPeca : Form
    {
        public AdminNovaPeca()
        {
            InitializeComponent();
        }

        Bitmap localImg;
        public static byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return mStream.ToArray();
            }
        }

        private void uploadBt_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Image imagem = Image.FromFile(dialog.FileName);
                    imgImportar.Image = imagem;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro ocorreu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void criarBt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\20231350252\Documents\museuDb.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "INSERT INTO Peca (nome, imagem, descricao,ano) values (@nome,@imagem,@descricao,@ano)";
                comando.Parameters.AddWithValue("@nome", nomeTbox.Text);
                comando.Parameters.AddWithValue("@descricao", descricaoRichTbox.Text);
                comando.Parameters.AddWithValue("@ano", (int)anoNumeric.Value);
                comando.Parameters.AddWithValue("@imagem", ConvertImageToBinary(imgImportar.Image));
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Registro Inserido com Sucesso!");
                AdminInicio i = new AdminInicio();
                i.Show();
                this.Hide();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Incluir!==> " + erro.Message);
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminInicio f = new AdminInicio();
            f.Show();
            this.Hide();
        }
    }
}
