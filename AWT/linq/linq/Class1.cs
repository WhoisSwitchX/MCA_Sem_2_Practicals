using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace linq
{
    public class Class1
    {
        public string id { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }
        public DateTime dateOfRelease { get; set; }

        public static List<Class1> GetBooks()
        {
            List<Class1> list = new List<Class1>();
            list.Add(new Class1
            {
                id = "001",
                title = "Programming in C#",
                price = 600.14m,
                dateOfRelease=Convert.ToDateTime("2018-05-07")
            });
            list.Add(new Class1
            {
                id = "002",
                title = "Let us C",
                price = 340.00m,
                dateOfRelease = Convert.ToDateTime("2010-01-20")
            });
            list.Add(new Class1
            {
                id = "003",
                title = "Machine Learning",
                price = 1200m,
                dateOfRelease = Convert.ToDateTime("2018-12-14")
            });
            list.Add(new Class1
            {
                id = "004",
                title = "Operations Research",
                price = 475m,
                dateOfRelease = Convert.ToDateTime("2013-05-30")
            });
            return list;
        }
    }
}