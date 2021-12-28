using System;

namespace carrr.Domain
{
    public class Request
    {
        public int RequestId { get; set; }
        public string Model { get; set; }
        public string Mark { get; set; }
        public string BodyType { get; set; }
        public DateTime Year { get; set; }
        public int Sum { get; set; }
    }
}