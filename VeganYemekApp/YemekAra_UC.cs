using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace VeganYemekApp
{
    public partial class YemekAra_UC : UserControl
    {
        public YemekAra_UC()
        {
            InitializeComponent();
            
            
            
            
            

        }
        
        
        SqlBaglanti bgl = new SqlBaglanti();
        

        private void YemekAra_UC_Load(object sender, EventArgs e)
        {
            
            
        }
         
        void select()
        {

            SqlCommand komut = new SqlCommand("Select YemekAd from Tbl_Yemekler  where YemekAd like '%" + textBox1.Text + "%'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.ValueMember = "YemekAd";
            listBox1.DisplayMember = "YemekAd";


        }

   



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            select();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            select();



        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komutx = new SqlCommand("Select * From Tbl_Yemekler Where YemekAd = '" + listBox1.SelectedValue + "'", bgl.baglanti());
            SqlDataReader dr = komutx.ExecuteReader();
            while (dr.Read())
            {
                richTextBox1.Text = dr.GetString(2);
                richTextBox2.Text = dr.GetString(3);
            }
            SqlCommand sqlCommand = new SqlCommand("Select YemekResim from Tbl_Yemekler where YemekAd ='" + listBox1.SelectedValue + "'", bgl.baglanti());
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
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);

                bw.Flush();
                bw.Close();
                ms.Close();
            }
        }

        private void listBox1_DisplayMemberChanged(object sender, EventArgs e)
        {

        }
    }
}
