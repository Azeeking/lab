using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        public static void Main()
        {
            string path = @"C:\Users\the_k\Desktop\LAB\example\example.txt";
            string path2 = @"C:\Users\the_k\Desktop\LAB\example1.txt";

            if (!File.Exists(path)) //если файл не существует 
            {
                FileStream fs = File.Create(path);//создаем этот файл 
            }

            File.Move(path, path2);//переместим через Move файл в другую папку, учитывая, что в первой папке он исчезает 
        }
    }
}