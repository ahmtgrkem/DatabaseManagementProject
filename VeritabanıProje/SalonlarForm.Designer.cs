namespace VeritabanıProje
{
    partial class SalonlarForm
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
            BtnGeri = new Button();
            dataGridViewSalonlar = new DataGridView();
            BtnSalonEkle = new Button();
            BtnSalonSil = new Button();
            BtnSalonGuncelle = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            numericUpDownKapasite = new NumericUpDown();
            comboBoxIl = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxSalonAdi = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            textBoxAra = new TextBox();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalonlar).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKapasite).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
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
            // dataGridViewSalonlar
            // 
            dataGridViewSalonlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSalonlar.Location = new Point(242, 142);
            dataGridViewSalonlar.Name = "dataGridViewSalonlar";
            dataGridViewSalonlar.ReadOnly = true;
            dataGridViewSalonlar.RowHeadersWidth = 51;
            dataGridViewSalonlar.Size = new Size(740, 490);
            dataGridViewSalonlar.TabIndex = 6;
            dataGridViewSalonlar.CellContentClick += dataGridViewSalonlar_CellContentClick;
            // 
            // BtnSalonEkle
            // 
            BtnSalonEkle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnSalonEkle.Location = new Point(3, 3);
            BtnSalonEkle.Name = "BtnSalonEkle";
            BtnSalonEkle.Size = new Size(256, 65);
            BtnSalonEkle.TabIndex = 8;
            BtnSalonEkle.Text = "Ekle";
            BtnSalonEkle.UseVisualStyleBackColor = true;
            BtnSalonEkle.Click += BtnSalonEkle_Click;
            // 
            // BtnSalonSil
            // 
            BtnSalonSil.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnSalonSil.Location = new Point(509, 3);
            BtnSalonSil.Name = "BtnSalonSil";
            BtnSalonSil.Size = new Size(229, 65);
            BtnSalonSil.TabIndex = 9;
            BtnSalonSil.Text = "Sil";
            BtnSalonSil.UseVisualStyleBackColor = true;
            BtnSalonSil.Click += BtnSalonSil_Click;
            // 
            // BtnSalonGuncelle
            // 
            BtnSalonGuncelle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnSalonGuncelle.Location = new Point(265, 3);
            BtnSalonGuncelle.Name = "BtnSalonGuncelle";
            BtnSalonGuncelle.Size = new Size(238, 65);
            BtnSalonGuncelle.TabIndex = 10;
            BtnSalonGuncelle.Text = "Güncelle";
            BtnSalonGuncelle.UseVisualStyleBackColor = true;
            BtnSalonGuncelle.Click += BtnSalonGuncelle_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BtnGeri);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 79);
            panel1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(228, 3);
            button1.Name = "button1";
            button1.Size = new Size(261, 74);
            button1.TabIndex = 9;
            button1.Text = "İllerdeki Salon Fonk";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(numericUpDownKapasite);
            panel2.Controls.Add(comboBoxIl);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxSalonAdi);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 612);
            panel2.TabIndex = 15;
            // 
            // numericUpDownKapasite
            // 
            numericUpDownKapasite.Location = new Point(6, 253);
            numericUpDownKapasite.Name = "numericUpDownKapasite";
            numericUpDownKapasite.Size = new Size(211, 27);
            numericUpDownKapasite.TabIndex = 8;
            // 
            // comboBoxIl
            // 
            comboBoxIl.FormattingEnabled = true;
            comboBoxIl.Location = new Point(5, 375);
            comboBoxIl.Name = "comboBoxIl";
            comboBoxIl.Size = new Size(212, 28);
            comboBoxIl.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(5, 342);
            label4.Name = "label4";
            label4.Size = new Size(53, 30);
            label4.TabIndex = 6;
            label4.Text = "İl Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(3, 220);
            label3.Name = "label3";
            label3.Size = new Size(86, 30);
            label3.TabIndex = 5;
            label3.Text = "Kapasite";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 112);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 4;
            label2.Text = "Salon Adı";
            // 
            // textBoxSalonAdi
            // 
            textBoxSalonAdi.Location = new Point(3, 145);
            textBoxSalonAdi.Name = "textBoxSalonAdi";
            textBoxSalonAdi.Size = new Size(214, 27);
            textBoxSalonAdi.TabIndex = 1;
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
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(BtnSalonEkle);
            panel3.Controls.Add(BtnSalonGuncelle);
            panel3.Controls.Add(BtnSalonSil);
            panel3.Location = new Point(242, 638);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 71);
            panel3.TabIndex = 16;
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
            panel4.Location = new Point(242, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(740, 37);
            panel4.TabIndex = 30;
            // 
            // SalonlarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewSalonlar);
            MaximizeBox = false;
            Name = "SalonlarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalonlarForm";
            Load += SalonlarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalonlar).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKapasite).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnGeri;
        private DataGridView dataGridViewSalonlar;
        private Button BtnSalonEkle;
        private Button BtnSalonSil;
        private Button BtnSalonGuncelle;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBoxSalonAdi;
        private ComboBox comboBoxIl;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDownKapasite;
        private PictureBox pictureBox1;
        private TextBox textBoxAra;
        private Panel panel4;
        private Button button1;
    }
}