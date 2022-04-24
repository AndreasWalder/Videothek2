using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videothek2.BAL;

namespace Videothek2.Services
{
    public class CategoryService
    {
        #region Property
        private readonly VideothekContext _appDBContext;
        #endregion

        #region Constructor
        public CategoryService(VideothekContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Article
        public async Task<List<Category>> GetAllAsync()
        {
            return await _appDBContext.Categories.ToListAsync();
        }
        #endregion

        #region Insert User
        public async Task<bool> InsertAsync(Category category)
        {
            await _appDBContext.Categories.AddAsync(category);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get User by Id
        public async Task<Category> GetByIdAsync(int Id)
        {
            Category category = await _appDBContext.Categories.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return category;
        }
        #endregion

        #region Update User
        public async Task<bool> UpdateAsync(Category category)
        {
            _appDBContext.Categories.Update(category);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteUser
        public async Task<bool> DeleteAsync(Category category)
        {
            _appDBContext.Remove(category);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
