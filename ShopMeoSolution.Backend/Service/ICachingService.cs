namespace ShopMeoSolution.Backend.Service
{
    public interface ICachingService
    {
        T GetData<T>(string key);
        bool SetData<T>(string key,T value,DateTimeOffset offset);
        object RemoveData(string key);
    }
}
