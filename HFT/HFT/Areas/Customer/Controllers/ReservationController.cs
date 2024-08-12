using Microsoft.AspNetCore.Mvc;
using HFT.DataAccess.Data;
using HFT.DataAccess.Repository.IRepository;
using HFT.Models;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using HFT.Utility;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.Design;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace HFT.Areas.Customer.Controllers
{
	[Area("Customer")]
    [Authorize(Roles = SD.Role_Customer + "," + SD.Role_Admin)]
    public class ReservationController : Controller
	{
		private readonly IReservationRepository ReservationRepository;
		private readonly IRoomRepository RoomRepository;
		private readonly IEmailSender _emailSender;

		public ReservationController(IReservationRepository db, IRoomRepository roomDb, IEmailSender emailSender)
		{
			ReservationRepository = db;
			RoomRepository = roomDb;
			_emailSender = emailSender;
		}

		public IActionResult Index()
		{
			
			List<RoomModel> RoomList = RoomRepository.GetAll().ToList();

			return View(RoomList);
		}

		public IActionResult Create()
		{
			IEnumerable<SelectListItem> Rooms = RoomRepository.
			GetAll().Select(u => new SelectListItem
			{
				Text = u.Name,
				Value = u.ID.ToString()
			});
			ViewBag.RoomList = Rooms;
			return View();
		}
		[HttpPost]
		public IActionResult Create(ReservationModel Reservation)
		{
			IEnumerable<SelectListItem> Rooms = RoomRepository.
			GetAll().Select(u => new SelectListItem
			{
				Text = u.Name,
				Value = u.ID.ToString()
			});
			ViewBag.RoomList = Rooms;

			if (ModelState.IsValid)
			{
				
				RoomModel? izbranaSoba = RoomRepository.GetFirstOrDefault(u => u.ID == Reservation.RoomID);
				var totalDays = (Reservation.CheckOut - Reservation.CheckIn).Days;
				var totalPrice = totalDays * izbranaSoba.Cena;
                _emailSender.SendEmailAsync(Reservation.Email, "Hvala za vašo rezervacijo",
                        $"Rezervirali ste: {izbranaSoba.Name}.\n"+
                        $"Datum registracije: {DateTime.Now.ToString("yyyy-MM-dd")}. \n" +
                        $"Datum prihoda: {Reservation.CheckIn}.\n" +
                        $"Datum odhoda: {Reservation.CheckOut}.\n"+
						$"Cena bivanja: {totalPrice}€ \n Se vidimo!");

				_emailSender.SendEmailAsync("sergej.ajlec@gmail.com", "Dobili ste rezervacijo",
						$"Ime in Priimek: {Reservation.Name}, {Reservation.LastName} \n"+
						$"Telefonska stevilka: {Reservation.PhoneNumber}. \n"+
						$"Opomba: {Reservation.Note}. \n"+
						$"Podatki o sobi: Ime sobe: {izbranaSoba.Name}.\n"+
						$"Končna cena: {totalPrice}€.");

                ReservationRepository.Add(Reservation);
				ReservationRepository.Save();
				return RedirectToAction("Index", "Home");
			}
			return View();
		}



	}
}
