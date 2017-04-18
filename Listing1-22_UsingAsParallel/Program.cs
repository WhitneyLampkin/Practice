﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace Listing1_22_UsingAsParallel
{
    public class Program
    {
        void Main(string[] args)
        {
            Blah();  // ???????????????????????????????????????????????????????????????????????????????????????????????
            
            Console.ReadLine();
        }

        public async Task Blah()
        {
                var numbers = Enumerable.Range(0, 100000000);
                var parallelResult = numbers.AsParallel()
                    .Where(i => i % 2 == 0)
                    .ToArray();

                foreach (var item in parallelResult)
                {
                    Console.WriteLine(item);
                    await Task.Delay(5000);
                }
        }
    }
}