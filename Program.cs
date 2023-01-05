
List<int> sayiListesi = new List<int>();

sayiListesi.Add(10);
sayiListesi.Add(5);
sayiListesi.Add (23);
sayiListesi.Add(48);
sayiListesi.Add(7);
sayiListesi.Add (36);


List<string> renkListesi = new List<string>();

renkListesi.Add("Sarı");
renkListesi.Add("Lacivert");
renkListesi.Add("Kırmızı");
renkListesi.Add("Yeşil");
renkListesi.Add("Mor");
renkListesi.Add("Kahverengi");
renkListesi.Add("Pembe");
renkListesi.Add("Turuncyu");

//count
Console.WriteLine(sayiListesi.Count);
Console.WriteLine(renkListesi.Count);

//foreach ve List.foreach....
foreach (var item in sayiListesi)
    Console.WriteLine(item);

foreach (var item in renkListesi)
    Console.WriteLine(item);

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));


//listeden eleman çıkarma

sayiListesi.Remove(4);
renkListesi.Remove("Yeşil");

sayiListesi.RemoveAt(0);
renkListesi.RemoveAt(1);


//Liste içerisinde arama

if (sayiListesi.Contains(10))
{
    Console.WriteLine("10 liste içinde bulundu");
}

//eleman ile indexe erişme
Console.WriteLine(renkListesi.BinarySearch("mor")); 

//diziyi list'e çevirme
string[] hayvanlar= {"kedi","kopek","kus"};

List<string> hayvanlistesi = new List<string>(hayvanlar);


//listeyi temizlemek

hayvanlistesi.Clear();



//liste içerisinde nesne tutmak

List<Kullanicilar> kullanicilistesi= new List<Kullanicilar>();
Kullanicilar kullanici1 = new Kullanicilar();
kullanici1.Isim="Ayse";
kullanici1.SoyIsim="Yılaz";
kullanici1.Yas=26;


Kullanicilar kullanici2 = new Kullanicilar();
kullanici2.Isim="özcan";
kullanici2.SoyIsim="çalışkan";
kullanici2.Yas=36;

kullanicilistesi.Add(kullanici1);
kullanicilistesi.Add(kullanici2);

List<Kullanicilar> yeniliste= new List<Kullanicilar>();
yeniliste.Add(new Kullanicilar(){
    Isim="Deniz",
    SoyIsim="Arda",
    Yas=29
});



foreach (var kullanici in kullanicilistesi)
{
    
Console.WriteLine(kullanici.Isim);
Console.WriteLine(kullanici.SoyIsim);
Console.WriteLine(kullanici.Yas);
}
yeniliste.Clear();


public class Kullanicilar{

   private string name;
   private string lastName;
   private int yas;

public string Isim{get=> name; set =>name=value;}
public string SoyIsim{get=> lastName; set =>lastName=value;}
public int Yas{get=> yas; set =>yas=value;}
    
}