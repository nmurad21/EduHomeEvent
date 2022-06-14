using EduhomeEvent.DAL;
using EduhomeEvent.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EduhomeEvent.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Event> list = _context.Event.ToList();
            return View(list);
        }
    }
}
