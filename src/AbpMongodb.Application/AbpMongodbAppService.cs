using System;
using System.Collections.Generic;
using System.Text;
using AbpMongodb.Localization;
using AbpMongodb.Users;
using MongoDB.Bson;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpMongodb
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpMongodbAppService : ApplicationService, IAbpMongodbAppService
    {
        readonly IRepository<MyEntity, string> myEntitieRepository;
        protected AbpMongodbAppService(IRepository<MyEntity, string> myEntitieRepository)
        {
            this.myEntitieRepository = myEntitieRepository;
            LocalizationResource = typeof(AbpMongodbResource);
        }

        public async System.Threading.Tasks.Task TestAsync()
        {
            await myEntitieRepository.InsertAsync(new MyEntity(ObjectId.GenerateNewId().ToString()) { UserId = ObjectId.GenerateNewId().ToString(), Name = "test" });
        }
    }
}
