using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Proxy
{
    public class Client
    {
        public static void Execute()
        {

            IDatabase database = new DatabaseProxy (new Database());

            database = new DatabaseCacheProxy(database);

            for (int i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }

            Console.ReadKey();

            for (int i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }

            Console.ReadKey();
        }
    }
}
