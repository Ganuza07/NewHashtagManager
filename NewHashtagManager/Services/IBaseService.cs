using NewHashtagManager.Repository;

namespace NewHashtagManager.Services
{
    public interface IBaseService<T> : IBaseRepository<T> where T : class
    {
    }
}
