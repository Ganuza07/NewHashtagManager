using NewHashtagManager.Domain.Repository;

namespace HashtagManager.Application.Service.Interface
{
    interface IPosteoService<T> : IBaseRepository<T> where T : class
    {
    }
}
