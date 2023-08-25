using Microsoft.AspNetCore.Mvc;
namespace Web.Views.Shared.Components.DateTimeComponent
{
   public class InputDateTimeViewComponent : ViewComponent
   {
      public IViewComponentResult Invoke(DateTime? value, string name)
      {
         return View(new InputDateTimeViewComponentModel
         {
            Value = value,
            Name = name
         });
      }
   }
}
