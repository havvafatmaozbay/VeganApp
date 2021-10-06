using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeganYemekApp
{
    public partial class ElimdekilereGore_UC : UserControl
    {
        public ElimdekilereGore_UC()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataTable tbl = new DataTable();
        SqlBaglanti bgl = new SqlBaglanti();

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ElimdekilereGore_UC_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                string s = "";
                int x;
                for (x = 0; x <= checkedListBox1.CheckedItems.Count - 1; x++)
                {
                    s = checkedListBox1.CheckedItems[x].ToString();
                }

                s = s.Substring(0, s.Length - 1);
                SqlCommand komut = new SqlCommand(" SELECT YemekAd from Tbl_Yemekler WHERE YemekMalzeme like '%" + s + "%'", bgl.baglanti());
                da = new SqlDataAdapter(komut);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                SqlDataReader dr = komut.ExecuteReader();


              
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["YemekAd"].FormattedValue.ToString();
                detaygoster();

            }

        }

        void detaygoster()
        {
            SqlCommand komutx = new SqlCommand("Select * From Tbl_Yemekler Where YemekAd = '" + textBox1.Text + "'", bgl.baglanti());
            SqlDataReader drx = komutx.ExecuteReader();

            while (drx.Read())
            {
                richTextBox1.Text = drx.GetString(3);
                richTextBox2.Text = drx.GetString(2);

            }
            SqlCommand sqlCommand = new SqlCommand("Select YemekResim from Tbl_Yemekler where YemekAd ='" + textBox1.Text + "'", bgl.baglanti());
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //sdjkfdns
        }
    }
}
