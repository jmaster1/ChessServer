using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chess.Model;

namespace ChessServer.Controllers
{
    public class HomeController : Controller
    {
        private Desk desk = new Desk();
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            desk.CreateMap();
            var piece = desk.GetPieceAt(Vector2Int.Zero);
            ViewBag.Message = "Your application description page." + piece.GetPieceType();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}