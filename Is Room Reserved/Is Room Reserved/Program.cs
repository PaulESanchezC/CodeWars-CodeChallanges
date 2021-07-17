using System;
using System.Collections.Generic;


namespace Is_Room_Reserved
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Kata
    {
        public static bool IsRoomReserved(List<Interval> intervals, Interval checkInterval)
        {
            foreach (var interval in intervals)
            {
                if (IsOccupied(interval, checkInterval))
                    return true;
            }

            return false;
        }
        private static bool IsOccupied(Interval roomInterval, Interval checkInterval)
        {
            return (
                    /* [S-C-E] */
                    checkInterval.StartDate >= roomInterval.StartDate &&
                    checkInterval.StartDate <= roomInterval.EndDate &&
                    checkInterval.EndDate >= roomInterval.StartDate &&
                    checkInterval.EndDate <= roomInterval.EndDate ||

                     /* (CS-[S-CE-E] */
                     checkInterval.StartDate < roomInterval.StartDate &&
                     checkInterval.EndDate >= roomInterval.StartDate &&
                     checkInterval.EndDate <= roomInterval.EndDate ||

                     /* [S-CS-E]-CE) */
                     checkInterval.StartDate >= roomInterval.StartDate &&
                     checkInterval.StartDate <= roomInterval.EndDate &&
                     checkInterval.EndDate > roomInterval.EndDate ||
                    /* (CS-[S-E]-CE) */
                    checkInterval.StartDate <= roomInterval.StartDate &&
                    checkInterval.EndDate >= roomInterval.EndDate);
        }
    }
    public class Interval
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    };
}
