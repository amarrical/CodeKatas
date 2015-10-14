using DieCup.Business;
using DieCup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DieCup.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            return View(new DieCupModel());
        }

        public virtual ActionResult Roll(DieCupModel model)
        {
            var cup = new CupOfDice(
                model.Count,
                model.Minimum,
                model.Maximum,
                model.LoadedValue,
                model.LoadedChance);

            return PartialView(MVC.Home.Views._RollResult, cup.RollDice());
        }
    }
}