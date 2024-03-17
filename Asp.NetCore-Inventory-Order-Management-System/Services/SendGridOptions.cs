using System.Collections.Generic;
using System.Linq;
﻿using System;
using System.Threading.Tasks;

namespace Asp.NetCore_Inventory_Order_Management_System.Services
{
    public class SendGridOptions
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }
        public string FromEmail { get; set; }
        public string FromFullName { get; set; }
        public bool IsDefault { get; set; }
    }
}
