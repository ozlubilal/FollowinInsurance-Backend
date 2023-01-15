using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
             //categoryManager.Add(new Category {  CategoryName="Sağlık" });;
            var result=categoryManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CategoryName);
            }
            Console.ReadLine();
            
        }
       
    }
}
