namespace TimeToRun
{
    using System;
    using System.Collections.Generic;

    public class Log
    {
        private List<string> messages;

        public static Log Instance
        {
            get;
            private set;
        }

        static Log()
        {
            Instance = new Log();
        }

        public Log()
        {
            this.messages = new List<string>();
        }

        public void Add(string message)
        {
            this.messages.Add(string.Format("{0} : {1}", DateTime.Now, message));
        }

        public string[] GetMessages()
        {
            return this.messages.ToArray();
        }

        public void Clear()
        {
            messages.Clear();
        }
    }
}
