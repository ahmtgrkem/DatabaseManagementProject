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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VeritabanıProje
{
    public partial class PersonellerForm : Form
    {
        public PersonellerForm()
        {
            InitializeComponent();
            dataGridViewPersoneller.CellClick += dataGridViewPersoneller_CellContentClick;
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void PersonellerForm_Load(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
        SELECT 
            k.kisi_id AS ""Kisi ID"",
            k.ad AS ""Ad"",
            k.soyad AS ""Soyad"",
            k.dogum_tarihi AS ""Doğum Tarihi"",
            CASE WHEN k.cinsiyet = TRUE THEN 'Erkek' ELSE 'Kadın' END AS ""Cinsiyet"",
            k.tel_no AS ""Telefon"",
            p.calisma_tipi AS ""Çalışma Tipi"",
            p.gorev AS ""Görev"",
            s.ad AS ""Salon Adı""
        FROM 
            ""kisi"".""Personel"" p
        JOIN 
            ""kisi"".""Kisi"" k ON p.kisi_id = k.kisi_id
        JOIN 
            ""Salonlar"" s ON p.salon_id = s.salon_id";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPersoneller.DataSource = dt;

                // Kisi ID sütununu gizle
                dataGridViewPersoneller.Columns["Kisi ID"].Visible = false;

                // Çalışma Tipi combobox'ını doldur
                comboBoxCalismaTipi.Items.Add("Tam Zamanlı");
                comboBoxCalismaTipi.Items.Add("Yarı Zamanlı");

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

        private void dataGridViewPersoneller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPersoneller.Rows[e.RowIndex];
                textBoxPersonelAdi.Text = row.Cells["Ad"].Value.ToString();
                textBoxPersonelSoyadi.Text = row.Cells["Soyad"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Doğum Tarihi"].Value);
                comboBoxCalismaTipi.Text = row.Cells["Çalışma Tipi"].Value.ToString();
                textBoxGorev.Text = row.Cells["Görev"].Value.ToString();
                comboBoxSalon.Text = row.Cells["Salon Adı"].Value.ToString();
                maskedTextBoxTelNo.Text = row.Cells["Telefon"].Value.ToString();

                // Cinsiyet radio button'larını ayarla
                string cinsiyet = row.Cells["Cinsiyet"].Value.ToString();
                if (cinsiyet == "Erkek")
                {
                    radioButtonErkek.Checked = true;
                }
                else if (cinsiyet == "Kadın")
                {
                    radioButtonKadin.Checked = true;
                }
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
                    k.ad AS ""Ad"",
                    k.soyad AS ""Soyad"",
                    k.dogum_tarihi AS ""Doğum Tarihi"",
                    CASE WHEN k.cinsiyet = TRUE THEN 'Erkek' ELSE 'Kadın' END AS ""Cinsiyet"",
                    k.tel_no AS ""Telefon"",
                    p.calisma_tipi AS ""Çalışma Tipi"",
                    p.gorev AS ""Görev"",
                    s.ad AS ""Salon Adı""
                FROM 
                    ""kisi"".""Personel"" p
                JOIN 
                    ""kisi"".""Kisi"" k ON p.kisi_id = k.kisi_id
                JOIN 
                    ""Salonlar"" s ON p.salon_id = s.salon_id
                WHERE 
                    k.ad LIKE '%" + searchValue + "%' OR k.soyad LIKE '%" + searchValue + "%'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewPersoneller.DataSource = dt;
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
                        // Kisi tablosuna ekleme
                        string kisiQuery = @"
                INSERT INTO ""kisi"".""Kisi"" (ad, soyad, dogum_tarihi, cinsiyet, tel_no, kisi_tipi)
                VALUES (@ad, @soyad, @dogum_tarihi, @cinsiyet, @tel_no, '3')
                RETURNING kisi_id";
                        int kisiId;
                        using (NpgsqlCommand cmd = new NpgsqlCommand(kisiQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ad", textBoxPersonelAdi.Text);
                            cmd.Parameters.AddWithValue("@soyad", textBoxPersonelSoyadi.Text);
                            cmd.Parameters.AddWithValue("@dogum_tarihi", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@cinsiyet", radioButtonErkek.Checked);
                            cmd.Parameters.AddWithValue("@tel_no", maskedTextBoxTelNo.Text);
                            kisiId = (int)cmd.ExecuteScalar();
                        }

                        // Personel tablosuna ekleme
                        string personelQuery = @"
                INSERT INTO ""kisi"".""Personel"" (kisi_id, salon_id, calisma_tipi, gorev)
                VALUES (@kisi_id, (SELECT salon_id FROM ""Salonlar"" WHERE ad = @salon_ad), @calisma_tipi, @gorev)";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(personelQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@kisi_id", kisiId);
                            cmd.Parameters.AddWithValue("@salon_ad", comboBoxSalon.Text);
                            cmd.Parameters.AddWithValue("@calisma_tipi", comboBoxCalismaTipi.Text);
                            cmd.Parameters.AddWithValue("@gorev", textBoxGorev.Text);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Personel başarıyla eklendi.");

                        // DataGridView'i güncelle
                        PersonellerForm_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersoneller.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewPersoneller.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridViewPersoneller.SelectedRows[0];
                int kisiId = Convert.ToInt32(selectedRow.Cells["Kisi ID"].Value);

                // Mevcut bilgileri al
                string mevcutAd = selectedRow.Cells["Ad"].Value.ToString();
                string mevcutSoyad = selectedRow.Cells["Soyad"].Value.ToString();
                DateTime mevcutDogumTarihi = Convert.ToDateTime(selectedRow.Cells["Doğum Tarihi"].Value);
                string mevcutCinsiyet = selectedRow.Cells["Cinsiyet"].Value.ToString();
                string mevcutTelNo = selectedRow.Cells["Telefon"].Value.ToString();
                string mevcutCalismaTipi = selectedRow.Cells["Çalışma Tipi"].Value.ToString();
                string mevcutGorev = selectedRow.Cells["Görev"].Value.ToString();
                string mevcutSalon = selectedRow.Cells["Salon Adı"].Value.ToString();

                // Yeni bilgileri al
                string yeniAd = textBoxPersonelAdi.Text;
                string yeniSoyad = textBoxPersonelSoyadi.Text;
                DateTime yeniDogumTarihi = dateTimePicker1.Value;
                string yeniCinsiyet = radioButtonErkek.Checked ? "Erkek" : "Kadın";
                string yeniTelNo = maskedTextBoxTelNo.Text;
                string yeniCalismaTipi = comboBoxCalismaTipi.Text;
                string yeniGorev = textBoxGorev.Text;
                string yeniSalon = comboBoxSalon.Text;

                // Bilgilerde değişiklik olup olmadığını kontrol et
                if (mevcutAd == yeniAd && mevcutSoyad == yeniSoyad && mevcutDogumTarihi == yeniDogumTarihi &&
                    mevcutCinsiyet == yeniCinsiyet && mevcutTelNo == yeniTelNo && mevcutCalismaTipi == yeniCalismaTipi &&
                    mevcutGorev == yeniGorev && mevcutSalon == yeniSalon)
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
                            // Kisi tablosunu güncelle
                            string kisiQuery = @"
    UPDATE ""kisi"".""Kisi"" 
    SET ad = @ad, soyad = @soyad, dogum_tarihi = @dogum_tarihi, cinsiyet = @cinsiyet, tel_no = @tel_no
    WHERE kisi_id = @kisi_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(kisiQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@ad", yeniAd);
                                cmd.Parameters.AddWithValue("@soyad", yeniSoyad);
                                cmd.Parameters.AddWithValue("@dogum_tarihi", yeniDogumTarihi);
                                cmd.Parameters.AddWithValue("@cinsiyet", yeniCinsiyet == "Erkek");
                                cmd.Parameters.AddWithValue("@tel_no", yeniTelNo);
                                cmd.Parameters.AddWithValue("@kisi_id", kisiId);
                                cmd.ExecuteNonQuery();
                            }

                            // Personel tablosunu güncelle
                            string personelQuery = @"
    UPDATE ""kisi"".""Personel"" 
    SET calisma_tipi = @calisma_tipi, gorev = @gorev, salon_id = (SELECT salon_id FROM ""Salonlar"" WHERE ad = @salon_ad)
    WHERE kisi_id = @kisi_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(personelQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@calisma_tipi", yeniCalismaTipi);
                                cmd.Parameters.AddWithValue("@gorev", yeniGorev);
                                cmd.Parameters.AddWithValue("@salon_ad", yeniSalon);
                                cmd.Parameters.AddWithValue("@kisi_id", kisiId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Personel başarıyla güncellendi.");

                            // DataGridView'i güncelle
                            PersonellerForm_Load(sender, e);
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
                MessageBox.Show("Lütfen güncellemek için bir personel seçin.");
            }
        }

        private void BtnpPersonelSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersoneller.SelectedRows.Count > 0)
            {
                int kisiId = Convert.ToInt32(dataGridViewPersoneller.SelectedRows[0].Cells["Kisi ID"].Value);

                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Personel tablosundan silme
                            string personelQuery = @"DELETE FROM ""kisi"".""Personel"" WHERE kisi_id = @kisi_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(personelQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@kisi_id", kisiId);
                                cmd.ExecuteNonQuery();
                            }

                            // Kisi tablosundan silme
                            string kisiQuery = @"DELETE FROM ""kisi"".""Kisi"" WHERE kisi_id = @kisi_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(kisiQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@kisi_id", kisiId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Personel başarıyla silindi.");

                            // DataGridView'i güncelle
                            PersonellerForm_Load(sender, e);
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
                MessageBox.Show("Lütfen silmek için bir personel seçin.");
            }
        }
    }
}
