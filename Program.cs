using System;
using System.Text;

namespace lesson9
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //DateTime date = new DateTime();
            //var date = new DateTime(2020, 10, 26, 8, 30, 00);

            //var date = DateTime.Now;
            //Console.WriteLine($"{date.Day}/{date.Month}/{date.Year}");
            //Console.WriteLine($"{date.Hour}:{date.Minute}:{date.Second}");

            //var today = DateTime.Now;
            //var tomoro = today.AddYears(1);
            //Console.WriteLine(tomoro);

            //var today = DateTime.Now;
            //Console.WriteLine(today);
            //Console.WriteLine(today.ToString());
            //Console.WriteLine(today.ToLongDateString());
            //Console.WriteLine(today.ToShortDateString());
            //Console.WriteLine(today.ToLongTimeString());
            //Console.WriteLine(today.ToShortTimeString());

            //TimeSpan t = new TimeSpan();
            //var today = DateTime.Now;
            //var birthdate = new DateTime(1989, 10, 4);

            //var age = today - birthdate;

            //Console.WriteLine(age.Days / 360);


            //var name = " saeed abullah balkhair";
            //Console.WriteLine($"'{name}'");
            //Console.WriteLine($"'{name.Trim()}'");
            //Console.WriteLine($"'{name.ToUpper()}'");
            //Console.WriteLine($"'{name.ToLower()}'");
            //Console.WriteLine($"'{name.IndexOf('s')}'");
            //Console.WriteLine($"'{name.IndexOf("balkhair")}'");

            //var input = "22,12,10,59,22,30";
            //var numbers = input.Split(',');
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //var input = "saeed abdulla ahmed blakhair";
            //var names = input.Split(' ');

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            //var input = "saeed abdullah balkhair";

            //Console.WriteLine(input.Substring(6));
            //Console.WriteLine(input.Substring(0, 5));
            //Console.WriteLine(input.Replace("saeed", "khaled"));

            //Console.WriteLine("Enter your name");
            //var input = Console.ReadLine();
            //if (!String.IsNullOrEmpty(input))
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //{
            //    Console.WriteLine("Not valid");
            //}

            //Console.ReadKey();


            //Console.WriteLine("Enter your name");
            //var input = Console.ReadLine();
            //if (!String.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //{
            //    Console.WriteLine("Not valid");
            //}

            //Console.ReadKey();

            //var price = 12.2239939939939;
            //Console.WriteLine(price.ToString("C"));
            //Console.WriteLine(price.ToString("C4"));
            //Console.ReadKey();

            //var bulider = new StringBuilder();
            //bulider.Append('-', 50);
            //bulider.AppendLine();
            //bulider.Append("saeed abdullah balkhri");
            //bulider.AppendLine();
            //bulider.Append('-', 50);

            ////bulider.Replace('-', '*');
            ////bulider.Remove(51, 5);
            //bulider.Insert(66, "Ahmed ");
            //Console.WriteLine(bulider);
            //Console.ReadKey();

            var bulider = new StringBuilder();
            bulider.Append('-', 50)
                   .AppendLine()
                   .Append("saeed balkhair")
                   .AppendLine()
                   .Append('-', 50);

            Console.WriteLine(bulider);
            Console.ReadKey();

        }
    }
}
