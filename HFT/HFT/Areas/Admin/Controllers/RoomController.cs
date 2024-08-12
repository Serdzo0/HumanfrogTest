using Microsoft.AspNetCore.Mvc;
using HFT.DataAccess.Data;
using HFT.DataAccess.Repository.IRepository;
using HFT.Models;
using System.ComponentModel;
using Microsoft.AspNetCore.Authorization;
using HFT.Utility;

namespace HFT.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class RoomController : Controller
    {
        private readonly IRoomRepository roomRepository;
        private readonly IWebHostEnvironment _webHostEnviroment;
        public RoomController(IRoomRepository db, IWebHostEnvironment webHost)
        {
            roomRepository = db;
            _webHostEnviroment = webHost;

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
        public IActionResult Create(RoomModel room, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnviroment.WebRootPath;
                if(file!= null)
                {
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"images\Room");

                    using (var fileStream = new FileStream(Path.Combine(productPath,filename),FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    room.ImageURL = @"\images\Room\" + filename; 
                }
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
            RoomModel? room = roomRepository.GetFirstOrDefault(u => u.ID == id);
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
            RoomModel? room = roomRepository.GetFirstOrDefault(u => u.ID == id);
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
            RoomModel? room = roomRepository.GetFirstOrDefault(u => u.ID == id);
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
