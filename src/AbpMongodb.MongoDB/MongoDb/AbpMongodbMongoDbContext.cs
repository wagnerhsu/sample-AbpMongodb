using MongoDB.Driver;
using AbpMongodb.Users;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson;

namespace AbpMongodb.MongoDB
{
    [ConnectionStringName("Default")]
    public class AbpMongodbMongoDbContext : AbpMongoDbContext
    {
        public IMongoCollection<AppUser> Users => Collection<AppUser>();

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.Entity<AppUser>(b =>
            {  
                b.CollectionName = "AbpUsers";
            });

            BsonClassMap.RegisterClassMap<MyEntity>(cm =>
            {
                cm.AutoMap();
                //Id是继承自Entity的属性，会报异常：
                //System.ArgumentOutOfRangeException: The memberInfo argument must be for class MyEntity, but was for class Entity`1. (Parameter 'memberInfo')
                cm.MapMember(c => c.Id).SetSerializer(new StringSerializer(BsonType.ObjectId));

                //UserId是MyEntity的属性，不会报异常
                cm.MapMember(c => c.UserId).SetSerializer(new StringSerializer(BsonType.ObjectId));
            });
        }
    }
}
