using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestYourMight.Data.Interfaces;
using TestYourMight.ViewModels;

namespace TestYourMight.Controllers
{
    public class DealsController : Controller
    {
        private readonly IDeals _allDeals;
        private readonly IGames _allGames;

        public DealsController(IDeals iDeals, IGames iGames)
        {
            _allDeals = iDeals;
            _allGames = iGames;
        }

        public ViewResult DealsList()
        {
            ViewBag.Title = "Deals Page";
            DealsListViewModel obj = new DealsListViewModel();
            obj.AllDeals = _allDeals.getAll;
            obj.currGame = "Games";
            return View(obj);
        }
    }
}
