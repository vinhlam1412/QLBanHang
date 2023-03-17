﻿using AspNetCoreHero.ToastNotification.Abstractions;
using EShop.Extension;
using EShop.Helpper;
using EShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AdminAccountsController : Controller
    {
        private readonly EcommerceVer2Context _context;
        public INotyfService _notyfService { get; }

        public AdminAccountsController(EcommerceVer2Context context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminAccounts
        public async Task<IActionResult> Index()
        {
            //Đổ dữ liệu vào ViewData
            ViewData["AccessType"] = new SelectList(_context.Roles, "RoleId", "Descriptions");

            //Custom dữ liệu trước khi đổ vào ViewData
            List<SelectListItem> _Status = new List<SelectListItem>();
            _Status.Add(new SelectListItem() { Text = "Active", Value = "1" });
            _Status.Add(new SelectListItem() { Text = "Disable", Value = "0" });
            ViewData["Status"] = _Status;

            var ecommerceVer2Context = _context.Accounts.Include(a => a.Role);
            return View(await ecommerceVer2Context.ToListAsync());
        }

        // GET: Admin/AdminAccounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.Role)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Admin/AdminAccounts/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "Descriptions");
            return View();
        }

        // POST: Admin/AdminAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Username,Password,Email,FullName,Phone,CreateDate,LastLogin,RoleId,IsActived,CartId,Randomkey")] Account account)
        {
            if (ModelState.IsValid)
            {
                var _account = from m in _context.Accounts.Include(a => a.Role) select m;
                if (_account.Any(a => a.Username == account.Username))
                {
                    _notyfService.Error("Tên tài khoản đã được sử dụng");
                    return RedirectToAction(nameof(Create));
                }
                string RandomKey = Utilities.GetRandomKey();
                account.Password = (account.Password + RandomKey.Trim()).PassToMD5();
                account.Randomkey = RandomKey;
                _context.Add(account);
                _notyfService.Success("Thêm thành công!");
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "Descriptions", account.RoleId);
            return View(account);
        }

        // GET: Admin/AdminAccounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "Descriptions", account.RoleId);
            return View(account);
        }

        // POST: Admin/AdminAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Username,Password,Email,FullName,Phone,CreateDate,LastLogin,RoleId,IsActived,CartId,Randomkey")] Account account)
        {
            if (id != account.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var _Account = _context.Accounts.AsNoTracking().SingleOrDefault(x => x.UserId == account.UserId);
                    string newpass = (account.Password.Trim() + _Account.Randomkey.Trim()).PassToMD5();
                    account.Password = newpass;
                    _context.Update(account);
                    _notyfService.Success("Sửa thành công!");
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "Descriptions", account.RoleId);
            return View(account);
        }

        // GET: Admin/AdminAccounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.Role)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Admin/AdminAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Accounts.FindAsync(id);
            _context.Accounts.Remove(account);
            _notyfService.Success("Xóa thành công!");
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.UserId == id);
        }
    }
}
