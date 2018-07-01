namespace Visitor
{
    abstract class Visitor
    {
        public delegate void GetErrorInfo();
        public abstract void VisitErrorInfo(GetErrorInfo getErrorInfo);
    }
}
