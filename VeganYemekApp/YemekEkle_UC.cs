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
    public partial class YemekEkle_UC : UserControl
    {
        public YemekEkle_UC()
        {
            InitializeComponent();
        }
        SqlBaglanti baglantiekle = new SqlBaglanti();
        private void YemekEkle_UC_Load(object sender, EventArgs e)
        {
            
        }

        public void Refresh_UC()
        {
            SqlBaglanti baglantiekle = new SqlBaglanti();
            comboBox1.Items.Clear();
            SqlCommand komut = new SqlCommand("Select YemekAd From Tbl_Yemekler ", baglantiekle.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());

            }
            comboBox1.Text = "seciniz";
            richTextBox_malzeme.Clear();
            richTextBox_tarif.Clear();
            textBox_yemekadi.Clear();
            pictureBox1.Image = null;

        }
        void YemekEkle()
        {
            SqlBaglanti baglantiekle = new SqlBaglanti();

            SqlCommand ekle = new SqlCommand("INSERT INTO Tbl_Yemekler (YemekAd, YemekMalzeme, YemekTArif) VALUES (@YemekAd, @YemekMalzeme, @YemekTarif)", baglantiekle.baglanti());
            ekle.Parameters.AddWithValue("@YemekAd", textBox_yemekadi.Text);
            ekle.Parameters.AddWithValue("@YemekMalzeme", richTextBox_malzeme.Text);
            ekle.Parameters.AddWithValue("@YemekTarif", richTextBox_tarif.Text);

            if (textBox_yemekadi.Text.Length != 0 && richTextBox_tarif.Text.Length != 0 && richTextBox_malzeme.Text.Length != 0)
            {
                ekle.ExecuteNonQuery();
                string message = "Yemek Kaydedildi!";
                MessageBox.Show(message);

            }
            else
            {
                string uyarı4 = "Lütfen Tüm alanları Doldurunuz";
                MessageBox.Show(uyarı4);
            }



            if (textBox_yemekadi.Text.Length == 0 && richTextBox_malzeme.Text.Length == 0 && richTextBox_tarif.Text.Length == 0)
            {
                string uyarı = " Lütfen Yemek Adı Giriniz";
                MessageBox.Show(uyarı);


            }



            

        }

        string resimAdresi;
        void ResimEkle()
        {
            FileStream fsResim = new FileStream(resimAdresi, FileMode.Open, FileAccess.Read);
            BinaryReader brResim = new BinaryReader(fsResim);

            byte[] resim = brResim.ReadBytes((int)fsResim.Length);
            brResim.Close();
            fsResim.Close();

            SqlConnection conResim = new SqlConnection("Data Source=DESKTOP-OQ1P4OP\\SQLEXPRESS;Initial Catalog=düzeltmeVeganYemekArifi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmdResimKaydet = new SqlCommand("update Tbl_Yemekler set YemekResim = @YemekResim  where YemekAd='" + textBox_yemekadi.Text + "'", conResim);
            //cmdResimKaydet.Parameters.Add("@Yorum", SqlDbType.Char, 250).Value = txtYorum.Text; /* Bu parametremiz @Yorum isminde ve Char tipinde. 250 karakter uzunlugunda. Hemen ayni satirda Value özelligini kullanarak parametrenin degerinide belirliyoruz. */
            cmdResimKaydet.Parameters.Add("@yemekresim", SqlDbType.Image, resim.Length).Value = resim; /* Seçtigimiz resim dosyasinin byte'larini, tablodaki ilgili alana tasiyacak parametremizi belirtiyoruz. Deger olarak, resim isimli byte dizimizi aktariyoruz. Parametre tipinin, image olduguna dikkat edelim. */

            try
            {
                conResim.Open();
                cmdResimKaydet.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conResim.Close();
            }


        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            YemekEkle();
            ResimEkle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                resimAdresi = openFileDialog1.FileName.ToString();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_Yemekler where YemekAd ='" + comboBox1.Text + "'", baglantiekle.baglanti());
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {


                richTextBox_malzeme.Text = dr.GetString(3);
                richTextBox_tarif.Text = dr.GetString(2);

            }
            SqlCommand komut = new SqlCommand("Select YemekResim from Tbl_Yemekler where YemekAd ='" + comboBox1.Text + "'", baglantiekle.baglanti());
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
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Yemekler where YemekAd='" + comboBox1.Text + "'", baglantiekle.baglanti());

            komut.ExecuteNonQuery();

            DialogResult secenek = MessageBox.Show("Yemeği Silmek İstediğinizden Emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Yemek Silindi!");
                //Veritabanına kayıt ekleyen kodlar
            }
            else if (secenek == DialogResult.No)
            {

            }
        }

        void YemekGuncelle()
        {
            SqlCommand komut = new SqlCommand("update Tbl_Yemekler set YemekAd=@YemekAd, YemekMalzeme=@YemekMalzeme, YemekTArif=@YemekTarif where YemekAd ='" + comboBox1.Text + "'", baglantiekle.baglanti());

            komut.Parameters.AddWithValue("@YemekAd", textBox_yemekadi.Text);
            komut.Parameters.AddWithValue("@YemekMalzeme", richTextBox_malzeme.Text);
            komut.Parameters.AddWithValue("@YemekTarif", richTextBox_tarif.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Yemek Güncellendi!");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            YemekGuncelle();
            ResimEkle();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
