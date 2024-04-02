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
    public interface ITablesRepository : IRepository<TableNumber>
    {
        public void insertTables(TableNumber tables);
        public void updateTables(TableNumber tables);
        public void deleteTables(TableNumber tables);
    }
    public class TableNumberRepository : RepositoryBase<TableNumber>, ITablesRepository
    {
        public TableNumberRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void deleteTables(TableNumber tables)
        {
            if (tables == null)
            {
                return;
            }
            else
            {
                _dbContext.TableNumber.Remove(tables);
            }
        }
        public void insertTables(TableNumber Tables)
        {
            _dbContext.TableNumber.Add(Tables);
        }
        public void updateTables(TableNumber tables)
        {
            if (tables == null)
            {
                return;
            }
            else
            {
                _dbContext.TableNumber.Update(tables);
            }
        }
    }
}
