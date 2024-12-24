namespace VeritabanıProje
{
    partial class TurnuvalarForm
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
            BtnTurnuvaEkle = new Button();
            BtnTurnuvaGuncelle = new Button();
            BtnTurnuvaSil = new Button();
            panel2 = new Panel();
            comboBoxOdul = new ComboBox();
            label6 = new Label();
            comboBoxBrans = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBoxIl = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            textBoxTurnuvaAdi = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            BtnGeri = new Button();
            dataGridViewTurnuvalar = new DataGridView();
            pictureBox1 = new PictureBox();
            textBoxAra = new TextBox();
            panel4 = new Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurnuvalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(BtnTurnuvaEkle);
            panel3.Controls.Add(BtnTurnuvaGuncelle);
            panel3.Controls.Add(BtnTurnuvaSil);
            panel3.Location = new Point(248, 638);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 71);
            panel3.TabIndex = 22;
            // 
            // BtnTurnuvaEkle
            // 
            BtnTurnuvaEkle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnTurnuvaEkle.Location = new Point(3, 3);
            BtnTurnuvaEkle.Name = "BtnTurnuvaEkle";
            BtnTurnuvaEkle.Size = new Size(256, 65);
            BtnTurnuvaEkle.TabIndex = 8;
            BtnTurnuvaEkle.Text = "Ekle";
            BtnTurnuvaEkle.UseVisualStyleBackColor = true;
            BtnTurnuvaEkle.Click += BtnTurnuvaEkle_Click;
            // 
            // BtnTurnuvaGuncelle
            // 
            BtnTurnuvaGuncelle.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnTurnuvaGuncelle.Location = new Point(265, 3);
            BtnTurnuvaGuncelle.Name = "BtnTurnuvaGuncelle";
            BtnTurnuvaGuncelle.Size = new Size(238, 65);
            BtnTurnuvaGuncelle.TabIndex = 10;
            BtnTurnuvaGuncelle.Text = "Güncelle";
            BtnTurnuvaGuncelle.UseVisualStyleBackColor = true;
            BtnTurnuvaGuncelle.Click += BtnTurnuvaGuncelle_Click;
            // 
            // BtnTurnuvaSil
            // 
            BtnTurnuvaSil.Font = new Font("League Spartan", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnTurnuvaSil.Location = new Point(509, 3);
            BtnTurnuvaSil.Name = "BtnTurnuvaSil";
            BtnTurnuvaSil.Size = new Size(229, 65);
            BtnTurnuvaSil.TabIndex = 9;
            BtnTurnuvaSil.Text = "Sil";
            BtnTurnuvaSil.UseVisualStyleBackColor = true;
            BtnTurnuvaSil.Click += BtnTurnuvaSil_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(comboBoxOdul);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBoxBrans);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(comboBoxIl);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxTurnuvaAdi);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 612);
            panel2.TabIndex = 21;
            // 
            // comboBoxOdul
            // 
            comboBoxOdul.FormattingEnabled = true;
            comboBoxOdul.Location = new Point(5, 421);
            comboBoxOdul.Name = "comboBoxOdul";
            comboBoxOdul.Size = new Size(212, 28);
            comboBoxOdul.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(5, 388);
            label6.Name = "label6";
            label6.Size = new Size(82, 30);
            label6.TabIndex = 16;
            label6.Text = "Ödül Adı";
            // 
            // comboBoxBrans
            // 
            comboBoxBrans.FormattingEnabled = true;
            comboBoxBrans.Location = new Point(3, 327);
            comboBoxBrans.Name = "comboBoxBrans";
            comboBoxBrans.Size = new Size(212, 28);
            comboBoxBrans.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(3, 294);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 13;
            label3.Text = "Brans Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(3, 201);
            label5.Name = "label5";
            label5.Size = new Size(54, 30);
            label5.TabIndex = 12;
            label5.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(5, 234);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // comboBoxIl
            // 
            comboBoxIl.FormattingEnabled = true;
            comboBoxIl.Location = new Point(5, 518);
            comboBoxIl.Name = "comboBoxIl";
            comboBoxIl.Size = new Size(212, 28);
            comboBoxIl.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(5, 485);
            label4.Name = "label4";
            label4.Size = new Size(53, 30);
            label4.TabIndex = 6;
            label4.Text = "İl Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("League Spartan", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 112);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 4;
            label2.Text = "Turnuva Adı";
            // 
            // textBoxTurnuvaAdi
            // 
            textBoxTurnuvaAdi.Location = new Point(3, 145);
            textBoxTurnuvaAdi.Name = "textBoxTurnuvaAdi";
            textBoxTurnuvaAdi.Size = new Size(214, 27);
            textBoxTurnuvaAdi.TabIndex = 1;
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
            // dataGridViewTurnuvalar
            // 
            dataGridViewTurnuvalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTurnuvalar.Location = new Point(249, 142);
            dataGridViewTurnuvalar.Name = "dataGridViewTurnuvalar";
            dataGridViewTurnuvalar.ReadOnly = true;
            dataGridViewTurnuvalar.RowHeadersWidth = 51;
            dataGridViewTurnuvalar.Size = new Size(740, 490);
            dataGridViewTurnuvalar.TabIndex = 17;
            dataGridViewTurnuvalar.CellContentClick += dataGridViewTurnuvalar_CellContentClick;
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
            panel4.Location = new Point(249, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(740, 37);
            panel4.TabIndex = 30;
            // 
            // TurnuvalarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewTurnuvalar);
            MaximizeBox = false;
            Name = "TurnuvalarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TurnuvalarForm";
            Load += TurnuvalarForm_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurnuvalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button BtnTurnuvaEkle;
        private Button BtnTurnuvaGuncelle;
        private Button BtnTurnuvaSil;
        private Panel panel2;
        private ComboBox comboBoxIl;
        private Label label4;
        private Label label2;
        private TextBox textBoxTurnuvaAdi;
        private Label label1;
        private Panel panel1;
        private Button BtnGeri;
        private DataGridView dataGridViewTurnuvalar;
        private ComboBox comboBoxBrans;
        private Label label3;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox textBoxAra;
        private Panel panel4;
        private ComboBox comboBoxOdul;
    }
}