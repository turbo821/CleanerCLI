using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class StaticMethods
    {
       public static void DisplayToConsole(object sender, CustomEventArgs eventArgs)
        {
            Console.WriteLine(eventArgs.Message);
        }
        public static void DisplayRedToConsole(object sender, CustomEventArgs eventArgs)
        {
            // Устанавливаем красный цвет символов
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(eventArgs.Message);
            // Сбрасываем настройки цвета
            Console.ResetColor();
        }
        public static async void LogToFile(object sender, CustomEventArgs eventArgs)
        {
            using (StreamWriter writer = new StreamWriter("logs.txt", true))
            {
                await writer.WriteAsync($"{eventArgs.DateTime} [Message]\n{eventArgs.Message}\n");
            }
        }




    }
}
