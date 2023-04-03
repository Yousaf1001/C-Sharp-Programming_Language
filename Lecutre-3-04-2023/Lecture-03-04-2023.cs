using System;
using System.IO;

namespace Lecture_03_04_2023
{
    internal class Program
    {
        //Write Bytes in  file
        // static void Main(string[] args)
        // {
        //     FileStream fin = new FileStream("path.txt", FileMode.Create);
        //     for(char c='A'; c<'Z'; c++)
        //     {
        //         fin.WriteByte((byte)c);
        //     }
           
        //     fin.Close();
        // }

        //Read  Data from one file wrote another file(Duplication) 
         static void Main(string[] args)
        {
            FileStream fin = new FileStream("path.txt", FileMode.Open);
            FileStream fin1 = new FileStream("path1.txt", FileMode.Create);
            /* for(char c='A';c<='Z'; c++)
             {
                 fin.WriteByte((byte)c);
             }*/
            int i  = fin.ReadByte(); 
            while (i != -1)
            {
                char c = (Char)i;
                fin1.WriteByte((byte)c);
                i = fin.ReadByte();
            }

            fin.Close();
        }
    }
}
