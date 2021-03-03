using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList_TA
{
    public class Cli
    {

        public static void DisplayLine(string prompt= null)
        {
            Console.WriteLine($"{prompt}");
        }
        public static DateTime? GetDateTime(string prompt)
        {
            var response = GetString(prompt);
            if(response.Length == 0)
            {
                return null;
            }
            return Convert.ToDateTime(response);
        }

        public static int GetInt(string prompt)
        {
            var response = GetString(prompt);
            return Convert.ToInt32(response);

        }


        public static string GetString(string prompt)
        {
            Console.WriteLine($"{prompt}: ");
            var response = Console.ReadLine();
            return response;

        }
    }
}
