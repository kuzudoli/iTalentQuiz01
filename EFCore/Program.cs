using EFCore.Models;
using EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            DBContext _context = new();

            ////Fakulte üzerinden fakulte, bolum, öğrenci ve kulup ekleniyor
            //var fakulte = new Fakulte() { Name = "Mühendislik Fakültesi" };
            //fakulte.Rektor = new() { Name = "Fatih Çakıroğlu" };
            //fakulte.Bolumler = new()
            //{
            //    new()
            //    {
            //        Name = "Bilgisayar Mühendisliği",
            //        Ogrenciler = new()
            //        {
            //            new()
            //            {
            //                Name = "Enes Cakir",
            //                Kulupler = new()
            //                {
            //                    new()
            //                    {
            //                        Name = ".NET Kulubu"
            //                    }
            //                }
            //            }
            //        }
            //    },
            //    new()
            //    {
            //        Name = "Elektrik-Elektronik Mühendisliği",
            //        Ogrenciler = new()
            //        {
            //            new()
            //            {
            //                Name = "Ahmet Taylan",
            //                Kulupler = new()
            //                {
            //                    new()
            //                    {
            //                        Name = ".Arduino Kulubu"
            //                    }
            //                }
            //            }
            //        }
            //    }
            //};
            //_context.Fakulteler.Add(fakulte);
            //_context.SaveChanges();


            ////Kulube yeni öğrenci ekleniyor
            //var kulup = _context.Kulupler.Find(1);
            //var ogrenci = new Ogrenci() { Name = "Ahmet Yilmaz", BolumId = 1 };
            //kulup.Ogrenciler.Add(ogrenci);
            //_context.SaveChanges();


            ////Öğrenci üzerinden yeni kulup oluşturuluyor
            //var updateOgrenci = _context.Ogrenciler.Find(1);
            //updateOgrenci.Kulupler.Add(new() { Name = "Drone Kulubu" });
            //_context.SaveChanges();


            //Öğrenci Join ile okunuyor
            //var ilkOgrenci = _context.Ogrenciler.Include(o => o.Bolum).ThenInclude(b => b.Fakulte).Include(o => o.Kulupler).First();
            //Console.WriteLine($"\nAd Soyad: {ilkOgrenci.Name}\nFakulte: {ilkOgrenci.Bolum.Fakulte.Name}\nBolum: {ilkOgrenci.Bolum.Name}");


            //Öğrenci siliniyor
            //var silinecekOgrenci = _context.Ogrenciler.First();
            //_context.Remove(silinecekOgrenci);
            //if(_context.SaveChanges()>0)
            //    Console.WriteLine("Başarıyla silindi!");
        }
    }
}
