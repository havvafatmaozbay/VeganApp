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
using System.IO;

namespace VeganYemekApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            benimIcınSec_UC1.Hide();
            
            lbl_hazirlanisi.Hide();
            lbl_malzemeler.Hide();
            richTextBox_hazirlanisi.Hide();
            richTextBox_malzemeler.Hide();
            pictureBox1.Hide();
            yemekEkle_UC1.Hide();
            elimdekilereGore_UC1.Hide();
            yemekAra_UC1.Hide();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select YemekAd From Tbl_Yemekler where Kategoriid=1", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox_anayemek.Items.Add(dr[0].ToString());

            }
            //bgl.baglanti().Close();
            SqlCommand komut2 = new SqlCommand("Select YemekAd From Tbl_Yemekler where Kategoriid=3", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox_kahvalti.Items.Add(dr2[0].ToString());

            }
            SqlCommand komut3 = new SqlCommand("Select YemekAd From Tbl_Yemekler where Kategoriid=2", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox_corba.Items.Add(dr3[0].ToString());

            }
            SqlCommand komut4 = new SqlCommand("Select YemekAd From Tbl_Yemekler where Kategoriid=4", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                comboBox_tatli.Items.Add(dr4[0].ToString());

            }
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            benimIcınSec_UC1.Hide();
            lbl_hazirlanisi.Hide();
            lbl_malzemeler.Hide();
            richTextBox_hazirlanisi.Hide();
            richTextBox_malzemeler.Hide();
            pictureBox1.Hide();
            lbl_anasayfa.Show();
            yemekEkle_UC1.Hide();
            elimdekilereGore_UC1.Hide();
            yemekAra_UC1.Hide();
        }

        private void btn_benimicinsec_Click(object sender, EventArgs e)
        {
            BenimIcınSec_UC benimIcınSec_UC = new BenimIcınSec_UC();
            pictureBox1.Hide();
            //lbl_anasayfa.Hide();
            yemekEkle_UC1.Hide();
            elimdekilereGore_UC1.Hide();
            yemekAra_UC1.Hide();
            benimIcınSec_UC1.Show();



        }

        private void comboBox_anayemek_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select YemekResim from Tbl_Yemekler where YemekAd ='" + comboBox_anayemek.Text + "'", bgl.baglanti());
            SqlDataReader dr = sqlCommand.ExecuteReader();
            byte[] bytediziResim = new byte[50];
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);

            long donenbytelar;
            long baslangicindeksi = 0;


            while (dr.Read())
            {

                donenbytelar = dr.GetBytes(0, 0, bytediziResim, 0, 50);
                while (donenbytelar == 50)
                {
                    bw.Write(bytediziResim);
                    bw.Flush();
                    baslangicindeksi += 50;
                    donenbytelar = dr.GetBytes(0, baslangicindeksi, bytediziResim, 0, 50);
                }
                bw.Write(bytediziResim);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);

                bw.Flush();
                bw.Close();
                ms.Close();

            }


            //dr.Close();


            SqlCommand yazikomut = new SqlCommand("Select * from Tbl_Yemekler where YemekAd='" + comboBox_anayemek.Text + "'", bgl.baglanti());
            SqlDataReader dryazi = yazikomut.ExecuteReader();

            while (dryazi.Read())
            {
                richTextBox_hazirlanisi.Text = dryazi.GetString(3);
                richTextBox_malzemeler.Text = dryazi.GetString(2);

            }
            //dr.Close();

            lbl_hazirlanisi.Show();
            lbl_malzemeler.Show();
            richTextBox_hazirlanisi.Show();
            richTextBox_malzemeler.Show();
            pictureBox1.Show();
            lbl_anasayfa.Hide();
            benimIcınSec_UC1.Hide();
            yemekEkle_UC1.Hide();
            elimdekilereGore_UC1.Hide();
            yemekAra_UC1.Hide();

        }

        private void comboBox_corba_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_Yemekler where YemekAd ='" + comboBox_corba.Text + "'", bgl.baglanti());
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {


                richTextBox_hazirlanisi.Text = dr.GetString(3);
                richTextBox_malzemeler.Text = dr.GetString(2);

            }
            SqlCommand komut = new SqlCommand("Select YemekResim from Tbl_Yemekler where YemekAd ='" + comboBox_corba.Text + "'", bgl.baglanti());
            SqlDataReader drResim = komut.ExecuteReader();
            byte[] bytediziResim = new byte[50];
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);

            long donenbytelar;
            long baslangicindeksi = 0;


            while (drResim.Read())
            {
                //richTextBox1.Text = dr.GetString(3);
                //richTextBox2.Text = dr.GetString(2);
                donenbytelar = drResim.GetBytes(0, 0, bytediziResim, 0, 50);
                while (donenbytelar == 50)
                {
                    bw.Write(bytediziResim);
                    bw.Flush();
                    baslangicindeksi += 50;
                    donenbytelar = drResim.GetBytes(0, baslangicindeksi, bytediziResim, 0, 50);
                }
                bw.Write(bytediziResim);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);

                bw.Flush();
                bw.Close();
                ms.Close();

            }
            lbl_hazirlanisi.Show();
            lbl_malzemeler.Show();
            richTextBox_hazirlanisi.Show();
            richTextBox_malzemeler.Show();
            pictureBox1.Show();
            lbl_anasayfa.Hide();
            benimIcınSec_UC1.Hide();
            yemekEkle_UC1.Hide();
            elimdekilereGore_UC1.Hide();
            yemekAra_UC1.Hide();
        }

        private void comboBox_kahvalti_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_Yemekler where YemekAd ='" + comboBox_kahvalti.Text + "'", bgl.baglanti());
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {


                richTextBox_hazirlanisi.Text = dr.GetString(3);
                richTextBox_malzemeler.Text = dr.GetString(2);

            }
            SqlCommand komut = new SqlCommand("Select YemekResim from Tbl_Yemekler where YemekAd ='" + comboBox_kahvalti.Text + "'", bgl.baglanti());
            SqlDataReader drResim = komut.ExecuteReader();
            byte[] bytediziResim = new byte[50];
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);

            long donenbytelar;
            long baslangicindeksi = 0;


            while (drResim.Read())
            {
                //richTextBox1.Text = dr.GetString(3);
                //richTextBox2.Text = dr.GetString(2);
                donenbytelar = drResim.GetBytes(0, 0, bytediziResim, 0, 50);
                while (donenbytelar == 50)
                {
                    bw.Write(bytediziResim);
                    bw.Flush();
                    baslangicindeksi += 50;
                    donenbytelar = drResim.GetBytes(0, baslangicindeksi, bytediziResim, 0, 50);
                }
                bw.Write(bytediziResim);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);

                bw.Flush();
                bw.Close();
                ms.Close();

            }
            lbl_hazirlanisi.Show();
            lbl_malzemeler.Show();
            richTextBox_hazirlanisi.Show();
            richTextBox_malzemeler.Show();
            pictureBox1.Show();
            lbl_anasayfa.Hide();
            benimIcınSec_UC1.Hide();
            yemekEkle_UC1.Hide();
            elimdekilereGore_UC1.Hide();
            yemekAra_UC1.Hide();
        }

        private void comboBox_tatli_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_Yemekler where YemekAd ='" + comboBox_tatli.Text + "'", bgl.baglanti());
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {


                richTextBox_hazirlanisi.Text = dr.GetString(3);
                richTextBox_malzemeler.Text = dr.GetString(2);

            }
            SqlCommand komut = new SqlCommand("Select YemekResim from Tbl_Yemekler where YemekAd ='" + comboBox_tatli.Text + "'", bgl.baglanti());
            SqlDataReader drResim = komut.ExecuteReader();
            byte[] bytediziResim = new byte[50];
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);

            long donenbytelar;
            long baslangicindeksi = 0;


            while (drResim.Read())
            {

                donenbytelar = drResim.GetBytes(0, 0, bytediziResim, 0, 50);
                while (donenbytelar == 50)
                {
                    bw.Write(bytediziResim);
                    bw.Flush();
                    baslangicindeksi += 50;
                    donenbytelar = drResim.GetBytes(0, baslangicindeksi, bytediziResim, 0, 50);
                }
                bw.Write(bytediziResim);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);

                bw.Flush();
                bw.Close();
                ms.Close();

            }
            lbl_hazirlanisi.Show();
            lbl_malzemeler.Show();
            richTextBox_hazirlanisi.Show();
            richTextBox_malzemeler.Show();
            pictureBox1.Show();
            lbl_anasayfa.Hide();
            benimIcınSec_UC1.Hide();
            yemekEkle_UC1.Hide();
            elimdekilereGore_UC1.Hide();
            yemekAra_UC1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YemekEkle_UC yemekEkle_UC = new YemekEkle_UC();
            pictureBox1.Hide();
            benimIcınSec_UC1.Hide();
            elimdekilereGore_UC1.Hide();
            yemekAra_UC1.Hide();
            yemekEkle_UC1.Show();
            yemekEkle_UC1.Refresh_UC();
        }

        private void btn_malzemeyegore_Click(object sender, EventArgs e)
        {
            ElimdekilereGore_UC elimdekilereGore_UC = new ElimdekilereGore_UC();
            pictureBox1.Hide();
            elimdekilereGore_UC1.Show();

            benimIcınSec_UC1.Hide();
            yemekEkle_UC1.Hide();
            yemekAra_UC1.Hide();
        }

        private void btn_YemekAra_Click(object sender, EventArgs e)
        {
            YemekAra_UC yemekAra_UC = new YemekAra_UC();
            pictureBox1.Hide();
            yemekAra_UC1.Show();
            
            benimIcınSec_UC1.Hide();
            elimdekilereGore_UC1.Hide();
            yemekEkle_UC1.Hide();
        }
    }
}
