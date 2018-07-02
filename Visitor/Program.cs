using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var logServer = new LogServer();
            DatabaseErrorInfo error1 = new DatabaseErrorInfo(new Guid(), "error message", DateTime.Now, Severity.Low, "WebDatabase", new Guid());
            ServerErrorInfo error2 = new ServerErrorInfo(new Guid(), "fatal error", DateTime.Now, Severity.Critical, new Guid());
            logServer.Add(error1);
            logServer.Add(error2);
            logServer.Add(error1);
            logServer.Accept(new ConcreteVisitor());

            Console.ReadKey();
        }
    }
}

