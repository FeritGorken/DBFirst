using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            NORTHWNDEntities db = new NORTHWNDEntities();
            //ilk orderla sonra productname göre orderla
            //var result = db.Products.OrderBy(x => x.CategoryID).ThenBy(x=>x.ProductName).Select(x => new
            //{
            //    Id = x.CategoryID,
            //    Name = x.ProductName
            //});
            //***********************************************************************************************************************************
            //ilk 5 i bırak sonraki 5 i al bas
            //var result = db.Products.OrderBy(x => x.CategoryID).Skip(5).Take(5).Select(x => new
            //{
            //    Id = x.CategoryID,
            //    Name = x.ProductName
            //});            ConsoleTable.From(result).Write();
            //***********************************************************************************************************************************
            //bütün dataların price büyükse true doner 1 tane bile düşükse false döner
            //var result = db.Products.All(x => x.UnitPrice > 0); //true 
            //var result = db.Products.All(x => x.UnitPrice > 1000); //false 
            //***********************************************************************************************************************************
            //herhangi bir kayıt şartı sağlarsa true sağlamazsa false
            //var result = db.Products.Any(x => x.UnitPrice > 0); //true
            //var result = db.Products.Any(x => x.UnitPrice > 10000); //false
            //***********************************************************************************************************************************
            //category id si 1 olanı getir aynı değere ait 1 den fazla değer varsa hata verir sadece 1 sonuc getirir
            //var result = db.Products.Single(x => x.CategoryID == 1);
            //***********************************************************************************************************************************
            //Birden cok değer varsa hata atar eger hiç yoksa null döner
            //var result = db.Products.SingleOrDefault(x => x.CategoryID == 1);
            //***********************************************************************************************************************************
            //Category id si 1 olanın ilkini getir değer yoksa hata atar 
            //var result = db.Products.First(x => x.CategoryID == 1);
            //***********************************************************************************************************************************
            //Category idsi 1  olanın ilkini getir yoksa hata atma null yaz
            var result = db.Products.FirstOrDefault(x => x.CategoryID == 1);
            Console.WriteLine(result);

            //Metod
            //var category = db.Categories;
            //***********************************************************************************************************************************
            //categoryid,categoryname olan adları id name olarak yazdırma
            //var category = db.Categories.Select(x => new
            //{
            //    Id = x.CategoryID,
            //    Name = x.CategoryName
            //});
            //***********************************************************************************************************************************
            //en üstte olan 2 veri
            //var category = db.Categories.Take(2); 
            //***********************************************************************************************************************************
            //Ada göre sırala
            //var category = db.Categories.OrderBy(x => x.CategoryName);
            //var category = db.Categories.OrderByDescending(x => x.CategoryName);
            //***********************************************************************************************************************************
            //5 Ten büyük olanlar
            //var category = db.Categories.Where(x => x.CategoryID > 5);
            //***********************************************************************************************************************************
            //1 ile 3 arasında olan category
            //var category = db.Categories.Where(x => x.CategoryID > 1 && x.CategoryID < 3);
            //***********************************************************************************************************************************
            ////Bütün idleri sum,min,avg,max işlemleri 
            //var category = db.Categories.Sum(x => x.CategoryID);
            //var category = db.Categories.Min(x => x.CategoryID);
            //var category = db.Categories.Max(x => x.CategoryID);
            //var category = db.Categories.Average(x => x.CategoryID);
            //Console.WriteLine(category);
            //***********************************************************************************************************************************
            //karelerini alarak idleri name yazma
            //var category = db.Categories.Select(x => new
            //{
            //    Id = x.CategoryID,
            //    IdKare = x.CategoryID * x.CategoryID,
            //    Name = x.CategoryName
            //});
            //***********************************************************************************************************************************
            //içinde ro olan
            //var category = db.Categories.Where(x => x.CategoryName.Contains("ro"));
            //var category = db.Categories.Where(x => x.CategoryName.StartsWith("ro"));//ro ile başlayan
            //var category = db.Categories.Where(x => x.CategoryName.EndsWith("ro"));//ro ile biten
            //***********************************************************************************************************************************
            //var category = db.Categories.Where(x => x.CategoryName.Contains("ro"));
            //ConsoleTable.From(category).Write();
            //***********************************************************************************************************************************
            //
            //
            //
            //***********************************************************************************************************************************

            //LinQ
            //var result = from cat in db.Categories
            //               select cat;
            //***********************************************************************************************************************************
            //var result = from cat in db.Categories
            //             select new
            //             {
            //                 Id = cat.CategoryID,
            //                 Name = cat.CategoryName
            //             };
            //***********************************************************************************************************************************
            //var result = from c in db.Categories
            //             join p in db.Products
            //             on c.CategoryID equals p.CategoryID
            //             orderby p.UnitPrice descending
            //             select new
            //             {
            //                 c.CategoryName,
            //                 p.ProductName,
            //                 p.UnitPrice
            //             };
            //***********************************************************************************************************************************
            //var result = from c in db.Products
            //             group c by c.CategoryID into g
            //             select new
            //             {
            //                 g.Key,
            //                 NumberOfProduct = g.Count()
            //             };
            //***********************************************************************************************************************************
            //var result = from c in db.Categories
            //             join p in db.Products
            //             on c.CategoryID equals p.CategoryID
            //             group c by c.CategoryName into g
            //             select new
            //             {
            //                 g.Key,
            //                 NumberOfProducts = g.Count()
            //             };
            //ConsoleTable.From(result).Write();





            //CRUD COMMAND
            //List
            //var category = db.Categories;
            //foreach (var cat in category)
            //{
            //    Console.WriteLine(cat.CategoryName);
            //}

            //Create new data
            //var category = new Category();
            //category.CategoryName = "Temizlik";
            //category.Description = "Are you Corona?";
            //db.Categories.Add(category);
            //db.SaveChanges();

            //Update Data
            //var category = db.Categories.Find(9);
            //category.CategoryName = "Corona Cleaner";
            //category.Description = "Corona Corona";
            //db.SaveChanges();


            //ReadData 
            //var category = db.Categories;
            //foreach (var cat in category)
            //{
            //    Console.WriteLine(cat.CategoryName + " " + cat.Description);
            //}

            //Remove data
            //var category = db.Categories.Find(9);
            //db.Categories.Remove(category);
            //db.SaveChanges();



            Console.ReadLine();
        }
    }
}
