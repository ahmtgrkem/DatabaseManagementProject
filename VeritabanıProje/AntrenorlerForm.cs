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
    public partial class AntrenorlerForm : Form
    {
        public AntrenorlerForm()
        {
            InitializeComponent();
            dataGridViewAntrenorler.CellClick += dataGridViewAntrenorler_CellContentClick;
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void AntrenorlerForm_Load(object sender, EventArgs e)
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
            a.calisma_tipi AS ""Çalışma Tipi"",
            a.baslama_tarihi AS ""Başlama Tarihi""
        FROM 
            ""kisi"".""Antrenor"" a
        JOIN 
            ""kisi"".""Kisi"" k ON a.kisi_id = k.kisi_id";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAntrenorler.DataSource = dt;

                // Kisi ID sütununu gizle
                dataGridViewAntrenorler.Columns["Kisi ID"].Visible = false;

                // Çalışma Tipi combobox'ını doldur
                comboBoxCalismaTipi.Items.Add("Takım Antrenörü");
                comboBoxCalismaTipi.Items.Add("Bireysel Antrenör");
            }
        }


        private void dataGridViewAntrenorler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAntrenorler.Rows[e.RowIndex];
                textBoxAntrenorAdi.Text = row.Cells["Ad"].Value.ToString();
                textBoxAntrenorSoyadi.Text = row.Cells["Soyad"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Doğum Tarihi"].Value);
                comboBoxCalismaTipi.Text = row.Cells["Çalışma Tipi"].Value.ToString();
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["Başlama Tarihi"].Value);
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
                        a.calisma_tipi AS ""Çalışma Tipi"",
                        a.baslama_tarihi AS ""Başlama Tarihi""
                    FROM 
                        ""kisi"".""Antrenor"" a
                    JOIN 
                        ""kisi"".""Kisi"" k ON a.kisi_id = k.kisi_id
                    WHERE 
                        k.ad ILIKE @searchValue";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchValue", searchValue + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAntrenorler.DataSource = dt;
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
                    VALUES (@ad, @soyad, @dogum_tarihi, @cinsiyet, @tel_no, '2')
                    RETURNING kisi_id";
                        int kisiId;
                        using (NpgsqlCommand cmd = new NpgsqlCommand(kisiQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ad", textBoxAntrenorAdi.Text);
                            cmd.Parameters.AddWithValue("@soyad", textBoxAntrenorSoyadi.Text);
                            cmd.Parameters.AddWithValue("@dogum_tarihi", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@cinsiyet", radioButtonErkek.Checked);
                            cmd.Parameters.AddWithValue("@tel_no", maskedTextBoxTelNo.Text);
                            kisiId = (int)cmd.ExecuteScalar();
                        }

                        // Antrenor tablosuna ekleme
                        string antrenorQuery = @"
                    INSERT INTO ""kisi"".""Antrenor"" (kisi_id, calisma_tipi, baslama_tarihi)
                    VALUES (@kisi_id, @calisma_tipi, @baslama_tarihi)";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(antrenorQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@kisi_id", kisiId);
                            cmd.Parameters.AddWithValue("@calisma_tipi", comboBoxCalismaTipi.Text);
                            cmd.Parameters.AddWithValue("@baslama_tarihi", dateTimePicker2.Value);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Antrenör başarıyla eklendi.");

                        // DataGridView'i güncelle
                        AntrenorlerForm_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void BtnAntrenorGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewAntrenorler.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAntrenorler.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridViewAntrenorler.SelectedRows[0];
                int kisiId = Convert.ToInt32(selectedRow.Cells["Kisi ID"].Value);

                // Mevcut bilgileri al
                string mevcutAd = selectedRow.Cells["Ad"].Value.ToString();
                string mevcutSoyad = selectedRow.Cells["Soyad"].Value.ToString();
                DateTime mevcutDogumTarihi = Convert.ToDateTime(selectedRow.Cells["Doğum Tarihi"].Value);
                string mevcutCinsiyet = selectedRow.Cells["Cinsiyet"].Value.ToString();
                string mevcutTelNo = selectedRow.Cells["Telefon"].Value.ToString();
                string mevcutCalismaTipi = selectedRow.Cells["Çalışma Tipi"].Value.ToString();
                DateTime mevcutBaslamaTarihi = Convert.ToDateTime(selectedRow.Cells["Başlama Tarihi"].Value);

                // Yeni bilgileri al
                string yeniAd = textBoxAntrenorAdi.Text;
                string yeniSoyad = textBoxAntrenorSoyadi.Text;
                DateTime yeniDogumTarihi = dateTimePicker1.Value;
                string yeniCinsiyet = radioButtonErkek.Checked ? "Erkek" : "Kadın";
                string yeniTelNo = maskedTextBoxTelNo.Text;
                string yeniCalismaTipi = comboBoxCalismaTipi.Text;
                DateTime yeniBaslamaTarihi = dateTimePicker2.Value;

                // Bilgilerde değişiklik olup olmadığını kontrol et
                if (mevcutAd == yeniAd && mevcutSoyad == yeniSoyad && mevcutDogumTarihi == yeniDogumTarihi &&
                    mevcutCinsiyet == yeniCinsiyet && mevcutTelNo == yeniTelNo && mevcutCalismaTipi == yeniCalismaTipi &&
                    mevcutBaslamaTarihi == yeniBaslamaTarihi)
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

                            // Antrenor tablosunu güncelle
                            string antrenorQuery = @"
    UPDATE ""kisi"".""Antrenor"" 
    SET calisma_tipi = @calisma_tipi, baslama_tarihi = @baslama_tarihi
    WHERE kisi_id = @kisi_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(antrenorQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@calisma_tipi", yeniCalismaTipi);
                                cmd.Parameters.AddWithValue("@baslama_tarihi", yeniBaslamaTarihi);
                                cmd.Parameters.AddWithValue("@kisi_id", kisiId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Antrenör başarıyla güncellendi.");

                            // DataGridView'i güncelle
                            AntrenorlerForm_Load(sender, e);
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
                MessageBox.Show("Lütfen güncellemek için bir antrenör seçin.");
            }
        }

        private void BtnAntrenorSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewAntrenorler.SelectedRows.Count > 0)
            {
                int kisiId = Convert.ToInt32(dataGridViewAntrenorler.SelectedRows[0].Cells["Kisi ID"].Value);

                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Antrenor tablosundan silme
                            string antrenorQuery = @"DELETE FROM ""kisi"".""Antrenor"" WHERE kisi_id = @kisi_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(antrenorQuery, conn))
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
                            MessageBox.Show("Antrenör başarıyla silindi.");

                            // DataGridView'i güncelle
                            AntrenorlerForm_Load(sender, e);
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
                MessageBox.Show("Lütfen silmek için bir antrenör seçin.");
            }
        }
    }
}
