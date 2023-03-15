using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace BodyCare
{
    public partial class Form1 : Form
    {

        // koneksi ke database
        MySqlConnection koneksi = Koneksi.getConnection();
        DataTable dataTable = new DataTable();

        //Tampilan MySql
        public DataTable getDataTable()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM body_care", koneksi))
            {
                koneksi.Open();

                MySqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        // mengambil data tabe
        public void filldataTable()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowTemplate.Height = 170;
            dataGridView1.DataSource = getDataTable();
            Column1.DataPropertyName = "id";
            Column2.DataPropertyName = "nama_produk";
            Column3.DataPropertyName = "kategori";
            Column4.DataPropertyName = "deskripsi";
            Column5.DataPropertyName = "harga";
            Column6.DataPropertyName = "stock";
            Column7.DataPropertyName = "gambar";

        }

        // fungsi menghapus isi field
        public void clear()
        {
            id_barang.Clear();
            nama_produk.Clear();
            kategori.Clear();
            deskripsi.Clear();
            harga.Clear();
            stock.Clear();
            gambar_box.Image = null;
        }

        // mengurutkan id
        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id :=0; Update body_care SET id = @id := (@id+1); " + "ALTER TABLE body_care AUTO_INCREMENT = 1;");
            script.Execute();
        }

        // fungsi mencari data
        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM body_care WHERE CONCAT (id, nama_produk, kategori, deskripsi, harga, stock) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            searchData(t_seacrh.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // mengambil data dari grid view dan memasukannya ke dalam form
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // menambah data
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            // mengecek apakah ada field yang kosong
            if ((nama_produk.Text == string.Empty || deskripsi.Text == string.Empty || kategori.Text == string.Empty || harga.Text == string.Empty || stock.Text == string.Empty))
            {
                MessageBox.Show("Tolong Isi Semua Field!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlCommand cmd;
                // error handling jika data tidak masuk
                try
                {
                    // Convert image to byte array
                    byte[] imageData;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        gambar_box.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }
                    resetIncrement();
                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "INSERT INTO body_care(nama_produk, kategori, deskripsi, harga, stock, gambar) VALUE(@nama_produk, @kategori, @deskripsi, @harga, @stock, @gambar)";
                    cmd.Parameters.AddWithValue("@nama_produk", nama_produk.Text);
                    cmd.Parameters.AddWithValue("@kategori", kategori.Text);
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text);
                    cmd.Parameters.AddWithValue("@harga", harga.Text);
                    cmd.Parameters.AddWithValue("@stock", stock.Text);
                    cmd.Parameters.AddWithValue("@gambar", imageData);
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    filldataTable();
                    clear();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat memasukkan data: " + ex.Message);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        // membersihkan field
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        // mengupdate data
        private void btn_update_Click(object sender, EventArgs e)
        {
            // mengecek apakah ada field yang kosong
            if ((nama_produk.Text == string.Empty || deskripsi.Text == string.Empty || kategori.Text == string.Empty || harga.Text == string.Empty || stock.Text == string.Empty))
            {
                MessageBox.Show("Tolong Isi Semua Field!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MySqlCommand cmd;
                // error handling jika data tidak masuk
                try
                {
                    // Convert image to byte array
                    byte[] imageData;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        gambar_box.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }
                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "UPDATE body_care SET nama_produk = @nama_produk, kategori = @kategori, deskripsi = @deskripsi, harga = @harga, stock = @stock ,gambar = @gambar WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id_barang.Text);
                    cmd.Parameters.AddWithValue("@nama_produk", nama_produk.Text);
                    cmd.Parameters.AddWithValue("@kategori", kategori.Text);
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi.Text);
                    cmd.Parameters.AddWithValue("@harga", harga.Text);
                    cmd.Parameters.AddWithValue("@stock", stock.Text);
                    cmd.Parameters.AddWithValue("@gambar", imageData);
                    cmd.ExecuteNonQuery();

                    clear();
                    koneksi.Close();
                    filldataTable();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat memasukkan data: " + ex.Message);
                }

            }
        }

        // menghapus data
        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());

            MySqlCommand cmd;

            try
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "DELETE from body_care WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", id_barang.Text);
                cmd.ExecuteNonQuery();

                resetIncrement();
                clear();
                koneksi.Close();
                dataTable.Clear();
                filldataTable();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Data Gagal Dihapus = " + ex);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                gambar_box.Image = new Bitmap(openfd.FileName);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
            id_barang.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            nama_produk.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            kategori.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            deskripsi.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            harga.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
            stock.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();
            // retrieve the BLOB image data for the clicked row and create an Image object
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(img);
            gambar_box.Image = Image.FromStream(ms);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}