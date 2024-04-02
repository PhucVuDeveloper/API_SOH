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
    public interface IStaffRepository : IRepository<Staff>
    {
        public void insertStaff(Staff staff);
        public void updateStaff(Staff staff);
        public void deleteStaff(Staff staff);
    }
    public class StaffRepository : RepositoryBase<Staff>, IStaffRepository
    {
        public StaffRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void deleteStaff(Staff staff)
        {
            if (staff == null)
            {
                return;
            }
            else
            {
                _dbContext.Staff.Remove(staff);
            }
        }
        public void insertStaff(Staff staff)
        {
            _dbContext.Staff.Add(staff);
        }
        public void updateStaff(Staff staff)
        {
            if (staff == null)
            {
                return;
            }
            else
            {
                _dbContext.Staff.Update(staff);
            }
        }
    }
}
