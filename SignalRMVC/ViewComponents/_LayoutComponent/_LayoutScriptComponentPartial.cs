using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents._LayoutComponent
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
