using System;
namespace FisherInsurance.Claims
{    
        public class Quote    {        
            public int Id { get; set; }        
            public string PolicyType { get; set; }        
            public DateTime LossDate { get; set; }        
            public decimal LossAmount { get; set; }
        }
}