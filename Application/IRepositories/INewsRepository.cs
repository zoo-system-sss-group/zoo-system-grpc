using Domain.Entities;

namespace Application.IRepositories
{
    public interface INewsRepository
    {
        Task AddNews(News p);
        Task DeleteNews(News p);
        Task<List<News>> GetNews();
        Task<List<News>> GetRandomNews(int? id);
        Task<News?> GetNews(int id);
        Task UpdateNews(News p);
    }
}