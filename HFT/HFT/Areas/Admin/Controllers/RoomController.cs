using Microsoft.AspNetCore.Mvc;
using HFT.DataAccess.Data;
using HFT.DataAccess.Repository.IRepository;
using HFT.Models;
using System.ComponentModel;

namespace HFT.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoomController : Controller
    {
        private readonly IRoomRepository roomRepository;
        public RoomController(IRoomRepository db)
        {
            roomRepository = db;
        }

        public IActionResult Index()
        {

            List<RoomModel> RoomList = roomRepository.GetAll().ToList();
            return View(RoomList);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(RoomModel room)
        {
            if (ModelState.IsValid)
            {
                roomRepository.Add(room);
                roomRepository.Save();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            RoomModel? room = roomRepository.GetFirstOrDefault(u => u.RoomID == id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }
        [HttpPost]
        public IActionResult Edit(RoomModel room)
        {
            if (ModelState.IsValid)
            {
                roomRepository.Update(room);
                roomRepository.Save();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            RoomModel? room = roomRepository.GetFirstOrDefault(u => u.RoomID == id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            RoomModel? room = roomRepository.GetFirstOrDefault(u => u.RoomID == id);
            if (room == null)
            {
                return NotFound();
            }
            roomRepository.Delete(room);
            roomRepository.Save();
            return RedirectToAction("Index");
        }

    }
}
