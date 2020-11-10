using NewHashtagManager.Domain.Repository;

namespace HashtagManager.Application.Service.Interface
{
    interface IBaseService<T> : IBaseRepository<T> where T : class
    {
    }
}
