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
    public partial class GÜNCELLE : Form
    {



       public int k;
        public GÜNCELLE()
        {
            NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;User ID=postgres;password=sara1236;Database=takip;");
            NpgsqlCommand komut;
            DataTable tablo = new DataTable();
            InitializeComponent();
            baglanti.Open();
            komut = new NpgsqlCommand("select k_no from kurum", baglanti);
            NpgsqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                k_no.Items.Add(dr["k_no"]);
            }
            baglanti.Close();
            yas.SelectedIndex = 0;
            kat.SelectedIndex = 0;
            k_no.SelectedIndex = 0;
        }

        private void GÜNCELLE_Load(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;User ID=postgres;password=sara1236;Database=takip;");
            NpgsqlCommand komut;
          
            int a = 1;
            if (adi.Text.Length == 0)
                a = 0;
            if (soyad.Text.Length == 0)
                a = 0;
            if (meslek.Text.Length == 0)
                a = 0;
              if (((kadın.Checked == true && erkek.Checked == true) ||
                (kadın.Checked == false && erkek.Checked == false)))//checkBox1 de cinsiyetin sadece 1 deger olamsı için kontrolu yapar
                a = 0;

              if ((a == 0))
                  MessageBox.Show("LÜTFEN BOS ALAN BIRAKMAYIN VE CİNSİYETİNİZİ DOGRU İSARETLEDİGİNİZDEN EMİN OLUN");
              else
              {
                  baglanti.Open();
                  Form1 t=new Form1();

                  komut = new NpgsqlCommand("update  personel set ad='" + adi.Text + "',soyad='" + soyad.Text + "',meslek='" + meslek.Text + "',cinsiyet=@cinsiyet,c_kat='" + Convert.ToInt32(kat.Text) + "',yas='" + Convert.ToInt32(yas.Text) + "',k_no='" + Convert.ToInt32(k_no.Text) + "'  where per_no='" + k + "'; ", baglanti);
                  //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                 
                  if (kadın.Checked == true)
                  {
                      komut.Parameters.AddWithValue("@cinsiyet", kadın.Text);
                  }
                  else
                  {
                      komut.Parameters.AddWithValue("@cinsiyet", erkek.Text);
                  }
                  //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                  komut.ExecuteNonQuery();
                  //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.

                  baglanti.Close();
                  MessageBox.Show("Personel güncellendi");
                  
                  adi.Clear();
                  soyad.Clear();
                  meslek.Clear();
              }
        }
    }
}
