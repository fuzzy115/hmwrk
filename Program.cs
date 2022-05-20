

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPro
{  
    class Program
    {   public static void FillArr(ref string [] ms)
        {   string [] mas;
            string str="";
            Console.WriteLine("enter words separated by spaces");
            str = Console.ReadLine();
            mas=str.Split(" ");
             if ((mas.Length>ms.Length)||(mas.Length<ms.Length))
            {
                Array.Resize(ref ms,mas.Length);
            }
            ms=mas;
        }
        public static void FillArrFile(ref string [] ms)
        {   string str="";
            string [] mas;
            StreamReader sr = new StreamReader(@".\DummyFile.txt");
        while (sr.EndOfStream)
              {
                str+=sr.ReadLine();
              }
            mas=str.Split(" ");
             if ((mas.Length>ms.Length)||(mas.Length<ms.Length))
            {
                Array.Resize(ref ms,mas.Length);
            }
            ms=mas;
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
        Console.WriteLine("1=from file, 2= static definition, all else from console");
        int k=Convert.ToInt32(Console.ReadLine());
        switch(k)
        {
        case 1:
           {  sSourceWords=new string[5];
              Program.FillArrFile(ref sSourceWords);
              break;
              }
        case 2:
            {
                sSourceWords=new string [] {"hello", "2", "world", ":-)"};
              //  sSourceWords={"1234", "1567", "-2", "computer science"};
              //  sSourceWords={"Russia", "Denmark", "Kazan"};
                break;
            }
        default:
            { sSourceWords=new string[5];
              Program.FillArr(ref sSourceWords);
               break;
             }
        }
        sResWords=new string[sSourceWords.Length];
        Program.CalcRes(sSourceWords,sResWords);
        Program.OutPutArray(sResWords);

            
        }
        

    }

}
