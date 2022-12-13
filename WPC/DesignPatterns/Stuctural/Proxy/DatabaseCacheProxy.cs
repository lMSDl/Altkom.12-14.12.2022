using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Proxy
{
    internal class DatabaseCacheProxy : IDatabase
    {

        private IDatabase _database;

        public DatabaseCacheProxy(IDatabase database)
        {
            _database = database;
        }

        private Queue<int> ints = new Queue<int>();

        public async Task RequestAsync(int @int)
        {
            if(ints.Contains(@int))
                return;

            if (ints.Count >= 7)
                ints.Dequeue();

            await _database.RequestAsync(@int);

            ints.Enqueue(@int);
        }
    }
}
