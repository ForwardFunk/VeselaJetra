using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Neo4jClient;

namespace JeeBerryHome3.Controllers
{
    public class GraphClientWrapper
    {
        private static GraphClient client;

        public static GraphClient ConnectToDb()
        {
            if (client == null)
            {
                client = new GraphClient(new Uri("http://localhost:7474"));
            }

            client.Connect();

            return client;

        }
    }
}