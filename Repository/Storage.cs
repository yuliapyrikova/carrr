namespace carrr.Repository
{
    public static class Storage
    {
        public static readonly AutopickerStorage AutopickerStorage = new();
        public static readonly ClientStorage ClientStorage = new();
        public static readonly CarStorage CarStorage = new();
        public static readonly RequestStorage RequestStorage = new();
        public static readonly PaymentStorage PaymentStorage = new();
    }
}