using System;

namespace PlayingWithMongoDb.Web.ViewModels.Order
{
    public class IndexViewModel
    {
        public DateTime OrderDateTime { get; set; }
        public decimal OrderTotal { get; set; }
    }
}