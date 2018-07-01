using System;

namespace Visitor
{
    class ServerErrorInfo: ErrorInfo 
    {
        public Guid ServerId { get; set; }

        public ServerErrorInfo(Guid id, string description, DateTime time, Severity severity, Guid serverId) : base(id, description, time, severity)
        {
            Id = id;
            Description = description;
            TimeStamp = time;
            Severity = severity;
            ServerId = serverId;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitServerErrorInfo(this);
        }
    }
}
