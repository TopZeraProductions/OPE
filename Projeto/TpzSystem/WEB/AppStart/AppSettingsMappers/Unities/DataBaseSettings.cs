using System.Collections.Generic;

namespace WEB.AppStart.AppSettingsMappers.Unities {

    public class DataBaseSettings {
        public IList<DataBaseArgs> listDatabases { get; set; }

        public DataBaseSettings() {
            listDatabases = new List<DataBaseArgs>();
        }
    }

    public class DataBaseArgs {
        public string provider { get; set; }
        public string host     { get; set; }
        public string database { get; set; }
        public string user     { get; set; }
        public string password { get; set; }
    }
    
}