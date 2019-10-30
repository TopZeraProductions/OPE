using System.Collections.Generic;

namespace DAL.Core {

    public class Connections {
        
        public IList<Connection> listConnections { get; set; }
        
        public Connections() {
            listConnections = new List<Connection>();
            
            listConnections.Add(
                new Connection {
                    Name          = "StdSqlite",
                    StrConnection = @"Data Source =DATABASE.db",
                    Provider      = "SqlLite"
                }
            );
            listConnections.Add(
                /*new Connection {
                   Name          = "StdSqlServer",
                   StrConnection = @"Server=127.0.0.1,8051; Database=Lms2019;User Id=SA;Password=TopZera123",
                   Provider      = "SqlServer"
                },*/
                new Connection {
                   Name          = "StdSqlServer",
                   StrConnection = @"Server=localhost\SQLEXPRESS01;Database=master;Trusted_Connection=True;",
                   Provider      = "SqlServer"
                }
            );
            listConnections.Add(
                new Connection {
                    Name          =  "StdMysql",
                    StrConnection =  @"Server=127.0.0.1;Port=8050;Database=Lms2019;Uid=root;Pwd=TopZera12356;",
                    Provider      =  "MySql"
                }
            );
        }
    }
    
    public class Connection {
        public string Name          { get; set; }
        public string StrConnection { get; set; }
        public string Provider      { get; set; }
    }

}