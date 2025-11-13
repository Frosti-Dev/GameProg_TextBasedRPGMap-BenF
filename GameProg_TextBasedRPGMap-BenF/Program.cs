using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameProg_TextBasedRPGMap_BenF
{
    class Program
    {

        static char[,] map = new char[,] // dimensions defined by following data:
    {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
    };

        // usage: map[y, x]

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees

        static void DisplayMap()
        {
            Console.WriteLine("Map legend: ");
            Console.WriteLine("^ = mountain");
            Console.WriteLine("` = grass");
            Console.WriteLine("~ = water");
            Console.WriteLine("* = trees");

            //border top
            Console.Write("+");
            for (int k = 0; k < map.GetLength(0) * 2; k++)
            {
                Console.Write('-');
            }
            Console.Write('+');
            //Console.WriteLine(" ");
            
            for (int i = 0; i < map.GetLength(0); i++)
            {
                Console.WriteLine(" ");
                Console.Write('|');
                for (int j = 0; j < map.GetLength(0); j++)
                {
                    Console.Write(map[i, j] + " ");
                }
                Console.Write('|');
            }


            //bottom border
            Console.WriteLine(" ");
            Console.Write("+");
            for (int f = 0; f < map.GetLength(0) * 2; f++)
            {
                Console.Write('-');
            }
            Console.Write('+');
            Console.WriteLine(" ");
        }

        static void DisplayMap(int scale)
        {
            Console.WriteLine("Map legend: ");
            Console.WriteLine("^ = mountain");
            Console.WriteLine("` = grass");
            Console.WriteLine("~ = water");
            Console.WriteLine("* = trees");


            //border top
            Console.Write("+");
            for(int k = 0;  k < map.GetLength(0) * scale * 2; k++)
            {
                Console.Write('-');
            }
            Console.Write('+');
            Console.WriteLine(" ");

            //print map
            for (int i = 0; i < map.GetLength(0); i++)
            {
                    
                int row = 0;
                while (row < scale)
                {
                    Console.Write('|');
                    for (int j = 0; j < map.GetLength(0); j++)
                    {
                        int timer = 0;
                        while (timer < scale)
                        {
                            Console.Write(map[i, j] + " ");
                            timer++;
                        }
                    }
                    Console.Write('|');
                    Console.WriteLine(" ");
                    row++;
                }
            }

            //bottom border
            Console.Write("+");
            for (int f = 0; f < map.GetLength(0) * scale * 2; f++)
            {
                Console.Write('-');
            }
            Console.Write('+');
            Console.WriteLine(" ");
        }

        static void Main(string[] args)
        { 
            Console.WriteLine("Display 1");
            Console.WriteLine("  ");


            DisplayMap();

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  ");
            Console.WriteLine("  ");

            Console.WriteLine("Display 2");
            Console.WriteLine("  ");

            DisplayMap(2);

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  ");
            Console.WriteLine("  ");

            Console.WriteLine("Display 3");
            Console.WriteLine("  ");

            DisplayMap(3);
        }
    }
}
