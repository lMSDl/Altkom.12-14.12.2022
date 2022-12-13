using System;

namespace WPC.DesignPatterns.Creational.Singleton
{
    public class Context
    {
        private readonly Dictionary<string, string> _settings = new Dictionary<string, string>();

        private Context()
        {
            Console.WriteLine("Inicjalizacja ustawień");

            _settings.Add("1", "A");
            _settings.Add("2", "B");
            _settings.Add("3", "C");
        }

        public string GetSettings(string key)
        {
            return _settings[key];
        }
        public void SetSettings(string key, string value)
        {
            _settings[key] = value;
        }

        public override string ToString()
        {
            return string.Join("\n", _settings.Select(x => $"{x.Key}: {x.Value}"));
        }

        private static Context? _instance;

        /*public static Context Instance => _instance ?? (_instance = new Context());

        public static Context GetInstance()
        {
            if(_instance == null)
                _instance = new Context();

            return _instance;
        }*/

        private static object _locker = new object();
        /*public static Context Instance
        {
            get
            {
                lock (_locker)
                {
                    if (_instance == null)
                        _instance = new Context();
                    return _instance;
                }
            }
        }*/

        /*public static Context Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                            _instance = new Context();
                    }
                }
                return _instance;
            }
        }*/


        public static Context Instance { get; } = new Context();


        /*private static Lazy<Context> _lazyInstance = new Lazy<Context>(() => new Context());
        public static Context Instance => _lazyInstance.Value;*/
    }
}
