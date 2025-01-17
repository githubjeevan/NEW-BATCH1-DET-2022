﻿using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EventsController : Controller
    {
        public List<Booking>events { get; set; }
        public IActionResult Index()
        {
            events = new List<Booking>();
            events.Add(new Booking { Title = "Ask CEO", EventDate = DateTime.Now, Qty = 10 });
            return View(events);
        }
    }
}
