using Data.Context;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MyContext context;
        private DbSet<T> dataSet;

        public BaseRepository(MyContext context)
        {
            this.context = context;
            dataSet = context.Set<T>();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try 
            {
                var entity = await dataSet.FirstOrDefaultAsync(entity => entity.id == id);
                context.Remove(entity);
                return await context.SaveChangesAsync() > 0;
            }catch (Exception ex) 
            {
                throw ex;
            }
            
        }

        public async Task<T> InsertAsync(T entity)
        {
            try 
            {
                if(entity != null) 
                {
                    dataSet.Add(entity);
                    if (await context.SaveChangesAsync() > 0)
                        return entity;
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            entity = null;
            return entity;
        }

        public async Task<T> SelectAsync(Guid id)
        {
            
            try 
            {
                
                return await dataSet.AsNoTracking().FirstOrDefaultAsync(entity => entity.id == id);
                
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<List<T>> SelectAsync()
        {
            try 
            {
                return await dataSet.AsNoTracking().ToListAsync();
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try 
            {
                if(entity != null) 
                {
                    var result = await dataSet.AsNoTracking().FirstOrDefaultAsync(item => item.id == entity.id);
                    if(result != null) 
                    {
                        entity.updateDate = DateTime.Now;
                        context.Update<T>(entity);
                        await context.SaveChangesAsync();
                    }
                }
            }catch (Exception ex) 
            {
                throw ex;
            }
            return entity;
        }
    }
}
