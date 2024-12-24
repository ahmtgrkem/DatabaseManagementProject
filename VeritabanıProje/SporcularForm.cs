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
    public partial class SporcularForm : Form
    {
        public SporcularForm()
        {
            InitializeComponent();
            dataGridViewSporcular.CellClick += dataGridViewSporcular_CellContentClick;
        }

        private void SporcularForm_Load(object sender, EventArgs e)
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
            s.sporcu_durumu AS ""Sporcu Durumu"",
            b.ad AS ""Branş"",
            a.ad AS ""Antrenman""
        FROM 
            ""kisi"".""Sporcu"" s
        JOIN 
            ""kisi"".""Kisi"" k ON s.kisi_id = k.kisi_id
        JOIN 
            ""Branslar"" b ON s.brans_id = b.brans_id
        LEFT JOIN 
            ""Antrenmanlar"" a ON s.antrenman_id = a.antrenman_id"; // Antrenman bilgilerini ekledik
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSporcular.DataSource = dt;

                // Kisi ID sütununu gizle
                dataGridViewSporcular.Columns["Kisi ID"].Visible = false;

                // Durum combobox'ını doldur
                comboBoxDurum.Items.Add("Aktif");
                comboBoxDurum.Items.Add("Pasif");

                // Branş combobox'ını doldur
                string bransQuery = "SELECT ad FROM \"Branslar\"";
                NpgsqlCommand cmd = new NpgsqlCommand(bransQuery, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxBrans.Items.Add(reader["ad"].ToString());
                }
                reader.Close();

                // Antrenman combobox'ını doldur
                string antrenmanQuery = "SELECT ad FROM \"Antrenmanlar\"";
                cmd = new NpgsqlCommand(antrenmanQuery, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxAntrenman.Items.Add(reader["ad"].ToString());
                }
                reader.Close();
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void dataGridViewSporcular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSporcular.Rows[e.RowIndex];
                textBoxSporcuAdi.Text = row.Cells["Ad"].Value.ToString();
                textBoxSporcuSoyadi.Text = row.Cells["Soyad"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Doğum Tarihi"].Value);
                comboBoxDurum.Text = row.Cells["Sporcu Durumu"].Value.ToString();
                comboBoxBrans.Text = row.Cells["Branş"].Value.ToString();
                maskedTextBoxTelNo.Text = row.Cells["Telefon"].Value.ToString();
                comboBoxAntrenman.Text = row.Cells["Antrenman"].Value.ToString(); // Antrenman bilgilerini ekledik

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
                        s.sporcu_durumu AS ""Sporcu Durumu"",
                        b.ad AS ""Branş""
                    FROM 
                        ""kisi"".""Sporcu"" s
                    JOIN 
                        ""kisi"".""Kisi"" k ON s.kisi_id = k.kisi_id
                    JOIN 
                        ""Branslar"" b ON s.brans_id = b.brans_id
                    WHERE 
                        k.ad ILIKE @searchValue";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchValue", searchValue + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSporcular.DataSource = dt;
            }
        }

        private void BtnSporcuEkle_Click(object sender, EventArgs e)
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
        VALUES (@ad, @soyad, @dogum_tarihi, @cinsiyet, @tel_no, '1')
        RETURNING kisi_id";
                        int kisiId;
                        using (NpgsqlCommand cmd = new NpgsqlCommand(kisiQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ad", textBoxSporcuAdi.Text);
                            cmd.Parameters.AddWithValue("@soyad", textBoxSporcuSoyadi.Text);
                            cmd.Parameters.AddWithValue("@dogum_tarihi", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@cinsiyet", radioButtonErkek.Checked);
                            cmd.Parameters.AddWithValue("@tel_no", maskedTextBoxTelNo.Text);
                            kisiId = (int)cmd.ExecuteScalar();
                        }

                        // Sporcu tablosuna ekleme
                        string sporcuQuery = @"
        INSERT INTO ""kisi"".""Sporcu"" (kisi_id, sporcu_durumu, brans_id, antrenman_id)
        VALUES (@kisi_id, @sporcu_durumu, (SELECT brans_id FROM ""Branslar"" WHERE ad = @brans_ad), (SELECT antrenman_id FROM ""Antrenmanlar"" WHERE ad = @antrenman_ad))";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(sporcuQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@kisi_id", kisiId);
                            cmd.Parameters.AddWithValue("@sporcu_durumu", comboBoxDurum.Text);
                            cmd.Parameters.AddWithValue("@brans_ad", comboBoxBrans.Text);
                            cmd.Parameters.AddWithValue("@antrenman_ad", comboBoxAntrenman.Text); // Antrenman bilgilerini ekledik
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Sporcu başarıyla eklendi.");

                        // DataGridView'i güncelle
                        SporcularForm_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void BtnSporcuGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewSporcular.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewSporcular.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridViewSporcular.SelectedRows[0];
                int kisiId = Convert.ToInt32(selectedRow.Cells["Kisi ID"].Value);

                // Mevcut bilgileri al
                string mevcutAd = selectedRow.Cells["Ad"].Value.ToString();
                string mevcutSoyad = selectedRow.Cells["Soyad"].Value.ToString();
                DateTime mevcutDogumTarihi = Convert.ToDateTime(selectedRow.Cells["Doğum Tarihi"].Value);
                string mevcutCinsiyet = selectedRow.Cells["Cinsiyet"].Value.ToString();
                string mevcutTelNo = selectedRow.Cells["Telefon"].Value.ToString();
                string mevcutSporcuDurumu = selectedRow.Cells["Sporcu Durumu"].Value.ToString();
                string mevcutBrans = selectedRow.Cells["Branş"].Value.ToString();
                string mevcutAntrenman = selectedRow.Cells["Antrenman"].Value.ToString();

                // Yeni bilgileri al
                string yeniAd = textBoxSporcuAdi.Text;
                string yeniSoyad = textBoxSporcuSoyadi.Text;
                DateTime yeniDogumTarihi = dateTimePicker1.Value;
                string yeniCinsiyet = radioButtonErkek.Checked ? "Erkek" : "Kadın";
                string yeniTelNo = maskedTextBoxTelNo.Text;
                string yeniSporcuDurumu = comboBoxDurum.Text;
                string yeniBrans = comboBoxBrans.Text;
                string yeniAntrenman = comboBoxAntrenman.Text;

                // Bilgilerde değişiklik olup olmadığını kontrol et
                if (mevcutAd == yeniAd && mevcutSoyad == yeniSoyad && mevcutDogumTarihi == yeniDogumTarihi &&
                    mevcutCinsiyet == yeniCinsiyet && mevcutTelNo == yeniTelNo && mevcutSporcuDurumu == yeniSporcuDurumu &&
                    mevcutBrans == yeniBrans && mevcutAntrenman == yeniAntrenman)
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

                            // Sporcu tablosunu güncelle
                            string sporcuQuery = @"
    UPDATE ""kisi"".""Sporcu"" 
    SET sporcu_durumu = @sporcu_durumu, brans_id = (SELECT brans_id FROM ""Branslar"" WHERE ad = @brans_ad), antrenman_id = (SELECT antrenman_id FROM ""Antrenmanlar"" WHERE ad = @antrenman_ad)
    WHERE kisi_id = @kisi_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(sporcuQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@sporcu_durumu", yeniSporcuDurumu);
                                cmd.Parameters.AddWithValue("@brans_ad", yeniBrans);
                                cmd.Parameters.AddWithValue("@antrenman_ad", yeniAntrenman);
                                cmd.Parameters.AddWithValue("@kisi_id", kisiId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Sporcu başarıyla güncellendi.");

                            // DataGridView'i güncelle
                            SporcularForm_Load(sender, e);
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
                MessageBox.Show("Lütfen güncellemek için bir sporcu seçin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT hesapla_sporcu_yas_ortalama()", conn))
                {
                    decimal yasOrtalama = (decimal)cmd.ExecuteScalar();
                    MessageBox.Show($"Sporcuların yaş ortalaması: {yasOrtalama:F1}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bransAdi = comboBoxBrans.Text; // ComboBox'tan seçilen branş

            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT brans_aktif_sporcu_sayisi(@brans)", conn))
                {
                    cmd.Parameters.AddWithValue("@brans", bransAdi);
                    int sporcuSayisi = (int)cmd.ExecuteScalar();
                    MessageBox.Show($"{bransAdi} branşında {sporcuSayisi} aktif sporcu bulunmaktadır.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewSporcular.SelectedRows.Count > 0)
            {
                int sporcuId = Convert.ToInt32(dataGridViewSporcular.SelectedRows[0].Cells["Kisi ID"].Value);

                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("CALL listele_sporcu_turnuvalar(@sporcu_id)", conn))
                    {
                        cmd.Parameters.AddWithValue("@sporcu_id", sporcuId);
                        cmd.ExecuteNonQuery();

                        // Query temp table
                        using (NpgsqlCommand selectCmd = new NpgsqlCommand("SELECT * FROM temp_turnuvalar", conn))
                        {
                            NpgsqlDataAdapter da = new NpgsqlDataAdapter(selectCmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            // Show results in a new DataGridView or MessageBox
                            MessageBox.Show(string.Join("\n", dt.Rows.Cast<DataRow>()
                                .Select(row => $"Turnuva: {row["turnuva_adi"]}, Tarih: {row["tarih"]}, Ödül: {row["odul_adi"]} ({row["odul_miktari"]} TL)")));
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sporcu seçin.");
            }
        }

        private void BtnSporcuSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewSporcular.SelectedRows.Count > 0)
            {
                int kisiId = Convert.ToInt32(dataGridViewSporcular.SelectedRows[0].Cells["Kisi ID"].Value);

                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Sporcu tablosundan silme
                            string sporcuQuery = @"DELETE FROM ""kisi"".""Sporcu"" WHERE kisi_id = @kisi_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(sporcuQuery, conn))
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
                            MessageBox.Show("Sporcu başarıyla silindi.");

                            // DataGridView'i güncelle
                            SporcularForm_Load(sender, e);
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
                MessageBox.Show("Lütfen silmek için bir sporcu seçin.");
            }
        }
    }
}