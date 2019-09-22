using System;
using System.Collections.Generic;
using Rishi.ShellBind;

namespace cs_shellchain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			List<ShellSocket> SS = new List<ShellSocket>();
			for (int i=0; i<args.Length; i++) 
			{
				System.Console.WriteLine(args[i]);
			}
        }
    }
}
