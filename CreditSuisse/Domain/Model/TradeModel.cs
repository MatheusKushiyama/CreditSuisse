using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class TradeModel
    {
        public double Value { get; set; }
        public string ClientSector { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public string Category { get; set; } = null;

        public bool IsPoliticallyExposed { get; set; }
    }
}
