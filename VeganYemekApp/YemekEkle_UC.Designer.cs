
namespace VeganYemekApp
{
    partial class YemekEkle_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_yemekadi = new System.Windows.Forms.TextBox();
            this.richTextBox_malzeme = new System.Windows.Forms.RichTextBox();
            this.richTextBox_tarif = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.düzeltmeVeganYemekArifiDataSet = new VeganYemekApp.düzeltmeVeganYemekArifiDataSet();
            this.tblKategorilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_KategorilerTableAdapter = new VeganYemekApp.düzeltmeVeganYemekArifiDataSetTableAdapters.Tbl_KategorilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.düzeltmeVeganYemekArifiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategorilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_yemekadi
            // 
            this.textBox_yemekadi.Location = new System.Drawing.Point(56, 54);
            this.textBox_yemekadi.Multiline = true;
            this.textBox_yemekadi.Name = "textBox_yemekadi";
            this.textBox_yemekadi.Size = new System.Drawing.Size(188, 22);
            this.textBox_yemekadi.TabIndex = 0;
            // 
            // richTextBox_malzeme
            // 
            this.richTextBox_malzeme.Location = new System.Drawing.Point(56, 131);
            this.richTextBox_malzeme.Name = "richTextBox_malzeme";
            this.richTextBox_malzeme.Size = new System.Drawing.Size(320, 238);
            this.richTextBox_malzeme.TabIndex = 1;
            this.richTextBox_malzeme.Text = "";
            // 
            // richTextBox_tarif
            // 
            this.richTextBox_tarif.Location = new System.Drawing.Point(406, 131);
            this.richTextBox_tarif.Name = "richTextBox_tarif";
            this.richTextBox_tarif.Size = new System.Drawing.Size(320, 238);
            this.richTextBox_tarif.TabIndex = 2;
            this.richTextBox_tarif.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(637, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(415, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_kaydet.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(705, 395);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(123, 33);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_guncelle.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(847, 395);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(123, 33);
            this.btn_guncelle.TabIndex = 6;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_sil.Font = new System.Drawing.Font("Minion Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(986, 395);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(123, 33);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(53, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Yemek Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(52, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yemek Malzemeleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Font = new System.Drawing.Font("Minion Pro Cond", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(409, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yemek Tarifi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RosyBrown;
            this.label4.Font = new System.Drawing.Font("Minion Pro Cond", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(613, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Güncellemek veya Silmek İstediğiniz Yemeği Seçiniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RosyBrown;
            this.label5.Font = new System.Drawing.Font("Minion Pro Cond", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(761, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yemek Resmi";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Minion Pro Cond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(949, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 32);
            this.button4.TabIndex = 13;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(767, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::VeganYemekApp.Properties.Resources.Adsız_tasarım__2_;
            this.pictureBox2.InitialImage = global::VeganYemekApp.Properties.Resources.Adsız_tasarım__2_;
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1196, 491);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblKategorilerBindingSource, "KategoriAd", true));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(284, 54);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // düzeltmeVeganYemekArifiDataSet
            // 
            this.düzeltmeVeganYemekArifiDataSet.DataSetName = "düzeltmeVeganYemekArifiDataSet";
            this.düzeltmeVeganYemekArifiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKategorilerBindingSource
            // 
            this.tblKategorilerBindingSource.DataMember = "Tbl_Kategoriler";
            this.tblKategorilerBindingSource.DataSource = this.düzeltmeVeganYemekArifiDataSet;
            // 
            // tbl_KategorilerTableAdapter
            // 
            this.tbl_KategorilerTableAdapter.ClearBeforeFill = true;
            // 
            // YemekEkle_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox_tarif);
            this.Controls.Add(this.richTextBox_malzeme);
            this.Controls.Add(this.textBox_yemekadi);
            this.Controls.Add(this.pictureBox2);
            this.Name = "YemekEkle_UC";
            this.Size = new System.Drawing.Size(1196, 491);
            this.Load += new System.EventHandler(this.YemekEkle_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.düzeltmeVeganYemekArifiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategorilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_yemekadi;
        private System.Windows.Forms.RichTextBox richTextBox_malzeme;
        private System.Windows.Forms.RichTextBox richTextBox_tarif;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource tblKategorilerBindingSource;
        private düzeltmeVeganYemekArifiDataSet düzeltmeVeganYemekArifiDataSet;
        private düzeltmeVeganYemekArifiDataSetTableAdapters.Tbl_KategorilerTableAdapter tbl_KategorilerTableAdapter;
    }
}
