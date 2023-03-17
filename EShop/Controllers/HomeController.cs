﻿using EShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EcommerceVer2Context _context;

        public HomeController(ILogger<HomeController> logger, EcommerceVer2Context context)
        {
            _context = context;
            _logger = logger;
        }

        public ActionResult Index()
        {
            var lstNewProduct = _context.Products
                .Include(n => n.Cate)
                .Where(n => n.IsActived && n.UnitInStock > 5)
                .OrderByDescending(n => n.DateCreated);
            ViewBag.ListNPD = lstNewProduct;

            var lstBestSeller = _context.Products
                .Include(n => n.Cate)
                .Include(n=>n.OrderDetails)
                .Where(n => n.IsActived && n.UnitInStock > 5 && n.IsBestsellers == true)
                .OrderByDescending(n => n.DateCreated);
            ViewBag.BestSeller = lstBestSeller;
            return View();
        }

        public ActionResult NPPartial()
        {
            return PartialView();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("SmartPhoneColection.html", Name = "SmartPhoneColection")]
        public IActionResult SmartPhoneColection(int? page)
        {
            var pageNo = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 6;
            var lstSmartPhone = _context.Products
                .AsNoTracking()
                .Include(a => a.Cate)
                .Where(a => a.IsActived && a.UnitInStock > 0 && a.Cate.CategoryName == "SmartPhone" && a.Homeflag == true)
                .Include(a => a.Brand)
                .OrderByDescending(a => a.DateCreated);
            PagedList<Product> model = new PagedList<Product>(lstSmartPhone, pageNo, pageSize);
            ViewBag.CurrentPage = pageNo;
            return View(model);
        }

        [Route("PhuKienColection.html", Name = "PhuKienColection")]
        public IActionResult PhuKienColection(int? page)
        {
            var pageNo = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 6;
            var lstPhuKien = _context.Products
                .AsNoTracking()
                .Include(a => a.Cate)
                .Where(a => a.IsActived && a.Cate.CategoryName == "Phụ Kiện" && a.UnitInStock > 0 && a.Homeflag == true)
                .Include(a => a.Brand)
                .OrderByDescending(a => a.DateCreated);
            PagedList<Product> model = new PagedList<Product>(lstPhuKien, pageNo, pageSize);
            ViewBag.CurrentPage = pageNo;
            return View(model);
        }

        //[Route("DiaGameColection.html", Name = "DiaGameColection")]
        //public IActionResult DiaGameColection(int? page)
        //{
        //    var pageNo = page == null || page <= 0 ? 1 : page.Value;
        //    var pageSize = 6;
        //    var lstDiaGame = _context.Products
        //        .AsNoTracking()
        //        .Include(a => a.Cate)
        //        .Where(a => a.IsActived && a.Cate.CategoryName == "Đĩa game" && a.UnitInStock > 0 && a.Homeflag == true)
        //        .Include(a => a.Brand)
        //        .OrderByDescending(a => a.DateCreated);
        //    PagedList<Product> model = new PagedList<Product>(lstDiaGame, pageNo, pageSize);
        //    ViewBag.CurrentPage = pageNo;
        //    return View(model);
        //}


        [Route("LaptopColection.html", Name = "LaptopColection")]
        public IActionResult LaptopColection(int? page)
        {
            var pageNo = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 6;
            var lstLaptop = _context.Products
                .AsNoTracking()
                .Include(a => a.Cate)
                .Where(a => a.IsActived && a.UnitInStock > 0 && a.Cate.CategoryName == "Laptop" && a.Homeflag == true)
                .Include(a => a.Brand)
                .OrderByDescending(a => a.DateCreated);
            PagedList<Product> model = new PagedList<Product>(lstLaptop, pageNo, pageSize);
            ViewBag.CurrentPage = pageNo;
            return View(model);
        }

    }
}
