using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    public class Program
    {
       static void Main(string[] args)
        {

            //Vatandas vatandas1 = new Vatandas();//Bir tane vatandaş oluştur demek(instance)
            //selamver(isim:"Furkan");
            //selamver(isim:"Emre");
            //selamver(); 


            //int sonuc = topla(3,5);


            Person person= new Person();
            person.FirstName = "Furkan";
            person.LastName = "Karataş";
            person.BirthDay = 1998;
            person.NationalIdenty = 292164;




            //Generic Collection
            //List<string> sehirler = new List<string> {"Ankara","İstanbul","İzmir" };//yeni liste oluşturdum
            //sehirler.Add("Adana");//Listeye eleman ekledim
            //foreach (string s in sehirler) 
            //{
            //    Console.WriteLine(s);
            //}

            PttManager pttManager =new PttManager(new PersonManager());
            pttManager.GiveMask(person);



            Console.ReadLine();
        }

        //static void selamver(string isim="non")//fonksiyonun isminden sonra parantez içinde yazılan değerlere parametre denir.
        //{
        //    Console.WriteLine("Merhaba "+isim);
        //}

        //static int topla(int sayi1,int sayi2)
        //{
        //    int sonuc = sayi1 + sayi2;
        //    Console.WriteLine( "Toplam "+sonuc);
        //    return sonuc;
        //}

    }

    
    
}
