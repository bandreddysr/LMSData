﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSAusDataApi
{
    public class LMSQuestions
    {
        public DateTime Date { get; set; }

        //public int TemperatureC { get; set; }
        public int SubjectId { get; set; }

        //public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string SubjectSummary { get; set; }
    }
}
