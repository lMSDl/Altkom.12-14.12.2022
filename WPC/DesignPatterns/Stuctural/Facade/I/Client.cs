using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Stuctural.Facade.I
{
    public class Client
    {
        public static void Execute()
        {
            var person = new Person { FirstName = "Ewa", LastName = "Ewowska", BirthDate = DateTime.Now.AddYears(-23) };

            /*var settings = new JsonSerializerSettings();
            settings.Formatting = Formatting.Indented;
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            settings.DateFormatString = "yy MMM d";*/


            //var json = JsonConvert.SerializeObject(person, settings);

            var message = SerializeFacade.Serialize(person);

            Console.WriteLine(message);

            person = SerializeFacade.Deserialize<Person>(message);
        }
    }
}
