# CamstarDbClient

```c#
//为CamstarDbClient配置数据库信息
            DbConfiguration.Type = "Oracle";
            DbConfiguration.DefaultConnection = "user id=******;data source=localhost:1521/orclpdb;password=******;";
            

            using (var client = new DbClient())
            {
                Container data = client.GetContainerByName<Container>("20231201_P_02");
            }
```
