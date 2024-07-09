# CamstarDbClient

```c#
//为CamstarDbClient配置数据库信息
DbConfiguration.DbType = "Oracle";
DbConfiguration.ConnectionString = "user id=******;data source=localhost:1521/orcl;password=******;";
DbConfiguration.LoggerFactory = loggerFactory;

using var client = new DbClient()
Container c = client.GetContainerByName<Container>("20231201_P_02");
var product = c?.Product?.Base?.Name;
var qty = c?.Qty;
var mfgline = c?.MfgLine?.Name;
```

基于Opcenter EX EL套件，EF框架实现
