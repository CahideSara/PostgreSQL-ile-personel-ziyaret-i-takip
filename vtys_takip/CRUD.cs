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
    public partial class CRUD : Form
    {
       

         NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;User ID=postgres;password=sara1236;Database=takip;");
            NpgsqlCommand komut;
            NpgsqlDataAdapter adtr;
            DataTable tablo = new DataTable();
           
           public CRUD()
        {
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            int a = 1;
            if (per_no.Text.Length == 0)
                a = 0;
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
                int kayit;
                baglanti.Open();
                komut = new NpgsqlCommand("select per_no from personel where per_no= ' "+per_no.Text +" ' ", baglanti);
                kayit = Convert.ToInt32(komut.ExecuteScalar());
                baglanti.Close();

                if (kayit !=0)
                {
                    MessageBox.Show("Girdiğiniz 'NO' da kayıtlı personel vardır");
                    per_no.Clear();
                }
               
                else
                {//eger bütün sartlar saglanmıs ise yeni personelin kaydı yapılır
                    baglanti.Open();

                     komut = new NpgsqlCommand("insert into personel(per_no,ad,soyad,meslek,cinsiyet,c_kat,yas,k_no) values (@per_no,@ad,@soyad,@meslek,@cinsiyet,@c_kat,@yas,@k_no)", baglanti);
                    //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                     komut.Parameters.AddWithValue("@per_no", Convert.ToInt32(per_no.Text));
                    komut.Parameters.AddWithValue("@ad", adi.Text);
                    komut.Parameters.AddWithValue("@soyad", soyad.Text);
                    komut.Parameters.AddWithValue("@meslek", meslek.Text);
                    komut.Parameters.AddWithValue("@c_kat", Convert.ToInt32(kat.Text));
                    komut.Parameters.AddWithValue("@yas", Convert.ToInt32(yas.Text));
                    komut.Parameters.AddWithValue("@k_no", Convert.ToInt32(k_no.Text));
                    if (kadın.Checked == true) {
                        komut.Parameters.AddWithValue("@cinsiyet", kadın.Text);
                    }
                    else {
                        komut.Parameters.AddWithValue("@cinsiyet", erkek.Text);
                    }
                    //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                    komut.ExecuteNonQuery();
                    //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                               
                    baglanti.Close();
                    MessageBox.Show("Personel Eklendi");
                    per_no.Clear();
                    adi.Clear();
                    soyad.Clear();
                    meslek.Clear();
                } 
            }
        }

        private void per_no_TextChanged(object sender, EventArgs e)
        {
            try//try catch ile texBox2 ye girilen degerin sadece integer deger olmasını saglar
            {
                if ((Convert.ToInt32(per_no.Text) > 0))
                {
                    return;
                }
            }
            catch
            {
                per_no.Clear();
            }
        }

        private void CRUD_Load(object sender, EventArgs e)
        {

        }

        private void k_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void kat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
    }
}
