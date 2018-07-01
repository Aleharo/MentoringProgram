using System;

namespace Visitor
{
    class ConcreteVisitor : Visitor
    {
        public override void VisitDatabaseErrorInfo(DatabaseErrorInfo databaseErrorInfo)
        {
            if (databaseErrorInfo.Severity == Severity.Critical)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"{databaseErrorInfo.TimeStamp} - Guid is {databaseErrorInfo.Id} \n " +
                $"Severity: {databaseErrorInfo.Severity} \n " +
                $"Description: {databaseErrorInfo.Description} \n " +
                $"Database name: {databaseErrorInfo.DatabaseName} \n " +
                $"User: {databaseErrorInfo.UserId} \n");
            Console.ResetColor();
        }

        public override void VisitServerErrorInfo(ServerErrorInfo serverErrorInfo)
        {
            if (serverErrorInfo.Severity == Severity.Critical)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine($"{serverErrorInfo.TimeStamp} - Guid is {serverErrorInfo.Id} \n " +
                    $"Severity: {serverErrorInfo.Severity} \n " +
                    $"Description: {serverErrorInfo.Description} \n " +
                    $"Server id: {serverErrorInfo.ServerId} \n");
            Console.ResetColor();
        }
    }
}
