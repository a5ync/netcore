using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {        	 
        	DateTime start=DateTime.Now;
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            
            psi.FileName = args[0];
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;

            psi.Arguments = String.Join(" ",args.Skip(1));
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi);
            string strOutput = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            
            Console.WriteLine("output:"+strOutput);// +args[0]);
            DateTime end=DateTime.Now;
        	Console.WriteLine(string.Format("Processing time :{0}",end-start));
        
        }
    }
}