using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DAL.Core
{
    public sealed partial class DataContext : DbContext
    {
        private IList<Connection> ListConnections { get; set; }

        private Connection Connection { get; set; }

        public void SetDataBase(string connectionName)
        {
            var connectionBuilder = new Connections();

            ListConnections = connectionBuilder.listConnections;

            Connection = ListConnections.FirstOrDefault(x => x.Name == connectionName) ?? new Connection();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            this.SetDataBase("StdSqlServer");
            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Connection.StrConnection);
                // optionsBuilder.UseSqlite(Connection.StrConnection);
            }
        }
    }
}