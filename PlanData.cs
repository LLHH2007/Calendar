﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar
{
    [Serializable]
    class PlanData
    {
        private List<PlanItem> job;

        internal List<PlanItem> Job { get => job; set => job = value; }
    }
}