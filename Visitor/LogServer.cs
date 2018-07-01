using System.Collections.Generic;

namespace Visitor
{
    class LogServer
    {
        List<ErrorInfo> LogList = new List<ErrorInfo>();

        public void Add(ErrorInfo error)
        {
            LogList.Add(error);
        }

        public void Remove(ErrorInfo error)
        {
            LogList.Remove(error);
        }

        public void Accept(Visitor visitor)
        {
            foreach (var item in LogList)
            {
                item.Accept(visitor);
            }
        }
    }
}
