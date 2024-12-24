using System;
using Npgsql;

namespace VeritabanıProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;");
        }

        private void BtnSporcular_Click(object sender, EventArgs e)
        {
            SporcularForm sporcularForm = new SporcularForm();
            this.Hide();
            sporcularForm.FormClosed += (sender, e) => this.Close();
            sporcularForm.Show();
            return;
        }

        private void BtnAntrenorler_Click(object sender, EventArgs e)
        {
            AntrenorlerForm antrenorlerForm = new AntrenorlerForm();
            this.Hide();
            antrenorlerForm.FormClosed += (sender, e) => this.Close();
            antrenorlerForm.Show();
            return;
        }

        private void BtnPersoneller_Click(object sender, EventArgs e)
        {
            PersonellerForm personellerForm = new PersonellerForm();
            this.Hide();
            personellerForm.FormClosed += (sender, e) => this.Close();
            personellerForm.Show();
            return;
        }

        private void BtnSalonlar_Click(object sender, EventArgs e)
        {
            SalonlarForm salonlarForm = new SalonlarForm();
            this.Hide();
            salonlarForm.FormClosed += (sender, e) => this.Close();
            salonlarForm.Show();
            return;
        }

        private void BtnTurnuvalar_Click(object sender, EventArgs e)
        {
            TurnuvalarForm turnuvalarForm = new TurnuvalarForm();
            this.Hide();
            turnuvalarForm.FormClosed += (sender, e) => this.Close();
            turnuvalarForm.Show();
            return;
        }

        private void BtnEkipmanlar_Click(object sender, EventArgs e)
        {
            EkipmanlarForm ekipmanlarForm = new EkipmanlarForm();
            this.Hide();
            ekipmanlarForm.FormClosed += (sender, e) => this.Close();
            ekipmanlarForm.Show();
            return;
        }

        private void BtnAntrenmanlar_Click(object sender, EventArgs e)
        {
            AntrenmanlarForm antrenmanlarForm = new AntrenmanlarForm();
            this.Hide();
            antrenmanlarForm.FormClosed += (sender, e) => this.Close();
            antrenmanlarForm.Show();
            return;
        }

        private void BtnOduller_Click(object sender, EventArgs e)
        {
            OdullerForm odullerForm = new OdullerForm();
            this.Hide();
            odullerForm.FormClosed += (sender, e) => this.Close();
            odullerForm.Show();
            return;
        }
    }
}
