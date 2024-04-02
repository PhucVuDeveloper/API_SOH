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
    public interface ICartlistRepository : IRepository<Cartlist>
    {
        public void insertCartlist(Cartlist cartlist);
        public void updateCartlist(Cartlist cartlist);
        public void deleteCartlist(Cartlist cartlist);
    }
    public class CartlistRepository : RepositoryBase<Cartlist>, ICartlistRepository
    {
        public CartlistRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void deleteCartlist(Cartlist cartlist)
        {
            if (cartlist == null)
            {
                return;
            }
            else
            {
                _dbContext.Cartlist.Remove(cartlist);
            }
        }
        public void insertCartlist(Cartlist Cartlist)
        {
            _dbContext.Cartlist.Add(Cartlist);
        }
        public void updateCartlist(Cartlist cartlist)
        {
            if (cartlist == null)
            {
                return;
            }
            else
            {
                _dbContext.Cartlist.Update(cartlist);
            }
        }
    }
}
