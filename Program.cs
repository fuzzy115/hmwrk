

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPro
{  
    class Program
    {   public static void FillArr(string [] ms)
        { 
            string str="/0";
            Console.WriteLine("enter words separated by spaces");
            str = Console.ReadLine();
            ms=str.Split(" ",1,StringSplitOptions.None);
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
        
        int k=Convert.ToInt32(Console.ReadLine());
        switch(k)
        {
        case 1:
            { Console.WriteLine("enter begin range");
              n=Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("enter end range");
              m=Convert.ToInt32(Console.ReadLine());
              Program.RecRangereturn(n,m);
                break;
                }
        case 2:
           {  Console.WriteLine("enter begin range");
              n=Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("enter end range  ");
              m=Convert.ToInt32(Console.ReadLine());
              result=Program.Recsumreturn(n,m);
              Console.WriteLine("result is "+result);
              break;
              }
            case 3:
            { Console.WriteLine("enter m");
              m=Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("enter n");
              n=Convert.ToInt32(Console.ReadLine());
              result=Program.Ackkerman(n,m);
              Console.WriteLine("result is "+result);
              break;
                }
            default:
              {

              Console.WriteLine("you didn't enter anything");
            break;
            }
        }

    }

        

    }
}