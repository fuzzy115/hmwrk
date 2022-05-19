

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPro
{  
    class Program
    {   public static void FillArr(string [] ms)
        {   string [] mas;
            Console.WriteLine("enter amount of words");
            int n=Convert.ToInt32(Console.ReadLine);
            mas=new string[n];
            string str="/0";
            Console.WriteLine("enter words separated by spaces");
            str = Console.ReadLine();
            mas=str.Split(" ",1,StringSplitOptions.None);
             if ((mas.Length>ms.Length)||(mas.Length<ms.Length))
            {
                Array.Resize(ms,n);
            }
            ms=mas;
        }
        public static void FillArrFile()
        {
            
        }
        public static void OutPutArray(string [] res)
        {
            int i=0;
            for (i=0;i<res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
        }

        public static void CalcRes(string [] ms, string [] res)
        { int k=0;
            for (int i=0;i<ms.Length;i++)
            {
                if (ms[i].Length<=3)
                {
                    res[k]=ms[i];
                    k++;
                }
            }
            Array.Resize(ref res,k);
        }

        public static void Main(string[] args)
        { 
         int  n;
         string [] sSourceWords;
         string [] sResWords;

        Console.WriteLine("Program to find all words less than three symbols");
        Console.WriteLine("choose option to enter data");
        Console.WriteLine("1=from file, all else from console");
        int k=Convert.ToInt32(Console.ReadLine());
        switch(k)
        {
        case 1:
           {  sSourceWords=new string[5];
              Program.FillArrFile(sSourceWords);
              break;
              }
        
        default:
            { sSourceWords=new string[5];
              Program.FillArr(sSourceWords);
               break;
             }
        }
        sResWords=new string[sSourceWords.Length];
        Program.CalcRes(sSourceWords,sResWords);
        Program.OutPutArray(sResWords);

            
        }
        

    }

        

    }
}