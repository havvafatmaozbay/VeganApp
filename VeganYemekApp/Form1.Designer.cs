
namespace VeganYemekApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_YemekAra = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_malzemeyegore = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_benimicinsec = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.comboBox_kahvalti = new System.Windows.Forms.ComboBox();
            this.comboBox_corba = new System.Windows.Forms.ComboBox();
            this.comboBox_anayemek = new System.Windows.Forms.ComboBox();
            this.comboBox_tatli = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox_malzemeler = new System.Windows.Forms.RichTextBox();
            this.richTextBox_hazirlanisi = new System.Windows.Forms.RichTextBox();
            this.lbl_malzemeler = new System.Windows.Forms.Label();
            this.lbl_hazirlanisi = new System.Windows.Forms.Label();
            this.lbl_anasayfa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yemekEkle_UC1 = new VeganYemekApp.YemekEkle_UC();
            this.benimIcınSec_UC1 = new VeganYemekApp.BenimIcınSec_UC();
            this.elimdekilereGore_UC1 = new VeganYemekApp.ElimdekilereGore_UC();
            this.yemekAra_UC1 = new VeganYemekApp.YemekAra_UC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.btn_YemekAra);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_malzemeyegore);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_benimicinsec);
            this.panel1.Controls.Add(this.btn_anasayfa);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 582);
            this.panel1.TabIndex = 0;
            // 
            // btn_YemekAra
            // 
            this.btn_YemekAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_YemekAra.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_YemekAra.Location = new System.Drawing.Point(0, 253);
            this.btn_YemekAra.Name = "btn_YemekAra";
            this.btn_YemekAra.Size = new System.Drawing.Size(170, 73);
            this.btn_YemekAra.TabIndex = 15;
            this.btn_YemekAra.Text = "Yemek Ara";
            this.btn_YemekAra.UseVisualStyleBackColor = true;
            this.btn_YemekAra.Click += new System.EventHandler(this.btn_YemekAra_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(11, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "VeganApp";
            // 
            // btn_malzemeyegore
            // 
            this.btn_malzemeyegore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_malzemeyegore.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_malzemeyegore.Location = new System.Drawing.Point(0, 482);
            this.btn_malzemeyegore.Name = "btn_malzemeyegore";
            this.btn_malzemeyegore.Size = new System.Drawing.Size(173, 84);
            this.btn_malzemeyegore.TabIndex = 5;
            this.btn_malzemeyegore.Text = "Elimdeki Malzemeye Göre ";
            this.btn_malzemeyegore.UseVisualStyleBackColor = true;
            this.btn_malzemeyegore.Click += new System.EventHandler(this.btn_malzemeyegore_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 64);
            this.button3.TabIndex = 4;
            this.button3.Text = "Yemek Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_benimicinsec
            // 
            this.btn_benimicinsec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_benimicinsec.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_benimicinsec.Location = new System.Drawing.Point(0, 332);
            this.btn_benimicinsec.Name = "btn_benimicinsec";
            this.btn_benimicinsec.Size = new System.Drawing.Size(173, 74);
            this.btn_benimicinsec.TabIndex = 3;
            this.btn_benimicinsec.Text = "Benim İçin Seç";
            this.btn_benimicinsec.UseVisualStyleBackColor = true;
            this.btn_benimicinsec.Click += new System.EventHandler(this.btn_benimicinsec_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anasayfa.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anasayfa.Location = new System.Drawing.Point(0, 174);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(170, 73);
            this.btn_anasayfa.TabIndex = 2;
            this.btn_anasayfa.Text = "AnaSayfa";
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // comboBox_kahvalti
            // 
            this.comboBox_kahvalti.BackColor = System.Drawing.Color.RosyBrown;
            this.comboBox_kahvalti.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_kahvalti.FormattingEnabled = true;
            this.comboBox_kahvalti.Location = new System.Drawing.Point(498, 40);
            this.comboBox_kahvalti.Name = "comboBox_kahvalti";
            this.comboBox_kahvalti.Size = new System.Drawing.Size(245, 36);
            this.comboBox_kahvalti.TabIndex = 2;
            this.comboBox_kahvalti.Text = "KAHVALTI";
            this.comboBox_kahvalti.SelectedIndexChanged += new System.EventHandler(this.comboBox_kahvalti_SelectedIndexChanged);
            // 
            // comboBox_corba
            // 
            this.comboBox_corba.BackColor = System.Drawing.Color.RosyBrown;
            this.comboBox_corba.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_corba.FormattingEnabled = true;
            this.comboBox_corba.Location = new System.Drawing.Point(255, 40);
            this.comboBox_corba.Name = "comboBox_corba";
            this.comboBox_corba.Size = new System.Drawing.Size(222, 35);
            this.comboBox_corba.TabIndex = 3;
            this.comboBox_corba.Text = "ÇORBA";
            this.comboBox_corba.SelectedIndexChanged += new System.EventHandler(this.comboBox_corba_SelectedIndexChanged);
            // 
            // comboBox_anayemek
            // 
            this.comboBox_anayemek.BackColor = System.Drawing.Color.RosyBrown;
            this.comboBox_anayemek.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_anayemek.FormattingEnabled = true;
            this.comboBox_anayemek.Location = new System.Drawing.Point(27, 40);
            this.comboBox_anayemek.Name = "comboBox_anayemek";
            this.comboBox_anayemek.Size = new System.Drawing.Size(205, 36);
            this.comboBox_anayemek.TabIndex = 4;
            this.comboBox_anayemek.Text = "ANAYEMEK";
            this.comboBox_anayemek.SelectedIndexChanged += new System.EventHandler(this.comboBox_anayemek_SelectedIndexChanged);
            // 
            // comboBox_tatli
            // 
            this.comboBox_tatli.BackColor = System.Drawing.Color.RosyBrown;
            this.comboBox_tatli.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_tatli.FormattingEnabled = true;
            this.comboBox_tatli.Location = new System.Drawing.Point(758, 40);
            this.comboBox_tatli.Name = "comboBox_tatli";
            this.comboBox_tatli.Size = new System.Drawing.Size(341, 36);
            this.comboBox_tatli.TabIndex = 5;
            this.comboBox_tatli.Text = "TATLI";
            this.comboBox_tatli.SelectedIndexChanged += new System.EventHandler(this.comboBox_tatli_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.comboBox_tatli);
            this.panel2.Controls.Add(this.comboBox_corba);
            this.panel2.Controls.Add(this.comboBox_kahvalti);
            this.panel2.Controls.Add(this.comboBox_anayemek);
            this.panel2.Location = new System.Drawing.Point(168, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 106);
            this.panel2.TabIndex = 6;
            // 
            // richTextBox_malzemeler
            // 
            this.richTextBox_malzemeler.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_malzemeler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_malzemeler.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_malzemeler.Location = new System.Drawing.Point(219, 237);
            this.richTextBox_malzemeler.Name = "richTextBox_malzemeler";
            this.richTextBox_malzemeler.Size = new System.Drawing.Size(337, 259);
            this.richTextBox_malzemeler.TabIndex = 7;
            this.richTextBox_malzemeler.Text = "";
            // 
            // richTextBox_hazirlanisi
            // 
            this.richTextBox_hazirlanisi.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_hazirlanisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_hazirlanisi.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_hazirlanisi.Location = new System.Drawing.Point(917, 237);
            this.richTextBox_hazirlanisi.Name = "richTextBox_hazirlanisi";
            this.richTextBox_hazirlanisi.Size = new System.Drawing.Size(337, 259);
            this.richTextBox_hazirlanisi.TabIndex = 10;
            this.richTextBox_hazirlanisi.Text = "";
            // 
            // lbl_malzemeler
            // 
            this.lbl_malzemeler.AutoSize = true;
            this.lbl_malzemeler.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_malzemeler.Location = new System.Drawing.Point(234, 201);
            this.lbl_malzemeler.Name = "lbl_malzemeler";
            this.lbl_malzemeler.Size = new System.Drawing.Size(194, 25);
            this.lbl_malzemeler.TabIndex = 11;
            this.lbl_malzemeler.Text = "MALZEMELER";
            // 
            // lbl_hazirlanisi
            // 
            this.lbl_hazirlanisi.AutoSize = true;
            this.lbl_hazirlanisi.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hazirlanisi.Location = new System.Drawing.Point(945, 201);
            this.lbl_hazirlanisi.Name = "lbl_hazirlanisi";
            this.lbl_hazirlanisi.Size = new System.Drawing.Size(182, 25);
            this.lbl_hazirlanisi.TabIndex = 12;
            this.lbl_hazirlanisi.Text = "HAZIRLANIŞI";
            // 
            // lbl_anasayfa
            // 
            this.lbl_anasayfa.AutoSize = true;
            this.lbl_anasayfa.Font = new System.Drawing.Font("Talking to the Moon", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_anasayfa.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_anasayfa.Location = new System.Drawing.Point(427, 218);
            this.lbl_anasayfa.Name = "lbl_anasayfa";
            this.lbl_anasayfa.Size = new System.Drawing.Size(664, 172);
            this.lbl_anasayfa.TabIndex = 14;
            this.lbl_anasayfa.Text = "Vegan Yemek Tariflerine Hoşgeldiniz!\r\nMevcutta bulunan yemek tariflerini seçebili" +
    "r, dilerseniz \r\nsizler de Yemek Tarifi ekleyebilirsiniz!\r\nAfiyet Olsun!\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(576, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // yemekEkle_UC1
            // 
            this.yemekEkle_UC1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.yemekEkle_UC1.Location = new System.Drawing.Point(180, 106);
            this.yemekEkle_UC1.Name = "yemekEkle_UC1";
            this.yemekEkle_UC1.Size = new System.Drawing.Size(1196, 487);
            this.yemekEkle_UC1.TabIndex = 16;
            // 
            // benimIcınSec_UC1
            // 
            this.benimIcınSec_UC1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.benimIcınSec_UC1.Location = new System.Drawing.Point(180, 106);
            this.benimIcınSec_UC1.Name = "benimIcınSec_UC1";
            this.benimIcınSec_UC1.Size = new System.Drawing.Size(1196, 487);
            this.benimIcınSec_UC1.TabIndex = 13;
            // 
            // elimdekilereGore_UC1
            // 
            this.elimdekilereGore_UC1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.elimdekilereGore_UC1.Location = new System.Drawing.Point(177, 106);
            this.elimdekilereGore_UC1.Name = "elimdekilereGore_UC1";
            this.elimdekilereGore_UC1.Size = new System.Drawing.Size(1199, 487);
            this.elimdekilereGore_UC1.TabIndex = 17;
            // 
            // yemekAra_UC1
            // 
            this.yemekAra_UC1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.yemekAra_UC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yemekAra_UC1.BackgroundImage")));
            this.yemekAra_UC1.Location = new System.Drawing.Point(177, 106);
            this.yemekAra_UC1.Name = "yemekAra_UC1";
            this.yemekAra_UC1.Size = new System.Drawing.Size(1199, 487);
            this.yemekAra_UC1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 592);
            this.Controls.Add(this.yemekAra_UC1);
            this.Controls.Add(this.elimdekilereGore_UC1);
            this.Controls.Add(this.yemekEkle_UC1);
            this.Controls.Add(this.benimIcınSec_UC1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_anasayfa);
            this.Controls.Add(this.lbl_hazirlanisi);
            this.Controls.Add(this.lbl_malzemeler);
            this.Controls.Add(this.richTextBox_hazirlanisi);
            this.Controls.Add(this.richTextBox_malzemeler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_malzemeyegore;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_benimicinsec;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.ComboBox comboBox_kahvalti;
        private System.Windows.Forms.ComboBox comboBox_corba;
        private System.Windows.Forms.ComboBox comboBox_anayemek;
        private System.Windows.Forms.ComboBox comboBox_tatli;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox_malzemeler;
        private System.Windows.Forms.RichTextBox richTextBox_hazirlanisi;
        private System.Windows.Forms.Label lbl_malzemeler;
        private System.Windows.Forms.Label lbl_hazirlanisi;
        private BenimIcınSec_UC benimIcınSec_UC1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_anasayfa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private YemekEkle_UC yemekEkle_UC1;
        private ElimdekilereGore_UC elimdekilereGore_UC1;
        private System.Windows.Forms.Button btn_YemekAra;
        private YemekAra_UC yemekAra_UC1;
    }
}

