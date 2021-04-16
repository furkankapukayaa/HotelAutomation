using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurkanHotel
{
    public partial class odaListesi : Form
    {
        public odaListesi()
        {
            InitializeComponent();
        }

        private void geriDon_Click(object sender, EventArgs e)
        {
            anaMenu anaMenu = new anaMenu();
            anaMenu.Show();
            this.Close();
        }

        private void odalar_Load(object sender, EventArgs e)
        {
            this.tblOdaTableAdapter.Fill(this.oDALAR.tblOda);
            DataGridViewTasarım(dataGridView1);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value.ToString() == "Dolu")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value.ToString() == "Boş")
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value.ToString() == "Kirli")
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value.ToString() == "Temiz")
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        public void DataGridViewTasarım(DataGridView DataGridViewAdi)
        {
            DataGridViewAdi.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei", 12, FontStyle.Bold);
            DataGridViewAdi.DefaultCellStyle.Font = new System.Drawing.Font("Poppins", 10);
            DataGridViewAdi.EnableHeadersVisualStyles = false;
            DataGridViewAdi.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            DataGridViewAdi.ClearSelection();
        }

        private void odaBosalt_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            SqlConnection baglanti = new SqlConnection("Data Source=FURKAN;Initial Catalog=dbFurkanOtel;Integrated Security=True");
            komut = new SqlCommand("Update tblOda Set odadurum=@durum Where odaad=@ad", baglanti);
            komut.Parameters.AddWithValue("@ad", dataGridView1.SelectedCells[1].Value.ToString());
            komut.Parameters.AddWithValue("@durum", "Kirli");
            if ((baglanti.State == ConnectionState.Closed))
            {
                baglanti.Open();

            }
            komut.ExecuteNonQuery();
            baglanti.Close();
            odalar_Load(sender, e);
        }

        private void odaTemizle_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            SqlConnection baglanti = new SqlConnection("Data Source=FURKAN;Initial Catalog=dbFurkanOtel;Integrated Security=True");
            komut = new SqlCommand("Update tblOda Set odadurum=@durum Where odaad=@ad", baglanti);
            komut.Parameters.AddWithValue("@ad", dataGridView1.SelectedCells[1].Value.ToString());
            komut.Parameters.AddWithValue("@durum", "Temiz");
            if ((baglanti.State == ConnectionState.Closed))
            {
                baglanti.Open();

            }
            komut.ExecuteNonQuery();
            baglanti.Close();
            odalar_Load(sender, e);
        }

        private void odaHazır_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            SqlConnection baglanti = new SqlConnection("Data Source=FURKAN;Initial Catalog=dbFurkanOtel;Integrated Security=True");
            komut = new SqlCommand("Update tblOda Set odadurum=@durum Where odaad=@ad", baglanti);
            komut.Parameters.AddWithValue("@ad", dataGridView1.SelectedCells[1].Value.ToString());
            komut.Parameters.AddWithValue("@durum", "Boş");
            if ((baglanti.State == ConnectionState.Closed))
            {
                baglanti.Open();

            }
            komut.ExecuteNonQuery();
            baglanti.Close();
            odalar_Load(sender, e);
        }
    }
}
