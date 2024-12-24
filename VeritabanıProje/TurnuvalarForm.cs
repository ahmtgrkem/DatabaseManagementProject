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
    public partial class TurnuvalarForm : Form
    {
        public TurnuvalarForm()
        {
            InitializeComponent();
            dataGridViewTurnuvalar.CellClick += dataGridViewTurnuvalar_CellContentClick;
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void TurnuvalarForm_Load(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                        SELECT 
                            t.turnuva_id AS ""Turnuva ID"",
                            t.ad AS ""Turnuva Adı"",
                            t.tarih AS ""Tarih"",
                            b.ad AS ""Branş Adı"",
                            o.ad AS ""Ödül Adı"",
                            i.ad AS ""İl Adı""
                        FROM 
                            ""Turnuvalar"" t
                        JOIN 
                            ""Branslar"" b ON t.brans_id = b.brans_id
                        JOIN 
                            ""Oduller"" o ON t.odul_id = o.odul_id
                        JOIN 
                            ""Iller"" i ON t.il_id = i.il_id";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewTurnuvalar.DataSource = dt;

                // Branş combobox'ını doldur
                string bransQuery = "SELECT ad FROM \"Branslar\"";
                NpgsqlCommand cmdBrans = new NpgsqlCommand(bransQuery, conn);
                NpgsqlDataReader readerBrans = cmdBrans.ExecuteReader();
                while (readerBrans.Read())
                {
                    comboBoxBrans.Items.Add(readerBrans["ad"].ToString());
                }
                readerBrans.Close();

                // İl combobox'ını doldur
                string ilQuery = "SELECT ad FROM \"Iller\"";
                NpgsqlCommand cmdIl = new NpgsqlCommand(ilQuery, conn);
                NpgsqlDataReader readerIl = cmdIl.ExecuteReader();
                while (readerIl.Read())
                {
                    comboBoxIl.Items.Add(readerIl["ad"].ToString());
                }
                readerIl.Close();

                // Ödül combobox'ını doldur
                string odulQuery = "SELECT ad FROM \"Oduller\"";
                NpgsqlCommand cmdOdul = new NpgsqlCommand(odulQuery, conn);
                NpgsqlDataReader readerOdul = cmdOdul.ExecuteReader();
                while (readerOdul.Read())
                {
                    comboBoxOdul.Items.Add(readerOdul["ad"].ToString());
                }
                readerOdul.Close();
            }
        }

        private void dataGridViewTurnuvalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewTurnuvalar.Rows[e.RowIndex];
                textBoxTurnuvaAdi.Text = row.Cells["Turnuva Adı"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Tarih"].Value);
                comboBoxBrans.Text = row.Cells["Branş Adı"].Value.ToString();
                comboBoxOdul.Text = row.Cells["Ödül Adı"].Value.ToString(); // Ödül bilgilerini ekledik
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
                        t.turnuva_id AS ""Turnuva ID"",
                        t.ad AS ""Turnuva Adı"",
                        t.tarih AS ""Tarih"",
                        b.ad AS ""Branş Adı"",
                        o.ad AS ""Ödül Adı"",
                        i.ad AS ""İl Adı""
                    FROM 
                        ""Turnuvalar"" t
                    JOIN 
                        ""Branslar"" b ON t.brans_id = b.brans_id
                    JOIN 
                        ""Oduller"" o ON t.odul_id = o.odul_id
                    JOIN 
                        ""Iller"" i ON t.il_id = i.il_id
                    WHERE 
                        t.ad ILIKE @searchValue";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewTurnuvalar.DataSource = dt;
            }
        }

        private void BtnTurnuvaEkle_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Turnuva tablosuna ekleme
                        string turnuvaQuery = @"
                    INSERT INTO ""Turnuvalar"" (ad, tarih, brans_id, odul_id, il_id)
                    VALUES (@ad, @tarih, (SELECT brans_id FROM ""Branslar"" WHERE ad = @brans_ad), 
                            (SELECT odul_id FROM ""Oduller"" WHERE ad = @odul_ad), 
                            (SELECT il_id FROM ""Iller"" WHERE ad = @il_ad))";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(turnuvaQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ad", textBoxTurnuvaAdi.Text);
                            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@brans_ad", comboBoxBrans.Text);
                            cmd.Parameters.AddWithValue("@odul_ad", comboBoxOdul.Text); // Ödül bilgilerini ekledik
                            cmd.Parameters.AddWithValue("@il_ad", comboBoxIl.Text);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Turnuva başarıyla eklendi.");

                        // DataGridView'i güncelle
                        TurnuvalarForm_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void BtnTurnuvaGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewTurnuvalar.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewTurnuvalar.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridViewTurnuvalar.SelectedRows[0];
                int turnuvaId = Convert.ToInt32(selectedRow.Cells["Turnuva ID"].Value);

                // Mevcut bilgileri al
                string mevcutAd = selectedRow.Cells["Turnuva Adı"].Value.ToString();
                DateTime mevcutTarih = Convert.ToDateTime(selectedRow.Cells["Tarih"].Value);
                string mevcutBrans = selectedRow.Cells["Branş Adı"].Value.ToString();
                string mevcutOdul = selectedRow.Cells["Ödül Adı"].Value.ToString();
                string mevcutIl = selectedRow.Cells["İl Adı"].Value.ToString();

                // Yeni bilgileri al
                string yeniAd = textBoxTurnuvaAdi.Text;
                DateTime yeniTarih = dateTimePicker1.Value;
                string yeniBrans = comboBoxBrans.Text;
                string yeniOdul = comboBoxOdul.Text;
                string yeniIl = comboBoxIl.Text;

                // Bilgilerde değişiklik olup olmadığını kontrol et
                if (mevcutAd == yeniAd && mevcutTarih == yeniTarih && mevcutBrans == yeniBrans &&
                    mevcutOdul == yeniOdul && mevcutIl == yeniIl)
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
                            // Turnuva tablosunu güncelle
                            string turnuvaQuery = @"
                        UPDATE ""Turnuvalar"" 
                        SET ad = @ad, tarih = @tarih, 
                            brans_id = (SELECT brans_id FROM ""Branslar"" WHERE ad = @brans_ad), 
                            odul_id = (SELECT odul_id FROM ""Oduller"" WHERE ad = @odul_ad), 
                            il_id = (SELECT il_id FROM ""Iller"" WHERE ad = @il_ad)
                        WHERE turnuva_id = @turnuva_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(turnuvaQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@ad", yeniAd);
                                cmd.Parameters.AddWithValue("@tarih", yeniTarih);
                                cmd.Parameters.AddWithValue("@brans_ad", yeniBrans);
                                cmd.Parameters.AddWithValue("@odul_ad", yeniOdul);
                                cmd.Parameters.AddWithValue("@il_ad", yeniIl);
                                cmd.Parameters.AddWithValue("@turnuva_id", turnuvaId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Turnuva başarıyla güncellendi.");

                            // DataGridView'i güncelle
                            TurnuvalarForm_Load(sender, e);
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
                MessageBox.Show("Lütfen güncellemek için bir turnuva seçin.");
            }
        }

        private void BtnTurnuvaSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewTurnuvalar.SelectedRows.Count > 0)
            {
                int turnuvaId = Convert.ToInt32(dataGridViewTurnuvalar.SelectedRows[0].Cells["Turnuva ID"].Value);

                string connString = "Server=localhost;Port=5432;User Id=postgres;Password=ahmet123;Database=TestVeritabani;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Turnuva tablosundan silme
                            string turnuvaQuery = @"DELETE FROM ""Turnuvalar"" WHERE turnuva_id = @turnuva_id";
                            using (NpgsqlCommand cmd = new NpgsqlCommand(turnuvaQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@turnuva_id", turnuvaId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Turnuva başarıyla silindi.");

                            // DataGridView'i güncelle
                            TurnuvalarForm_Load(sender, e);
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
                MessageBox.Show("Lütfen silmek için bir turnuva seçin.");
            }
        }
    }
}
