using System;
using Mongo2Go;

namespace AbpMongodb.MongoDB
{
    public class AbpMongodbMongoDbFixture : IDisposable
    {
        private static readonly MongoDbRunner MongoDbRunner;
        public static readonly string ConnectionString;

        static AbpMongodbMongoDbFixture()
        {
            MongoDbRunner = MongoDbRunner.Start();
            ConnectionString = MongoDbRunner.ConnectionString;
        }

        public void Dispose()
        {
            MongoDbRunner?.Dispose();
        }
    }
}
