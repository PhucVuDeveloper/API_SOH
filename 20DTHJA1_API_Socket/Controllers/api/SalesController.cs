using _20DTHJA1_API_Socket.Models;
using Google.Api.Ads.AdWords.v201809;
using Libs.Entities;
using Libs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Data.Common;
using ProductImage = _20DTHJA1_API_Socket.Models.ProductImage;

namespace _20DTHJA1_API_Socket.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private ProductService productService;

        public SalesController(ProductService productService)
        {
            this.productService = productService;
        }

        //Staff
        [HttpPost]
        [Route("update-staff")]
        //string id, string name, decimal price , string url , string groupName
        public IActionResult updateStaff(StaffModel staffModel)
        {
            Staff Stafft = productService.GetStaffById_G(staffModel.IdStaff); // Đảm bảo rằng bạn có một phương thức để lấy sản phẩm dựa trên id


            if (Stafft == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại!! " });
            }
            Stafft.NameStaff = staffModel.NameStaff;
            Stafft.PhoneNum = staffModel.PhoneNum;
            Stafft.Address = staffModel.Address;
            Stafft.Role = staffModel.Role;
            productService.updateStaff(Stafft);
            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("delete-staff")]
        public IActionResult deleteStaff(string idstaff)
        {

            Staff staffToDelete = productService.GetStaffById_S(idstaff);

            if (staffToDelete == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại " });
            }

            productService.deleteStaff(staffToDelete);

            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("insert-staff")]
        public IActionResult insertStaffv1(StaffModel staffModel)
        {
            Staff sta = new Staff();
            sta.IdStaff = Guid.NewGuid();
            sta.NameStaff = staffModel.NameStaff;
            sta.PhoneNum = staffModel.PhoneNum;
            sta.Address = staffModel.Address;
            sta.Role = staffModel.Role;
            productService.insertStaff(sta);
            return Ok(new { status = true, message = "" });
        }

        [HttpGet]
        [Route("get-allstaff-list")]
        public IActionResult getAllStaffList()
        {
            List<Staff> staffList = productService.getStaffss();
            return Ok(new { status = true, message = "", data = staffList });
        }

        [HttpGet]
        [Route("get-staff-list")]
        public IActionResult getStaffList(string Role)
        {
            List<Staff> staffList = productService.getStaffs(Role);
            return Ok(new { status = true, message = "", data = staffList });
        }

        //Tables
        [HttpPost]
        [Route("update-tables")]
        //string id, string name, decimal price , string url , string groupName
        public IActionResult updateTables(TableNumberModel tablenumberModel)
        {
            TableNumber Tablest = productService.GetTablesById_G(tablenumberModel.IdTable); // Đảm bảo rằng bạn có một phương thức để lấy sản phẩm dựa trên id


            if (Tablest == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại!! " });
            }
            Tablest.TableNum = tablenumberModel.TableNum;
            Tablest.TableStatus = tablenumberModel.TableStatus;
            Tablest.Floor = tablenumberModel.Floor;
            productService.updateTables(Tablest);
            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("delete-tables")]
        public IActionResult deleteTables(string idtable)
        {

            TableNumber tablesToDelete = productService.GetTablesById_S(idtable);

            if (tablesToDelete == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại " });
            }

            productService.deleteTables(tablesToDelete);

            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("insert-tables")]
        public IActionResult insertTablesv1(TableNumberModel tablenumberModel)
        {
            TableNumber tab = new TableNumber();
            tab.IdTable = Guid.NewGuid();
            tab.TableNum = tablenumberModel.TableNum;
            tab.TableStatus = tablenumberModel.TableStatus;
            tab.Floor = tablenumberModel.Floor;
            productService.insertTables(tab);
            return Ok(new { status = true, message = "" });
        }

        [HttpGet]
        [Route("get-alltables-list")]
        public IActionResult getAllTablesList()
        {
            List<TableNumber> tablesList = productService.getTablesss();
            return Ok(new { status = true, message = "", data = tablesList });
        }

        [HttpGet]
        [Route("get-tables-list")]
        public IActionResult getTablesList(int Floor)
        {
            List<TableNumber> tablesList = productService.getTabless(Floor);
            return Ok(new { status = true, message = "", data = tablesList });
        }
        [HttpGet]
        [Route("get-tablesnumber-list")]
        public IActionResult getTablesNumList(int TableNum)
        {
            List<TableNumber> tablesList = productService.getTablessNum(TableNum);
            return Ok(new { status = true, message = "", data = tablesList });
        }
        [HttpGet]
        [Route("get-tablesstatus-list")]
        public IActionResult getTablesStatusList(int TableStatus)
        {
            List<TableNumber> tablesList = productService.getTablessStatus(TableStatus);
            return Ok(new { status = true, message = "", data = tablesList });
        }

        //Account
        [HttpPost]
        [Route("update-account")]
        //string id, string name, decimal price , string url , string groupName
        public IActionResult updateAccount(AccountModel accountModel)
        {
            Account Accountt = productService.GetAccountById_G(accountModel.IdAcc); // Đảm bảo rằng bạn có một phương thức để lấy sản phẩm dựa trên id


            if (Accountt == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại!! " });
            }
            Accountt.AccountName = accountModel.AccountName;
            Accountt.Password = accountModel.Password;
            Accountt.Permission = accountModel.Permission;
            productService.updateAccount(Accountt);
            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("delete-account")]
        public IActionResult deleteAccount(string idacc)
        {

            Account accountToDelete = productService.GetAccountById_S(idacc);

            if (accountToDelete == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại " });
            }

            productService.deleteAccount(accountToDelete);

            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("insert-account")]
        public IActionResult insertAccountv1(AccountModel accountModel)
        {
            Account acc = new Account();
            acc.IdAcc = Guid.NewGuid();
            acc.AccountName = accountModel.AccountName;
            acc.Password = accountModel.Password;
            acc.Permission = accountModel.Permission;
            productService.insertAccount(acc);
            return Ok(new { status = true, message = "" });
        }

        [HttpGet]
        [Route("get-allaccount-list")]
        public IActionResult getAllAccountList()
        {
            List<Account> accountList = productService.getAccountss();
            return Ok(new { status = true, message = "", data = accountList });
        }

        [HttpGet]
        [Route("get-account-list")]
        public IActionResult getAccountList(int Permission)
        {
            List<Account> accountList = productService.getAccounts(Permission);
            return Ok(new { status = true, message = "", data = accountList });
        }



        //Product
        [HttpPost]
        [Route("update-product")]
        //string id, string name, decimal price , string url , string groupName
        public async  Task<IActionResult> updateProductAsync( [FromForm] ProductImage p )
        {
            Product Productt = productService.GetProductById_G(p.IdProduct); // Đảm bảo rằng bạn có một phương thức để lấy sản phẩm dựa trên id
            if (Productt == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại!! " });
            }
            //Productt.ProductName = productModel.ProductName;//
            //Productt.ProductPrice = productModel.ProductPrice;
            //Productt.ProductType = productModel.ProductType;
            //Productt.ImageUrl = productModel.ImageUrl;
            //Productt.ProductQuantity = productModel.ProductQuantity;
            //Productt.ProductStatus = productModel.ProductStatus;

            Productt.ProductName = p.ProductName;
            Productt.ProductPrice = p.ProductPrice;
            Productt.ProductType = p.ProductType;
            Productt.ProductQuantity = p.ProductQuantity;
            Productt.ProductStatus = p.ProductStatus;
            if (p.Image.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", p.Image.FileName);
                using (var stream = System.IO.File.Create(path))
            {
                    await p.Image.CopyToAsync(stream);
                }
                Productt.ImageUrl = "/images/" + p.Image.FileName;
            }
            else
            {
               Productt.ImageUrl = "";
            }
            productService.updateProduct(Productt);
            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("delete-product")]
        public IActionResult deleteProduct(string idproduct)
        {

            Product productToDelete = productService.GetProductById_S(idproduct);

            if (productToDelete == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại " });
            }

            productService.deleteProduct(productToDelete);

            return Ok(new { status = true, message = "" });
        }


        [HttpPost]
        [Route("insert-product")]
        public IActionResult insertProductv1(ProductModel productModel)
        {
            Product pro = new Product();
            pro.IdProduct = Guid.NewGuid();
            pro.ProductName = productModel.ProductName;
            pro.ProductPrice = productModel.ProductPrice;          
            pro.ImageUrl = productModel.ImageUrl;
            pro.ProductType = productModel.ProductType;
            pro.ProductQuantity = productModel.ProductQuantity;
            pro.ProductStatus = productModel.ProductStatus;
            productService.insertProduct(pro);
            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("insert-product-image")]
        public async Task<IActionResult> PostWithImageAsync([FromForm] ProductImage p)
        {
                Product t = new Product();
                t.IdProduct = Guid.NewGuid();
                t.ProductName = p.ProductName;
                t.ProductPrice = p.ProductPrice;
                t.ProductType = p.ProductType;
                t.ProductQuantity = p.ProductQuantity;
                t.ProductStatus = p.ProductStatus;
            if (p.Image.Length > 0)
                {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", p.Image.FileName);
                    using (var stream = System.IO.File.Create(path))
                    {
                        await p.Image.CopyToAsync(stream);
                    }
                    t.ImageUrl = "/images/" + p.Image.FileName;
                }
                else
                {
                    t.ImageUrl = "";
                }
                productService.insertProduct(t);
                return Ok(new { status = true, message = "" });
        }

        [HttpGet]
        [Route("get-allproduct-list")]
        public IActionResult getAllProductList()
        {
            List<Product> productList = productService.getProductss();
            return Ok(new { status = true, message = "", data = productList });
        }

        [HttpGet]
        [Route("get-product-list")]
        public IActionResult getProductList(int ProductType)
        {
            List<Product> productList = productService.getProducts(ProductType);
            return Ok(new { status = true, message = "", data = productList });
        }

        //Kitchen
        [HttpPost]
        [Route("update-kitchen")]
        //string id, string name, decimal price , string url , string groupName
        public IActionResult updateKitchen(KitchenModel kitchenModel)
        {
            Kitchen kitchenn = productService.GetKitchenById_G(kitchenModel.IdKitchen); // Đảm bảo rằng bạn có một phương thức để lấy sản phẩm dựa trên id


            if (kitchenn == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại!! " });
            }
            kitchenn.ProductName = kitchenModel.ProductName;
            kitchenn.ProductPrice = kitchenModel.ProductPrice;
            kitchenn.ImageUrl = kitchenModel.ImageUrl;
            kitchenn.TableNum = kitchenModel.TableNum;
            kitchenn.ProductQuantity = kitchenModel.ProductQuantity;
            kitchenn.ProductNote = kitchenModel.ProductNote;
            productService.updateKitchen(kitchenn);
            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("delete-kitchen")]
        public IActionResult deleteKitchen(string idkitchen)
        {

            Kitchen kitchenToDelete = productService.GetKitchenById_S(idkitchen);

            if (kitchenToDelete == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại " });
            }

            productService.deleteKitchen(kitchenToDelete);

            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("insert-kitchen")]
        public IActionResult insertKitchenv1(KitchenModel kitchenModel)
        {
            Kitchen kitch = new Kitchen();
            kitch.IdKitchen = Guid.NewGuid();
            kitch.ProductName = kitchenModel.ProductName;
            kitch.ProductPrice = kitchenModel.ProductPrice;
            kitch.ImageUrl = kitchenModel.ImageUrl;
            kitch.CreatedNumber = kitchenModel.CreatedNumber;
            kitch.TableNum = kitchenModel.TableNum;
            kitch.ProductQuantity = kitchenModel.ProductQuantity;
            kitch.ProductNote = kitchenModel.ProductNote;
            productService.insertKitchen(kitch);
            return Ok(new { status = true, message = "" });
        }

        [HttpGet]
        [Route("get-kitchen-list")]
        public IActionResult getKitchenList(int TableNum)
        {
            List<Kitchen> kitchenList = productService.getKitchens(TableNum);
            return Ok(new { status = true, message = "", data = kitchenList });
        }

        [HttpGet]
        [Route("get-allkitchen-list")]
        public IActionResult getAllKichenList()
        {
            List<Kitchen> kitchenList = productService.getKitchenss();
            return Ok(new { status = true, message = "", data = kitchenList });
        }

        //Cashier
        [HttpPost]
        [Route("update-cashier")]
        //string id, string name, decimal price , string url , string groupName
        public IActionResult updateCashier(CashierModel cashierModel)
        {
            Cashier Cashiert = productService.GetCashierById_G(cashierModel.IdCashier); // Đảm bảo rằng bạn có một phương thức để lấy sản phẩm dựa trên id


            if (Cashiert == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại!! " });
            }
            Cashiert.ProductName = cashierModel.ProductName;
            Cashiert.ProductPrice = cashierModel.ProductPrice;
            Cashiert.ProductQuantity = cashierModel.ProductQuantity;
            Cashiert.TableNum = cashierModel.TableNum;
            productService.updateCashier(Cashiert);
            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("delete-cashier")]
        public IActionResult deleteCashier(string idcashier)
        {

            Cashier cashierToDelete = productService.GetCashierById_S(idcashier);

            if (cashierToDelete == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại " });
            }

            productService.deleteCashier(cashierToDelete);

            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("insert-cashier")]
        public IActionResult insertCashierv1(CashierModel cashierModel)
        {
            Cashier cas = new Cashier();
            cas.IdCashier = Guid.NewGuid();
            cas.ProductName = cashierModel.ProductName;
            cas.ProductPrice = cashierModel.ProductPrice;
            cas.ProductQuantity = cashierModel.ProductQuantity;
            cas.TableNum = cashierModel.TableNum;
            productService.insertCashier(cas);
            return Ok(new { status = true, message = "" });
        }

        [HttpGet]
        [Route("get-allcashier-list")]
        public IActionResult getAllCashierList()
        {
            List<Cashier> cashierList = productService.getCashierss();
            return Ok(new { status = true, message = "", data = cashierList });
        }

        [HttpGet]
        [Route("get-cashier-list")]
        public IActionResult getCashierList(int TableNum)
        {
            List<Cashier> cashierList = productService.getCashiers(TableNum);
            return Ok(new { status = true, message = "", data = cashierList });
        }

        //Cartlist
        [HttpPost]
        [Route("update-cartlist")]
        //string id, string name, decimal price , string url , string groupName
        public IActionResult updateCartlist(CartlistModel cartlistModel)
        {
            Cartlist Cartlistt = productService.GetCartlistById_G(cartlistModel.IdCart); // Đảm bảo rằng bạn có một phương thức để lấy sản phẩm dựa trên id


            if (Cartlistt == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại!! " });
            }
            Cartlistt.ProductName = cartlistModel.ProductName;
            Cartlistt.ProductPrice = cartlistModel.ProductPrice;
            Cartlistt.ImageUrl = cartlistModel.ImageUrl;
            Cartlistt.ProductQuantity = cartlistModel.ProductQuantity;
            Cartlistt.TableNum = cartlistModel.TableNum;
            productService.updateCartlist(Cartlistt);
            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("delete-cartlist")]
        public IActionResult deleteCartlist(string idcartlist)
        {

            Cartlist cartlistToDelete = productService.GetCartlistById_S(idcartlist);

            if (cartlistToDelete == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại " });
            }

            productService.deleteCartlist(cartlistToDelete);

            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("insert-cartlist")]
        public IActionResult insertCartlistv1(CartlistModel cartlistModel)
        {
            Cartlist car = new Cartlist();
            car.IdCart = Guid.NewGuid();
            car.ProductName = cartlistModel.ProductName;
            car.ProductPrice = cartlistModel.ProductPrice;
            car.ImageUrl = cartlistModel.ImageUrl;
            car.ProductQuantity = cartlistModel.ProductQuantity;
            car.TableNum = cartlistModel.TableNum;
            productService.insertCartlist(car);
            return Ok(new { status = true, message = "" });
        }

        [HttpGet]
        [Route("get-allcartlist-list")]
        public IActionResult getAllCartlistList()
        {
            List<Cartlist> cartlistList = productService.getCartlistss();
            return Ok(new { status = true, message = "", data = cartlistList });
        }

        [HttpGet]
        [Route("get-cartlist-list")]
        public IActionResult getCartlistList(int TableNum)
        {
            List<Cartlist> cartlistList = productService.getCartlists(TableNum);
            return Ok(new { status = true, message = "", data = cartlistList });
        }

        //Report
        [HttpPost]
        [Route("update-report")]
        //string id, string name, decimal price , string url , string groupName
        public IActionResult updateReport(ReportModel reportModel)
        {
            Report Reportt = productService.GetReportById_G(reportModel.IdRep); // Đảm bảo rằng bạn có một phương thức để lấy sản phẩm dựa trên id


            if (Reportt == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại!! " });
            }
            Reportt.ProductName = reportModel.ProductName;
            Reportt.ProductPrice = reportModel.ProductPrice;
            Reportt.ProductQuantity = reportModel.ProductQuantity;
            Reportt.ReportDate = reportModel.ReportDate;
            productService.updateReport(Reportt);
            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("delete-report")]
        public IActionResult deleteReport(string idreport)
        {

            Report reportToDelete = productService.GetReportById_S(idreport);

            if (reportToDelete == null)
            {
                return NotFound(new { status = false, message = "Sản phẩm không tồn tại " });
            }

            productService.deleteReport(reportToDelete);

            return Ok(new { status = true, message = "" });
        }

        [HttpPost]
        [Route("insert-report")]
        public IActionResult insertReportv1(ReportModel reportModel)
        {
            Report rep = new Report();
            rep.IdRep = Guid.NewGuid();
            rep.ProductName = reportModel.ProductName;
            rep.ProductPrice = reportModel.ProductPrice;
            rep.ProductQuantity = reportModel.ProductQuantity;
            rep.ReportDate = reportModel.ReportDate;
            productService.insertReport(rep);
            return Ok(new { status = true, message = "" });
        }

        [HttpGet]
        [Route("get-allreport-list")]
        public IActionResult getAllReportList()
        {
            List<Report> reportList = productService.getReportss();
            return Ok(new { status = true, message = "", data = reportList });
        }

        [HttpGet]
        [Route("get-report-list")]
        public IActionResult getReportList(string ReportDate)
        {
            List<Report> reportList = productService.getReports(ReportDate);
            return Ok(new { status = true, message = "", data = reportList });
        }
    }
}
