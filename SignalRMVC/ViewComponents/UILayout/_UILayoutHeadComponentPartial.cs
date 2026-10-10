using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.UILayout
{
    public class _UILayoutHeadComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
