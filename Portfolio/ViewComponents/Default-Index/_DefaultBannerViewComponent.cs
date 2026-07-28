using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultBannerViewComponent : ViewComponent
    {
        private readonly AppDbContext _Context;

        public _DefaultBannerViewComponent(AppDbContext context)
        {
            _Context = context;
        }

        public IViewComponentResult Invoke()
        {
            var banner = _Context.Banners.ToList();
            return View(banner);
        }
    }
}
