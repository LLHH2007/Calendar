using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Calendar
{
    public class PlanItem
    {
        private DateTime currentDay;
        private string job;
        public string Job { get => job; set => job = value; }
        private Point fromTime;
        public Point FromTime { get => fromTime; set => fromTime = value; }
        private Point toTime;
        public Point ToTime { get => toTime; set => toTime = value; }
        public string Status { get => status; set => status = value; }
        public DateTime CurrentDay { get => currentDay; set => currentDay = value; }

        private string status;
        public static List<String> listStatus = new List<string> { "Done","Doing","Coming","Missed"};

    }
    public enum EPlanItem
    {
        Done,
        Doing,
        Coming,
        Missed
    }
}
