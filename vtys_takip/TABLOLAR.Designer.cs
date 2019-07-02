namespace vtys_takip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sil = new System.Windows.Forms.Button();
            this.tablo = new System.Windows.Forms.Button();
            this.gncl = new System.Windows.Forms.Button();
            this.per_crud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.per_no = new System.Windows.Forms.TextBox();
            this.tablolar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // sil
            // 
            this.sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.Location = new System.Drawing.Point(52, 80);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(97, 30);
            this.sil.TabIndex = 2;
            this.sil.Text = "PERSONEL SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // tablo
            // 
            this.tablo.Location = new System.Drawing.Point(251, 80);
            this.tablo.Name = "tablo";
            this.tablo.Size = new System.Drawing.Size(154, 41);
            this.tablo.TabIndex = 3;
            this.tablo.Text = "TABLOYU GÖSTER";
            this.tablo.UseVisualStyleBackColor = true;
            this.tablo.Click += new System.EventHandler(this.tablo_Click);
            // 
            // gncl
            // 
            this.gncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gncl.Location = new System.Drawing.Point(52, 116);
            this.gncl.Name = "gncl";
            this.gncl.Size = new System.Drawing.Size(97, 30);
            this.gncl.TabIndex = 5;
            this.gncl.Text = "GÜNCELLE";
            this.gncl.UseVisualStyleBackColor = true;
            this.gncl.Click += new System.EventHandler(this.gncl_Click);
            // 
            // per_crud
            // 
            this.per_crud.BackColor = System.Drawing.Color.Transparent;
            this.per_crud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.per_crud.Location = new System.Drawing.Point(500, 35);
            this.per_crud.Name = "per_crud";
            this.per_crud.Size = new System.Drawing.Size(97, 67);
            this.per_crud.TabIndex = 6;
            this.per_crud.Text = "PERSONEL  EKLE";
            this.per_crud.UseVisualStyleBackColor = false;
            this.per_crud.Click += new System.EventHandler(this.per_crud_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ZİYARETCİ NO";
            // 
            // per_no
            // 
            this.per_no.Location = new System.Drawing.Point(52, 35);
            this.per_no.Multiline = true;
            this.per_no.Name = "per_no";
            this.per_no.Size = new System.Drawing.Size(161, 24);
            this.per_no.TabIndex = 8;
            this.per_no.Text = "0";
            this.per_no.TextChanged += new System.EventHandler(this.per_no_TextChanged);
            // 
            // tablolar
            // 
            this.tablolar.FormattingEnabled = true;
            this.tablolar.Items.AddRange(new object[] {
            "personel",
            "ziyaretci",
            "kurum",
            "ziyaret_et",
            "giris_cikis",
            "log_tablo",
            "genc_personel",
            "kcalısan_sayısı",
            "ziyaretcisi_olanlar"});
            this.tablolar.Location = new System.Drawing.Point(251, 35);
            this.tablolar.Name = "tablolar";
            this.tablolar.Size = new System.Drawing.Size(154, 24);
            this.tablolar.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(622, 456);
            this.Controls.Add(this.tablolar);
            this.Controls.Add(this.per_no);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.per_crud);
            this.Controls.Add(this.gncl);
            this.Controls.Add(this.tablo);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAKİP";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button tablo;
        private System.Windows.Forms.Button gncl;
        private System.Windows.Forms.Button per_crud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox per_no;
        private System.Windows.Forms.ComboBox tablolar;
    }
}

