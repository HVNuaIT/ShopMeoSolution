using StackExchange.Redis;

namespace ShopMeoSolution.Backend.Service
{
    public class CacheService : ICachingService
    {
        public CacheService() {
            var redis = ConnectionMultiplexer.Connect("localhost:6379");

        }
        public T GetData<T>(string key)
        {
            throw new NotImplementedException();
        }

        public object RemoveData(string key)
        {
            throw new NotImplementedException();
        }

        public bool SetData<T>(string key, T value, DateTimeOffset offset)
        {
            throw new NotImplementedException();
        }
    }
}
