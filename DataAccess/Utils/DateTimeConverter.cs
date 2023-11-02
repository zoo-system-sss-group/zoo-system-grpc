using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Utils
{
    public class DateTimeConverter
    {
        public static Timestamp ToTimeSpamp(DateTime dateTime)
        {
            long num = dateTime.Ticks / 10000000;
            int nanos = (int)(dateTime.Ticks % 10000000) * 100;
            return new Timestamp
            {
                Seconds = num - 62135596800L,
                Nanos = nanos
            };
        }
    }
}
