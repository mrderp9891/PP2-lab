using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace _1.Up_Down
{
    class Program
    {
        static void ShowState(DirectoryInfo cur, int position)
        {
            FileSystemInfo[] infos = cur.GetFileSystemInfos();
            for (int i = 0; i < infos.Length; i++)
            {
                
                Console.BackgroundColor = i == position ? ConsoleColor.Gray : ConsoleColor.Black;
                Console.ForegroundColor = infos[i].GetType() == typeof(DirectoryInfo) ? ConsoleColor.Red : ConsoleColor.Magenta;
                Console.WriteLine(infos[i].Name);
            }
        }



        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int position = 0;
            DirectoryInfo dir = new DirectoryInfo(@"D:\Doge");
            
            while (true)
            {
                Console.Clear();
                ShowState(dir, position);
                ConsoleKeyInfo btn = Console.ReadKey();
                if (btn.Key == ConsoleKey.UpArrow)
                {
                    System.Media.SystemSounds.Beep.Play(); //just for fun
                    position--;
                    if (position < 0)
                    {
                        position = dir.GetFileSystemInfos().Length - 1;
                        
                    }
                }
                if (btn.Key == ConsoleKey.DownArrow)
                {
                    System.Media.SystemSounds.Beep.Play();
                    position++;
                    if (position > dir.GetFileSystemInfos().Length - 1)
                    {
                       
                        position = 0;
                    }
                }
                if (btn.Key == ConsoleKey.Enter)
                {
                    FileSystemInfo f = dir.GetFileSystemInfos()[position];
                    if (f.GetType() == typeof(DirectoryInfo))
                    {
                        dir = new DirectoryInfo(f.FullName);
                        position = 0; 
                    } 
                    else
                    {
                        Process.Start(f.FullName);
                    }
                    
                }
                if (btn.Key == ConsoleKey.Escape)
                {
                    dir = dir.Parent;
                }
                if (btn.Key == ConsoleKey.NumPad1)
                {
                    Console.Beep(1000, 500);
                }
                if (btn.Key == ConsoleKey.NumPad2)
                {
                    Console.Beep(2000, 500);
                }
                if (btn.Key == ConsoleKey.NumPad3)
                {
                    Console.Beep(3000, 500);
                }
                if (btn.Key == ConsoleKey.NumPad4)
                {
                    Console.Beep(4000, 500);
                }
                if (btn.Key == ConsoleKey.NumPad5)
                {
                    Console.Beep(5000, 500);
                }
                if (btn.Key == ConsoleKey.NumPad6)
                {
                    Console.Beep(6000, 500);
                }
                if (btn.Key == ConsoleKey.NumPad7)
                {
                    Console.Beep(7000, 500);
                }
                if (btn.Key == ConsoleKey.NumPad8)
                {
                    Console.Beep(8000, 500);
                }
                if (btn.Key == ConsoleKey.NumPad9)
                {
                    Console.Beep(9000, 500);
                }
                if (btn.Key == ConsoleKey.NumPad0)
                {
                    Console.Beep(16000, 500);
                }
            }
            
        }
    }
}
