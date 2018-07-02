using System;

namespace Visitor
{
    abstract class ErrorInfo
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamp { get; set; }
        public Severity Severity { get; set; }

        public ErrorInfo(Guid id, string description, DateTime time, Severity severity)
        {
            Id = id;
            Description = description;
            TimeStamp = time;
            Severity = severity;
        }

        public abstract void Accept(Visitor visitor);

        protected virtual void LogErrorInfo()
        {
            if (Severity == Severity.Critical)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine($"{TimeStamp} - Id: {Id}");
            Console.WriteLine($"Severity: {Severity}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}
