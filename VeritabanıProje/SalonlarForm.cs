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
    public partial class SalonlarForm : Form
    {
        public SalonlarForm()
        {
            InitializeComponent();
            dataGridViewSalonlar.CellClick += dataGridViewSalonlar_CellContentClick;
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void SalonlarForm_Load(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
        SELECT 
            s.salon_id AS ""Salon ID"",
            s.ad AS ""Salon Adı"",
            s.kapasite AS ""Kapasite"",
            i.ad AS ""İl Adı""
        FROM 
            ""Salonlar"" s
        JOIN 
            ""Iller"" i ON s.il_id = i.il_id";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSalonlar.DataSource = dt;

                // Salon ID sütununu gizle
                dataGridViewSalonlar.Columns["Salon ID"].Visible = false;

                // Iller combobox'ını doldur
                string ilQuery = "SELECT ad FROM \"Iller\"";
                NpgsqlCommand cmd = new NpgsqlCommand(ilQuery, conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxIl.Items.Add(reader["ad"].ToString());
                }
                reader.Close();
            }
        }

        private void BtnSalonAra_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxAra.Text;
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                        SELECT 
                            s.salon_id AS ""Salon ID"",
                            s.ad AS ""Salon Adı"",
                            s.kapasite AS ""Kapasite"",
                            i.ad AS ""İl Adı""
                        FROM 
                            ""Salonlar"" s
                        JOIN 
                            ""Iller"" i ON s.il_id = i.il_id
                        WHERE 
                            s.ad ILIKE @searchValue OR i.ad ILIKE @searchValue";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSalonlar.DataSource = dt;
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
                        // Salon tablosuna ekleme
                        string salonQuery = @"
                    INSERT INTO ""Salonlar"" (ad, kapasite, il_id)
                    VALUES (@ad, @kapasite, (SELECT il_id FROM ""Iller"" WHERE ad = @il_ad))";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(salonQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ad", textBoxSalonAdi.Text);
                            cmd.Parameters.AddWithValue("@kapasite", numericUpDownKapasite.Value);
                            cmd.Parameters.AddWithValue("@il_ad", comboBoxIl.Text);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Salon başarıyla eklendi.");

                        // DataGridView'i güncelle
                        SalonlarForm_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void BtnSalonGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewSalonlar.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewSalonlar.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridViewSalonlar.SelectedRows[0];
                int salonId = Convert.ToInt32(selectedRow.Cells["Salon ID"].Value);

                // Mevcut bilgileri al
                string mevcutAd = selectedRow.Cells["Salon Adı"].Value.ToString();
                int mevcutKapasite = Convert.ToInt32(selectedRow.Cells["Kapasite"].Value);
                string mevcutIl = selectedRow.Cells["İl Adı"].Value.ToString();

                // Yeni bilgileri al
                string yeniAd = textBoxSalonAdi.Text;
                int yeniKapasite = Convert.ToInt32(numericUpDownKapasite.Value);
                string yeniIl = comboBoxIl.Text;

                // Bilgilerde değişiklik olup olmadığını kontrol et
                if (mevcutAd == yeniAd && mevcutKapasite == yeniKapasite && mevcutIl == yeniIl)
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
                            // Salon tablosunu güncelle
                            string salonQuery = @"
    UPDATE ""Salonlar"" 
    SET ad = @ad, kapasite = @kapasite, il_id = (SELECT il_id FROM ""Iller"" WHERE ad = @il_ad)
    WHERE salon_id = @salon_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(salonQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@ad", yeniAd);
                                cmd.Parameters.AddWithValue("@kapasite", yeniKapasite);
                                cmd.Parameters.AddWithValue("@il_ad", yeniIl);
                                cmd.Parameters.AddWithValue("@salon_id", salonId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Salon başarıyla güncellendi.");

                            // DataGridView'i güncelle
                            SalonlarForm_Load(sender, e);
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
                MessageBox.Show("Lütfen güncellemek için bir salon seçin.");
            }
        }

        private void dataGridViewSalonlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSalonlar.Rows[e.RowIndex];
                textBoxSalonAdi.Text = row.Cells["Salon Adı"].Value.ToString();
                numericUpDownKapasite.Text = row.Cells["Kapasite"].Value.ToString();
                comboBoxIl.Text = row.Cells["İl Adı"].Value.ToString();
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
                        s.salon_id AS ""Salon ID"",
                        s.ad AS ""Salon Adı"",
                        s.kapasite AS ""Kapasite"",
                        i.ad AS ""İl Adı""
                    FROM 
                        ""Salonlar"" s
                    JOIN 
                        ""Iller"" i ON s.il_id = i.il_id
                    WHERE 
                        s.ad ILIKE @searchValue";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSalonlar.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxIl.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir il seçin.");
                return;
            }

            string selectedIl = comboBoxIl.SelectedItem.ToString();
            int salonSayisi;

            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
            SELECT COUNT(*) 
            FROM ""Salonlar"" 
            WHERE il_id = (SELECT il_id FROM ""Iller"" WHERE ad = @il_ad)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@il_ad", selectedIl);
                    salonSayisi = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            MessageBox.Show($"Seçilen il: {selectedIl} için salon sayısı: {salonSayisi}");
        }

        private void BtnSalonSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewSalonlar.SelectedRows.Count > 0)
            {
                int salonId = Convert.ToInt32(dataGridViewSalonlar.SelectedRows[0].Cells["Salon ID"].Value);

                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Salon tablosundan silme
                            string salonQuery = @"DELETE FROM ""Salonlar"" WHERE salon_id = @salon_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(salonQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@salon_id", salonId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Salon başarıyla silindi.");

                            // DataGridView'i güncelle
                            SalonlarForm_Load(sender, e);
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
                MessageBox.Show("Lütfen silmek için bir salon seçin.");
            }
        }
    }
}
