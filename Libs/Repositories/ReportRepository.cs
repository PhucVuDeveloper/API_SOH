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
    public interface IReportRepository : IRepository<Report>
    {
        public void insertReport(Report report);
        public void updateReport(Report report);
        public void deleteReport(Report report);
    }
    public class ReportRepository : RepositoryBase<Report>, IReportRepository
    {
        public ReportRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void deleteReport(Report report)
        {
            if (report == null)
            {
                return;
            }
            else
            {
                _dbContext.Report.Remove(report);
            }
        }
        public void insertReport(Report Report)
        {
            _dbContext.Report.Add(Report);
        }
        public void updateReport(Report report)
        {
            if (report == null)
            {
                return;
            }
            else
            {
                _dbContext.Report.Update(report);
            }
        }
    }
}
