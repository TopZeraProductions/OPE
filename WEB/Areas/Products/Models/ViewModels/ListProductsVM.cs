using WEB.AppStart.AppSettingsMappers.Unities;

namespace WEB.Areas.Products.Models.ViewModels {
    public class ListProductsVM {
        public DataBaseSettings    DataBaseSettings    { get; set; }
        public ApiServicesSettings ApiServicesSettings { get; set; }
    }

}