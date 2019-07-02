using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;


namespace vtys_takip
{
    public partial class Form1 : Form
    {

       public int no;
        public Form1()
        {
            InitializeComponent();
            tablolar.SelectedIndex = 0;
          
        }
        public void tabloyap(string tablo_ad)
        {
            NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;User ID=postgres;password=sara1236;Database=takip;");
            NpgsqlCommand komut;
            NpgsqlDataAdapter adtr;
            DataTable tablo = new DataTable();

            baglanti.Open();

            komut = new NpgsqlCommand("select * from " + tablo_ad + " ", baglanti);
            adtr = new NpgsqlDataAdapter(komut);
            adtr.Fill(tablo);

            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;User ID=postgres;password=sara1236;Database=takip;");
            NpgsqlCommand komut;
            DataTable tablo = new DataTable();
            int kayit=0;
            baglanti.Open();
            komut = new NpgsqlCommand("select per_no from personel where per_no= ' " + per_no.Text + " ' ", baglanti);
            kayit = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            if (kayit == 0)
            {
                MessageBox.Show("Girdiğiniz 'NO' da kayıtlı personel yoktur");
                per_no.Clear();
            }
           

            else { 

            baglanti.Open();
            komut = new NpgsqlCommand("delete  from  personel p   where p.per_no='" + Convert.ToInt32(per_no.Text) + "' ; ", baglanti);
            
            komut.ExecuteNonQuery();

                MessageBox.Show("personel Silindi");
                string ad = "personel";
                tabloyap(ad);
                per_no.Clear();
                baglanti.Close();
                  }
        }

        private void tablo_Click(object sender, EventArgs e)
        {

            tabloyap(tablolar.Text);
        }

    

        private void gncl_Click(object sender, EventArgs e)
        {

             NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;User ID=postgres;password=sara1236;Database=takip;");
            NpgsqlCommand komut;
            DataTable tablo = new DataTable();
            int kayit=0;
            baglanti.Open();
            komut = new NpgsqlCommand("select per_no from personel where per_no= ' " + per_no.Text + " ' ", baglanti);
            kayit = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            this.no = kayit;
            if (kayit == 0)
            {
                MessageBox.Show("Girdiğiniz 'NO' da kayıtlı personel yoktur");
                per_no.Clear();
            }


            else
            {
                GÜNCELLE göster = new GÜNCELLE();
                göster.k = Convert.ToInt32(per_no.Text);
                göster.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void per_crud_Click(object sender, EventArgs e)
        {
            CRUD göster = new CRUD();
            
            göster.Show();
        }

        private void per_no_TextChanged(object sender, EventArgs e)
        {
             try
            {
                if ((Convert.ToInt32(per_no.Text) > 0))
                {return;}

              }
            catch
            {
                per_no.Clear();
                }
        }
      
        }
    }

