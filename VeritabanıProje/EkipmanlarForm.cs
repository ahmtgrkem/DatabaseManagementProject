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
    public partial class EkipmanlarForm : Form
    {
        public EkipmanlarForm()
        {
            InitializeComponent();
            dataGridViewEkipmanlar.CellClick += dataGridViewEkipmanlar_CellContentClick;
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void EkipmanlarForm_Load(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                        SELECT 
                            e.ekipman_id AS ""Ekipman ID"",
                            e.ad AS ""Ekipman Adı"",
                            e.adet AS ""Adet"",
                            e.durum AS ""Durum"",
                            s.ad AS ""Salon Adı""
                        FROM 
                            ""Ekipmanlar"" e
                        JOIN 
                            ""Salonlar"" s ON e.salon_id = s.salon_id";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewEkipmanlar.DataSource = dt;
                // Durum combobox'ını doldur
                comboBoxDurum.Items.Add("Eski");
                comboBoxDurum.Items.Add("Yeni");

                // Salon combobox'ını doldur
                string salonQuery = "SELECT ad FROM \"Salonlar\"";
                NpgsqlCommand cmd = new NpgsqlCommand(salonQuery, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxSalon.Items.Add(reader["ad"].ToString());
                }
                reader.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEkipmanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEkipmanlar.Rows[e.RowIndex];
                textBoxEkipmanAdi.Text = row.Cells["Ekipman Adı"].Value.ToString();
                numericUpDownAdet.Value = Convert.ToInt32(row.Cells["Adet"].Value);
                comboBoxDurum.Text = row.Cells["Durum"].Value.ToString();
                comboBoxSalon.Text = row.Cells["Salon Adı"].Value.ToString();
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
                        e.ekipman_id AS ""Ekipman ID"",
                        e.ad AS ""Ekipman Adı"",
                        e.adet AS ""Adet"",
                        e.durum AS ""Durum"",
                        s.ad AS ""Salon Adı""
                    FROM 
                        ""Ekipmanlar"" e
                    JOIN 
                        ""Salonlar"" s ON e.salon_id = s.salon_id
                    WHERE 
                        e.ad ILIKE @searchValue";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewEkipmanlar.DataSource = dt;
            }
        }

        private void BtnEkipmanEkle_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Ekipman tablosuna ekleme
                        string ekipmanQuery = @"
                    INSERT INTO ""Ekipmanlar"" (ad, adet, durum, salon_id)
                    VALUES (@ad, @adet, @durum, (SELECT salon_id FROM ""Salonlar"" WHERE ad = @salon_ad))";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(ekipmanQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ad", textBoxEkipmanAdi.Text);
                            cmd.Parameters.AddWithValue("@adet", numericUpDownAdet.Value);
                            cmd.Parameters.AddWithValue("@durum", comboBoxDurum.Text);
                            cmd.Parameters.AddWithValue("@salon_ad", comboBoxSalon.Text);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Ekipman başarıyla eklendi.");

                        // DataGridView'i güncelle
                        EkipmanlarForm_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void BtnEkipmanGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewEkipmanlar.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewEkipmanlar.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridViewEkipmanlar.SelectedRows[0];
                int ekipmanId = Convert.ToInt32(selectedRow.Cells["Ekipman ID"].Value);

                // Mevcut bilgileri al
                string mevcutAd = selectedRow.Cells["Ekipman Adı"].Value.ToString();
                int mevcutAdet = Convert.ToInt32(selectedRow.Cells["Adet"].Value);
                string mevcutDurum = selectedRow.Cells["Durum"].Value.ToString();
                string mevcutSalon = selectedRow.Cells["Salon Adı"].Value.ToString();

                // Yeni bilgileri al
                string yeniAd = textBoxEkipmanAdi.Text;
                int yeniAdet = (int)numericUpDownAdet.Value;
                string yeniDurum = comboBoxDurum.Text;
                string yeniSalon = comboBoxSalon.Text;

                // Bilgilerde değişiklik olup olmadığını kontrol et
                if (mevcutAd == yeniAd && mevcutAdet == yeniAdet && mevcutDurum == yeniDurum && mevcutSalon == yeniSalon)
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
                            // Ekipman tablosunu güncelle
                            string ekipmanQuery = @"
                        UPDATE ""Ekipmanlar"" 
                        SET ad = @ad, adet = @adet, durum = @durum, 
                            salon_id = (SELECT salon_id FROM ""Salonlar"" WHERE ad = @salon_ad)
                        WHERE ekipman_id = @ekipman_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(ekipmanQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@ad", yeniAd);
                                cmd.Parameters.AddWithValue("@adet", yeniAdet);
                                cmd.Parameters.AddWithValue("@durum", yeniDurum);
                                cmd.Parameters.AddWithValue("@salon_ad", yeniSalon);
                                cmd.Parameters.AddWithValue("@ekipman_id", ekipmanId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Ekipman başarıyla güncellendi.");

                            // DataGridView'i güncelle
                            EkipmanlarForm_Load(sender, e);
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
                MessageBox.Show("Lütfen güncellemek için bir ekipman seçin.");
            }
        }

        private void BtnEkipmanSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewEkipmanlar.SelectedRows.Count > 0)
            {
                int ekipmanId = Convert.ToInt32(dataGridViewEkipmanlar.SelectedRows[0].Cells["Ekipman ID"].Value);

                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Ekipman tablosundan silme
                            string ekipmanQuery = @"DELETE FROM ""Ekipmanlar"" WHERE ekipman_id = @ekipman_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(ekipmanQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@ekipman_id", ekipmanId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Ekipman başarıyla silindi.");

                            // DataGridView'i güncelle
                            EkipmanlarForm_Load(sender, e);
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
                MessageBox.Show("Lütfen silmek için bir ekipman seçin.");
            }
        }
    }
}
