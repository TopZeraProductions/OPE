using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;

namespace WEB.AppInfra {

    public static class LinqToExtensions {

        public static List<T> ToListJsonObject<T>(this IQueryable entity, bool? flagIgnoreObjects = false) {
            if (entity == null) {
                return new List<T>();
            }

            var settings = serializeSettings(flagIgnoreObjects);

            var json = JsonConvert.SerializeObject(entity, settings);

            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        public static List<T> ToListJsonObject<T>(this object entity, bool? flagIgnoreObjects = false) {
            if (entity == null) {
                return new List<T>();
            }

            var settings = serializeSettings(flagIgnoreObjects);

            var json = JsonConvert.SerializeObject(entity, settings);

            return JsonConvert.DeserializeObject<List<T>>(json);
        }
        
        public static T ToJsonObject<T>(this object entity, bool? flagIgnoreObjects = false) {
            var settings = serializeSettings(flagIgnoreObjects);

            var json = JsonConvert.SerializeObject(entity, settings);

            return JsonConvert.DeserializeObject<T>(json);
        }
        
        public static List<T> ToListNoLock<T>(this IQueryable<T> query) {
            using (var txn = GetNewReadUncommittedScope()) {
                return query.ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static int CountNoLock<T>(this IQueryable<T> query) {
            using (var txn = GetNewReadUncommittedScope()) {
                return query.Count();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static int SumNoLock(this IQueryable<int> query) {
            using (var txn = GetNewReadUncommittedScope()) {
                return query.Sum();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static decimal SumNoLock(this IQueryable<decimal> query) {
            using (var txn = GetNewReadUncommittedScope()) {
                return query.Sum();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool AnyNoLock<T>(this IQueryable<T> query) {
            using (var txn = GetNewReadUncommittedScope()) {
                return query.Any();
            }
        }
        
        public static T FirstOrDefaultNoLock<T>(this IQueryable<T> query) {
            using (var txn = GetNewReadUncommittedScope()) {
                return query.FirstOrDefault();
            }
        }
        
        private static System.Transactions.TransactionScope GetNewReadUncommittedScope() =>
            new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.RequiresNew, new System.Transactions.TransactionOptions {
                IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted
            });
        
        private static JsonSerializerSettings serializeSettings(bool? flagIgnoreObjects = false) {
            var settings = new JsonSerializerSettings {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                NullValueHandling     = NullValueHandling.Ignore
            };


            return settings;
        }

    }

}