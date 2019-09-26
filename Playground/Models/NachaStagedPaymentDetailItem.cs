using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class NachaStagedPaymentDetailItem
    {
        public long Id { get; set; }
        public long StagedPaymentDetailId { get; set; }
        public int PaymentId { get; set; }
        public decimal InvoiceNet { get; set; }
        public int PaymentDetailId { get; set; }
        public string InvoiceNum { get; set; }
        public string AvidInvoiceNum { get; set; }
        public Guid? InvoiceID { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}
