using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constant
{
	public static class Messages
	{
		public static string ProductAdded = "Ürün eklendi";
		public static string ProductNameInvalid = "Ürün ismi geçersiz";
		internal static string MaintenanceTime="sistem bakımda";
		internal static string ProductsListed="ürünler listelendi";
		internal static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
		internal static string ProductNameAldreadyExist="Bu isimde zaten başka bir ürün var";
		internal static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
		internal static string AuthorizationDenied="Yetkiniz yok";
	}
}
