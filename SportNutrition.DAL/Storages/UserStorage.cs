using Microsoft.EntityFrameworkCore;
using SportNutrition.DAL.Interfaces;
using SportNutrition.Domain.ModelDb;

namespace SportNutrition.DAL.Storages;

public class UserStorage : IBaseStorage<UserDb>{
    
    private readonly ApplicationDbContext _context;
        
    public UserStorage(ApplicationDbContext context)
    {
        _context = context;
    }
    
    
    public async Task<UserDb> AddAsync(UserDb entity)
    {
        var a = await _context.Users.AddAsync(entity);
        await _context.SaveChangesAsync();
        return a.Entity;
    }

    public async Task DeleteAsync(UserDb entity)
    {
        _context.Users.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<UserDb> GetByIdAsync(Guid id)
    {
        var a = await _context.Users.FirstOrDefaultAsync(x=> x.Id == id);
        return a;
    }

    public async Task<UserDb> Update(UserDb entity)
    {
        var a =  _context.Users.Update(entity);
        await _context.SaveChangesAsync();
        return a.Entity;
    }

    public IQueryable<UserDb> GetAllAsync()
    {
        return _context.Users.AsQueryable();
    }
}