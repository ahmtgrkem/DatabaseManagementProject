namespace VeritabanıProje
{
    partial class EkipmanlarForm
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
            BtnEkipmanEkle = new Button();
            BtnEkipmanGuncelle = new Button();
            BtnEkipmanSil = new Button();
            panel2 = new Panel();
            label5 = new Label();
            comboBoxSalon = new ComboBox();
            numericUpDownAdet = new NumericUpDown();
            comboBoxDurum = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxEkipmanAdi = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            BtnGeri = new Button();
            dataGridViewEkipmanlar = new DataGridView();
            pictureBox1 = new PictureBox();
            textBoxAra = new TextBox();
            panel4 = new Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdet).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEkipmanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(BtnEkipmanEkle);
            panel3.Controls.Add(BtnEkipmanGuncelle);
            panel3.Controls.Add(BtnEkipmanSil);
            panel3.Location = new Point(248, 638);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 71);
            panel3.TabIndex = 22;
            // 
            // BtnEkipmanEkle
            // 
            BtnEkipmanEkle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnEkipmanEkle.Location = new Point(3, 3);
            BtnEkipmanEkle.Name = "BtnEkipmanEkle";
            BtnEkipmanEkle.Size = new Size(256, 65);
            BtnEkipmanEkle.TabIndex = 8;
            BtnEkipmanEkle.Text = "Ekle";
            BtnEkipmanEkle.UseVisualStyleBackColor = true;
            BtnEkipmanEkle.Click += BtnEkipmanEkle_Click;
            // 
            // BtnEkipmanGuncelle
            // 
            BtnEkipmanGuncelle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnEkipmanGuncelle.Location = new Point(265, 3);
            BtnEkipmanGuncelle.Name = "BtnEkipmanGuncelle";
            BtnEkipmanGuncelle.Size = new Size(238, 65);
            BtnEkipmanGuncelle.TabIndex = 10;
            BtnEkipmanGuncelle.Text = "Güncelle";
            BtnEkipmanGuncelle.UseVisualStyleBackColor = true;
            BtnEkipmanGuncelle.Click += BtnEkipmanGuncelle_Click;
            // 
            // BtnEkipmanSil
            // 
            BtnEkipmanSil.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnEkipmanSil.Location = new Point(509, 3);
            BtnEkipmanSil.Name = "BtnEkipmanSil";
            BtnEkipmanSil.Size = new Size(229, 65);
            BtnEkipmanSil.TabIndex = 9;
            BtnEkipmanSil.Text = "Sil";
            BtnEkipmanSil.UseVisualStyleBackColor = true;
            BtnEkipmanSil.Click += BtnEkipmanSil_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBoxSalon);
            panel2.Controls.Add(numericUpDownAdet);
            panel2.Controls.Add(comboBoxDurum);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxEkipmanAdi);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 612);
            panel2.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(6, 449);
            label5.Name = "label5";
            label5.Size = new Size(90, 30);
            label5.TabIndex = 10;
            label5.Text = "Salon Adı";
            // 
            // comboBoxSalon
            // 
            comboBoxSalon.FormattingEnabled = true;
            comboBoxSalon.Location = new Point(6, 482);
            comboBoxSalon.Name = "comboBoxSalon";
            comboBoxSalon.Size = new Size(211, 28);
            comboBoxSalon.TabIndex = 9;
            // 
            // numericUpDownAdet
            // 
            numericUpDownAdet.Location = new Point(6, 253);
            numericUpDownAdet.Name = "numericUpDownAdet";
            numericUpDownAdet.Size = new Size(211, 27);
            numericUpDownAdet.TabIndex = 8;
            // 
            // comboBoxDurum
            // 
            comboBoxDurum.FormattingEnabled = true;
            comboBoxDurum.Location = new Point(6, 368);
            comboBoxDurum.Name = "comboBoxDurum";
            comboBoxDurum.Size = new Size(211, 28);
            comboBoxDurum.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(6, 335);
            label4.Name = "label4";
            label4.Size = new Size(66, 30);
            label4.TabIndex = 6;
            label4.Text = "Durum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(3, 220);
            label3.Name = "label3";
            label3.Size = new Size(52, 30);
            label3.TabIndex = 5;
            label3.Text = "Adet";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 112);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 4;
            label2.Text = "Ekipman Adı";
            // 
            // textBoxEkipmanAdi
            // 
            textBoxEkipmanAdi.Location = new Point(3, 145);
            textBoxEkipmanAdi.Name = "textBoxEkipmanAdi";
            textBoxEkipmanAdi.Size = new Size(214, 27);
            textBoxEkipmanAdi.TabIndex = 1;
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
            panel1.TabIndex = 20;
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
            // dataGridViewEkipmanlar
            // 
            dataGridViewEkipmanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEkipmanlar.Location = new Point(248, 142);
            dataGridViewEkipmanlar.Name = "dataGridViewEkipmanlar";
            dataGridViewEkipmanlar.ReadOnly = true;
            dataGridViewEkipmanlar.RowHeadersWidth = 51;
            dataGridViewEkipmanlar.Size = new Size(740, 490);
            dataGridViewEkipmanlar.TabIndex = 17;
            dataGridViewEkipmanlar.CellContentClick += dataGridViewEkipmanlar_CellContentClick;
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
            // EkipmanlarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewEkipmanlar);
            MaximizeBox = false;
            Name = "EkipmanlarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EkipmanlarForm";
            Load += EkipmanlarForm_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdet).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEkipmanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button BtnEkipmanEkle;
        private Button BtnEkipmanGuncelle;
        private Button BtnEkipmanSil;
        private Panel panel2;
        private NumericUpDown numericUpDownAdet;
        private ComboBox comboBoxDurum;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxEkipmanAdi;
        private Label label1;
        private Panel panel1;
        private Button BtnGeri;
        private DataGridView dataGridViewEkipmanlar;
        private Label label5;
        private ComboBox comboBoxSalon;
        private PictureBox pictureBox1;
        private TextBox textBoxAra;
        private Panel panel4;
    }
}