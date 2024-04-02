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
    public interface ICashierRepository : IRepository<Cashier>
    {
        public void insertCashier(Cashier cashier);
        public void updateCashier(Cashier cashier);
        public void deleteCashier(Cashier cashier);
    }
    public class CashierRepository : RepositoryBase<Cashier>, ICashierRepository
    {
        public CashierRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public void deleteCashier(Cashier cashier)
        {
            if (cashier == null)
            {
                return;
            }
            else
            {
                _dbContext.Cashier.Remove(cashier);
            }
        }

        public void insertCashier(Cashier cashier)
        {
            _dbContext.Cashier.Add(cashier);
        }

        public void updateCashier(Cashier cashier)
        {
            if(cashier == null)
            {
                return;
            }
            else
            {
                _dbContext.Cashier.Update(cashier);
            }
        }
    }
}
