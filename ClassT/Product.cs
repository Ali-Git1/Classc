using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassT
{
    public class Product
    {
        public int Id;

        public string BrandName;

        public string Model;

        public decimal Qiymet;

        public decimal Xercler;

        public decimal UmumiGelir;

        public int MehsulunSayi;


        public Product(int id,string brandname,string model,decimal qiymet,decimal xercler,decimal umumigelir,int mehsulunsayi)
        {
            Id=id;
            BrandName=brandname;
            Model=model;
            Qiymet=qiymet;
            Xercler=xercler;
            UmumiGelir = umumigelir;
            MehsulunSayi=mehsulunsayi;
           

        }


        public void GetInfo()
        {
            Console.WriteLine($"Id - {Id}");
            Console.WriteLine($"Marka Adi - {BrandName}");
            Console.WriteLine($"Model - {Model}");
            Console.WriteLine($"Qiymet - {Qiymet}");
            Console.WriteLine($"Xercler - {Xercler}");
            Console.WriteLine($"UmumiGelir - {UmumiGelir}");
            Console.WriteLine($"Say - {MehsulunSayi}");
        }


        public void Sale(int eded)
        {
            if (eded <= MehsulunSayi)
            {
                decimal satisqiymeti = Qiymet * eded;
                decimal Xerc = Xercler * eded;
                UmumiGelir += satisqiymeti - Xerc;
                MehsulunSayi -= eded;
                Console.WriteLine($"{eded} eded mehsul satildi. UmumiGelir artirildi, Mehsulun sayi azaldildi.");
            }
            else
            {
                Console.WriteLine("Kifayət qədər məhsul yoxdur!");
            }
        }
    }
}
