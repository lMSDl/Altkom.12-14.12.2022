using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.TemplateMethod
{
    internal class DatabaseLogger : Logger<DbLog, DbLogService>
    {
        protected override void Save(DbLog item, DbLogService? service)
        {
            service.Write(item);
        }

        protected override DbLog CreateItem(string message)
        {
            Console.WriteLine("Serializing message");
            return new DbLog { DateTime = DateTime.Now, Message = message };
        }

        protected override DbLogService GetService()
        {
            return new DbLogService();
        }
    }
}
