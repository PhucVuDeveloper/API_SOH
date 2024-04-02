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
    public interface IKitchenRepository : IRepository<Kitchen>
    {
        public void insertKitchen(Kitchen kitchen);
        public void updateKitchen(Kitchen kitchen);
        public void deleteKitchen(Kitchen kitchen);
    }
    public class KitchenRepository : RepositoryBase<Kitchen>, IKitchenRepository
    {
        public KitchenRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void deleteKitchen(Kitchen kitchen)
        {
            if (kitchen == null)
            {
                return;
            }
            else
            {
                _dbContext.Kitchen.Remove(kitchen);
            }
        }
        public void insertKitchen(Kitchen Kitchen)
        {
            _dbContext.Kitchen.Add(Kitchen);
        }
        public void updateKitchen(Kitchen kitchen)
        {
            if (kitchen == null)
            {
                return;
            }
            else
            {
                _dbContext.Kitchen.Update(kitchen);
            }
        }
    }
}
