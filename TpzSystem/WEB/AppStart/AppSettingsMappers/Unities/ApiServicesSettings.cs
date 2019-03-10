using System.Collections.Generic;

namespace WEB.AppStart.AppSettingsMappers.Unities {

    public class ApiServicesSettings {
        public IList<ApiServicesArgs> listServices { get; set; }

        public ApiServicesSettings() {
            listServices = new List<ApiServicesArgs>();
        }
    }

    public class ApiServicesArgs {
        public string name { get; set; }
        public string path { get; set; }
    }

}