using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            //GetSymbols(str);
            //Ex2(str);
            //Ex3(str);
            //Ex4(str);
            //int collichestvo = Convert.ToInt32(Console.ReadLine());
            // Ex5(str, collichestvo);
            // Ex6(str);
            Ex7(str);
            Console.ReadKey();

        }
        private static void Ex7(string str)
        {
            StringBuilder str2 = new StringBuilder();
            int l = str.Length;
            str2.Insert(0, "*", l);
            str2.Insert(str.Length, str);
            int h=str2.Length;
            str2.Insert(str2.Length, "*", l);
            
           
            
            Console.WriteLine(str2);
            
        }
            private static void Ex6(string str)
        {
            StringBuilder str2= new StringBuilder();
            string plusi = "++++";
            string minusi = "-----";
            str2.Insert(0, str);
            str2.Insert(0, plusi);
            str2.Insert(str2.Length, minusi);
            Console.WriteLine(str2);
        }
        private static void Ex5(string str, int collichestvo)
        {
            
            for (int i = 0; i < collichestvo; i++)
            {
                Console.WriteLine(str);
            }
        }
        private static void Ex4(string str)
        {
            StringBuilder t = new StringBuilder();
            for(int i = str.Length - 1; i >= 0; i--)
            {
                t.Append(str[i]);
            }
            Console.WriteLine(t);
        }
            private static void Ex3(string str)
        {
            StringBuilder str2 = new StringBuilder();
            for (int i = 0; i < str.Length; i += 2)
            {
                str2.Append(str[i]);
            }
            Console.WriteLine(str2);
        }

        private static void Ex2(string str)
        {
            StringBuilder str2= new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--) 
            {
                str2.Append(str[i]);
            }
                Console.Write(str2);
        }

        /// <summary>
        /// Печать символа столбиком
        /// </summary>
        /// <param name="str"></param>
        private static void GetSymbols(string str)
        {
            foreach (char item in str)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
