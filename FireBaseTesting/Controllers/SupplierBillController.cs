using Microsoft.AspNetCore.Mvc;

namespace FireBaseTesting.Controllers
{
   public class SupplierBillController : Controller
   {
      public IActionResult Index()
      {
         return View();
      }
      public IActionResult SupplierForm()
      {
         //var firebase = require('firebase');
         //var firebaseui = require('firebaseui');
         return View();
      }
   }
}
