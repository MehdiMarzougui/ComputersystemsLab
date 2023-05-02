using System;
using System.Collections.Generic;

namespace LibraryManager.BLL
{
    public class Member : Person
    {
        public String id { get; set; }

        List<PaymentRequest> paymentRequests;

        public Member(string name, string nationality, string DOB, string id): base(name, nationality, DOB)
        {
            this.id = id;
            paymentRequests = new List<PaymentRequest>();
        }

        public void FulfilPaymentRequest(PaymentRequest request)
        {
            if (paymentRequests.Contains(request))
            {
                _ = paymentRequests.Remove(request);
            }
        }

        public bool HasOngoingPaymentRequest()
        {
            return (paymentRequests.Count > 0);
        }

        public void AssignPaymentRequest(PaymentRequest request)
        {
            paymentRequests.Add(request);
        }
    }
}
