using System;
using System.Collections.Generic;

namespace StudentDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Student> dictionary = new Dictionary<string,Student>();

            string answer = "";
            string fullname = "";
            int point;
            string strPoint;
            string key;
            do
            {
                Console.WriteLine("1.Student elave et\n2.Studentlari goster\n0.Proqrami dayandir");
                answer = Console.ReadLine();
                if (answer=="1")
                {
                    do
                    {
                        Console.WriteLine("telebenin adini daxil edin: ");
                        fullname = Console.ReadLine();
                    } while (String.IsNullOrWhiteSpace(fullname));
                    
                    do
                    {
                        Console.WriteLine("telebenin balini daxil edin: ");
                        strPoint = Console.ReadLine();
                    } while (!int.TryParse(strPoint, out point));
                    do
                    {
                        Console.WriteLine("Telebenin nomresini daxil edin:");
                        key = Console.ReadLine();
                    } while (dictionary.ContainsKey(key));

                    Student student = new Student()
                    {
                        Fullname = fullname,
                        Point = point,
                    };
                    dictionary.Add(key, student);
                }
                else if (answer == "2")
                {
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + " " + item.Value.Fullname + " " + item.Value.Point);
                    }
                }
            } while (answer!="0");
        }
    }
}
