using Microsoft.EntityFrameworkCore;
using SportNutrition.DAL.Interfaces;
using SportNutrition.Domain.ModelDb;

namespace SportNutrition.DAL.Storages;

public class NutritionStorage : IBaseStorage<NutritionDb>
{
    private readonly ApplicationDbContext _context;

    public NutritionStorage(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<NutritionDb> AddAsync(NutritionDb entity)
    {
        var a = await _context.Nutritions.AddAsync(entity);
        await _context.SaveChangesAsync();
        return a.Entity;
    }

    public async Task DeleteAsync(NutritionDb entity)
    {
        _context.Nutritions.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<NutritionDb> GetByIdAsync(Guid id)
    {
        return await _context.Nutritions.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<NutritionDb> Update(NutritionDb entity)
    {
        var a = _context.Nutritions.Update(entity);
        await _context.SaveChangesAsync();
        return a.Entity;
    }

    public IQueryable<NutritionDb> GetAllAsync()
    {
        return _context.Nutritions.AsQueryable();
    }
}