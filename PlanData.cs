using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar
{
    public class PlanData
    {
        private List<PlanItem> job;

        public List<PlanItem> Job { get => job; set => job = value; }
    }
}
