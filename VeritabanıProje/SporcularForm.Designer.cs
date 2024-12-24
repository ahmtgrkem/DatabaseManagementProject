namespace VeritabanıProje
{
    partial class SporcularForm
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
            BtnSporcuEkle = new Button();
            BtnSporcuGuncelle = new Button();
            BtnSporcuSil = new Button();
            panel2 = new Panel();
            comboBoxAntrenman = new ComboBox();
            label8 = new Label();
            maskedTextBoxTelNo = new MaskedTextBox();
            label9 = new Label();
            comboBoxDurum = new ComboBox();
            label7 = new Label();
            radioButtonKadin = new RadioButton();
            radioButtonErkek = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBoxSporcuSoyadi = new TextBox();
            comboBoxBrans = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxSporcuAdi = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            BtnGeri = new Button();
            textBoxAra = new TextBox();
            dataGridViewSporcular = new DataGridView();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSporcular).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(BtnSporcuEkle);
            panel3.Controls.Add(BtnSporcuGuncelle);
            panel3.Controls.Add(BtnSporcuSil);
            panel3.Location = new Point(248, 638);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 71);
            panel3.TabIndex = 28;
            // 
            // BtnSporcuEkle
            // 
            BtnSporcuEkle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnSporcuEkle.Location = new Point(3, 3);
            BtnSporcuEkle.Name = "BtnSporcuEkle";
            BtnSporcuEkle.Size = new Size(256, 65);
            BtnSporcuEkle.TabIndex = 8;
            BtnSporcuEkle.Text = "Ekle";
            BtnSporcuEkle.UseVisualStyleBackColor = true;
            BtnSporcuEkle.Click += BtnSporcuEkle_Click;
            // 
            // BtnSporcuGuncelle
            // 
            BtnSporcuGuncelle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnSporcuGuncelle.Location = new Point(265, 3);
            BtnSporcuGuncelle.Name = "BtnSporcuGuncelle";
            BtnSporcuGuncelle.Size = new Size(238, 65);
            BtnSporcuGuncelle.TabIndex = 10;
            BtnSporcuGuncelle.Text = "Güncelle";
            BtnSporcuGuncelle.UseVisualStyleBackColor = true;
            BtnSporcuGuncelle.Click += BtnSporcuGuncelle_Click;
            // 
            // BtnSporcuSil
            // 
            BtnSporcuSil.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnSporcuSil.Location = new Point(509, 3);
            BtnSporcuSil.Name = "BtnSporcuSil";
            BtnSporcuSil.Size = new Size(229, 65);
            BtnSporcuSil.TabIndex = 9;
            BtnSporcuSil.Text = "Sil";
            BtnSporcuSil.UseVisualStyleBackColor = true;
            BtnSporcuSil.Click += BtnSporcuSil_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(comboBoxAntrenman);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(maskedTextBoxTelNo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBoxDurum);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(radioButtonKadin);
            panel2.Controls.Add(radioButtonErkek);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(textBoxSporcuSoyadi);
            panel2.Controls.Add(comboBoxBrans);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxSporcuAdi);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 612);
            panel2.TabIndex = 27;
            // 
            // comboBoxAntrenman
            // 
            comboBoxAntrenman.FormattingEnabled = true;
            comboBoxAntrenman.Location = new Point(5, 530);
            comboBoxAntrenman.Name = "comboBoxAntrenman";
            comboBoxAntrenman.Size = new Size(210, 28);
            comboBoxAntrenman.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(3, 497);
            label8.Name = "label8";
            label8.Size = new Size(105, 30);
            label8.TabIndex = 22;
            label8.Text = "Antrenman";
            // 
            // maskedTextBoxTelNo
            // 
            maskedTextBoxTelNo.Location = new Point(3, 339);
            maskedTextBoxTelNo.Mask = "(999) 000-0000";
            maskedTextBoxTelNo.Name = "maskedTextBoxTelNo";
            maskedTextBoxTelNo.Size = new Size(212, 27);
            maskedTextBoxTelNo.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(3, 306);
            label9.Name = "label9";
            label9.Size = new Size(70, 30);
            label9.TabIndex = 20;
            label9.Text = "Tel No.";
            // 
            // comboBoxDurum
            // 
            comboBoxDurum.FormattingEnabled = true;
            comboBoxDurum.Location = new Point(3, 402);
            comboBoxDurum.Name = "comboBoxDurum";
            comboBoxDurum.Size = new Size(212, 28);
            comboBoxDurum.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(3, 369);
            label7.Name = "label7";
            label7.Size = new Size(66, 30);
            label7.TabIndex = 14;
            label7.Text = "Durum";
            // 
            // radioButtonKadin
            // 
            radioButtonKadin.AutoSize = true;
            radioButtonKadin.Location = new Point(74, 279);
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
            radioButtonErkek.Location = new Point(3, 279);
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
            label6.Location = new Point(3, 246);
            label6.Name = "label6";
            label6.Size = new Size(80, 30);
            label6.TabIndex = 11;
            label6.Text = "Cinsiyet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(5, 183);
            label5.Name = "label5";
            label5.Size = new Size(121, 30);
            label5.TabIndex = 10;
            label5.Text = "Doğum Tarihi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 216);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBoxSporcuSoyadi
            // 
            textBoxSporcuSoyadi.Location = new Point(3, 153);
            textBoxSporcuSoyadi.Name = "textBoxSporcuSoyadi";
            textBoxSporcuSoyadi.Size = new Size(214, 27);
            textBoxSporcuSoyadi.TabIndex = 8;
            // 
            // comboBoxBrans
            // 
            comboBoxBrans.FormattingEnabled = true;
            comboBoxBrans.Location = new Point(5, 466);
            comboBoxBrans.Name = "comboBoxBrans";
            comboBoxBrans.Size = new Size(210, 28);
            comboBoxBrans.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(3, 433);
            label4.Name = "label4";
            label4.Size = new Size(64, 30);
            label4.TabIndex = 6;
            label4.Text = "Branşı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(3, 120);
            label3.Name = "label3";
            label3.Size = new Size(130, 30);
            label3.TabIndex = 5;
            label3.Text = "Sporcu Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(101, 30);
            label2.TabIndex = 4;
            label2.Text = "Sporcu Adı";
            // 
            // textBoxSporcuAdi
            // 
            textBoxSporcuAdi.Location = new Point(3, 90);
            textBoxSporcuAdi.Name = "textBoxSporcuAdi";
            textBoxSporcuAdi.Size = new Size(214, 27);
            textBoxSporcuAdi.TabIndex = 1;
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
            // button2
            // 
            button2.Location = new Point(492, 6);
            button2.Name = "button2";
            button2.Size = new Size(238, 69);
            button2.TabIndex = 25;
            button2.Text = "Branştaki Sporcu Sayı Fonk";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(228, 3);
            button1.Name = "button1";
            button1.Size = new Size(261, 74);
            button1.TabIndex = 24;
            button1.Text = "Sporcu Yaş Ortalama Fonk";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(BtnGeri);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(18, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 79);
            panel1.TabIndex = 26;
            // 
            // button3
            // 
            button3.Location = new Point(736, 8);
            button3.Name = "button3";
            button3.Size = new Size(227, 64);
            button3.TabIndex = 26;
            button3.Text = "Turnuva Fonk";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            // textBoxAra
            // 
            textBoxAra.Location = new Point(3, 3);
            textBoxAra.Name = "textBoxAra";
            textBoxAra.Size = new Size(695, 27);
            textBoxAra.TabIndex = 24;
            textBoxAra.TextChanged += textBoxAra_TextChanged;
            // 
            // dataGridViewSporcular
            // 
            dataGridViewSporcular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSporcular.Location = new Point(248, 140);
            dataGridViewSporcular.Name = "dataGridViewSporcular";
            dataGridViewSporcular.ReadOnly = true;
            dataGridViewSporcular.RowHeadersWidth = 51;
            dataGridViewSporcular.Size = new Size(740, 490);
            dataGridViewSporcular.TabIndex = 23;
            dataGridViewSporcular.CellContentClick += dataGridViewSporcular_CellContentClick;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(textBoxAra);
            panel4.Location = new Point(248, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(740, 37);
            panel4.TabIndex = 29;
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
            // SporcularForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewSporcular);
            MaximizeBox = false;
            Name = "SporcularForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SporcularForm";
            Load += SporcularForm_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSporcular).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button BtnSporcuEkle;
        private Button BtnSporcuGuncelle;
        private Button BtnSporcuSil;
        private Panel panel2;
        private TextBox textBoxSporcuSoyadi;
        private ComboBox comboBoxBrans;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxSporcuAdi;
        private Label label1;
        private Panel panel1;
        private Button BtnGeri;
        private TextBox textBoxAra;
        private DataGridView dataGridViewSporcular;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private RadioButton radioButtonKadin;
        private RadioButton radioButtonErkek;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxDurum;
        private Panel panel4;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBoxTelNo;
        private Label label9;
        private ComboBox comboBoxAntrenman;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}