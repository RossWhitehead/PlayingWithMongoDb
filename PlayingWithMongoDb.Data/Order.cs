using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PlayingWithMongoDb.Data
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string OrderId { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime OrderDateTime { get; set; }

        public OrderStatus Status { get; set; }

        [BsonRepresentation(BsonType.Double)]
        public decimal OrderTotal { get; set; }
    }
}