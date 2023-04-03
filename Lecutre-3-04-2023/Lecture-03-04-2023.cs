using System;
using System.IO;

namespace Lecture_03_04_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fin = new FileStream("path.txt", FileMode.Create);
            for(char c='A'; c<'Z'; c++)
            {
                fin.WriteByte((byte)c);
            }
           
            fin.Close();
        }
    }
}
