﻿using Microsoft.EntityFrameworkCore;

namespace RentalMotorcycle.Data.Repositories.Generic;

public class Repository<T> (DatabaseContext context) : IRepository<T> where T : class
{
    protected readonly DatabaseContext _context;
    protected readonly DbSet<T> _dbSet = context.Set<T>();
    
    public async Task<T> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);    
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity); 
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);  
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();    
    }
}