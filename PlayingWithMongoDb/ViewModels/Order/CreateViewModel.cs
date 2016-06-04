using System;

namespace PlayingWithMongoDb.Web.ViewModels.Order
{
    public class CreateViewModel
    {
        public DateTime OrderDateTime { get; set; }
        public decimal OrderTotal { get; set; }
    }
}