using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videothek2.BAL;

namespace Videothek2.Services
{
    public class MainActressService
    {
        #region Property
        private readonly VideothekContext _appDBContext;
        #endregion

        #region Constructor
        public MainActressService(VideothekContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Article
        public async Task<List<MainActress>> GetAllAsync()
        {
            return await _appDBContext.MainActresses.ToListAsync();
        }
        #endregion

        #region Insert User
        public async Task<bool> InsertAsync(MainActress mainActress)
        {
            await _appDBContext.MainActresses.AddAsync(mainActress);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get User by Id
        public async Task<MainActress> GetByIdAsync(int Id)
        {
            MainActress mainActress = await _appDBContext.MainActresses.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return mainActress;
        }
        #endregion

        #region Update User
        public async Task<bool> UpdateAsync(MainActress mainActress)
        {
            _appDBContext.MainActresses.Update(mainActress);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteUser
        public async Task<bool> DeleteAsync(MainActress mainActress)
        {
            _appDBContext.Remove(mainActress);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
