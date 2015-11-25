using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
        	for(int k=0;k<100;k++)
        	{
        	DateTime start=DateTime.Now;
        	for(long i=0;i<250000000;i++);
        	DateTime end=DateTime.Now;
        	Console.WriteLine(string.Format("{0}",end-start));
        }
        }
    }
}