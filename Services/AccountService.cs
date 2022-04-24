using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videothek2.BAL;

namespace Videothek2.Services
{
    public class AccountService
    {
        #region Property
        private readonly VideothekContext _appDBContext;
        #endregion

        #region Constructor
        public AccountService(VideothekContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Article
        public async Task<List<Account>> GetAllAsync()
        {
            return await _appDBContext.Accounts.ToListAsync();
        }
        #endregion

        #region Insert User
        public async Task<bool> InsertAsync(Account account)
        {
            await _appDBContext.Accounts.AddAsync(account);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get User by Id
        public async Task<Account> GetByIdAsync(int Id)
        {
            Account account = await _appDBContext.Accounts.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return account;
        }
        #endregion

        #region Update User
        public async Task<bool> UpdateAsync(Account account)
        {
            _appDBContext.Accounts.Update(account);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteUser
        public async Task<bool> DeleteAsync(Account account)
        {
            _appDBContext.Remove(account);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
