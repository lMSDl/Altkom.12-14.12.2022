using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Proxy
{
    public class Database : IDatabase, IDisposable
    {
        private int _connectionsCounter = 0;

        public Database()
        {
            Console.WriteLine("Otwieranie połączenia z bazą danych..");
        }

        public void Dispose()
        {
            Console.WriteLine("Zamykanie połączenia z bazą danych..");
        }

        public async Task RequestAsync(int @int)
        {
            if (_connectionsCounter >= 5)
            {
                Console.WriteLine($"Request {@int} dropped!");
                return;
            }

            Interlocked.Increment(ref _connectionsCounter);
            Console.WriteLine($"Opening connection {_connectionsCounter}");

            await Task.Delay(new Random(@int).Next(1000, 2000));
            Console.WriteLine($"Request {@int} completed ({_connectionsCounter})");
            Interlocked.Decrement(ref _connectionsCounter);
        }

    }
}
