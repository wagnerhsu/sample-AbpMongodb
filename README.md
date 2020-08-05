       
本次问题描述核心代码：
AbpMongodb.Domain.Users.MyEntity.cs
AbpMongodb.MongoDB.AbpMongodbMongoDbContext.cs      
       
       
 使用ObjectId作为Id（_id）字段的类型，是mongodb的最佳实践
 
 一般，有两种方式来配置：

 方式一：
 
 在C#中使用string类型，加上[BsonRepresentation(BsonType.ObjectId)]，映射到Mongodb中，字段类型就是ObjectId
 
 官方文档地址-设置字段类型为ObjectId：https://mongodb.github.io/mongo-csharp-driver/2.10/reference/bson/mapping/#objectids

 方式二：
 
 还有一种方式时在DbContext的CreateModel中进行配置（类似EF）
 
 详见：AbpMongodb.MongoDB.AbpMongodbMongoDbContext
  
 BsonClassMap.RegisterClassMap<MyEntity>(cm =>
       
 {
 
       cm.AutoMap();
 
       //Id是继承自Entity的属性，会报异常：
 
       //System.ArgumentOutOfRangeException: The memberInfo argument must be for class MyEntity, but was for class Entity. (Parameter 'memberInfo')
 
       cm.MapMember(c => c.Id).SetSerializer(new StringSerializer(BsonType.ObjectId));
 
       //UserId是MyEntity的属性，不会报异常
 
       cm.MapMember(c => c.UserId).SetSerializer(new StringSerializer(BsonType.ObjectId));
 
 });
 


 遇到的问题：无法将Id字段的类型设置为ObjectId
 
 方式一：Id字段被Abp封装在Entity中，无法为其添加[BsonRepresentation(BsonType.ObjectId)]
 
 方式二：会报异常：
 
 System.ArgumentOutOfRangeException: The memberInfo argument must be for class MyEntity, but was for class Entity`1. (Parameter 'memberInfo')
