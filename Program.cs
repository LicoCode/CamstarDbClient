using CamstarHelper.Context;
using CamstarClient.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamstarClient
{
    public class Program
    {
        public static void Main()
        {
            CamstarDbContext dbContext = new CamstarDbContext();
            var containers = dbContext.Containers.Where(b => b.Name.Equals("20240323_Product_A_01"));
            var container = containers.First();
            Console.WriteLine(container);
        }
    }
}
