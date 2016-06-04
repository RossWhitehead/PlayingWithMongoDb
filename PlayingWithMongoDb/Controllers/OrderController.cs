using System.Web.Mvc;
using PlayingWithMongoDb.Data;
using PlayingWithMongoDb.Data.Interfaces;
using PlayingWithMongoDb.Web.ViewModels.Order;

namespace PlayingWithMongoDb.Web.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        // GET: Order
        public ActionResult Index()
        {
            return View(orderRepository.FindAll());
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(CreateViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", vm);
            }

            Order order = new Order()
            {
                OrderDateTime = vm.OrderDateTime,
                OrderTotal = vm.OrderTotal,
                Status = OrderStatus.Submitted
            };

            var id = orderRepository.Create(order);

            return RedirectToAction("Index");
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
