using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Proxy
{
    internal class DatabaseProxy : IDatabase
    {
        public const int SemaphoreSlimCount = 4;

        private Database _database;
        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(SemaphoreSlimCount);

        public DatabaseProxy(Database database)
        {
            _database = database;
        }

        public async Task RequestAsync(int @int)
        {
            await semaphoreSlim.WaitAsync();

            if (_database == null)
                _database = new Database();

            await _database.RequestAsync(@int);
            semaphoreSlim.Release();

            if (semaphoreSlim.CurrentCount == SemaphoreSlimCount)
            {
                _database.Dispose();
                _database = null;
            }
        }
    }
}
