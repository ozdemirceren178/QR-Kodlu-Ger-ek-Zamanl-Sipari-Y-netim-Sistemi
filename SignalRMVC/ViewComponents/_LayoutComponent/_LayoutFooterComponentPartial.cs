using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents._LayoutComponent
{
    public class _LayoutFooterComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
