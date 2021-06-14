using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolefinalodev

{
    class Program
    {

        static string Menu()

        {

            Console.Clear();

            string secim;

            Console.WriteLine(" \n                *** OKAN ÜNİVERSİTESİ OTONOM PROGRAMI ***  ");

            Console.WriteLine("                 ------------------------------------ \n ");

            Console.WriteLine("                       1- Öğrenci Kayıt   ");

            Console.WriteLine("                       2- Öğrenci sil   ");

            Console.WriteLine("                       3- Öğrenci Güncelle   ");

            Console.WriteLine("                       4- personel kayıt   ");

            Console.WriteLine("                       5- personel sil  ");

            Console.WriteLine("                       6- peronel güncelle ");

            Console.WriteLine("                       7- idari personel Kayıt   ");

            Console.WriteLine("                       8- idari personel sil   ");

            Console.WriteLine("                       9- idari personel Güncelle   ");

            Console.WriteLine("                       10- öğretim görevlisi kayıt   ");

            Console.WriteLine("                       11- öğretim görevlisi sil  ");

            Console.WriteLine("                       12- öğretim görevlisi güncelle ");

            Console.WriteLine("                       13- ders Kayıt   ");

            Console.WriteLine("                       14- ders sil   ");

            Console.WriteLine("                       15- ders Güncelle   ");

            Console.WriteLine("                       16- öğrenci ders kayıt   ");

            Console.WriteLine("                       17- öğrenci ders sil  ");

            Console.WriteLine("                       18- öğrenci ders güncelle ");

            Console.WriteLine("                       19- Çıkış \n  ");



            Console.Write("                           Seçiminiz ( 1- 18 ) >>>  ");

            secim = Console.ReadLine();

            return secim;

        }

        static void Kayit()

        {

            Console.Clear();

            string adi, soyadi, sinif, ogrno,notort,dogumtarihi;

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");

            

            OleDbCommand kmt = new OleDbCommand();

            Console.WriteLine("********* Kayıt Ekranı ********** \n");

            Console.Write("Öğrenci Adı = ");

            adi = Console.ReadLine();

            Console.Write("Öğrenci Soyadı = ");

            soyadi = Console.ReadLine();

            Console.Write("Öğrenci Sınıfı = ");

            sinif = Console.ReadLine();

            Console.Write("Öğrenci No = ");

            ogrno = Console.ReadLine();

            Console.Write("Öğrenci not ortalaması = ");

            notort = Console.ReadLine();

            Console.Write("Öğrenci dogum tarihi = ");
            dogumtarihi = Console.ReadLine();



            ogrno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "INSERT INTO ogrbil(adi,soyadi,sinif,ogrno ,notort,dogumtarihi) VALUES ('" + adi + "','" + soyadi + "','" + sinif + "','" + ogrno + "','" + notort + "','" + dogumtarihi + "') ";

            ////kayıt ekleme sorgu metni

            kmt.ExecuteNonQuery();

            //sorguyu çalıştır

            kmt.Dispose();

            //Komut kullanımını kapatıyoruz

            bag.Close();

            Console.WriteLine("\nKayıt İşlemi Tamamlandı");

            Console.WriteLine("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }

        static void Sil()

        {

            Console.Clear();

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");

           

            OleDbCommand kmt = new OleDbCommand();

            string ogrno;

            Console.WriteLine("             ********* Silme Ekranı ********** \n");

            Console.Write("Silme işlemi yapılacak Öğrenci Numarasını Giriniz >>> ");

            ogrno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "Delete * from ogrbil Where ogrno='" + ogrno + "'";

            kmt.ExecuteNonQuery();

            bag.Close();

            Console.Write("\nSilme işlemi tamamlandı !");

            Console.Write("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }

        static void Guncelle()

        {

            Console.Clear();

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");

            

            OleDbCommand kmt = new OleDbCommand();

            string ogrno, adi, soyadi, sinif,notort,dogumtarihi;

            int id = 0;

            Console.WriteLine("             ********* Güncelleme Ekranı ********** \n");

            Console.Write("Güncelleme yapılacak Öğrenci Numarasını Giriniz >>> ");

            ogrno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "Select * from ogrbil Where ogrno='" + ogrno + "'";

            OleDbDataReader oku;

            oku = kmt.ExecuteReader();

            while (oku.Read())

            {

                id = Convert.ToInt32(oku[0].ToString());

                

            }

            kmt.Dispose();

            oku.Dispose();

            Console.WriteLine(" ** Güncelleme işlemi için aşağıdaki bölümlere değişiklikleri giriniz ! ** ");

            Console.Write("Adı >>> ");

            adi = Console.ReadLine();

            Console.Write("Soyadı >>> ");

            soyadi = Console.ReadLine();

            Console.Write("Sınıfı >>> ");

            sinif = Console.ReadLine();

            Console.Write("Öğrenci No >>> ");

            ogrno = Console.ReadLine();


            Console.Write("not ortalaması >>> ");

            notort = Console.ReadLine();

            Console.Write("doğum tarihi >>> ");

            dogumtarihi = Console.ReadLine();






            kmt.Connection = bag;

            kmt.CommandText = "UPDATE ogrbil SET adi='" + adi + "',,sinif='" + sinif + "',ogrno='" + ogrno + "',notort='" + notort + "',doğumtarihi='" + dogumtarihi + "' WHERE id=" + id;

            kmt.ExecuteNonQuery();

            bag.Close();

            oku.Dispose();

            Console.WriteLine("Güncelleme işlemi Tamamlandı !");

            Console.Write("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }


        static void personelkayit()

        {

            Console.Clear();

            string tcno, adi, soyadi, , doğumtarihi, departman,görevi,baslamatarihi;

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            Console.WriteLine("********* Kayıt Ekranı ********** \n");

            Console.Write("personel tc no= ");

            tcno = Console.ReadLine();

            Console.Write("personel adı = ");

            adi = Console.ReadLine();

            Console.Write("personel soyadı = ");

            soyadi = Console.ReadLine();

            Console.Write("doğum tarihi= ");

            doğumtarihi = Console.ReadLine();

            Console.Write("departman = ");

            departman = Console.ReadLine();

            Console.Write("görev = ");
            görevi = Console.ReadLine();

            Console.Write("başlama tarihi= ");

            baslamatarihi = Console.ReadLine();


            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "INSERT INTO ogrbil(adi,soyadi,sinif,ogrno ,notort,dogumtarihi) VALUES ('" + tcno + "','" + adi + "','" + soyadi+ "','" + doğumtarihi + "','" + departman + "','" + görevi+ "','" + baslamatarihi + "') ";

            ////kayıt ekleme sorgu metni

            kmt.ExecuteNonQuery();

            //sorguyu çalıştır

            kmt.Dispose();

            //Komut kullanımını kapatıyoruz

            bag.Close();

            Console.WriteLine("\nKayıt İşlemi Tamamlandı");

            Console.WriteLine("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }


        static void personelSil()

        {

            Console.Clear();

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            string ogrno;

            Console.WriteLine("             ********* Silme Ekranı ********** \n");

            Console.Write("Silme işlemi yapılacak personel tc Numarasını Giriniz >>> ");

            ogrno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "Delete * from ogrbil Where tcno='" + tcno+ "'";

            kmt.ExecuteNonQuery();

            bag.Close();

            Console.Write("\nSilme işlemi tamamlandı !");

            Console.Write("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }

        static void personelGuncelle()

        {

            Console.Clear();

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            string tcno, adi, soyadi, doğumtarihi, departman, görevi,baslamatarihi;

            int id = 0;

            Console.WriteLine("             ********* Güncelleme Ekranı ********** \n");

            Console.Write("Güncelleme yapılacakpersonel tc Numarasını Giriniz >>> ");

            tcno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "Select * from ogrbil Where ogrno='" + tcno + "'";

            OleDbDataReader oku;

            oku = kmt.ExecuteReader();

            while (oku.Read())

            {

                id = Convert.ToInt32(oku[0].ToString());



            }

            kmt.Dispose();

            oku.Dispose();

            Console.WriteLine(" ** Güncelleme işlemi için aşağıdaki bölümlere değişiklikleri giriniz ! ** ");

            Console.Write("tcno >>> ");

            tcno = Console.ReadLine();

            Console.Write("adı >>> ");

            adi = Console.ReadLine();

            Console.Write("soyadı>>> ");

            soyadi= Console.ReadLine();

            Console.Write("doğum tarihi>>> ");

            doğumtarihi= Console.ReadLine();


            Console.Write("depaertman >>> ");

            departman = Console.ReadLine();

            Console.Write("görevi>>> ");

            görevi = Console.ReadLine();

            Console.Write("başlama tarihi>>> ");

            baslamatarihi = Console.ReadLine();






            kmt.Connection = bag;

            kmt.CommandText = "UPDATE ogrbil SET tcno='" + tcno+ "',,adı='" + adi+ "',soyadı='" + soyadi+ "',doğumtarihi='" + doğumtarihi + "',departman='" + departman + "',görevi='" + görevi + "',başlamatarihi='" + baslamatarihi+ "' WHERE id=" + id;

            kmt.ExecuteNonQuery();

            bag.Close();

            oku.Dispose();

            Console.WriteLine("Güncelleme işlemi Tamamlandı !");

            Console.Write("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }

        static void ıdaripersonelKayit()

        {

            Console.Clear();

            string adi, soyadi, sinif,  tcno, dogumtarihi;

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            Console.WriteLine("********* Kayıt Ekranı ********** \n");

            Console.Write("idari p. Adı = ");

            adi = Console.ReadLine();

            Console.Write("idari p. Soyadı = ");

            soyadi = Console.ReadLine();

            Console.Write("idari p. Sınıfı = ");

            sinif = Console.ReadLine();

            Console.Write("idari p.tc No = ");

            tcno = Console.ReadLine();

            

            Console.Write("Öğrenci dogum tarihi = ");
            dogumtarihi = Console.ReadLine();



            tcno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "INSERT INTO ogrbil(adi,soyadi,sinif,ogrno ,notort,dogumtarihi) VALUES ('" + adi + "','" + soyadi + "','" + sinif + "','" + tcno + "','" + sinif + "','" + dogumtarihi + "') ";

            ////kayıt ekleme sorgu metni

            kmt.ExecuteNonQuery();

            //sorguyu çalıştır

            kmt.Dispose();

            //Komut kullanımını kapatıyoruz

            bag.Close();

            Console.WriteLine("\nKayıt İşlemi Tamamlandı");

            Console.WriteLine("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }

        static void idaripersonelSil()

        {

            Console.Clear();

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            string tcno;

            Console.WriteLine("             ********* Silme Ekranı ********** \n");

            Console.Write("Silme işlemi yapılacak i.p tc Numarasını Giriniz >>> ");

            tcno= Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "Delete * from ogrbil Where ogrno='" + tcno + "'";

            kmt.ExecuteNonQuery();

            bag.Close();

            Console.Write("\nSilme işlemi tamamlandı !");

            Console.Write("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }
        static void idaripersonelGuncelle()

        {

            Console.Clear();

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            string tcno, adi, soyadi, sinif, gorev, dogumtarihi;

            int id = 0;

            Console.WriteLine("             ********* Güncelleme Ekranı ********** \n");

            Console.Write("Güncelleme yapılacak i.p tc Numarasını Giriniz >>> ");

            tcno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "Select * from ogrbil Where ogrno='" + tcno + "'";

            OleDbDataReader oku;

            oku = kmt.ExecuteReader();

            while (oku.Read())

            {

                id = Convert.ToInt32(oku[0].ToString());



            }

            kmt.Dispose();

            oku.Dispose();

            Console.WriteLine(" ** Güncelleme işlemi için aşağıdaki bölümlere değişiklikleri giriniz ! ** ");

            Console.Write("tc>>> ");

            tcno = Console.ReadLine();

            Console.Write("ad >>> ");

            adi = Console.ReadLine();

            Console.Write("Soyad >>> ");

            soyadi = Console.ReadLine();

            Console.Write("sınıf >>> ");

            sinif = Console.ReadLine();


            Console.Write("görev>>> ");

            gorev = Console.ReadLine();

            Console.Write("doğum tarihi >>> ");

            dogumtarihi = Console.ReadLine();






            kmt.Connection = bag;

            kmt.CommandText = "UPDATE ogrbil SET adi='" + adi + "',,sinif='" + sinif + "',ogrno='" + tcno + "',notort='" + gorev + "',doğumtarihi='" + dogumtarihi + "' WHERE id=" + id;

            kmt.ExecuteNonQuery();

            bag.Close();

            oku.Dispose();

            Console.WriteLine("Güncelleme işlemi Tamamlandı !");

            Console.Write("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }

        static void öğretimgörevlisiKayit()

        {

            Console.Clear();

            string adi, soyadi,  gorev, tcno, dogumtarihi;

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            Console.WriteLine("********* Kayıt Ekranı ********** \n");

            Console.Write(" Adı = ");

            adi = Console.ReadLine();

            Console.Write(" Soyadı = ");

            soyadi = Console.ReadLine();

            Console.Write("gorev = ");

            gorev = Console.ReadLine();

            Console.Write("tc No = ");

            tcno = Console.ReadLine();

            

            Console.Write(" dogum tarihi = ");
            dogumtarihi = Console.ReadLine();



            tcno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "INSERT INTO ogrbil(adi,soyadi,tc,görev,dogumtarihi) VALUES ('" + adi + "','" + soyadi + "','" + tcno + "','" + gorev + "','" + dogumtarihi + "') ";

            ////kayıt ekleme sorgu metni

            kmt.ExecuteNonQuery();

            //sorguyu çalıştır

            kmt.Dispose();

            //Komut kullanımını kapatıyoruz

            bag.Close();

            Console.WriteLine("\nKayıt İşlemi Tamamlandı");

            Console.WriteLine("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

     
        
        }

        static void öğretimgörevlisilSil()

        {

            Console.Clear();

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            string tcno;

            Console.WriteLine("             ********* Silme Ekranı ********** \n");

            Console.Write("Silme işlemi yapılacak öğretim görevlisi tc Numarasını Giriniz >>> ");

            tcno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "Delete * from ogrbil Where tc='" + tcno+ "'";

            kmt.ExecuteNonQuery();

            bag.Close();

            Console.Write("\nSilme işlemi tamamlandı !");

            Console.Write("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }

        static void öğretimgörevlisiGuncelle()

        {

            Console.Clear();

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            string tcno, adi, soyadi, gorev, dogumtarihi;

            int id = 0;

            Console.WriteLine("             ********* Güncelleme Ekranı ********** \n");

            Console.Write("Güncelleme yapılacak öğretim görevlisi tc  Numarasını Giriniz >>> ");

            tcno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "Select * from ogrbil Where ogrno='" + tcno+ "'";

            OleDbDataReader oku;

            oku = kmt.ExecuteReader();

            while (oku.Read())

            {

                id = Convert.ToInt32(oku[0].ToString());



            }

            kmt.Dispose();

            oku.Dispose();

            Console.WriteLine(" ** Güncelleme işlemi için aşağıdaki bölümlere değişiklikleri giriniz ! ** ");

            Console.Write("Adı >>> ");

            adi = Console.ReadLine();

            Console.Write("Soyadı >>> ");

            soyadi = Console.ReadLine();

            Console.Write("tc >>> ");

            tcno = Console.ReadLine();

            Console.Write("görev >>> ");

            gorev = Console.ReadLine();


            

            Console.Write("doğum tarihi >>> ");

            dogumtarihi = Console.ReadLine();






            kmt.Connection = bag;

            kmt.CommandText = "UPDATE ogrbil SET adi='" + adi + "',,gorev='" + gorev + "',tcno='" + tcno+ "',doğumtarihi='" + dogumtarihi + "' WHERE id=" + id;

            kmt.ExecuteNonQuery();

            bag.Close();

            oku.Dispose();

            Console.WriteLine("Güncelleme işlemi Tamamlandı !");

            Console.Write("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }

        static void dersKayit()

        {

            Console.Clear();

            string adi, dersno, aciklama, ogretimgörevlisi;

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            Console.WriteLine("********* Kayıt Ekranı ********** \n");

            Console.Write(" Adı = ");

            adi = Console.ReadLine();

            Console.Write("ders no = ");

            dersno = Console.ReadLine();

            Console.Write("açıklama= ");

            aciklama = Console.ReadLine();

            Console.Write("öğretim görevlisi= ");

            ogretimgörevlisi = Console.ReadLine();



            


            dersno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "INSERT INTO ogrbil(adi,soyadi,sinif,ogrno ,notort,dogumtarihi) VALUES ('" + adi + "','" +dersno + "','" + ogretimgörevlisi + "','" + aciklama + "') ";

            ////kayıt ekleme sorgu metni

            kmt.ExecuteNonQuery();

            //sorguyu çalıştır

            kmt.Dispose();

            //Komut kullanımını kapatıyoruz

            bag.Close();

            Console.WriteLine("\nKayıt İşlemi Tamamlandı");

            Console.WriteLine("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }


        static void derslSil()

        {

            Console.Clear();

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            string dersno;

            Console.WriteLine("             ********* Silme Ekranı ********** \n");

            Console.Write("Silme işlemi yapılacak ders  Numarasını Giriniz >>> ");

            dersno= Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "Delete * from ogrbil Where tc='" + dersno + "'";

            kmt.ExecuteNonQuery();

            bag.Close();

            Console.Write("\nSilme işlemi tamamlandı !");

            Console.Write("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }

        static void dersGuncelle()

        {

            Console.Clear();

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            string dersno, adi,ogretimgörevlisi, acıklama;

            int id = 0;

            Console.WriteLine("             ********* Güncelleme Ekranı ********** \n");

            Console.Write("Güncelleme yapılacak ders Numarasını Giriniz >>> ");

            dersno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "Select * from ogrbil Where ogrno='" + dersno + "'";

            OleDbDataReader oku;

            oku = kmt.ExecuteReader();

            while (oku.Read())

            {

                id = Convert.ToInt32(oku[0].ToString());



            }

            kmt.Dispose();

            oku.Dispose();

            Console.WriteLine(" ** Güncelleme işlemi için aşağıdaki bölümlere değişiklikleri giriniz ! ** ");

            Console.Write("Adı >>> ");

            adi = Console.ReadLine();

            Console.Write("dersno >>> ");

            dersno = Console.ReadLine();

            Console.Write("aciklama>>> ");

            acıklama= Console.ReadLine();

            Console.Write("öğretim görevlisi >>> ");

            ogretimgörevlisi = Console.ReadLine();




            





            kmt.Connection = bag;

            kmt.CommandText = "UPDATE ogrbil SET adi='" + adi + "',,gorev='" + dersno+ "',tcno='" + acıklama + "',doğumtarihi='" + ogretimgörevlisi + "' WHERE id=" + id;

            kmt.ExecuteNonQuery();

            bag.Close();

            oku.Dispose();

            Console.WriteLine("Güncelleme işlemi Tamamlandı !");

            Console.Write("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

      
        
   
        
        }


        static void öğrencidersKayit()

        {

            Console.Clear();

            string ogrencino, dersno, ;

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            Console.WriteLine("********* Kayıt Ekranı ********** \n");

            Console.Write(" öğrenci no = ");

            ogrencino = Console.ReadLine();

            Console.Write("ders no = ");

            dersno = Console.ReadLine();

           




            dersno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "INSERT INTO ogrbil(adi,soyadi,sinif,ogrno ,notort,dogumtarihi) VALUES ('" + ogrencino + "','" + dersno + "') ";

            ////kayıt ekleme sorgu metni

            kmt.ExecuteNonQuery();

            //sorguyu çalıştır

            kmt.Dispose();

            //Komut kullanımını kapatıyoruz

            bag.Close();

            Console.WriteLine("\nKayıt İşlemi Tamamlandı");

            Console.WriteLine("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }



        static void öğrenciderslSil()

        {

            Console.Clear();

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            string dersno;

            Console.WriteLine("             ********* Silme Ekranı ********** \n");

            Console.Write("Silme işlemi yapılacak ders  Numarasını Giriniz >>> ");

            dersno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "Delete * from ogrbil Where tc='" + dersno + "'";

            kmt.ExecuteNonQuery();

            bag.Close();

            Console.Write("\nSilme işlemi tamamlandı !");

            Console.Write("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();

        }



        static void öğerencidersGuncelle()

        {

            Console.Clear();

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=data.accdb");



            OleDbCommand kmt = new OleDbCommand();

            string dersno, öğrencino,;

            int id = 0;

            Console.WriteLine("             ********* Güncelleme Ekranı ********** \n");

            Console.Write("Güncelleme yapılacak ders Numarasını Giriniz >>> ");

            dersno = Console.ReadLine();

            bag.Open();

            kmt.Connection = bag;

            kmt.CommandText = "Select * from ogrbil Where ogrno='" + dersno + "'";

            OleDbDataReader oku;

            oku = kmt.ExecuteReader();

            while (oku.Read())

            {

                id = Convert.ToInt32(oku[0].ToString());



            }

            kmt.Dispose();

            oku.Dispose();

            Console.WriteLine(" ** Güncelleme işlemi için aşağıdaki bölümlere değişiklikleri giriniz ! ** ");

            Console.Write("öğrenci no >>> ");

            öğrencino = Console.ReadLine();

            Console.Write("dersno >>> ");

            dersno = Console.ReadLine();

            






            kmt.Connection = bag;

            kmt.CommandText = "UPDATE ogrbil SET öğrencino='" + öğrencino + "',,dersno='" + dersno + "' WHERE id=" + id;

            kmt.ExecuteNonQuery();

            bag.Close();

            oku.Dispose();

            Console.WriteLine("Güncelleme işlemi Tamamlandı !");

            Console.Write("\nDevam etmek için bir tuşa basınız !");

            Console.ReadKey();





        }

    }

    static void Main(string[] args)

    {

        string secim = "";

        do

        {

            secim = menu();

            if (secim == "1")

            {

                kayit();

            }

            else if (secim == "2")

            {

                öğrencisil();

            }

            else if (secim == "3")

            {

                Guncelle();

            }

            else if (secim == "4")

            {

                personelkayıt();

            }

            else if (secim == "5")

            {

                personelSil();

            }

            else if (secim == "6")

            {
                personelgüncelle();





            }
            else if (secim == "7")

            {

                idaripersonelkayıt();

            }

            else if (secim == "8")

            {

                idaripersonelsil();

            }

            else if (secim == "9")

            {

                idaripersonelgüncelle();

            }

            else if (secim == "10")

            {

                öğretimgörevlisikayıt();

            }

            else if (secim == "11")

            {
                öğretimgörevlsisil();
            }

            else if (secim == "12")

            {

               öğretimgörevlisigüncelle ();

            }

            else if (secim == "13")

            {

                derskayıt();

            }

            else if (secim == "14")

            {

                dessil();

            }

            else if (secim == "15")

            {

               dersgüncelle();

            }

            else if (secim == "16")

            {
                öğrenciderskayıt();
            }

            else if (secim == "17")

            {
                öğrenciderssil();
            }

            else if (secim == "18")

            {
                öğrencidersgüncelle();

            }

            else if (secim == "19")

            {









                break;

            }

            else

            {

                Console.Write("Geçersiz Seçim Yaptınız");

                Console.Write("\nDevam etmek için bir tuşa basınız !");

                Console.ReadKey();

            }

            } while (true);

    }

}
 

    
    
    
    
    
    
    
    

