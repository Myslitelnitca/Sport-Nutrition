using Microsoft.EntityFrameworkCore;
using SportNutrition.DAL.Interfaces;
using SportNutrition.Domain.ModelDb;

namespace SportNutrition.DAL.Storages;

public class CategoryStorage : IBaseStorage<CategoryDb>
{
    private readonly ApplicationDbContext _context;

    public CategoryStorage(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<CategoryDb> AddAsync(CategoryDb entity)
    {
        var a = await _context.Categories.AddAsync(entity);
        await _context.SaveChangesAsync();
        return a.Entity;
    }

    public async Task DeleteAsync(CategoryDb entity)
    {
        _context.Categories.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<CategoryDb> GetByIdAsync(Guid id)
    {
        return await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<CategoryDb> Update(CategoryDb entity)
    {
        var a = _context.Categories.Update(entity);
        await _context.SaveChangesAsync();
        return a.Entity;
    }

    public IQueryable<CategoryDb> GetAllAsync()
    {
        return _context.Categories.AsQueryable();
    }
}