using CamstarDbClient.CamstarEntities;
using CamstarDbClient.Config;

namespace CamstarDbClient
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //为CamstarDbClient配置数据库信息
            DbConfiguration.Type = "Oracle";
            DbConfiguration.DefaultConnection = "user id=OPCENTER;data source=localhost:1521/orclpdb;password=*******;";
            

            using (var client = new DbClient())
            {

                var data = client.GetRDOByName<Product>("3001", "1");
                Console.ReadLine();
            }
        }
    }
}
