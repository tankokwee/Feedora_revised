﻿namespace Feedora_revised.Domain
{
    public class DeliveryPartner : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public int PhoneNum { get; set; }
    }
}