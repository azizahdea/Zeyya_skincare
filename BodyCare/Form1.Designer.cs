namespace BodyCare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewImageColumn();
            t_seacrh = new TextBox();
            btn_select = new Button();
            gambar_box = new PictureBox();
            label7 = new Label();
            label4 = new Label();
            stock = new TextBox();
            label8 = new Label();
            harga = new TextBox();
            label5 = new Label();
            label6 = new Label();
            deskripsi = new TextBox();
            kategori = new TextBox();
            label20 = new Label();
            label3 = new Label();
            nama_produk = new TextBox();
            id_barang = new TextBox();
            btn_delete = new Button();
            btn_clear = new Button();
            btn_update = new Button();
            btn_tambah = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gambar_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(413, 107);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1161, 760);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 64;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Nama Produk";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 144;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Kategori";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 114;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Deskripsi";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Harga";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 96;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Stock";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 91;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Gambar";
            Column7.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Resizable = DataGridViewTriState.True;
            Column7.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // t_seacrh
            // 
            t_seacrh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            t_seacrh.Location = new Point(1159, 30);
            t_seacrh.Margin = new Padding(4, 3, 4, 3);
            t_seacrh.Multiline = true;
            t_seacrh.Name = "t_seacrh";
            t_seacrh.Size = new Size(415, 47);
            t_seacrh.TabIndex = 3;
            t_seacrh.TextChanged += textBox7_TextChanged;
            // 
            // btn_select
            // 
            btn_select.Location = new Point(34, 804);
            btn_select.Margin = new Padding(4, 3, 4, 3);
            btn_select.Name = "btn_select";
            btn_select.Size = new Size(173, 37);
            btn_select.TabIndex = 25;
            btn_select.Text = "Select Image";
            btn_select.UseVisualStyleBackColor = true;
            btn_select.Click += btn_select_Click;
            // 
            // gambar_box
            // 
            gambar_box.BackColor = Color.White;
            gambar_box.Location = new Point(34, 635);
            gambar_box.Margin = new Padding(4, 3, 4, 3);
            gambar_box.Name = "gambar_box";
            gambar_box.Size = new Size(173, 163);
            gambar_box.SizeMode = PictureBoxSizeMode.StretchImage;
            gambar_box.TabIndex = 24;
            gambar_box.TabStop = false;
            gambar_box.Click += pictureBox2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(34, 597);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(109, 35);
            label7.TabIndex = 23;
            label7.Text = "Gambar";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(34, 502);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 35);
            label4.TabIndex = 21;
            label4.Text = "Stock";
            // 
            // stock
            // 
            stock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            stock.ForeColor = Color.Black;
            stock.Location = new Point(34, 540);
            stock.Margin = new Padding(4, 3, 4, 3);
            stock.Multiline = true;
            stock.Name = "stock";
            stock.Size = new Size(313, 46);
            stock.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(34, 410);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 35);
            label8.TabIndex = 15;
            label8.Text = "Harga";
            // 
            // harga
            // 
            harga.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            harga.ForeColor = Color.Black;
            harga.Location = new Point(34, 450);
            harga.Margin = new Padding(4, 3, 4, 3);
            harga.Multiline = true;
            harga.Name = "harga";
            harga.Size = new Size(313, 46);
            harga.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(34, 270);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 35);
            label5.TabIndex = 12;
            label5.Text = "Deskripsi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(34, 184);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 35);
            label6.TabIndex = 11;
            label6.Text = "Category";
            // 
            // deskripsi
            // 
            deskripsi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            deskripsi.Location = new Point(34, 308);
            deskripsi.Margin = new Padding(4, 3, 4, 3);
            deskripsi.Multiline = true;
            deskripsi.Name = "deskripsi";
            deskripsi.Size = new Size(313, 98);
            deskripsi.TabIndex = 10;
            // 
            // kategori
            // 
            kategori.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            kategori.Location = new Point(34, 222);
            kategori.Margin = new Padding(4, 3, 4, 3);
            kategori.Multiline = true;
            kategori.Name = "kategori";
            kategori.Size = new Size(313, 46);
            kategori.TabIndex = 9;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(34, 90);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(173, 35);
            label20.TabIndex = 8;
            label20.Text = "Nama Produk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(34, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 35);
            label3.TabIndex = 7;
            label3.Text = "ID";
            // 
            // nama_produk
            // 
            nama_produk.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            nama_produk.Location = new Point(34, 130);
            nama_produk.Margin = new Padding(4, 3, 4, 3);
            nama_produk.Multiline = true;
            nama_produk.Name = "nama_produk";
            nama_produk.Size = new Size(313, 46);
            nama_produk.TabIndex = 2;
            // 
            // id_barang
            // 
            id_barang.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            id_barang.Location = new Point(34, 39);
            id_barang.Margin = new Padding(4, 3, 4, 3);
            id_barang.Multiline = true;
            id_barang.Name = "id_barang";
            id_barang.Size = new Size(313, 46);
            id_barang.TabIndex = 1;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.Control;
            btn_delete.BackgroundImage = (Image)resources.GetObject("btn_delete.BackgroundImage");
            btn_delete.BackgroundImageLayout = ImageLayout.Stretch;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.Transparent;
            btn_delete.Location = new Point(742, 892);
            btn_delete.Margin = new Padding(4, 3, 4, 3);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(124, 56);
            btn_delete.TabIndex = 19;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += button4_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.Control;
            btn_clear.BackgroundImage = (Image)resources.GetObject("btn_clear.BackgroundImage");
            btn_clear.BackgroundImageLayout = ImageLayout.Stretch;
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.ForeColor = Color.Transparent;
            btn_clear.Location = new Point(908, 892);
            btn_clear.Margin = new Padding(4, 3, 4, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(124, 56);
            btn_clear.TabIndex = 18;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.Control;
            btn_update.BackgroundImage = (Image)resources.GetObject("btn_update.BackgroundImage");
            btn_update.BackgroundImageLayout = ImageLayout.Stretch;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.ForeColor = Color.Transparent;
            btn_update.Location = new Point(580, 892);
            btn_update.Margin = new Padding(4, 3, 4, 3);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(124, 56);
            btn_update.TabIndex = 17;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_tambah
            // 
            btn_tambah.BackColor = SystemColors.Control;
            btn_tambah.BackgroundImage = (Image)resources.GetObject("btn_tambah.BackgroundImage");
            btn_tambah.BackgroundImageLayout = ImageLayout.Stretch;
            btn_tambah.FlatAppearance.BorderSize = 0;
            btn_tambah.FlatStyle = FlatStyle.Flat;
            btn_tambah.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tambah.ForeColor = Color.Transparent;
            btn_tambah.Location = new Point(414, 892);
            btn_tambah.Margin = new Padding(4, 3, 4, 3);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(124, 56);
            btn_tambah.TabIndex = 16;
            btn_tambah.Text = "Tambah";
            btn_tambah.UseVisualStyleBackColor = false;
            btn_tambah.Click += btn_tambah_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1099, 30);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 100, 183);
            panel1.Controls.Add(btn_select);
            panel1.Controls.Add(gambar_box);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(stock);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(harga);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(deskripsi);
            panel1.Controls.Add(kategori);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(nama_produk);
            panel1.Controls.Add(id_barang);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 107);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 854);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(t_seacrh);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1604, 107);
            panel2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 15);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(349, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1067, 339);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(554, 622);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1604, 961);
            Controls.Add(panel1);
            Controls.Add(btn_clear);
            Controls.Add(btn_delete);
            Controls.Add(btn_tambah);
            Controls.Add(btn_update);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gambar_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox t_seacrh;
        private Button btn_delete;
        private Button btn_clear;
        private Button btn_update;
        private Button btn_tambah;
        private Label label8;
        private TextBox harga;
        private Label label5;
        private Label label6;
        private TextBox deskripsi;
        private TextBox kategori;
        private Label label20;
        private Label label3;
        private TextBox nama_produk;
        private TextBox id_barang;
        private Label label4;
        private TextBox stock;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox gambar_box;
        private Button btn_select;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn Column7;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}