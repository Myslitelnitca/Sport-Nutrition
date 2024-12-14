using Microsoft.EntityFrameworkCore;
using SportNutrition.DAL.Interfaces;
using SportNutrition.Domain.ModelDb;

namespace SportNutrition.DAL.Storages;

public class OrderStorage : IBaseStorage<OrderDb>
{
    private readonly ApplicationDbContext _context;

    public OrderStorage(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<OrderDb> AddAsync(OrderDb entity)
    {
        var a = await _context.Orders.AddAsync(entity);
        await _context.SaveChangesAsync();
        return a.Entity;
    }

    public async Task DeleteAsync(OrderDb entity)
    {
        _context.Orders.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<OrderDb> GetByIdAsync(Guid id)
    {
        return await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<OrderDb> Update(OrderDb entity)
    {
        var a = _context.Orders.Update(entity);
        await _context.SaveChangesAsync();
        return a.Entity;
    }

    public IQueryable<OrderDb> GetAllAsync()
    {
        return _context.Orders.AsQueryable();
    }
}