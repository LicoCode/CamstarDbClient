
using Microsoft.Extensions.Logging;
using System.IO;

namespace CamstarDb.Config
{
    /// <summary>
    /// EF框架配置信息
    /// </summary>
    public class DbConfiguration
    {
        public static string DbType { get; set; }
        public static string ConnectionString { get; set; }
        public static ILoggerFactory LoggerFactory { get; set; }
    }
}
