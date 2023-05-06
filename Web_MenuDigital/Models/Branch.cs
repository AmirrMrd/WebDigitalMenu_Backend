using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_MenuDigital.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchIpAddress { get; set; }
        public string BranchPortNumber { get; set; }
    }
}