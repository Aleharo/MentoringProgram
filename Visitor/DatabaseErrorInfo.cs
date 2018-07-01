using System;

namespace Visitor
{
    class DatabaseErrorInfo : ErrorInfo
    {
        public string DatabaseName { get; set; }
        public Guid UserId { get; set; }

        public DatabaseErrorInfo(Guid id, string description, DateTime time, Severity severity, string dbName, Guid userId) : base(id, description, time, severity)
        {
            Id = id;
            Description = description;
            TimeStamp = time;
            Severity = severity;
            DatabaseName = dbName;
            UserId = userId;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitErrorInfo(LogErrorInfo);
        }

        protected override void LogErrorInfo()
        {
            base.LogErrorInfo();            
            Console.WriteLine($"Database name: {DatabaseName}");
            Console.WriteLine($"User: {UserId} \n");
            Console.ResetColor();
        }

    }
}
