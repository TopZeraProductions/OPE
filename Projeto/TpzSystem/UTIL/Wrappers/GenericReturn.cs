using System.Collections.Generic;
using System.Linq;

namespace UTIL.Wrappers
{
    public class GenericReturn
    {
        public bool Error { get; set; }
        public IList<string> MessageList { get; set; }
        public object Info { get; set; }

        public GenericReturn()
        {
            this.MessageList = new List<string>();
        }

        public GenericReturn(bool flagError = false, string message = "", object info = null)
        {
            this.MessageList = new List<string>();

            this.Error = flagError;
            this.MessageList.Add(message);
            this.Info = info;
        }
        
        public static GenericReturn NewInstance(bool error = true, string message = "", object info = null)
        {
            var genReturn = new GenericReturn();

            if (!string.IsNullOrEmpty(message)) {
                genReturn.MessageList.Add(message);
            }

            genReturn.Error = error;

            if (info != null)
            {
                genReturn.Info = info;
            }

            return genReturn;
        }
    }
}