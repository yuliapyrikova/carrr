﻿using System;

namespace carrr.Domain
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FullName { get; set; }
        public DateTime BirthdayDate { get; set; }
        public string PhoneNumber { get; set; }
    }
}