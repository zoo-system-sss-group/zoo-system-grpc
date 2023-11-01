using Application.IRepositories;
using DataAccess.DAOs;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;

public class NewsRepository : INewsRepository
{
    private readonly NewsDAO _newsDao;

    public NewsRepository(NewsDAO newsDao)
    {
        _newsDao = newsDao;
    }

    public async Task<List<News>> GetNews() => await _newsDao.GetAllAsync();
    public async Task<List<News>> GetRandomNews(int? id)
    {
        var news = await _newsDao.GetAllAsync();
        if(id != null)
        {
            news.Remove(news.First(x => x.Id == id));
        }
        news = news.OrderBy(x => Guid.NewGuid()).Take(10).ToList();
        return news;
    }
    public async Task<News?> GetNews(int id) => await _newsDao.GetByIdAsync(id);
    public async Task AddNews(News p) => await _newsDao.SaveAsync(p);
    public async Task UpdateNews(News p) => await _newsDao.UpdateAsync(p);
    public async Task DeleteNews(News p) => await _newsDao.DeleteAsync(p);

}
