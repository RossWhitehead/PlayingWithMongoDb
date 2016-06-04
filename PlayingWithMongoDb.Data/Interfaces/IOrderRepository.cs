using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace PlayingWithMongoDb.Data.Interfaces
{
    public interface IOrderRepository
    {
        ReadOnlyCollection<Order> Find(Expression<Func<Order, bool>> filter);
        ReadOnlyCollection<Order> FindAll();
        Order FindById(string id);

        string Create(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
