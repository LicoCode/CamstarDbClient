
using System.IO;

namespace CamstarDbClient.Config
{
    /// <summary>
    /// EF框架配置信息
    /// </summary>
    public class DbConfiguration
    {
        public static string Type { get; set; }
        public static string DefaultConnection { get; set; }
    }
}
