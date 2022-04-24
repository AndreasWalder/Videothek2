using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videothek2.BAL;

namespace Videothek2.Services
{
    public class MovieCategoryService
    {
        #region Property
        private readonly VideothekContext _appDBContext;
        #endregion

        #region Constructor
        public MovieCategoryService(VideothekContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Article
        public async Task<List<MovieCategory>> GetAllAsync()
        {
            return await _appDBContext.MovieCategories.ToListAsync();
        }
        #endregion

        #region Insert User
        public async Task<bool> InsertAsync(MovieCategory movieCategory)
        {
            await _appDBContext.MovieCategories.AddAsync(movieCategory);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get User by Id
        public async Task<MovieCategory> GetByIdAsync(int Id)
        {
            MovieCategory movieCategory = await _appDBContext.MovieCategories.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return movieCategory;
        }
        #endregion

        #region Update User
        public async Task<bool> UpdateAsync(MovieCategory movieCategory)
        {
            _appDBContext.MovieCategories.Update(movieCategory);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteUser
        public async Task<bool> DeleteAsync(MovieCategory movieCategory)
        {
            _appDBContext.Remove(movieCategory);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
