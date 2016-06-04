using MongoDB.Driver;

namespace PlayingWithMongoDb.Data
{
    public class DataContext
    {
        IMongoDatabase db;
         
        public DataContext()
        {
            var client = new MongoClient(Properties.Settings.Default.DefaultConnection);
            db = client.GetDatabase(Properties.Settings.Default.DefaultDatabase);
        }

        public IMongoCollection<Order> Orders
        {
            get
            {
                return db.GetCollection<Order>("Orders");
            }
        }
    }
}