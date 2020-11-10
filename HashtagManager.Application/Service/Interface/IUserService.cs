using NewHashtagManager.Domain.Repository;

namespace HashtagManager.Application.Service.Interface
{
    interface IUserService<T> : IBaseRepository<T> where T : class
    {
    }
}
