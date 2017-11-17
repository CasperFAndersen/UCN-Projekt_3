﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyScheduleWebClient.Services
{
    public class EventRepository
    {

        public IEnumerable<Event> GetEvents()
        {
            Event e1 = new Event
            {
                EventID = 1,
                Subject = "Rikke",
                Description = "Rikke arbejder ved kassen",
                Start = DateTime.Now,
                End = DateTime.Now.AddHours(2),
                ThemeColor = "Red",
                IsFullDay = false
            };

            Event e2 = new Event
            {
                EventID = 1,
                Subject = "Morten",
                Description = "Morten er opfylder",
                Start = DateTime.Now.AddDays(1).AddHours(2),
                End = DateTime.Now.AddDays(1).AddHours(7),
                ThemeColor = "Green",
                IsFullDay = false
            };

            List<Event> res = new List<Event>();
            res.Add(e1);
            res.Add(e2);

            return res;

        }
    }

    public class Event
    {
        public int EventID { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string ThemeColor { get; set; }
        public bool IsFullDay { get; set; }
    }
}
    