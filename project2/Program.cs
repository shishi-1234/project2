using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("ПРивет\a");
            Console.WriteLine("Введите ваше ФИО");
            string fullname = Console.ReadLine();
            Console.Write("Введите вашу дату рождения(год-мм-дд) ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите город:");
            string city = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ФИО: " + fullname);
            Console.WriteLine("Находится в городе " + city);
            Console.WriteLine("Дата рождения " + birthday);
            Console.ReadLine();*/
            /*Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\tНЕвероятный диалог:\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t-А ты научился использовать \"Управляющие символы?\"\n\t-Да");
            Console.WriteLine("\n\nНевероятный звук \a");
            Console.ReadLine();*/
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\tРЕГИСТРАЦИЯ");
            Console.ForegroundColor = ConsoleColor.White;
            string email = "fewfwgwqgw@gmail.com";
            string password = "gehtrehe";
            int pincode = 1234;
            string nerpass = password.Replace("erdd","rehe");
            Console.WriteLine("email: "+email);
            Console.WriteLine("password " + password);
            Console.WriteLine("newpassword " + nerpass);
            Console.WriteLine("pincode " + pincode);
            Console.ReadLine();
            //gntrjt

        }
    }
}
