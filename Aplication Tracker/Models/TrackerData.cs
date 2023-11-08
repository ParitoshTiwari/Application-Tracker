using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication_Tracker.Models
{
    public class TrackerData
    {
        public string CompanyName { get; set; }
        public bool IsH1B { get; set; }
        public bool IsLinkedIn { get; set; }
        public bool IsIndeed { get; set; }
        public bool IsHandshake { get; set; }
        public bool IsSDE { get; set; }
        public string ContactName { get; set; }
        public string Notes { get; set; }

        public TrackerData()
        {
            this.CompanyName = string.Empty;
            this.IsH1B = false;
            this.IsLinkedIn = false;
            this.IsIndeed = false;
            this.IsHandshake = false;
            this.IsSDE = false;
            this.IsHandshake = false;
            this.Notes = string.Empty;
        }

    }
}
