using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabanıProje
{
    public partial class AntrenmanlarForm : Form
    {
        public AntrenmanlarForm()
        {
            InitializeComponent();
            dataGridViewAntrenmanlar.CellClick += dataGridViewAntrenmanlar_CellContentClick;
        }

        private void AntrenmanlarForm_Load(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                        SELECT 
                            antrenman_id AS ""Antrenman ID"",
                            ad AS ""Antrenman Adı"",
                            tur AS ""Antrenman Türü"",
                            zorluk AS ""Zorluk Derecesi""
                        FROM 
                            ""Antrenmanlar""";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAntrenmanlar.DataSource = dt;
                // Zorluk combobox'ını doldur
                comboBoxZorluk.Items.Add("Kolay");
                comboBoxZorluk.Items.Add("Orta");
                comboBoxZorluk.Items.Add("Zor");
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void dataGridViewAntrenmanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAntrenmanlar.Rows[e.RowIndex];
                textBoxAntrenmanAdi.Text = row.Cells["Antrenman Adı"].Value.ToString();
                textBoxAntrenmanTuru.Text = row.Cells["Antrenman Türü"].Value.ToString();
                comboBoxZorluk.Text = row.Cells["Zorluk Derecesi"].Value.ToString();
            }
        }

        private void textBoxAra_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxAra.Text;
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        antrenman_id AS ""Antrenman ID"",
                        ad AS ""Antrenman Adı"",
                        tur AS ""Antrenman Türü"",
                        zorluk AS ""Zorluk Derecesi""
                    FROM 
                        ""Antrenmanlar""
                    WHERE 
                        ad ILIKE @searchValue";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAntrenmanlar.DataSource = dt;
            }
        }

        private void BtnSalonEkle_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Antrenman tablosuna ekleme
                        string antrenmanQuery = @"
                    INSERT INTO ""Antrenmanlar"" (ad, tur, zorluk)
                    VALUES (@ad, @tur, @zorluk)";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(antrenmanQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ad", textBoxAntrenmanAdi.Text);
                            cmd.Parameters.AddWithValue("@tur", textBoxAntrenmanTuru.Text);
                            cmd.Parameters.AddWithValue("@zorluk", comboBoxZorluk.Text);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Antrenman başarıyla eklendi.");

                        // DataGridView'i güncelle
                        AntrenmanlarForm_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void BtnAntrenmanGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewAntrenmanlar.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAntrenmanlar.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridViewAntrenmanlar.SelectedRows[0];
                int antrenmanId = Convert.ToInt32(selectedRow.Cells["Antrenman ID"].Value);

                // Mevcut bilgileri al
                string mevcutAd = selectedRow.Cells["Antrenman Adı"].Value.ToString();
                string mevcutTur = selectedRow.Cells["Antrenman Türü"].Value.ToString();
                string mevcutZorluk = selectedRow.Cells["Zorluk Derecesi"].Value.ToString();

                // Yeni bilgileri al
                string yeniAd = textBoxAntrenmanAdi.Text;
                string yeniTur = textBoxAntrenmanTuru.Text;
                string yeniZorluk = comboBoxZorluk.Text;

                // Bilgilerde değişiklik olup olmadığını kontrol et
                if (mevcutAd == yeniAd && mevcutTur == yeniTur && mevcutZorluk == yeniZorluk)
                {
                    MessageBox.Show("Bilgilerde herhangi bir değişiklik yapılmadı.");
                    return;
                }

                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Antrenman tablosunu güncelle
                            string antrenmanQuery = @"
                        UPDATE ""Antrenmanlar"" 
                        SET ad = @ad, tur = @tur, zorluk = @zorluk
                        WHERE antrenman_id = @antrenman_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(antrenmanQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@ad", yeniAd);
                                cmd.Parameters.AddWithValue("@tur", yeniTur);
                                cmd.Parameters.AddWithValue("@zorluk", yeniZorluk);
                                cmd.Parameters.AddWithValue("@antrenman_id", antrenmanId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Antrenman başarıyla güncellendi.");

                            // DataGridView'i güncelle
                            AntrenmanlarForm_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir antrenman seçin.");
            }
            if (dataGridViewAntrenmanlar.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAntrenmanlar.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridViewAntrenmanlar.SelectedRows[0];
                int antrenmanId = Convert.ToInt32(selectedRow.Cells["Antrenman ID"].Value);

                // Mevcut bilgileri al
                string mevcutAd = selectedRow.Cells["Antrenman Adı"].Value.ToString();
                string mevcutTur = selectedRow.Cells["Antrenman Türü"].Value.ToString();
                string mevcutZorluk = selectedRow.Cells["Zorluk Derecesi"].Value.ToString();

                // Yeni bilgileri al
                string yeniAd = textBoxAntrenmanAdi.Text;
                string yeniTur = textBoxAntrenmanTuru.Text;
                string yeniZorluk = comboBoxZorluk.Text;

                // Bilgilerde değişiklik olup olmadığını kontrol et
                if (mevcutAd == yeniAd && mevcutTur == yeniTur && mevcutZorluk == yeniZorluk)
                {
                    MessageBox.Show("Bilgilerde herhangi bir değişiklik yapılmadı.");
                    return;
                }

                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Antrenman tablosunu güncelle
                            string antrenmanQuery = @"
                        UPDATE ""Antrenmanlar"" 
                        SET ad = @ad, tur = @tur, zorluk = @zorluk
                        WHERE antrenman_id = @antrenman_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(antrenmanQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@ad", yeniAd);
                                cmd.Parameters.AddWithValue("@tur", yeniTur);
                                cmd.Parameters.AddWithValue("@zorluk", yeniZorluk);
                                cmd.Parameters.AddWithValue("@antrenman_id", antrenmanId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Antrenman başarıyla güncellendi.");

                            // DataGridView'i güncelle
                            AntrenmanlarForm_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir antrenman seçin.");
            }
        }

        private void BtnAntrenmanSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewAntrenmanlar.SelectedRows.Count > 0)
            {
                int antrenmanId = Convert.ToInt32(dataGridViewAntrenmanlar.SelectedRows[0].Cells["Antrenman ID"].Value);

                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Antrenman tablosundan silme
                            string antrenmanQuery = @"DELETE FROM ""Antrenmanlar"" WHERE antrenman_id = @antrenman_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(antrenmanQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@antrenman_id", antrenmanId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Antrenman başarıyla silindi.");

                            // DataGridView'i güncelle
                            AntrenmanlarForm_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir antrenman seçin.");
            }
        }
    }
}
