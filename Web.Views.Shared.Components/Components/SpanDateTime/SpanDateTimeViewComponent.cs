using Microsoft.AspNetCore.Mvc;

namespace Web.Views.Shared.Components.Components.SpanDateTime
{
    public class SpanDateTimeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(DateTime? value)
        {
            return View(value);
        }
    }
}
