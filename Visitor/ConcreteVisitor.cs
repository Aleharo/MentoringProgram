namespace Visitor
{
    class ConcreteVisitor : Visitor
    {
        public override void VisitErrorInfo(GetErrorInfo getErrorInfo)
        {
            getErrorInfo.Invoke();
        }
    }
}
