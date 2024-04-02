using Libs.Data;
using Libs.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Repositories
{
    public interface IAccountRepository : IRepository<Account>
    {
        public void insertAccount(Account account);
        public void updateAccount(Account account);
        public void deleteAccount(Account account);
    }
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void deleteAccount(Account account)
        {
            if (account == null)
            {
                return;
            }
            else
            {
                _dbContext.Account.Remove(account);
            }
        }
        public void insertAccount(Account Account)
        {
            _dbContext.Account.Add(Account);
        }
        public void updateAccount(Account account)
        {
            if (account == null)
            {
                return;
            }
            else
            {
                _dbContext.Account.Update(account);
            }
        }
    }
}
