using Libs.Entities;
using Libs.Repositories;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Services
{
    public class ProductService
    {
        private ApplicationDbContext dbContext;
        private IProductRepository productRepository;
        private IKitchenRepository kitchenRepository;
        private IAccountRepository accountRepository;
        private ITablesRepository tablesRepository;
        private ICashierRepository cashierRepository;
        private IStaffRepository staffRepository;
        private ICartlistRepository cartlistRepository;
        private IReportRepository reportRepository;

        public ProductService(ApplicationDbContext dbContext) { 
            this.dbContext = dbContext; 
            this.productRepository = new ProductRepository(dbContext);
            this.kitchenRepository = new KitchenRepository(dbContext);
            this.accountRepository = new AccountRepository(dbContext);
            this.tablesRepository = new TableNumberRepository(dbContext);
            this.cashierRepository = new CashierRepository(dbContext);
            this.staffRepository = new StaffRepository(dbContext);
            this.cartlistRepository = new CartlistRepository(dbContext);
            this.reportRepository = new ReportRepository(dbContext);
        }
        public void Save() { 
            this.dbContext.SaveChanges();
        }
        
        //Product
        public void insertProduct(Product product)
        {
            productRepository.insertProduct(product);
            Save();
        }
        public void updateProduct(Product product)
        {
            if(product != null)
            {
                productRepository.updateProduct(product);
                Save();
            }
        }
        public void deleteProduct(Product product)
        {
            if(product != null)
            {
                productRepository.deleteProduct(product);
                Save();
            }
        }

        public Product GetProductById_G(Guid idproduct)

        {

                return dbContext.Product.FirstOrDefault(p => p.IdProduct == idproduct);
            


        }
        public Product GetProductById_S(string id)
        {
            if (Guid.TryParse(id, out Guid guidId))
            {
                return dbContext.Product.FirstOrDefault(p => p.IdProduct == guidId);
            }
            else
            {
                return null;
            }

        }
        public List<Product> getProducts(int ProductType)
        {
            //return dbContext.Product.ToList();
            List<Product> products = dbContext.Product.Where(s => s.ProductType == ProductType).ToList();
            return products;
        }

        public List<Product> getProductss()
        {
            return dbContext.Product.ToList();
        }

        //Kitchen
        public void insertKitchen(Kitchen kitchen)
        {
            kitchenRepository.insertKitchen(kitchen);
            Save();
        }
        public void updateKitchen(Kitchen kitchen)
        {
            if (kitchen != null)
            {
                kitchenRepository.updateKitchen(kitchen);
                Save();
            }
        }
        public void deleteKitchen(Kitchen kitchen)
        {
            if (kitchen != null)
            {
                kitchenRepository.deleteKitchen(kitchen);
                Save();
            }
        }

        public Kitchen GetKitchenById_G(Guid idkitchen)

        {
            return dbContext.Kitchen.FirstOrDefault(p => p.IdKitchen == idkitchen);

        }
        public Kitchen GetKitchenById_S(string idkitchen)
        {
            if (Guid.TryParse(idkitchen, out Guid guidId))
            {
                return dbContext.Kitchen.FirstOrDefault(p => p.IdKitchen == guidId);
            }
            else
            {
                return null;
            }

        }
        public List<Kitchen> getKitchens(int TableNum)
        {
            //return dbContext.Kitchen.ToList();
            List<Kitchen> kitchens = dbContext.Kitchen.Where(s => s.TableNum == TableNum).ToList();
            return kitchens;
        }

        public List<Kitchen> getKitchenss()
        {
            return dbContext.Kitchen.ToList();
        }

        //Account
        public void insertAccount(Account account)
        {
            accountRepository.insertAccount(account);
            Save();
        }
        public void updateAccount(Account account)
        {
            if (account != null)
            {
                accountRepository.updateAccount(account);
                Save();
            }
        }
        public void deleteAccount(Account account)
        {
            if (account != null)
            {
                accountRepository.deleteAccount(account);
                Save();
            }
        }

        public Account GetAccountById_G(Guid idacc)

        {
            return dbContext.Account.FirstOrDefault(p => p.IdAcc == idacc);

        }
        public Account GetAccountById_S(string idacc)
        {
            if (Guid.TryParse(idacc, out Guid guidId))
            {
                return dbContext.Account.FirstOrDefault(p => p.IdAcc == guidId);
            }
            else
            {
                return null;
            }

        }
        public List<Account> getAccounts(int Permission)
        {
            //return dbContext.Kitchen.ToList();
            List<Account> accounts = dbContext.Account.Where(s => s.Permission == Permission).ToList();
            return accounts;
        }

        public List<Account> getAccountss()
        {
            return dbContext.Account.ToList();
        }

        //TableNumber
        public void insertTables(TableNumber tables)
        {
            tablesRepository.insertTables(tables);
            Save();
        }
        public void updateTables(TableNumber tables)
        {
            if (tables != null)
            {
                tablesRepository.updateTables(tables);
                Save();
            }
        }
        public void deleteTables(TableNumber tables)
        {
            if (tables != null)
            {
                tablesRepository.deleteTables(tables);
                Save();
            }
        }

        public TableNumber GetTablesById_G(Guid idtable)

        {
            return dbContext.TableNumber.FirstOrDefault(p => p.IdTable == idtable);

        }
        public TableNumber GetTablesById_S(string idtable)
        {
            if (Guid.TryParse(idtable, out Guid guidId))
            {
                return dbContext.TableNumber.FirstOrDefault(p => p.IdTable == guidId);
            }
            else
            {
                return null;
            }

        }
        public List<TableNumber> getTabless(int Floor)
        {
            //return dbContext.Kitchen.ToList();
            List<TableNumber> tabless = dbContext.TableNumber.Where(s => s.Floor == Floor).ToList();
            return tabless;
        }
        public List<TableNumber> getTablessNum(int TableNum)
        {
            //return dbContext.Kitchen.ToList();
            List<TableNumber> tabless = dbContext.TableNumber.Where(s => s.TableNum == TableNum).ToList();
            return tabless;
        }
        public List<TableNumber> getTablessStatus(int TableStatus)
        {
            //return dbContext.Kitchen.ToList();
            List<TableNumber> tabless = dbContext.TableNumber.Where(s => s.TableStatus == TableStatus).ToList();
            return tabless;
        }

        public List<TableNumber> getTablesss()
        {
            return dbContext.TableNumber.ToList();
        }

        //Cashier
        public void insertCashier(Cashier cashier)
        {
            cashierRepository.insertCashier(cashier);
            Save();
        }
        public void updateCashier(Cashier cashier)
        {
            if (cashier != null)
            {
                cashierRepository.updateCashier(cashier);
                Save();
            }
        }
        public void deleteCashier(Cashier cashier)
        {
            if (cashier != null)
            {
                cashierRepository.deleteCashier(cashier);
                Save();
            }
        }

        public Cashier GetCashierById_G(Guid idcashier)

        {
            return dbContext.Cashier.FirstOrDefault(p => p.IdCashier == idcashier);

        }
        public Cashier GetCashierById_S(string idcashier)
        {
            if (Guid.TryParse(idcashier, out Guid guidId))
            {
                return dbContext.Cashier.FirstOrDefault(p => p.IdCashier == guidId);
            }
            else
            {
                return null;
            }

        }
        public List<Cashier> getCashiers(int TableNum)
        {
            //return dbContext.Kitchen.ToList();
            List<Cashier> cashiers = dbContext.Cashier.Where(s => s.TableNum == TableNum).ToList();
            return cashiers;
        }

        public List<Cashier> getCashierss()
        {
            return dbContext.Cashier.ToList();
        }

        //Staff
        public void insertStaff(Staff staff)
        {
            staffRepository.insertStaff(staff);
            Save();
        }
        public void updateStaff(Staff staff)
        {
            if (staff != null)
            {
                staffRepository.updateStaff(staff);
                Save();
            }
        }
        public void deleteStaff(Staff staff)
        {
            if (staff != null)
            {
                staffRepository.deleteStaff(staff);
                Save();
            }
        }

        public Staff GetStaffById_G(Guid idstaff)

        {
            return dbContext.Staff.FirstOrDefault(p => p.IdStaff == idstaff);

        }
        public Staff GetStaffById_S(string idstaff)
        {
            if (Guid.TryParse(idstaff, out Guid guidId))
            {
                return dbContext.Staff.FirstOrDefault(p => p.IdStaff == guidId);
            }
            else
            {
                return null;
            }

        }
        public List<Staff> getStaffs(string Role)
        {
            //return dbContext.Kitchen.ToList();
            List<Staff> staffs = dbContext.Staff.Where(s => s.Role.ToLower().Trim() == Role.ToLower().Trim()).ToList();
            return staffs;
        }

        public List<Staff> getStaffss()
        {
            return dbContext.Staff.ToList();
        }

        //Cartlist
        public void insertCartlist(Cartlist cartlist)
        {
            cartlistRepository.insertCartlist(cartlist);
            Save();
        }
        public void updateCartlist(Cartlist cartlist)
        {
            if (cartlist != null)
            {
                cartlistRepository.updateCartlist(cartlist);
                Save();
            }
        }
        public void deleteCartlist(Cartlist cartlist)
        {
            if (cartlist != null)
            {
                cartlistRepository.deleteCartlist(cartlist);
                Save();
            }
        }

        public Cartlist GetCartlistById_G(Guid idcartlist)

        {
            return dbContext.Cartlist.FirstOrDefault(p => p.IdCart == idcartlist);

        }
        public Cartlist GetCartlistById_S(string idcartlist)
        {
            if (Guid.TryParse(idcartlist, out Guid guidId))
            {
                return dbContext.Cartlist.FirstOrDefault(p => p.IdCart == guidId);
            }
            else
            {
                return null;
            }

        }
        public List<Cartlist> getCartlists(int TableNum)
        {
            //return dbContext.Kitchen.ToList();
            List<Cartlist> cartlists = dbContext.Cartlist.Where(s => s.TableNum == TableNum).ToList();
            return cartlists;
        }

        public List<Cartlist> getCartlistss()
        {
            return dbContext.Cartlist.ToList();
        }

        //Report
        public void insertReport(Report report)
        {
            reportRepository.insertReport(report);
            Save();
        }
        public void updateReport(Report report)
        {
            if (report != null)
            {
                reportRepository.updateReport(report);
                Save();
            }
        }
        public void deleteReport(Report report)
        {
            if (report != null)
            {
                reportRepository.deleteReport(report);
                Save();
            }
        }

        public Report GetReportById_G(Guid idreport)

        {
            return dbContext.Report.FirstOrDefault(p => p.IdRep == idreport);

        }
        public Report GetReportById_S(string idreport)
        {
            if (Guid.TryParse(idreport, out Guid guidId))
            {
                return dbContext.Report.FirstOrDefault(p => p.IdRep == guidId);
            }
            else
            {
                return null;
            }

        }
        public List<Report> getReports(string ReportDate)
        {
            //return dbContext.Kitchen.ToList();
            List<Report> reports = dbContext.Report.Where(s => s.ReportDate.ToLower().Trim() == ReportDate.ToLower().Trim()).ToList();
            return reports;
        }

        public List<Report> getReportss()
        {
            return dbContext.Report.ToList();
        }

    }
}
