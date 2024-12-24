namespace VeritabanıProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnSporcular = new Button();
            BtnAntrenorler = new Button();
            BtnPersoneller = new Button();
            BtnSalonlar = new Button();
            BtnTurnuvalar = new Button();
            BtnEkipmanlar = new Button();
            BtnAntrenmanlar = new Button();
            BtnOduller = new Button();
            SuspendLayout();
            // 
            // BtnSporcular
            // 
            BtnSporcular.Location = new Point(12, 12);
            BtnSporcular.Name = "BtnSporcular";
            BtnSporcular.Size = new Size(92, 426);
            BtnSporcular.TabIndex = 0;
            BtnSporcular.Text = "Sporcular";
            BtnSporcular.UseVisualStyleBackColor = true;
            BtnSporcular.Click += BtnSporcular_Click;
            // 
            // BtnAntrenorler
            // 
            BtnAntrenorler.Location = new Point(109, 12);
            BtnAntrenorler.Name = "BtnAntrenorler";
            BtnAntrenorler.Size = new Size(91, 426);
            BtnAntrenorler.TabIndex = 1;
            BtnAntrenorler.Text = "Antrenörler";
            BtnAntrenorler.UseVisualStyleBackColor = true;
            BtnAntrenorler.Click += BtnAntrenorler_Click;
            // 
            // BtnPersoneller
            // 
            BtnPersoneller.Location = new Point(206, 12);
            BtnPersoneller.Name = "BtnPersoneller";
            BtnPersoneller.Size = new Size(92, 426);
            BtnPersoneller.TabIndex = 2;
            BtnPersoneller.Text = "Personeller";
            BtnPersoneller.UseVisualStyleBackColor = true;
            BtnPersoneller.Click += BtnPersoneller_Click;
            // 
            // BtnSalonlar
            // 
            BtnSalonlar.Location = new Point(304, 12);
            BtnSalonlar.Name = "BtnSalonlar";
            BtnSalonlar.Size = new Size(91, 426);
            BtnSalonlar.TabIndex = 3;
            BtnSalonlar.Text = "Salonlar";
            BtnSalonlar.UseVisualStyleBackColor = true;
            BtnSalonlar.Click += BtnSalonlar_Click;
            // 
            // BtnTurnuvalar
            // 
            BtnTurnuvalar.Location = new Point(401, 12);
            BtnTurnuvalar.Name = "BtnTurnuvalar";
            BtnTurnuvalar.Size = new Size(92, 426);
            BtnTurnuvalar.TabIndex = 4;
            BtnTurnuvalar.Text = "Turnuvalar";
            BtnTurnuvalar.UseVisualStyleBackColor = true;
            BtnTurnuvalar.Click += BtnTurnuvalar_Click;
            // 
            // BtnEkipmanlar
            // 
            BtnEkipmanlar.Location = new Point(499, 12);
            BtnEkipmanlar.Name = "BtnEkipmanlar";
            BtnEkipmanlar.Size = new Size(91, 426);
            BtnEkipmanlar.TabIndex = 5;
            BtnEkipmanlar.Text = "Ekipmanlar";
            BtnEkipmanlar.UseVisualStyleBackColor = true;
            BtnEkipmanlar.Click += BtnEkipmanlar_Click;
            // 
            // BtnAntrenmanlar
            // 
            BtnAntrenmanlar.Location = new Point(596, 12);
            BtnAntrenmanlar.Name = "BtnAntrenmanlar";
            BtnAntrenmanlar.Size = new Size(92, 426);
            BtnAntrenmanlar.TabIndex = 6;
            BtnAntrenmanlar.Text = "Antrenmanlar";
            BtnAntrenmanlar.UseVisualStyleBackColor = true;
            BtnAntrenmanlar.Click += BtnAntrenmanlar_Click;
            // 
            // BtnOduller
            // 
            BtnOduller.Location = new Point(694, 12);
            BtnOduller.Name = "BtnOduller";
            BtnOduller.Size = new Size(92, 426);
            BtnOduller.TabIndex = 7;
            BtnOduller.Text = "Ödüller";
            BtnOduller.UseVisualStyleBackColor = true;
            BtnOduller.Click += BtnOduller_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnOduller);
            Controls.Add(BtnAntrenmanlar);
            Controls.Add(BtnEkipmanlar);
            Controls.Add(BtnTurnuvalar);
            Controls.Add(BtnSalonlar);
            Controls.Add(BtnPersoneller);
            Controls.Add(BtnAntrenorler);
            Controls.Add(BtnSporcular);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SporcuTakipUygulaması";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSporcular;
        private Button BtnAntrenorler;
        private Button BtnPersoneller;
        private Button BtnSalonlar;
        private Button BtnTurnuvalar;
        private Button BtnEkipmanlar;
        private Button BtnAntrenmanlar;
        private Button BtnOduller;
    }
}
