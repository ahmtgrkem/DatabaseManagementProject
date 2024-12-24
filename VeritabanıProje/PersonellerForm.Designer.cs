namespace VeritabanıProje
{
    partial class PersonellerForm
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
            panel3 = new Panel();
            BtnPersonelEkle = new Button();
            BtnPersonelGuncelle = new Button();
            BtnpPersonelSil = new Button();
            panel2 = new Panel();
            maskedTextBoxTelNo = new MaskedTextBox();
            label9 = new Label();
            label8 = new Label();
            textBoxGorev = new TextBox();
            comboBoxCalismaTipi = new ComboBox();
            label7 = new Label();
            radioButtonKadin = new RadioButton();
            radioButtonErkek = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBoxPersonelSoyadi = new TextBox();
            comboBoxSalon = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxPersonelAdi = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            BtnGeri = new Button();
            dataGridViewPersoneller = new DataGridView();
            pictureBox1 = new PictureBox();
            textBoxAra = new TextBox();
            panel4 = new Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersoneller).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(BtnPersonelEkle);
            panel3.Controls.Add(BtnPersonelGuncelle);
            panel3.Controls.Add(BtnpPersonelSil);
            panel3.Location = new Point(248, 638);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 71);
            panel3.TabIndex = 34;
            // 
            // BtnPersonelEkle
            // 
            BtnPersonelEkle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnPersonelEkle.Location = new Point(3, 3);
            BtnPersonelEkle.Name = "BtnPersonelEkle";
            BtnPersonelEkle.Size = new Size(256, 65);
            BtnPersonelEkle.TabIndex = 8;
            BtnPersonelEkle.Text = "Ekle";
            BtnPersonelEkle.UseVisualStyleBackColor = true;
            BtnPersonelEkle.Click += BtnSalonEkle_Click;
            // 
            // BtnPersonelGuncelle
            // 
            BtnPersonelGuncelle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnPersonelGuncelle.Location = new Point(265, 3);
            BtnPersonelGuncelle.Name = "BtnPersonelGuncelle";
            BtnPersonelGuncelle.Size = new Size(238, 65);
            BtnPersonelGuncelle.TabIndex = 10;
            BtnPersonelGuncelle.Text = "Güncelle";
            BtnPersonelGuncelle.UseVisualStyleBackColor = true;
            BtnPersonelGuncelle.Click += BtnPersonelGuncelle_Click;
            // 
            // BtnpPersonelSil
            // 
            BtnpPersonelSil.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnpPersonelSil.Location = new Point(509, 3);
            BtnpPersonelSil.Name = "BtnpPersonelSil";
            BtnpPersonelSil.Size = new Size(229, 65);
            BtnpPersonelSil.TabIndex = 9;
            BtnpPersonelSil.Text = "Sil";
            BtnpPersonelSil.UseVisualStyleBackColor = true;
            BtnpPersonelSil.Click += BtnpPersonelSil_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(maskedTextBoxTelNo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBoxGorev);
            panel2.Controls.Add(comboBoxCalismaTipi);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(radioButtonKadin);
            panel2.Controls.Add(radioButtonErkek);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(textBoxPersonelSoyadi);
            panel2.Controls.Add(comboBoxSalon);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxPersonelAdi);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 612);
            panel2.TabIndex = 33;
            // 
            // maskedTextBoxTelNo
            // 
            maskedTextBoxTelNo.Location = new Point(5, 415);
            maskedTextBoxTelNo.Mask = "(999) 000-0000";
            maskedTextBoxTelNo.Name = "maskedTextBoxTelNo";
            maskedTextBoxTelNo.Size = new Size(212, 27);
            maskedTextBoxTelNo.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(5, 382);
            label9.Name = "label9";
            label9.Size = new Size(70, 30);
            label9.TabIndex = 18;
            label9.Text = "Tel No.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(3, 445);
            label8.Name = "label8";
            label8.Size = new Size(64, 30);
            label8.TabIndex = 17;
            label8.Text = "Görev";
            label8.Click += label8_Click;
            // 
            // textBoxGorev
            // 
            textBoxGorev.Location = new Point(3, 478);
            textBoxGorev.Name = "textBoxGorev";
            textBoxGorev.Size = new Size(214, 27);
            textBoxGorev.TabIndex = 16;
            // 
            // comboBoxCalismaTipi
            // 
            comboBoxCalismaTipi.FormattingEnabled = true;
            comboBoxCalismaTipi.Location = new Point(5, 351);
            comboBoxCalismaTipi.Name = "comboBoxCalismaTipi";
            comboBoxCalismaTipi.Size = new Size(212, 28);
            comboBoxCalismaTipi.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(5, 318);
            label7.Name = "label7";
            label7.Size = new Size(114, 30);
            label7.TabIndex = 14;
            label7.Text = "Çalışma Tipi";
            // 
            // radioButtonKadin
            // 
            radioButtonKadin.AutoSize = true;
            radioButtonKadin.Location = new Point(74, 291);
            radioButtonKadin.Name = "radioButtonKadin";
            radioButtonKadin.Size = new Size(68, 24);
            radioButtonKadin.TabIndex = 13;
            radioButtonKadin.TabStop = true;
            radioButtonKadin.Text = "Kadın";
            radioButtonKadin.UseVisualStyleBackColor = true;
            // 
            // radioButtonErkek
            // 
            radioButtonErkek.AutoSize = true;
            radioButtonErkek.Location = new Point(3, 291);
            radioButtonErkek.Name = "radioButtonErkek";
            radioButtonErkek.Size = new Size(65, 24);
            radioButtonErkek.TabIndex = 12;
            radioButtonErkek.TabStop = true;
            radioButtonErkek.Text = "Erkek";
            radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(3, 258);
            label6.Name = "label6";
            label6.Size = new Size(80, 30);
            label6.TabIndex = 11;
            label6.Text = "Cinsiyet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(5, 195);
            label5.Name = "label5";
            label5.Size = new Size(121, 30);
            label5.TabIndex = 10;
            label5.Text = "Doğum Tarihi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 228);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBoxPersonelSoyadi
            // 
            textBoxPersonelSoyadi.Location = new Point(3, 165);
            textBoxPersonelSoyadi.Name = "textBoxPersonelSoyadi";
            textBoxPersonelSoyadi.Size = new Size(214, 27);
            textBoxPersonelSoyadi.TabIndex = 8;
            // 
            // comboBoxSalon
            // 
            comboBoxSalon.FormattingEnabled = true;
            comboBoxSalon.Location = new Point(5, 541);
            comboBoxSalon.Name = "comboBoxSalon";
            comboBoxSalon.Size = new Size(210, 28);
            comboBoxSalon.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(3, 508);
            label4.Name = "label4";
            label4.Size = new Size(90, 30);
            label4.TabIndex = 6;
            label4.Text = "Salon Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(3, 132);
            label3.Name = "label3";
            label3.Size = new Size(141, 30);
            label3.TabIndex = 5;
            label3.Text = "Personel Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 69);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 4;
            label2.Text = "Personel Adı";
            // 
            // textBoxPersonelAdi
            // 
            textBoxPersonelAdi.Location = new Point(3, 102);
            textBoxPersonelAdi.Name = "textBoxPersonelAdi";
            textBoxPersonelAdi.Size = new Size(214, 27);
            textBoxPersonelAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("League Spartan", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(54, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 45);
            label1.TabIndex = 0;
            label1.Text = "Bilgiler";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(BtnGeri);
            panel1.Location = new Point(18, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 79);
            panel1.TabIndex = 32;
            // 
            // BtnGeri
            // 
            BtnGeri.Font = new Font("League Spartan SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGeri.Location = new Point(3, 3);
            BtnGeri.Name = "BtnGeri";
            BtnGeri.Size = new Size(79, 69);
            BtnGeri.TabIndex = 7;
            BtnGeri.Text = "Geri";
            BtnGeri.UseVisualStyleBackColor = true;
            BtnGeri.Click += BtnGeri_Click;
            // 
            // dataGridViewPersoneller
            // 
            dataGridViewPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersoneller.Location = new Point(248, 140);
            dataGridViewPersoneller.Name = "dataGridViewPersoneller";
            dataGridViewPersoneller.ReadOnly = true;
            dataGridViewPersoneller.RowHeadersWidth = 51;
            dataGridViewPersoneller.Size = new Size(740, 490);
            dataGridViewPersoneller.TabIndex = 29;
            dataGridViewPersoneller.CellContentClick += dataGridViewPersoneller_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(704, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // textBoxAra
            // 
            textBoxAra.Location = new Point(3, 3);
            textBoxAra.Name = "textBoxAra";
            textBoxAra.Size = new Size(695, 27);
            textBoxAra.TabIndex = 24;
            textBoxAra.TextChanged += textBoxAra_TextChanged;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(textBoxAra);
            panel4.Location = new Point(248, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(740, 37);
            panel4.TabIndex = 35;
            // 
            // PersonellerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPersoneller);
            MaximizeBox = false;
            Name = "PersonellerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PersonellerForm";
            Load += PersonellerForm_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersoneller).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button BtnPersonelEkle;
        private Button BtnPersonelGuncelle;
        private Button BtnpPersonelSil;
        private Panel panel2;
        private ComboBox comboBoxCalismaTipi;
        private Label label7;
        private RadioButton radioButtonKadin;
        private RadioButton radioButtonErkek;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxPersonelSoyadi;
        private ComboBox comboBoxSalon;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxPersonelAdi;
        private Label label1;
        private Panel panel1;
        private Button BtnGeri;
        private DataGridView dataGridViewPersoneller;
        private Label label8;
        private TextBox textBoxGorev;
        private PictureBox pictureBox1;
        private TextBox textBoxAra;
        private Panel panel4;
        private MaskedTextBox maskedTextBoxTelNo;
        private Label label9;
    }
}