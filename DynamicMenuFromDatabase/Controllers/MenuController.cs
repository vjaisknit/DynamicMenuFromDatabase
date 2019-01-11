using DynamicMenuFromDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicMenuFromDatabase.Controllers
{
    public class MenuController : Controller
    {
        DatabaseContexts _db = new DatabaseContexts();
        MenuMst menu = new MenuMst();
       public PartialViewResult GenerateMenu()
        {
            var menuList = _db.MenuMsts.ToList();
            var menuForDisplay = menu.MenuTree(menuList, null);
            return PartialView("GenerateMenu", menuForDisplay);
        }
    }
}