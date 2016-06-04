using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using MongoDB.Driver;
using PlayingWithMongoDb.Data.Interfaces;

namespace PlayingWithMongoDb.Data
{
    public class OrderRepository : IOrderRepository
    {
        DataContext dataContext;

        public OrderRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public string Create(Order order)
        {
            dataContext.Orders.InsertOne(order);
            return order.OrderId;
        }

        public void Update(Order order)
        {
            dataContext.Orders.FindOneAndReplace(o => o.OrderId == order.OrderId, order);
        }

        public ReadOnlyCollection<Order> Find(Expression<Func<Order, bool>> filter)
        {
            return (ReadOnlyCollection<Order>)this.FindFluent(filter);
        }

        public ReadOnlyCollection<Order> FindAll()
        {
            return (ReadOnlyCollection<Order>)this.FindFluent(_ => true);
        }

        public Order FindById(string id)
        {
            return this.FindFluent(o => o.OrderId == id).First();
        }

        private IFindFluent<Order, Order> FindFluent(Expression<Func<Order, bool>> filter)
        {
            return this.dataContext.Orders.Find(filter);
        }

        public void Delete(Order order)
        {
            throw new NotImplementedException();
        }
    }
}