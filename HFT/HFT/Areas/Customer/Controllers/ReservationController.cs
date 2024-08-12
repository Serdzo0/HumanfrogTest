using Microsoft.AspNetCore.Mvc;
using HFT.DataAccess.Data;
using HFT.DataAccess.Repository.IRepository;
using HFT.Models;
using System.ComponentModel;

namespace HFT.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ReservationController : Controller
    {
        private readonly IReservationRepository ReservationRepository;
        private readonly IRoomRepository RoomRepository;

        public ReservationController(IReservationRepository db, IRoomRepository roomDb)
        {
            ReservationRepository = db;
            RoomRepository = roomDb;
        }

        public IActionResult Index()
        {

            List<RoomModel> RoomList = RoomRepository.GetAll().ToList();
            return View(RoomList);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(ReservationModel Reservation)
        {
            if (ModelState.IsValid)
            {
                ReservationRepository.Add(Reservation);
                ReservationRepository.Save();
                return RedirectToAction("Index","Home");
            }
            return View();
        }



    }
}
