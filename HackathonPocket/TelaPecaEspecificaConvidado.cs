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
using MessagingToolkit.QRCode.Codec;

namespace HackathonPocket
{
    public partial class TelaPecaEspecificaConvidado : Form
    {
        int id;

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



        public TelaPecaEspecificaConvidado(int id)
        {
            InitializeComponent();
            this.id = id;
            SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\20231350252\Documents\museuDb.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "SELECT * FROM Peca WHERE id_peca=@id_peca";
            comando.Parameters.AddWithValue("@id_peca", id);

            conexao.Open();
            SqlDataReader leitor = comando.ExecuteReader();
            
            if(leitor.Read())
            {
                nomeLabel.Text = "Nome: " + leitor["nome"].ToString();
                descricaoRichTbox.Text = leitor["descricao"].ToString();
                anoLabel.Text = "Ano: " + (int)leitor["ano"];
                imgImportar.Image = ByteArrayToImage((byte[])leitor["imagem"], imgImportar);
            }

            try
            {
                QRCodeEncoder qrCodecEncoder = new QRCodeEncoder();
                qrCodecEncoder.QRCodeBackgroundColor = System.Drawing.Color.White;
                qrCodecEncoder.QRCodeForegroundColor = System.Drawing.Color.Black;
                qrCodecEncoder.CharacterSet = "UTF-8";
                qrCodecEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                qrCodecEncoder.QRCodeScale = 6;
                qrCodecEncoder.QRCodeVersion = 0;
                qrCodecEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
                Image imageQRCode;
                String dados = "https://pt.wikipedia.org/wiki/" + leitor["nome"].ToString();
                imageQRCode = qrCodecEncoder.Encode(dados);
                qrCode.Image = imageQRCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void TelaPecaEspecificaConvidado_Load(object sender, EventArgs e)
        {

        }

        private void voltartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaConvidado f = new TelaConvidado();
            f.Show();
            this.Hide();
        }
    }
}
