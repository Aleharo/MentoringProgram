
namespace Visitor
{
    abstract class Visitor
    {
        public abstract void VisitDatabaseErrorInfo(DatabaseErrorInfo databaseErrorInfo);
        public abstract void VisitServerErrorInfo(ServerErrorInfo serverErrorInfo);
    }
}
