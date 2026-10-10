using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.UILayout
{
    public class _UILayoutNavBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
