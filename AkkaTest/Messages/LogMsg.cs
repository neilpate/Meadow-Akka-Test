namespace AkkaTest.Messages
{
    class LogMsg
    {
        public string Body { get; private set; }

        public LogMsg(string message)
        {
            Body = message;
        }
    }
}
