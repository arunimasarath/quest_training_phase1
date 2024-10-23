using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LearnCSharp.Repositories;


namespace LearnCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var categoryRepository = new CategoryRepository();

            var result = categoryRepository.GetCategoryById(10);
            if (result.Success)
            {
                Console.WriteLine(result.Data.Name);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
