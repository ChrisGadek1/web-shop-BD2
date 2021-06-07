using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BD2_projekt.Controllers
{
    public class BuyController : Controller
    {
        Context _db = new Context();
        [HttpGet]
        public IActionResult Index()
        {
            Cart cart = (from c in _db.Cart.Include(x => x.CartElements).ThenInclude(y => y.Product).Include("User") where c.User.Email == HttpContext.Session.GetString("user") select c).FirstOrDefault();

            SessionControl.setViewData(_db, ViewData, HttpContext);
            ViewData["cart"] = cart;
            return View();
        }


    }
}