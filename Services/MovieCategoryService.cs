using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videothek2.BAL;

namespace Videothek2.Services
{
    public class MovieService
    {
        #region Property
        private readonly VideothekContext _appDBContext;
        #endregion

        #region Constructor
        public MovieService(VideothekContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Article
        public async Task<List<Movie>> GetAllAsync()
        {
            return await _appDBContext.Movies.ToListAsync();
        }
        #endregion

        #region Insert User
        public async Task<bool> InsertAsync(Movie movie)
        {
            await _appDBContext.Movies.AddAsync(movie);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get User by Id
        public async Task<Movie> GetByIdAsync(int Id)
        {
            Movie movie = await _appDBContext.Movies.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return movie;
        }
        #endregion

        #region Update User
        public async Task<bool> UpdateAsync(Movie movie)
        {
            _appDBContext.Movies.Update(movie);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteUser
        public async Task<bool> DeleteAsync(Movie movie)
        {
            _appDBContext.Remove(movie);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
