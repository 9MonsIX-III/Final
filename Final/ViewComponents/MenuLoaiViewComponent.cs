using Final.Data;
using Final.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Final.ViewComponents
{
	public class MenuLoaiViewComponent : ViewComponent
	{
		private readonly TechShop db;

		public MenuLoaiViewComponent(TechShop context) => db = context;

		public IViewComponentResult Invoke()
		{
			var data = db.Loais.Select(lo => new MenuLoaiVM
			{
				MaLoai = lo.MaLoai,
				TenLoai = lo.TenLoai,
				SoLuong = lo.HangHoas.Count
			}).OrderBy(p => p.TenLoai);

			return View(data); // Default.cshtml
			//return View("Default", data);
		}
	}
}
