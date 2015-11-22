using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer.Context;
using ServiceLayer.Services;

namespace SaremChap.Controllers
{
    public class OrdersController : Controller
    {
        private IUnitOfWork _uow;
        private IFormService _formService;
        private IFieldService _fieldService;
        private IPriceService _priceService;
        private IValueService _valueService;
        private IOrderService _orderService;
        private IProductService _productService;

        public OrdersController(IUnitOfWork uow, IFormService formService, IFieldService fieldService,
            IValueService valueService, IOrderService orderService, IPriceService priceService,IProductService productService)
        {
            _uow = uow;
            _formService = formService;
            _fieldService = fieldService;
            _valueService = valueService;
            _orderService = orderService;
            _priceService = priceService;
            _productService = productService;
        }
        //
        // GET: /Orders/
        public ActionResult Form(int id)
        {
            var form = _formService.GetAllForms().FirstOrDefault(f=>f.Product_ID == id);
            ViewBag.form = form;
            ViewBag.PriceList = _priceService.GetPricesById(id);
            ViewBag.RelatedProduct = _productService.Get(id);
            var field = _fieldService.GetFieldsById(form.Id);

            return View(field);
        }
	}
}