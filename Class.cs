// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//1- CLASS KONUSU
///1.ADIM
int [] ogrno = {100,200,300}; //int dizisi tanımlarız.
string[] ad = {"Onur", "Duygu"}; // string dizisi tanımlarız.
string[] sube = {"10A", "10B" , "10C"}; 

//Console.WriteLine($"no: {ogrno[0]}");

//ŞİMDİ İSE NESNE TÜRETİRİZ.
///3.ADIM
    Ogrenci ogr1 = new Ogrenci(); //Yani burada; Öğrenci sınıfından ogr1 adında nesne üretmiş oluruz.
    ogr1.ogrno = 100;
    ogr1.ad = "Onur";
    ogr1.sube = "10A";

    Console.WriteLine($"no: {ogr1.ogrno} ad:{ogr1.ad}");


///2.ADIM
class Ogrenci //CLASS OLUŞTURURUZ, AŞAĞI KISIMA DA PROPERTYLERİ YAZARIZ.
{
    public int ogrno { get; set; }
    
    public string ad { get; set; }
    
    public string sube { get; set; }


}


