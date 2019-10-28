using System.Linq;

namespace UTIL.Wrappers {

    public static class GenericReturnExtensions {
        public static GenericReturn SetError(this GenericReturn GenRet, bool error) {
            GenRet.Error = error;

            return GenRet;
        }

        public static GenericReturn AddMessage(this GenericReturn GenRet, string message) {
            GenRet.MessageList.Add(message);

            return GenRet;
        }
        
        public static GenericReturn AddMessage(this GenericReturn GenRet,params string[] messages) {

            return messages.Aggregate(GenRet, (current, message) => current.AddMessage(message));
        }

        public static GenericReturn AddInfo(this GenericReturn GenRet, object info) {
            GenRet.Info = info;

            return GenRet;
        }
    }

}