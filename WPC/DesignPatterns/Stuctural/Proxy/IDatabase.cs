using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Proxy
{
    public interface IDatabase
    {
        Task RequestAsync(int @int);

    }
}
