﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalendar.ComponentProperties.ChangeManagement
{
    /// <summary>
    /// Calendar Components: VEVENT, VTODO, VJOURNAL;
    /// Value Type: DATETIME;
    /// Properties Parameters: iana, non-standard
    /// </summary>
    public class DateTimeCreated : IComponentProperty
    {

        public string Name => "CREATED";
        public IEnumerable<IPropertyParameter> PropertyParameters { get; set; }


        public void Serialize(TextWriter writer)
        {
            StringBuilder str = new StringBuilder("CREATED:");
            str.Append(Value);
            writer.WriteLine("{0}", str);
        }

        public IComponentProperty Deserialize(string value)
        {
            var valueStartIndex = value.IndexOf(':') + 1;
            var strValue = System.DateTime.Parse(value.Substring(valueStartIndex));
            Value = strValue;
            return this;
        }

        public System.DateTime Value { get; set; }
    }
}
