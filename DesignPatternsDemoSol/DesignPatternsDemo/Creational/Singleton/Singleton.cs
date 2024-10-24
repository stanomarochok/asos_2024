﻿namespace DesignPatternsDemo.Creational.Singleton
{
    public sealed class Singleton
    {
        private static Singleton? _instance = null;
        private static readonly object _lock = new object();

        public static Singleton GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new Singleton();

                return _instance;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
