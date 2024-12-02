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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HackathonPocket
{
    public partial class AdminVisualizarEditarPeca : Form
    {
        public AdminVisualizarEditarPeca()
        {
            InitializeComponent();
        }

        int id;
        byte[] byteImg;
        
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

                public static Image ByteArrayToImage(byte[] byteArray, PictureBox p)
        {
            try
            {
                using (MemoryStream mStream = new MemoryStream(byteArray))
                {
                    return Image.FromStream(mStream);
                }
            }

            catch (Exception)
            {
                return p.ErrorImage;
            }
        }


        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminInicio f = new AdminInicio();
            f.Show();
            this.Hide();
        }

        private void buscarBt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\20231350252\Documents\museuDb.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "SELECT * FROM Peca WHERE nome=@nome";
                comando.Parameters.AddWithValue("@nome", nomeBuscar.Text);

                conexao.Open();
                SqlDataReader leitor = comando.ExecuteReader(); 

                if (leitor.Read()) 
                {
                    id = (int)leitor["id_peca"];
                    nomeTbox.Text = leitor["nome"].ToString();
                    descricaoRichTbox.Text = leitor["descricao"].ToString();
                    anoNumeric.Value = Convert.ToInt32(leitor["ano"]);
                    imgImportar.Image = ByteArrayToImage((byte[])leitor["imagem"], imgImportar);
                    salvarBt.Enabled = true;
                    deletarBt.Enabled = true;
                    byteImg = (byte[])leitor["imagem"];
                }
                else
                {
                    MessageBox.Show("Peça não encontrada!");

                    AdminInicio i = new AdminInicio();
                    i.Show();
                    this.Hide();
                }

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao buscar a peça: " + erro.Message);

                AdminInicio i = new AdminInicio();
                i.Show();
                this.Hide();
            }

        }
        private void salvarBt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\20231350252\Documents\museuDb.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE Peca SET nome=@nome, imagem=@imagem, descricao=@descricao, ano=@ano WHERE id_peca=@id_peca";
                comando.Parameters.AddWithValue("@nome", nomeTbox.Text);
                comando.Parameters.AddWithValue("@descricao", descricaoRichTbox.Text);
                comando.Parameters.AddWithValue("@ano", (int)anoNumeric.Value);

                byte[] imgBytes = ConvertImageToBinary(imgImportar.Image);
                if (imgBytes != null)
                {
                    comando.Parameters.AddWithValue("@imagem", imgBytes);
                }
                else
                {
                    comando.Parameters.AddWithValue("@imagem", byteImg);
                }

                comando.Parameters.AddWithValue("@id_peca", id);

                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Peça alterada com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: "+erro.Message);
            }

            AdminInicio i = new AdminInicio();
            i.Show();
            this.Hide();
        }
        private void deletarBt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\20231350252\Documents\museuDb.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM Peca WHERE id_peca=@id_peca";
                comando.Parameters.AddWithValue("@id_peca", id); 
                conexao.Open();
                comando.ExecuteNonQuery(); 
                conexao.Close();

                MessageBox.Show("Peça excluída com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir a peça: " + erro.Message);
            }
            AdminInicio i = new AdminInicio();
            i.Show();
            this.Hide();
        }
    }
}
