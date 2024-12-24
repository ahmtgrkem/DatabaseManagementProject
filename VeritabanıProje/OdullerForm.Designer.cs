namespace VeritabanıProje
{
    partial class OdullerForm
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
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            textBoxAra = new TextBox();
            panel3 = new Panel();
            BtnOdulEkle = new Button();
            BtnOdulGuncelle = new Button();
            BtnOdulSil = new Button();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxOdulAdi = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            BtnGeri = new Button();
            dataGridViewOduller = new DataGridView();
            textBoxOdulMiktari = new TextBox();
            textBoxOdulSayisi = new TextBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOduller).BeginInit();
            SuspendLayout();
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
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(BtnOdulEkle);
            panel3.Controls.Add(BtnOdulGuncelle);
            panel3.Controls.Add(BtnOdulSil);
            panel3.Location = new Point(248, 638);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 71);
            panel3.TabIndex = 34;
            // 
            // BtnOdulEkle
            // 
            BtnOdulEkle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnOdulEkle.Location = new Point(3, 3);
            BtnOdulEkle.Name = "BtnOdulEkle";
            BtnOdulEkle.Size = new Size(256, 65);
            BtnOdulEkle.TabIndex = 8;
            BtnOdulEkle.Text = "Ekle";
            BtnOdulEkle.UseVisualStyleBackColor = true;
            BtnOdulEkle.Click += BtnOdulEkle_Click;
            // 
            // BtnOdulGuncelle
            // 
            BtnOdulGuncelle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnOdulGuncelle.Location = new Point(265, 3);
            BtnOdulGuncelle.Name = "BtnOdulGuncelle";
            BtnOdulGuncelle.Size = new Size(238, 65);
            BtnOdulGuncelle.TabIndex = 10;
            BtnOdulGuncelle.Text = "Güncelle";
            BtnOdulGuncelle.UseVisualStyleBackColor = true;
            BtnOdulGuncelle.Click += BtnOdulGuncelle_Click;
            // 
            // BtnOdulSil
            // 
            BtnOdulSil.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnOdulSil.Location = new Point(509, 3);
            BtnOdulSil.Name = "BtnOdulSil";
            BtnOdulSil.Size = new Size(229, 65);
            BtnOdulSil.TabIndex = 9;
            BtnOdulSil.Text = "Sil";
            BtnOdulSil.UseVisualStyleBackColor = true;
            BtnOdulSil.Click += BtnOdulSil_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBoxOdulSayisi);
            panel2.Controls.Add(textBoxOdulMiktari);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxOdulAdi);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 612);
            panel2.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(5, 342);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 6;
            label4.Text = "Ödül Sayısı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(3, 220);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 5;
            label3.Text = "Ödül Miktarı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 112);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 4;
            label2.Text = "Ödül Adı";
            // 
            // textBoxOdulAdi
            // 
            textBoxOdulAdi.Location = new Point(3, 145);
            textBoxOdulAdi.Name = "textBoxOdulAdi";
            textBoxOdulAdi.Size = new Size(214, 27);
            textBoxOdulAdi.TabIndex = 1;
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
            // dataGridViewOduller
            // 
            dataGridViewOduller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOduller.Location = new Point(248, 142);
            dataGridViewOduller.Name = "dataGridViewOduller";
            dataGridViewOduller.ReadOnly = true;
            dataGridViewOduller.RowHeadersWidth = 51;
            dataGridViewOduller.Size = new Size(740, 490);
            dataGridViewOduller.TabIndex = 31;
            dataGridViewOduller.CellContentClick += dataGridViewOduller_CellContentClick;
            // 
            // textBoxOdulMiktari
            // 
            textBoxOdulMiktari.Location = new Point(3, 253);
            textBoxOdulMiktari.Name = "textBoxOdulMiktari";
            textBoxOdulMiktari.Size = new Size(214, 27);
            textBoxOdulMiktari.TabIndex = 7;
            // 
            // textBoxOdulSayisi
            // 
            textBoxOdulSayisi.Location = new Point(3, 375);
            textBoxOdulSayisi.Name = "textBoxOdulSayisi";
            textBoxOdulSayisi.Size = new Size(214, 27);
            textBoxOdulSayisi.TabIndex = 8;
            // 
            // OdullerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewOduller);
            MaximizeBox = false;
            Name = "OdullerForm";
            Text = "OdullerForm";
            Load += OdullerForm_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOduller).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private PictureBox pictureBox1;
        private TextBox textBoxAra;
        private Panel panel3;
        private Button BtnOdulEkle;
        private Button BtnOdulGuncelle;
        private Button BtnOdulSil;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxOdulAdi;
        private Label label1;
        private Panel panel1;
        private Button BtnGeri;
        private DataGridView dataGridViewOduller;
        private TextBox textBoxOdulSayisi;
        private TextBox textBoxOdulMiktari;
    }
}