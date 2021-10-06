using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VeganYemekApp
{
    public partial class BenimIcınSec_UC : UserControl
    {
        public BenimIcınSec_UC()
        {
            InitializeComponent();
            anayemeksec();
            resimsec();
            corbasec();
            tatlisec();
            kahvaltisec();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void BenimIcınSec_UC_Load(object sender, EventArgs e)
        {

        }
        void anayemeksec()
        {
            textBox_anayemek.Text = "";
            SqlCommand komut = new SqlCommand("Select TOP 1 YemekAd from Tbl_Yemekler where Kategoriid = 1 Order By NEWID()", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                textBox_anayemek.Text += dr["YemekAd"];

            }


        }
        void resimsec()
        {
            SqlCommand sqlCommand = new SqlCommand("Select YemekResim from Tbl_Yemekler where YemekAd ='" + textBox_anayemek.Text + "'", bgl.baglanti());
            SqlDataReader drr = sqlCommand.ExecuteReader();
            byte[] bytediziResim = new byte[50];
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);

            long donenbytelar;
            long baslangicindeksi = 0;


            while (drr.Read())
            {
                
                donenbytelar = drr.GetBytes(0, 0, bytediziResim, 0, 50);
                while (donenbytelar == 50)
                {
                    bw.Write(bytediziResim);
                    bw.Flush();
                    baslangicindeksi += 50;
                    donenbytelar = drr.GetBytes(0, baslangicindeksi, bytediziResim, 0, 50);
                }
                bw.Write(bytediziResim);
                pictureBox_anayemek.Image = System.Drawing.Image.FromStream(ms);

                bw.Flush();
                bw.Close();
                ms.Close();

            }


        }
        void corbasec()
        {
            textBox_corba.Text = "";
            SqlCommand komut = new SqlCommand("Select TOP 1 YemekAd from Tbl_Yemekler where Kategoriid = 2 Order By NEWID()", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                textBox_corba.Text += dr["YemekAd"];

            }
            SqlCommand sqlCommand = new SqlCommand("Select YemekResim from Tbl_Yemekler where YemekAd ='" + textBox_corba.Text + "'", bgl.baglanti());
            SqlDataReader drr = sqlCommand.ExecuteReader();
            byte[] bytediziResim = new byte[50];
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);

            long donenbytelar;
            long baslangicindeksi = 0;


            while (drr.Read())
            {
                
                donenbytelar = drr.GetBytes(0, 0, bytediziResim, 0, 50);
                while (donenbytelar == 50)
                {
                    bw.Write(bytediziResim);
                    bw.Flush();
                    baslangicindeksi += 50;
                    donenbytelar = drr.GetBytes(0, baslangicindeksi, bytediziResim, 0, 50);
                }
                bw.Write(bytediziResim);
                pictureBox_corba.Image = System.Drawing.Image.FromStream(ms);

                bw.Flush();
                bw.Close();
                ms.Close();

            }
        }

        void tatlisec()
        {
            textBox_tatli.Text = "";
            SqlCommand komut = new SqlCommand("Select TOP 1 YemekAd from Tbl_Yemekler where Kategoriid = 4 Order By NEWID()", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                textBox_tatli.Text += dr["YemekAd"];

            }
            SqlCommand sqlCommand = new SqlCommand("Select YemekResim from Tbl_Yemekler where YemekAd ='" + textBox_tatli.Text + "'", bgl.baglanti());
            SqlDataReader drr = sqlCommand.ExecuteReader();
            byte[] bytediziResim = new byte[50];
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);

            long donenbytelar;
            long baslangicindeksi = 0;


            while (drr.Read())
            {

                donenbytelar = drr.GetBytes(0, 0, bytediziResim, 0, 50);
                while (donenbytelar == 50)
                {
                    bw.Write(bytediziResim);
                    bw.Flush();
                    baslangicindeksi += 50;
                    donenbytelar = drr.GetBytes(0, baslangicindeksi, bytediziResim, 0, 50);
                }
                bw.Write(bytediziResim);
                pictureBox_tatli.Image = System.Drawing.Image.FromStream(ms);

                bw.Flush();
                bw.Close();
                ms.Close();

            }
        }

        void kahvaltisec()
        {
            textBox_kahvalti.Text = "";
            SqlCommand komut = new SqlCommand("Select TOP 1 YemekAd from Tbl_Yemekler where Kategoriid=3 Order By NEWID()", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                textBox_kahvalti.Text += dr["YemekAd"];

            }
            SqlCommand sqlCommand = new SqlCommand("Select YemekResim from Tbl_Yemekler where YemekAd ='" + textBox_kahvalti.Text + "'", bgl.baglanti());
            SqlDataReader drr = sqlCommand.ExecuteReader();
            byte[] bytediziResim = new byte[50];
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);

            long donenbytelar;
            long baslangicindeksi = 0;


            while (drr.Read())
            {

                donenbytelar = drr.GetBytes(0, 0, bytediziResim, 0, 50);
                while (donenbytelar == 50)
                {
                    bw.Write(bytediziResim);
                    bw.Flush();
                    baslangicindeksi += 50;
                    donenbytelar = drr.GetBytes(0, baslangicindeksi, bytediziResim, 0, 50);
                }
                bw.Write(bytediziResim);
                pictureBox_kahvalti.Image = System.Drawing.Image.FromStream(ms);

                bw.Flush();
                bw.Close();
                ms.Close();

            }
        }

        private void pictureBox_anayemek_DoubleClick(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_Yemekler where YemekAd='" + textBox_anayemek.Text + "'", bgl.baglanti());
            SqlDataReader dr = sqlCommand.ExecuteReader();

            while (dr.Read())
            {
                textBox_yemekadi.Text = dr.GetString(1);
                richTextBox_yemekmalzeme.Text = dr.GetString(2);
                richTextBox_yemektarif.Text = dr.GetString(3);
            }


        }

        private void pictureBox_corba_DoubleClick(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_Yemekler where YemekAd='" + textBox_corba.Text + "'", bgl.baglanti());
            SqlDataReader dr = sqlCommand.ExecuteReader();

            while (dr.Read())
            {
                textBox_yemekadi.Text = dr.GetString(1);
                richTextBox_yemektarif.Text = dr.GetString(3);
                richTextBox_yemekmalzeme.Text = dr.GetString(2);
            }
        }

        private void pictureBox_kahvalti_DoubleClick(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_Yemekler where YemekAd='" + textBox_kahvalti.Text + "'", bgl.baglanti());
            SqlDataReader dr = sqlCommand.ExecuteReader();

            while (dr.Read())
            {
                textBox_yemekadi.Text = dr.GetString(1);
                richTextBox_yemektarif.Text = dr.GetString(3);
                richTextBox_yemekmalzeme.Text = dr.GetString(2);
            }
        }

        private void pictureBox_tatli_DoubleClick(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_Yemekler where YemekAd='" + textBox_tatli.Text + "'", bgl.baglanti());
            SqlDataReader dr = sqlCommand.ExecuteReader();

            while (dr.Read())
            {
                textBox_yemekadi.Text = dr.GetString(1);
                richTextBox_yemektarif.Text = dr.GetString(3);
                richTextBox_yemekmalzeme.Text = dr.GetString(2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anayemeksec();
            kahvaltisec();
            tatlisec();
            corbasec();
            resimsec();
        }

        private void textBox_corba_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
