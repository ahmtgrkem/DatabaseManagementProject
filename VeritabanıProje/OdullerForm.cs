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
    public partial class OdullerForm : Form
    {
        public OdullerForm()
        {
            InitializeComponent();
            dataGridViewOduller.CellClick += dataGridViewOduller_CellContentClick;
        }

        private void dataGridViewOduller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewOduller.Rows[e.RowIndex];
                textBoxOdulAdi.Text = row.Cells["Ödül Adı"].Value.ToString();
                textBoxOdulMiktari.Text = row.Cells["Ödül Miktarı"].Value.ToString();
                textBoxOdulSayisi.Text = row.Cells["Ödül Sayısı"].Value.ToString();
            }
        }

        private void OdullerForm_Load(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                        SELECT 
                            odul_id AS ""Ödül ID"",
                            ad AS ""Ödül Adı"",
                            odul_miktari AS ""Ödül Miktarı"",
                            odul_sayisi AS ""Ödül Sayısı""
                        FROM 
                            ""Oduller""";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewOduller.DataSource = dt;

                // Ödül ID sütununu gizle
                dataGridViewOduller.Columns["Ödül ID"].Visible = false;
            }
        }

        private void BtnOdulEkle_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Ödül tablosuna ekleme
                        string odulQuery = @"
                    INSERT INTO ""Oduller"" (ad, odul_miktari, odul_sayisi)
                    VALUES (@ad, @odul_miktari, @odul_sayisi)";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(odulQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ad", textBoxOdulAdi.Text);
                            cmd.Parameters.AddWithValue("@odul_miktari", Convert.ToDecimal(textBoxOdulMiktari.Text));
                            cmd.Parameters.AddWithValue("@odul_sayisi", Convert.ToInt32(textBoxOdulSayisi.Text));
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Ödül başarıyla eklendi.");

                        // DataGridView'i güncelle
                        OdullerForm_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void BtnOdulGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewOduller.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewOduller.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridViewOduller.SelectedRows[0];
                int odulId = Convert.ToInt32(selectedRow.Cells["Ödül ID"].Value);

                // Mevcut bilgileri al
                string mevcutAd = selectedRow.Cells["Ödül Adı"].Value.ToString();
                decimal mevcutMiktar = Convert.ToDecimal(selectedRow.Cells["Ödül Miktarı"].Value);
                int mevcutSayisi = Convert.ToInt32(selectedRow.Cells["Ödül Sayısı"].Value);

                // Yeni bilgileri al
                string yeniAd = textBoxOdulAdi.Text;
                decimal yeniMiktar = Convert.ToDecimal(textBoxOdulMiktari.Text);
                int yeniSayisi = Convert.ToInt32(textBoxOdulSayisi.Text);

                // Bilgilerde değişiklik olup olmadığını kontrol et
                if (mevcutAd == yeniAd && mevcutMiktar == yeniMiktar && mevcutSayisi == yeniSayisi)
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
                            // Ödül tablosunu güncelle
                            string odulQuery = @"
                        UPDATE ""Oduller"" 
                        SET ad = @ad, odul_miktari = @odul_miktari, odul_sayisi = @odul_sayisi
                        WHERE odul_id = @odul_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(odulQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@ad", yeniAd);
                                cmd.Parameters.AddWithValue("@odul_miktari", yeniMiktar);
                                cmd.Parameters.AddWithValue("@odul_sayisi", yeniSayisi);
                                cmd.Parameters.AddWithValue("@odul_id", odulId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Ödül başarıyla güncellendi.");

                            // DataGridView'i güncelle
                            OdullerForm_Load(sender, e);
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
                MessageBox.Show("Lütfen güncellemek için bir ödül seçin.");
            }
        }

        private void BtnOdulSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewOduller.SelectedRows.Count > 0)
            {
                int odulId = Convert.ToInt32(dataGridViewOduller.SelectedRows[0].Cells["Ödül ID"].Value);

                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Ödül tablosundan silme
                            string odulQuery = @"DELETE FROM ""Oduller"" WHERE odul_id = @odul_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(odulQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@odul_id", odulId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Ödül başarıyla silindi.");

                            // DataGridView'i güncelle
                            OdullerForm_Load(sender, e);
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
                MessageBox.Show("Lütfen silmek için bir ödül seçin.");
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
                        odul_id AS ""Ödül ID"",
                        ad AS ""Ödül Adı"",
                        odul_miktari AS ""Ödül Miktarı"",
                        odul_sayisi AS ""Ödül Sayısı""
                    FROM 
                        ""Oduller""
                    WHERE 
                        ad ILIKE @searchValue";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewOduller.DataSource = dt;
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.FormClosed += (sender, e) => this.Close();
            form1.Show();
            return;
        }
    }
}
