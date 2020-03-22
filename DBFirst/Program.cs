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

            //Fonksiyon
            var category = db.Categories;
            ConsoleTable.From(category).Write();
            //LinQ
            var result = from cat in db.Categories
                           select cat;
            ConsoleTable.From(result).Write();
            




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
