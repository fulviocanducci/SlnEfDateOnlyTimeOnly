using Microsoft.AspNetCore.Mvc;

namespace SharedViewComponents.Views.Shared.Components.SpanDateTime
{
    public class SpanDateTimeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(DateTime? value)
        {
            return View(value);
        }
    }
}
