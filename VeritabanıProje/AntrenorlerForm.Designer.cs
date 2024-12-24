namespace VeritabanıProje
{
    partial class AntrenorlerForm
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
            BtnAntrenorEkle = new Button();
            BtnAntrenorGuncelle = new Button();
            BtnAntrenorSil = new Button();
            panel2 = new Panel();
            maskedTextBoxTelNo = new MaskedTextBox();
            label9 = new Label();
            radioButtonKadin = new RadioButton();
            radioButtonErkek = new RadioButton();
            label7 = new Label();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            textBoxAntrenorSoyadi = new TextBox();
            comboBoxCalismaTipi = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            textBoxAntrenorAdi = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            BtnGeri = new Button();
            dataGridViewAntrenorler = new DataGridView();
            pictureBox1 = new PictureBox();
            textBoxAra = new TextBox();
            panel4 = new Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAntrenorler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(BtnAntrenorEkle);
            panel3.Controls.Add(BtnAntrenorGuncelle);
            panel3.Controls.Add(BtnAntrenorSil);
            panel3.Location = new Point(248, 638);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 71);
            panel3.TabIndex = 28;
            // 
            // BtnAntrenorEkle
            // 
            BtnAntrenorEkle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnAntrenorEkle.Location = new Point(3, 3);
            BtnAntrenorEkle.Name = "BtnAntrenorEkle";
            BtnAntrenorEkle.Size = new Size(256, 65);
            BtnAntrenorEkle.TabIndex = 8;
            BtnAntrenorEkle.Text = "Ekle";
            BtnAntrenorEkle.UseVisualStyleBackColor = true;
            BtnAntrenorEkle.Click += BtnSalonEkle_Click;
            // 
            // BtnAntrenorGuncelle
            // 
            BtnAntrenorGuncelle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnAntrenorGuncelle.Location = new Point(265, 3);
            BtnAntrenorGuncelle.Name = "BtnAntrenorGuncelle";
            BtnAntrenorGuncelle.Size = new Size(238, 65);
            BtnAntrenorGuncelle.TabIndex = 10;
            BtnAntrenorGuncelle.Text = "Güncelle";
            BtnAntrenorGuncelle.UseVisualStyleBackColor = true;
            BtnAntrenorGuncelle.Click += BtnAntrenorGuncelle_Click;
            // 
            // BtnAntrenorSil
            // 
            BtnAntrenorSil.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnAntrenorSil.Location = new Point(509, 3);
            BtnAntrenorSil.Name = "BtnAntrenorSil";
            BtnAntrenorSil.Size = new Size(229, 65);
            BtnAntrenorSil.TabIndex = 9;
            BtnAntrenorSil.Text = "Sil";
            BtnAntrenorSil.UseVisualStyleBackColor = true;
            BtnAntrenorSil.Click += BtnAntrenorSil_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(maskedTextBoxTelNo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(radioButtonKadin);
            panel2.Controls.Add(radioButtonErkek);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBoxAntrenorSoyadi);
            panel2.Controls.Add(comboBoxCalismaTipi);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxAntrenorAdi);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 612);
            panel2.TabIndex = 27;
            // 
            // maskedTextBoxTelNo
            // 
            maskedTextBoxTelNo.Location = new Point(0, 360);
            maskedTextBoxTelNo.Mask = "(999) 000-0000";
            maskedTextBoxTelNo.Name = "maskedTextBoxTelNo";
            maskedTextBoxTelNo.Size = new Size(212, 27);
            maskedTextBoxTelNo.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(1, 327);
            label9.Name = "label9";
            label9.Size = new Size(70, 30);
            label9.TabIndex = 36;
            label9.Text = "Tel No.";
            // 
            // radioButtonKadin
            // 
            radioButtonKadin.AutoSize = true;
            radioButtonKadin.Location = new Point(71, 334);
            radioButtonKadin.Name = "radioButtonKadin";
            radioButtonKadin.Size = new Size(68, 24);
            radioButtonKadin.TabIndex = 35;
            radioButtonKadin.TabStop = true;
            radioButtonKadin.Text = "Kadın";
            radioButtonKadin.UseVisualStyleBackColor = true;
            // 
            // radioButtonErkek
            // 
            radioButtonErkek.AutoSize = true;
            radioButtonErkek.Location = new Point(0, 300);
            radioButtonErkek.Name = "radioButtonErkek";
            radioButtonErkek.Size = new Size(65, 24);
            radioButtonErkek.TabIndex = 34;
            radioButtonErkek.TabStop = true;
            radioButtonErkek.Text = "Erkek";
            radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(0, 267);
            label7.Name = "label7";
            label7.Size = new Size(80, 30);
            label7.TabIndex = 33;
            label7.Text = "Cinsiyet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(0, 454);
            label3.Name = "label3";
            label3.Size = new Size(135, 30);
            label3.TabIndex = 32;
            label3.Text = "Başlama Tarihi";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(0, 487);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(212, 27);
            dateTimePicker2.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(3, 204);
            label5.Name = "label5";
            label5.Size = new Size(121, 30);
            label5.TabIndex = 30;
            label5.Text = "Doğum Tarihi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1, 237);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 27);
            dateTimePicker1.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(3, 141);
            label6.Name = "label6";
            label6.Size = new Size(146, 30);
            label6.TabIndex = 12;
            label6.Text = "Antrenör Soyadı";
            // 
            // textBoxAntrenorSoyadi
            // 
            textBoxAntrenorSoyadi.Location = new Point(3, 174);
            textBoxAntrenorSoyadi.Name = "textBoxAntrenorSoyadi";
            textBoxAntrenorSoyadi.Size = new Size(214, 27);
            textBoxAntrenorSoyadi.TabIndex = 11;
            // 
            // comboBoxCalismaTipi
            // 
            comboBoxCalismaTipi.FormattingEnabled = true;
            comboBoxCalismaTipi.Location = new Point(0, 423);
            comboBoxCalismaTipi.Name = "comboBoxCalismaTipi";
            comboBoxCalismaTipi.Size = new Size(211, 28);
            comboBoxCalismaTipi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(3, 390);
            label4.Name = "label4";
            label4.Size = new Size(114, 30);
            label4.TabIndex = 6;
            label4.Text = "Çalışma Tipi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 78);
            label2.Name = "label2";
            label2.Size = new Size(117, 30);
            label2.TabIndex = 4;
            label2.Text = "Antrenör Adı";
            // 
            // textBoxAntrenorAdi
            // 
            textBoxAntrenorAdi.Location = new Point(3, 111);
            textBoxAntrenorAdi.Name = "textBoxAntrenorAdi";
            textBoxAntrenorAdi.Size = new Size(214, 27);
            textBoxAntrenorAdi.TabIndex = 1;
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
            panel1.TabIndex = 26;
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
            // dataGridViewAntrenorler
            // 
            dataGridViewAntrenorler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAntrenorler.Location = new Point(248, 142);
            dataGridViewAntrenorler.Name = "dataGridViewAntrenorler";
            dataGridViewAntrenorler.ReadOnly = true;
            dataGridViewAntrenorler.RowHeadersWidth = 51;
            dataGridViewAntrenorler.Size = new Size(740, 490);
            dataGridViewAntrenorler.TabIndex = 23;
            dataGridViewAntrenorler.CellContentClick += dataGridViewAntrenorler_CellContentClick;
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
            panel4.TabIndex = 30;
            // 
            // AntrenorlerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewAntrenorler);
            MaximizeBox = false;
            Name = "AntrenorlerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AntrenorlerForm";
            Load += AntrenorlerForm_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAntrenorler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button BtnAntrenorEkle;
        private Button BtnAntrenorGuncelle;
        private Button BtnAntrenorSil;
        private Panel panel2;
        private ComboBox comboBoxCalismaTipi;
        private Label label4;
        private Label label2;
        private TextBox textBoxAntrenorAdi;
        private Label label1;
        private Panel panel1;
        private Button BtnGeri;
        private DataGridView dataGridViewAntrenorler;
        private Label label6;
        private TextBox textBoxAntrenorSoyadi;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButtonKadin;
        private RadioButton radioButtonErkek;
        private Label label7;
        private PictureBox pictureBox1;
        private TextBox textBoxAra;
        private Panel panel4;
        private MaskedTextBox maskedTextBoxTelNo;
        private Label label9;
    }
}