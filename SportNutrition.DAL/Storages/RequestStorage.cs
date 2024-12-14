using Microsoft.EntityFrameworkCore;
using SportNutrition.DAL.Interfaces;
using SportNutrition.Domain.ModelDb;

namespace SportNutrition.DAL.Storages;
public class RequestStorage : IBaseStorage<RequestDb>
{
    private readonly ApplicationDbContext _context;

    public RequestStorage(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<RequestDb> AddAsync(RequestDb entity)
    {
        var a = await _context.Requests.AddAsync(entity);
        await _context.SaveChangesAsync();
        return a.Entity;
    }

    public async Task DeleteAsync(RequestDb entity)
    {
        _context.Requests.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<RequestDb> GetByIdAsync(Guid id)
    {
        return await _context.Requests.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<RequestDb> Update(RequestDb entity)
    {
        var a = _context.Requests.Update(entity);
        await _context.SaveChangesAsync();
        return a.Entity;
    }

    public IQueryable<RequestDb> GetAllAsync()
    {
        return _context.Requests.AsQueryable();
    }
}