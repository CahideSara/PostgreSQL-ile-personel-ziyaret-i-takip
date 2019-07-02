namespace vtys_takip
{
    partial class CRUD
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
            this.adi = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.meslek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.per_no = new System.Windows.Forms.TextBox();
            this.kadın = new System.Windows.Forms.CheckBox();
            this.erkek = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.yas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.k_no = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // adi
            // 
            this.adi.Location = new System.Drawing.Point(135, 56);
            this.adi.Multiline = true;
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(125, 25);
            this.adi.TabIndex = 0;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(436, 127);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(125, 54);
            this.ekle.TabIndex = 1;
            this.ekle.Text = "PERSONEL EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "AD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kat
            // 
            this.kat.FormattingEnabled = true;
            this.kat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.kat.Location = new System.Drawing.Point(436, 29);
            this.kat.Name = "kat";
            this.kat.Size = new System.Drawing.Size(125, 21);
            this.kat.TabIndex = 3;
            this.kat.SelectedIndexChanged += new System.EventHandler(this.kat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "SOYAD";
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(135, 87);
            this.soyad.Multiline = true;
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(125, 25);
            this.soyad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "MESLEK";
            // 
            // meslek
            // 
            this.meslek.Location = new System.Drawing.Point(135, 118);
            this.meslek.Multiline = true;
            this.meslek.Name = "meslek";
            this.meslek.Size = new System.Drawing.Size(125, 25);
            this.meslek.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "NO";
            // 
            // per_no
            // 
            this.per_no.Location = new System.Drawing.Point(135, 24);
            this.per_no.Multiline = true;
            this.per_no.Name = "per_no";
            this.per_no.Size = new System.Drawing.Size(125, 25);
            this.per_no.TabIndex = 8;
            this.per_no.TextChanged += new System.EventHandler(this.per_no_TextChanged);
            // 
            // kadın
            // 
            this.kadın.AutoSize = true;
            this.kadın.BackColor = System.Drawing.Color.Fuchsia;
            this.kadın.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kadın.Location = new System.Drawing.Point(135, 152);
            this.kadın.Name = "kadın";
            this.kadın.Size = new System.Drawing.Size(36, 20);
            this.kadın.TabIndex = 10;
            this.kadın.Text = "K";
            this.kadın.UseVisualStyleBackColor = false;
            // 
            // erkek
            // 
            this.erkek.AutoSize = true;
            this.erkek.BackColor = System.Drawing.Color.Blue;
            this.erkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.erkek.Location = new System.Drawing.Point(202, 152);
            this.erkek.Name = "erkek";
            this.erkek.Size = new System.Drawing.Size(37, 20);
            this.erkek.TabIndex = 11;
            this.erkek.Text = "E";
            this.erkek.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "CİNSİYET";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(318, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "ÇALIŞTIGI KAT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(318, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "YAŞ";
            // 
            // yas
            // 
            this.yas.FormattingEnabled = true;
            this.yas.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.yas.Location = new System.Drawing.Point(436, 56);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(125, 21);
            this.yas.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(318, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "KURUMU";
            // 
            // k_no
            // 
            this.k_no.FormattingEnabled = true;
            this.k_no.Location = new System.Drawing.Point(436, 83);
            this.k_no.Name = "k_no";
            this.k_no.Size = new System.Drawing.Size(125, 21);
            this.k_no.TabIndex = 16;
            this.k_no.SelectedIndexChanged += new System.EventHandler(this.k_no_SelectedIndexChanged);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 237);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.k_no);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.erkek);
            this.Controls.Add(this.kadın);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.per_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.meslek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.kat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.adi);
            this.Name = "CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox meslek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox per_no;
        private System.Windows.Forms.CheckBox kadın;
        private System.Windows.Forms.CheckBox erkek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox yas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox k_no;
    }
}