using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgressBars.Models {
    public class ProgressionData {
        public int Total { get; set; }
        public List<int> Progress { get; set; }
    }
}