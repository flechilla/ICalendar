﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICalendar.ComponentProperties;
using ICalendar.GeneralInterfaces;

namespace ICalendar.CalendarComponents
{
    public interface ICalendarComponent
    {
        IEnumerable<IComponentProperty> Properties { get; set; }
    }
}
