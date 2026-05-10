using System;
using System.IO;

namespace AkilliTedarikSistemi.Patterns
{
    /// <summary>
    /// Singleton Pattern: Sistemin tek bir log dosyası üzerinden kayıt tutmasını sağlar.
    /// Kaynak çakışmalarını önler ve merkezi bir loglama noktası sunar.
    /// </summary>
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();
        private string _logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "system_logs.txt");

        // Private constructor: Dışarıdan "new Logger()" yapılamasın diye.
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                lock (_lock) // Thread-safe (güvenli) olması için
                {
                    if (_instance == null)
                        _instance = new Logger();
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
            File.AppendAllLines(_logPath, new[] { logEntry });
        }
    }
}