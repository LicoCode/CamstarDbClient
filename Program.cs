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
            var mfgorders = dbContext.MfgOrders.Where(b => b.Name.Equals("20220919"));
            var mfgorder = mfgorders.First();

            var products = dbContext.Products.Where(b => b.InstanceID.Equals("00062c8000000002"));
            var product = products.First();

            

            var lossReasonGroups = dbContext.LossReasonGroups.Where(b => b.Name.Equals("test"));
            var lossReasonGroup = lossReasonGroups.First();

            var resources = dbContext.Resources.Where(b => b.Name.Equals("test"));
            var resource = resources.First();

            

            Console.WriteLine(product);
        }
    }
}
