using Microsoft.EntityFrameworkCore;
using SportNutrition.DAL.Interfaces;
using SportNutrition.Domain.ModelDb;

namespace SportNutrition.DAL.Storages;

public class PicturesSportStorage : IBaseStorage<PicturesSportDb>
{
    private readonly ApplicationDbContext _context;

    public PicturesSportStorage(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<PicturesSportDb> AddAsync(PicturesSportDb entity)
    {
        var a = await _context.PicturesSports.AddAsync(entity);
        await _context.SaveChangesAsync();
        return a.Entity;
    }

    public async Task DeleteAsync(PicturesSportDb entity)
    {
        _context.PicturesSports.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<PicturesSportDb> GetByIdAsync(Guid id)
    {
        return await _context.PicturesSports.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<PicturesSportDb> Update(PicturesSportDb entity)
    {
        var a = _context.PicturesSports.Update(entity);
        await _context.SaveChangesAsync();
        return a.Entity;
    }

    public IQueryable<PicturesSportDb> GetAllAsync()
    {
        return _context.PicturesSports.AsQueryable();
    }
}