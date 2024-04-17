# CamstarDbClient

```c#
//为CamstarDbClient配置数据库信息
DbConfiguration.Type = "Oracle";
DbConfiguration.DefaultConnection = "user id=OPCENTERDBUSER;data source=localhost:1521/orclpdb;password=******;";

using (var client = new DbClient())
{
    Product data = client.GetRDOByName<Product>("3001", "1");
}
```
