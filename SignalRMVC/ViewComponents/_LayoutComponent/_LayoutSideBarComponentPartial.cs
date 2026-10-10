using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents._LayoutComponent
{
    public class _LayoutSideBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
