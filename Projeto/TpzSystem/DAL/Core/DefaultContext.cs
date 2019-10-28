using System;

namespace DAL.Core
{
    public class DefaultContext : IDisposable
    {
        public DataContext Ctx { get; set; }

        public DefaultContext()
        {
            this.Ctx = new DataContext();
            this.Ctx.SetDataBase("StdSqlServer");
        }

        public void Dispose()
        {
            this.Ctx?.Dispose();
        }
    }
}