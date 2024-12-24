namespace VeritabanıProje
{
    partial class AntrenmanlarForm
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
            BtnAntrenmanEkle = new Button();
            BtnAntrenmanGuncelle = new Button();
            BtnAntrenmanSil = new Button();
            panel2 = new Panel();
            textBoxAntrenmanTuru = new TextBox();
            comboBoxZorluk = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxAntrenmanAdi = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            BtnGeri = new Button();
            dataGridViewAntrenmanlar = new DataGridView();
            pictureBox1 = new PictureBox();
            textBoxAra = new TextBox();
            panel4 = new Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAntrenmanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(BtnAntrenmanEkle);
            panel3.Controls.Add(BtnAntrenmanGuncelle);
            panel3.Controls.Add(BtnAntrenmanSil);
            panel3.Location = new Point(248, 638);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 71);
            panel3.TabIndex = 22;
            // 
            // BtnAntrenmanEkle
            // 
            BtnAntrenmanEkle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnAntrenmanEkle.Location = new Point(3, 3);
            BtnAntrenmanEkle.Name = "BtnAntrenmanEkle";
            BtnAntrenmanEkle.Size = new Size(256, 65);
            BtnAntrenmanEkle.TabIndex = 8;
            BtnAntrenmanEkle.Text = "Ekle";
            BtnAntrenmanEkle.UseVisualStyleBackColor = true;
            BtnAntrenmanEkle.Click += BtnSalonEkle_Click;
            // 
            // BtnAntrenmanGuncelle
            // 
            BtnAntrenmanGuncelle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnAntrenmanGuncelle.Location = new Point(265, 3);
            BtnAntrenmanGuncelle.Name = "BtnAntrenmanGuncelle";
            BtnAntrenmanGuncelle.Size = new Size(238, 65);
            BtnAntrenmanGuncelle.TabIndex = 10;
            BtnAntrenmanGuncelle.Text = "Güncelle";
            BtnAntrenmanGuncelle.UseVisualStyleBackColor = true;
            BtnAntrenmanGuncelle.Click += BtnAntrenmanGuncelle_Click;
            // 
            // BtnAntrenmanSil
            // 
            BtnAntrenmanSil.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnAntrenmanSil.Location = new Point(509, 3);
            BtnAntrenmanSil.Name = "BtnAntrenmanSil";
            BtnAntrenmanSil.Size = new Size(229, 65);
            BtnAntrenmanSil.TabIndex = 9;
            BtnAntrenmanSil.Text = "Sil";
            BtnAntrenmanSil.UseVisualStyleBackColor = true;
            BtnAntrenmanSil.Click += BtnAntrenmanSil_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBoxAntrenmanTuru);
            panel2.Controls.Add(comboBoxZorluk);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxAntrenmanAdi);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 612);
            panel2.TabIndex = 21;
            // 
            // textBoxAntrenmanTuru
            // 
            textBoxAntrenmanTuru.Location = new Point(5, 253);
            textBoxAntrenmanTuru.Name = "textBoxAntrenmanTuru";
            textBoxAntrenmanTuru.Size = new Size(214, 27);
            textBoxAntrenmanTuru.TabIndex = 8;
            // 
            // comboBoxZorluk
            // 
            comboBoxZorluk.FormattingEnabled = true;
            comboBoxZorluk.Location = new Point(5, 375);
            comboBoxZorluk.Name = "comboBoxZorluk";
            comboBoxZorluk.Size = new Size(212, 28);
            comboBoxZorluk.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(5, 342);
            label4.Name = "label4";
            label4.Size = new Size(174, 30);
            label4.TabIndex = 6;
            label4.Text = "Antrenman Zorluğu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(3, 220);
            label3.Name = "label3";
            label3.Size = new Size(146, 30);
            label3.TabIndex = 5;
            label3.Text = "Antrenman Türü";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 112);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 4;
            label2.Text = "Antrenman Adı";
            // 
            // textBoxAntrenmanAdi
            // 
            textBoxAntrenmanAdi.Location = new Point(3, 145);
            textBoxAntrenmanAdi.Name = "textBoxAntrenmanAdi";
            textBoxAntrenmanAdi.Size = new Size(214, 27);
            textBoxAntrenmanAdi.TabIndex = 1;
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
            // dataGridViewAntrenmanlar
            // 
            dataGridViewAntrenmanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAntrenmanlar.Location = new Point(248, 142);
            dataGridViewAntrenmanlar.Name = "dataGridViewAntrenmanlar";
            dataGridViewAntrenmanlar.ReadOnly = true;
            dataGridViewAntrenmanlar.RowHeadersWidth = 51;
            dataGridViewAntrenmanlar.Size = new Size(740, 490);
            dataGridViewAntrenmanlar.TabIndex = 17;
            dataGridViewAntrenmanlar.CellContentClick += dataGridViewAntrenmanlar_CellContentClick;
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
            // AntrenmanlarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewAntrenmanlar);
            MaximizeBox = false;
            Name = "AntrenmanlarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AntrenmanlarForm";
            Load += AntrenmanlarForm_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAntrenmanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button BtnAntrenmanEkle;
        private Button BtnAntrenmanGuncelle;
        private Button BtnAntrenmanSil;
        private Panel panel2;
        private ComboBox comboBoxZorluk;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxAntrenmanAdi;
        private Label label1;
        private Panel panel1;
        private Button BtnGeri;
        private DataGridView dataGridViewAntrenmanlar;
        private TextBox textBoxAntrenmanTuru;
        private PictureBox pictureBox1;
        private TextBox textBoxAra;
        private Panel panel4;
    }
}